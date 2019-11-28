import faker from 'faker';
import { createUsers } from './TestUserCreator';

export function createGroup(name = null) {
  return {
    id: faker.random.uuid(),
    name: name || faker.random.words(2),
    logo: faker.image.imageUrl(720, 480),
    description: faker.lorem.paragraphs(2),
    type: Math.random() > .5 ? 0 : 1,
    leaders: createUsers(Math.floor(Math.random() * 5)).map(user => { user }),
    members: createUsers(Math.floor(Math.random() * 50)).map(user => { user }),
  };
}

export function createGroups(numberOfGroups) {
  return [...Array(numberOfGroups)].map(() => createGroup());
}
