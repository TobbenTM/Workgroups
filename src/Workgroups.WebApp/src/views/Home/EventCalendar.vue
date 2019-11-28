<template>
  <div class="event-calendar">
    <calendar
      is-expanded
      :attributes="attrs"
    />
  </div>
</template>

<script>
import Calendar from 'v-calendar/lib/components/calendar.umd';

export default {
  components: {
    Calendar,
  },
  data() {
    return {
      attrs: [
        {
          key: 'today',
          highlight: true,
          dates: new Date(),
        },
      ],
    };
  },
};
</script>

<style lang="scss" scoped>
@import '../../style/variables.scss';
@import '../../style/mixins.scss';

.event-calendar {
  width: 100%;
  margin-bottom: $overlap;
  color: white;
  padding: 1em;
  box-sizing: border-box;
}
</style>
