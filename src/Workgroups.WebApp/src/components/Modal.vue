<template>
  <div class="modal">
    <div class="modal__mask" v-on:click="close">
      <div class="modal__content" v-on:click.stop>
        <div class="modal__header">
          <h3>{{ title }}</h3>
          <button v-on:click="close">x</button>
        </div>
        <!-- modal body goes in slot -->
        <slot/>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  props: {
    title: {
      type: String,
      required: true,
    },
  },
  methods: {
    close() {
      this.$emit('close');
    }
  }
}
</script>

<style lang="scss" scoped>
.modal {
  &__mask {
    position: fixed;
    top: 0;
    right: 0;
    bottom: 0;
    left: 0;
    z-index: 1;
    background: rgba(0, 0, 0, .5);
    display: flex;
    justify-content: center;
    align-items: center;
  }

  &__content {
    background: white;
    overflow: hidden;
    border-radius: .75em;
    box-shadow: 0em 0.25em 1em 0em rgba(0, 0, 0, 0.25);
  }

  &__header {
    display: flex;
    align-items: center;
    padding-left: 1em;
    padding-right: .5em;
    border-bottom: 1px solid rgba(0, 0, 0, .25);

    h3 {
      margin: 0;
      flex-grow: 1;
    }

    button {
      margin: .5em;
      padding: .5em;
    }
  }
}
</style>
