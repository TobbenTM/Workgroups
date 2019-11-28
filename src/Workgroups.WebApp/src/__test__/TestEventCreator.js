import faker from 'faker';
import { createGroup } from './TestGroupCreator';
import { createUser, createUsers } from './TestUserCreator';

export function createEvent(group = null, user = null, title = null) {
  group = group || createGroup();
  const startDate = faker.date.future();
  startDate.setHours(17);
  const endDate = new Date(startDate);
  endDate.setHours(20);
  const maxAttendees = Math.random() > .5 ? null : Math.floor(Math.random()*50) + 15;
  return {
    id: faker.random.uuid(),
    hostedBy: group || createGroup(),
    createdBy: user || createUser(),
    startsAt: startDate,
    endsAt: endDate,
    title: title || faker.random.words(3),
    description: faker.lorem.paragraphs(3),
    imageUrl: faker.image.imageUrl(720, 480),
    location: faker.address.streetName(),
    maxNumberOfAttendees: maxAttendees,
    attendees: createUsers(Math.min(maxAttendees, Math.floor(Math.random() * 100))).map(user => ({
      user,
      comment: faker.random.words(Math.floor(Math.random() * 7)),
      isGoing: Math.random() > .1 ? true : false,
      isOnWaitlist: false,
    })),
  };
}

export function createEvents(numberOfEvents) {
  return [...Array(numberOfEvents)].map(() => createEvent()).sort((a, b) => new Date(a.startsAt) - new Date(b.startsAt));
}
