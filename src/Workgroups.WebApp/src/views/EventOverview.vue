<template>
  <div class="events">
    <div class="events__jumbo" ref="jumbo">
      <h2>Upcoming events</h2>
      <event-card
        v-for="event in upcomingEvents"
        :key="event.id"
        :event="event"
      />
    </div>
  </div>
</template>

<script>
import AutoscalingBackground from '../mixins/AutoscalingBackground';
import EventCard from '../components/EventCard';
import { createEvents } from '../__test__/TestEventCreator';

export default {
  mixins: [AutoscalingBackground],
  components: {
    EventCard,
  },
  computed: {
    upcomingEvents() {
      return createEvents(3);
    },
  },
};
</script>

<style lang="scss" scoped>
.events {
  &__jumbo {
    display: grid;
    grid-template-columns: repeat(3, minmax(0, 1fr));
    grid-gap: 1em;
    margin-bottom: 2em;

    h2 {
      color: white;
      margin: .75em 0 .25em 0;
      font-weight: 300;
      grid-column-end: span 3;
    }
  }
}
</style>
