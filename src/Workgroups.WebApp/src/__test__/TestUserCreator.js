import faker from 'faker';

export function createUser(name = null) {
  return {
    id: faker.random.uuid(),
    name: name || faker.name.findName(),
    username: `${faker.name.firstName()}.${faker.name.lastName()}`,
    avatarUrl: faker.image.avatar(),
  };
}

export function createUsers(numberOfUsers) {
  return [...Array(numberOfUsers)].map(() => createUser());
}
