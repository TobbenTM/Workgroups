<template>
  <div class="actions">
    <h3>Sign up now!</h3>
    <h4>
      <strong>{{ numberOfAttendeesGoing }}</strong> going,
      <strong>{{ numberOfAttendeesOnWaitlist }}</strong> on waitlist
    </h4>
    <div class="actions__attendees">
      <img
        v-for="attendee in displayableAttendees.slice(0, Math.min(10, numberOfAttendeesGoing))"
        :key="attendee.id"
        :src="attendee.user.avatarUrl"
        alt=""
      >
      <span v-if="numberOfAttendeesGoing > 10">+ {{ numberOfAttendeesGoing - 10 }} others</span>
    </div>
    <button class="actions__sign-up" :class="{ 'actions__sign-up--waitlist': !eventHasRoom }">
      <template v-if="eventHasRoom">
        Sign up
      </template>
      <template v-else>
        Join waitlist
      </template>
    </button>
  </div>
</template>

<script>
export default {
  props: {
    event: {
      type: Object,
      required: true,
    },
  },
  computed: {
    numberOfAttendeesGoing() {
      return this.event.attendees.filter(a => a.isGoing && !a.isOnWaitlist).length;
    },
    numberOfAttendeesOnWaitlist() {
      return this.event.attendees.filter(a => a.isGoing && a.isOnWaitlist).length;
    },
    displayableAttendees() {
      return this.event.attendees.filter(a => a.isGoing && !a.isOnWaitlist);
    },
    eventHasRoom() {
      return this.event.maxNumberOfAttendees == null || this.numberOfAttendeesGoing < this.event.maxNumberOfAttendees;
    }
  },
};
</script>

<style lang="scss" scoped>
.actions {
  display: flex;
  padding: 0 1em;
  align-items: center;
  white-space: nowrap;

  strong {
    font-size: 1.1em;
  }

  >:not(:last-child) {
    padding-right: 1em;
    border-right: 2px solid rgba(0, 0, 0, .5);
  }

  >:not(:first-child) {
    padding-left: 1em;
  }

  &__sign-up {
    &--waitlist {
      background-color: #626262;
    }
  }

  &__attendees {
    flex-grow: 1;
    max-width: 100%;
    overflow: hidden;
    align-items: center;

    span, img {
      vertical-align: middle;
      height: 1.5em;
    }

    img {
      width: 1.5em;
      border-radius: 50%;
      overflow: hidden;
      background: rgba(0, 0, 0, .5);

      &:not(:last-child) {
        margin-right: .4em;
      }
    }
  }
}
</style>
