<template>
  <router-link
    :to="{ name: 'group', params: { groupId: group.id } }"
    class="group-card"
    :style="{ backgroundImage: `url(${group.logo})` }"
  >
    <div class="group-card__banner">
      <h3>{{ group.name }}</h3>
      <span>{{ group.type === 1 ? 'Tech' : 'Social' }}</span>
    </div>
  </router-link>
</template>

<script>
export default {
  props: {
    group: {
      type: Object,
      required: true,
    },
  },
};
</script>

<style lang="scss" scoped>
@import '../../style/mixins.scss';

.group-card {
  @include card;
  height: 0;
  padding-top: 56.25%;
  overflow: hidden;
  background: #333;
  background-size: cover;
  position: relative;

  &:hover {
    @include card-hover;
  }

  &__banner {
    position: absolute;
    padding: .5em 1em;
    margin: 0;
    bottom: 0;
    width: 100%;
    color: white;
    background: rgba(0, 0, 0, .5);
    display: flex;
    align-items: baseline;
    justify-content: space-between;
    box-sizing: border-box;

    h3 {
      margin: 0;
    }
  }
}
</style>
