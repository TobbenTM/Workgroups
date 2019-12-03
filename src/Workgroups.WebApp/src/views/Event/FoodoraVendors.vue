<template>
  <div class="vendors">
    <p class="vendors__error" v-if="!vendors">
      <em>
        This event does not support foodora vendors :(
      </em>
    </p>
  </div>
</template>

<script>
export default {
  props: {
    vendors: {
      type: Array,
      required: false,
    },
  },
};
</script>

<style lang="scss" scoped>
.vendors {
  &__error {
    text-align: center;
  }
}
</style>
