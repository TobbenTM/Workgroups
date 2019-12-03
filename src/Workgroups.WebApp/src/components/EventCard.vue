<template>
  <router-link
    :to="{ name: 'event', params: { eventId: event.id } }"
    class="event-card"
    :style="{ backgroundImage: `url(${event.imageUrl})` }"
  >
    <div class="event-card__banner">
      <h3>{{ event.title }}</h3>
    </div>
  </router-link>
</template>

<script>
export default {
  props: {
    event: {
      type: Object,
      required: true,
    },
  },
};
</script>

<style lang="scss" scoped>
@import '../style/mixins.scss';

.event-card {
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
