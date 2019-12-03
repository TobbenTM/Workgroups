<template>
  <div class="summary">
    <h2>Summary</h2>
    <ul>
      <li>
        Time: <strong>{{ event.startsAt | formatDate }} - {{ event.endsAt | formatDate }}</strong>
      </li>
      <li>
        Hosted by: <strong>
        <router-link :to="{ name: 'group', params: { groupId: event.hostedBy.id }}">
          {{ event.hostedBy.name }}
        </router-link></strong>
      </li>
      <li>
        Location: <strong>{{ event.location }}</strong>
      </li>
      <li v-if="event.maxNumberOfAttendees">
        Max number of attendees: <strong>{{ event.maxNumberOfAttendees }}</strong>
      </li>
    </ul>
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
  filters: {
    formatDate(date) {
      return date.toLocaleString();
    },
  },
};
</script>

<style lang="scss" scoped>
.summary {
  h2 {
    text-align: center;
    font-weight: 500;
    padding: 0;
    margin: .75em 0 .5em 0;
  }

  li {
    padding: .4em 1em;
  }
}
</style>
