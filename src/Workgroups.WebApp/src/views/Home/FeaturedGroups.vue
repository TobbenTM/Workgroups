<template>
  <div class="groups">
    <h2>Featured Groups</h2>
    <div class="groups__grid">
      <group-card
        v-for="group in groups"
        :key="group.id"
        :group="group"
        class="groups__grid__item"
      />
    </div>
  </div>
</template>

<script>
import { createGroups } from '../../__test__/TestGroupCreator';
import GroupCard from './GroupCard';

export default {
  components: {
    GroupCard,
  },
  data() {
    return {
      groups: createGroups(9),
    };
  },
};
</script>

<style lang="scss" scoped>
.groups {
  h2 {
    font-weight: 400;
  }

  &__grid {
    display: grid;
    margin-bottom: 2em;
    grid-gap: 1em;
    grid-template-columns: repeat(3, minmax(0, 1fr));
  }
}
</style>
