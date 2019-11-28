import { mapActions } from 'vuex';

const AutoscalingBackground = {
  mounted() {
    if (this.$refs.jumbo) {
      this.setJumboElement(this.$refs.jumbo);
    }
  },
  destroyed() {
    this.setJumboElement(null);
  },
  methods: {
    ...mapActions(['setJumboElement']),
  },
};

export default AutoscalingBackground;
