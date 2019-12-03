<template>
  <main class="layout" id="app">
    <autoscaling-background :navbar="$refs.navbar"/>
    <div class="layout__container">
      <navbar class="layout__navbar" ref="navbar"/>
      <transition :name="routerTransition">
        <router-view class="layout__content" :key="key"/>
      </transition>
    </div>
  </main>
</template>

<script>
import AutoscalingBackground from './components/AutoscalingBackground';
import Navbar from './views/Navbar';

export default {
  name: 'app',
  components: {
    AutoscalingBackground,
    Navbar,
  },
  computed: {
    key() {
      return this.$route.fullPath;
    },
  },
  data() {
    return {
      routerTransition: null,
    };
  },
  watch: {
    '$route' (to, from) {
      if (!to.matched[0] || !from.matched[0]) return;
      if (to.matched[0].meta.order === from.matched[0].meta.order) {
        const toDepth = to.path.split('/').length;
        const fromDepth = from.path.split('/').length;
        if (toDepth < fromDepth) {
          this.routerTransition = 'slide-down';
        } else {
          this.routerTransition = 'slide-left';
        }
      } else {
        this.routerTransition = to.matched[0].meta.order < from.matched[0].meta.order ? 'slide-right' : 'slide-left'
      }
    },
  },
};
</script>

<style lang="scss">
@import './style/variables.scss';
@import './style/mixins.scss';

body, html{
  background-color: $background_light;
  margin: 0;
  padding: 0;
}

body {
  overflow-y: scroll;
}

#app {
  font-family: 'Segoe UI', sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  color: #2c3e50;
}

a {
  color: inherit;
  text-decoration: inherit;
}

ul {
  margin: 0;
  padding: 0;
}

li {
  margin: 0;
  list-style: none;
}

button {
  @include button;
}
</style>

<style lang="scss" scoped>
@import './style/mixins.scss';

.layout {
  @include content-container;

  &__container {
    z-index: 1;
    position: relative;
    @include content;
  }

  &__content {
    left: 0;
    right: 0;
    position: absolute;
    transition: all .5s cubic-bezier(.55,0,.1,1);
  }
}

.slide-left-enter, .slide-right-leave-active {
  opacity: 0;
  -webkit-transform: translate(50px, 0);
  transform: translate(50px, 0);
}
.slide-left-leave-active, .slide-right-enter {
  opacity: 0;
  -webkit-transform: translate(-50px, 0);
  transform: translate(-50px, 0);
}

.slide-up-enter, .slide-down-leave-active {
  opacity: 0;
  -webkit-transform: translate(0, 50px);
  transform: translate(0, 50px);
}
.slide-up-leave-active, .slide-down-enter {
  opacity: 0;
  -webkit-transform: translate(0, -50px);
  transform: translate(0, -50px);
}
</style>
