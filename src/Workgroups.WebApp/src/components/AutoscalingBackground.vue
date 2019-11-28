<template>
  <div class="background" :style="{ height, top: this.jumboElement ? null : 0 }"/>
</template>

<script>
import { mapState } from 'vuex';

export default {
  props: {
    navbar: {
      required: false,
      type: Object,
    },
  },
  computed: {
    height() {
      const baseHeight = this.navbar ? this.navbar.$el.offsetHeight : 0;
      return `${baseHeight + this.jumboElementHeight}px`;
    },
    ...mapState(['jumboElement']),
  },
  data() {
    return {
      jumboElementHeight: 0,
    };
  },
  created() {
    this.resizeObserver = new ResizeObserver(jumbo => {
      this.jumboElementHeight = jumbo.reduce((acc, el) => acc + el.target.offsetHeight);
    });
  },
  watch: {
    jumboElement(newElement) {
      if (newElement) {
        this.jumboElementHeight = newElement.offsetHeight;
        this.resizeObserver.observe(newElement);
      } else {
        this.jumboElementHeight = 0;
        this.resizeObserver.disconnect();
      }
    },
  },
};
</script>

<style lang="scss">
@import '../style/variables.scss';

.background {
  position: absolute;
  width: 100%;
  top: -$overlap;
  background-color: $background_dark;
  transition: height .5s ease-in-out, top .5s ease-in-out;
}
</style>
