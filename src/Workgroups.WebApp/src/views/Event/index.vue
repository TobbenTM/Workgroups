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
      <event-actions
        :event="event"
        class="event__content__actions"
        v-on:sign-up="signingUp = true"
      />
      <div class="event__content__description">
        {{ event.description }}
      </div>
      <div class="event__content__agenda">
        <h2>Agenda</h2>
      </div>
      <div class="event__content__vendors">
        <h2>Foodora Vendors</h2>
        <foodora-vendors :vendors="event.foodoraVendors"/>
      </div>
      <button style="margin: auto;" @click="loadEvent">Refresh</button>
    </div>
    <sign-up-modal
      v-if="signingUp"
      v-on:close="signingUp = false"
      :event="event"
    />
  </div>
</template>

<script>
import AutoscalingBackground from '../../mixins/AutoscalingBackground';
import { createEvent } from '../../__test__/TestEventCreator';
import EventSummary from './Summary';
import EventActions from './Actions';
import SignUpModal from './SignUpModal';
import FoodoraVendors from './FoodoraVendors';

export default {
  name: 'Event',
  mixins: [AutoscalingBackground],
  components: {
    EventSummary,
    EventActions,
    SignUpModal,
    FoodoraVendors,
  },
  data() {
    return {
      event: null,
      loadingEvent: false,
      signingUp: false,
    };
  },
  created() {
    this.loadEvent();
  },
  methods: {
    loadEvent() {
      this.loadingEvent = true;
      this.event = createEvent();
      this.loadingEvent = false;
    },
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
    display: grid;
    grid-gap: 1.5em;
    grid-template-areas:
      "actions actions"
      "description agenda"
      "description vendors";
    grid-template-columns: 2fr 1fr;

    &__actions, &__description, &__agenda, &__vendors {
      @include card;
      padding: 0 1em;
      width: 100%;
    }

    &__actions {
      grid-area: actions;
    }

    &__description {
      padding: 1em;
      grid-area: description;
    }

    &__agenda {
      grid-area: agenda;
    }

    &__vendors {
      grid-area: vendors;
    }

    &__agenda, &__vendors {
      h2 {
        text-align: center;
        font-weight: 500;
        padding: 0;
        margin: .75em 0 .75em 0;
      }
    }
  }
}
</style>
