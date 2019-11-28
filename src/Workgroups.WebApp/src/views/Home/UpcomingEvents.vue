<template>
  <div class="upcoming-events">
    <h2>Upcoming Events</h2>
    <ul>
      <event-list-item
        v-for="event in events"
        :key="event.id"
        :event="event"
      />
    </ul>
  </div>
</template>

<script>
import EventListItem from './EventListItem';
import { createEvents } from '../../__test__/TestEventCreator';

export default {
  components: {
    EventListItem,
  },
  data() {
    return {
      events: createEvents(3),
    };
  },
};
</script>

<style lang="scss" scoped>
@import '../../style/mixins.scss';

.upcoming-events {
  @include card;
  width: 100%;
  height: 100%;
  color: white;
  background: #05668d;

  h2 {
    text-align: center;
    font-weight: 500;
    padding: 0;
    margin: .75em 0 .5em 0;
  }
}
</style>
