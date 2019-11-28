<template>
  <div class="preloader">
    Loading...
  </div>
</template>

<script>
export default {

}
</script>

<style lang="scss" scoped>
@import '../style/variables.scss';

.preloader {
  position: absolute;
  background: $background_light;
  color: black;
  height: 100%;
  width: 100%;
  top: 0;
  left: 0;
  display: flex;
  justify-items: center;
  align-items: center;
  z-index: 999;
}
</style>
