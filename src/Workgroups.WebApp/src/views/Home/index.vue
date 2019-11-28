<template>
  <div class="home">
    <div class="home__highlights" ref="jumbo">
      <upcoming-events/>
      <event-calendar/>
      <featured-events/>
    </div>
    <featured-groups/>
  </div>
</template>

<script>
import EventCalendar from './EventCalendar';
import FeaturedEvents from './FeaturedEvents';
import FeaturedGroups from './FeaturedGroups';
import UpcomingEvents from './UpcomingEvents';
import AutoscalingBackground from '../../mixins/AutoscalingBackground';

export default {
  name: 'Home',
  components: {
    EventCalendar,
    FeaturedEvents,
    FeaturedGroups,
    UpcomingEvents,
  },
  mixins: [AutoscalingBackground],
};
</script>

<style lang="scss" scoped>
@import '../../style/variables.scss';

.home {
  &__highlights {
    display: grid;
    grid-template-columns: repeat(3, minmax(0, 1fr));
    grid-gap: 1em;
    margin-bottom: 2em;
  }
}
</style>
