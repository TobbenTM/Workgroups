<template>
  <li class="event">
    <router-link
      class="event__link"
      :to="{ name: 'event', params: { eventId: event.id } }"
    >
      <span class="event__title">{{ event.title }}</span>
      <span class="event__description">{{ event.description }}</span>
      <span class="event__details">{{ formattedTime }} @ {{ event.location }} - {{ event.hostedBy.name }}</span>
    </router-link>
  </li>
</template>

<script>
export default {
  props: {
    event: {
      required: true,
      type: Object,
    },
  },
  computed: {
    formattedTime() {
      return `${this.event.startsAt}`;
    },
  },
};
</script>

<style lang="scss" scoped>
.event {
  padding: .4em 0;
  border-top: 1px solid rgba(0, 0, 0, .1);
  transition: background-color .25s ease-in-out;

  &:hover {
    background-color: rgba(0, 0, 0, .05);
  }

  &:last-child {
    margin-bottom: .75em;
    border-bottom: 1px solid rgba(0, 0, 0, .1);
  }

  span {
    white-space: nowrap;
    text-overflow: ellipsis;
    overflow: hidden;
    display: block;
    padding: 0 1em;
  }

  &__title {
    opacity: 1;
    font-size: 1.2em;
  }

  &__description {
    opacity: .7;
  }

  &__details {
    opacity: .85;
  }
}
</style>
