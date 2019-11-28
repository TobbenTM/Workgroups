<template>
  <div class="event">
    <div class="event__jumbo" ref="jumbo">
      <div
        class="event__jumbo__image"
        :style="{ backgroundImage: `url(${event.imageUrl})` }"
      >
        <h1>{{ event.title }}</h1>
      </div>
      <event-summary :event="event" class="event__jumbo__summary"/>
    </div>
    <div class="event__content">
      <event-actions :event="event" class="event__content__actions"/>
    </div>
  </div>
</template>

<script>
import AutoscalingBackground from '../../mixins/AutoscalingBackground';
import { createEvent } from '../../__test__/TestEventCreator';
import EventSummary from './Summary';
import EventActions from './Actions';

export default {
  name: 'Event',
  mixins: [AutoscalingBackground],
  components: {
    EventSummary,
    EventActions,
  },
  data() {
    return {
      event: createEvent(),
    };
  },
};
</script>

<style lang="scss" scoped>
@import '../../style/mixins.scss';

.event {
  &__jumbo {
    display: grid;
    grid-template-columns: minmax(0, 2fr) minmax(0, 1fr);
    grid-gap: 1em;
    margin-bottom: 2em;

    &__image {
      @include card;
      height: 0;
      padding-top: 56.25%;
      overflow: hidden;
      background: #333;
      background-size: cover;
      position: relative;

      h1 {
        position: absolute;
        padding: .5em 1em;
        margin: 0;
        bottom: 0;
        width: 100%;
        color: white;
        background: rgba(0, 0, 0, .5);
      }
    }

    &__summary {
      @include card;
      color: white;
      background: #247ba0;
    }
  }

  &__content {
    &__actions {
      @include card;
    }
  }
}
</style>
