<template>
  <modal title="Sign Up" v-on:close="close">
    <div class="sign-up">
      <!-- TODO - Wrap with transition -->
      <div class="sign-up__foodora" v-if="!completedFoodoraOrder">
        <h4>Please select desired food:</h4>
        <!-- TODO - Show available foodora food -->
        <button v-on:click="completedFoodoraOrder = true">
          Next >>
        </button>
      </div>
      <div class="sign-up__summary" v-else-if="!confirmedAttendance">
        <h4>Please confirm attendance:</h4>
        <!-- TODO - Show foodora order w/ total -->
        <button v-on:click="signUp">
          Confirm
        </button>
      </div>
      <div class="sign-up__spinner" v-else-if="signingUp">
        <!-- TODO - Animated spinner -->
        <h4>Hold on, signing you up now!</h4>
      </div>
      <div class="sign-up__confirmation" v-else>
        <template v-if="result.isOnWaitlist">
          <h4>Awesome!</h4>
          <p>You are currently on the waitlist for the event!</p>
        </template>
        <template v-else-if="result.isOnWaitlist">
          <h4>Great news!</h4>
          <p>You are signed up for the event!</p>
        </template>
        <template v-else>
          <!-- TODO - Is this a reasonable branch? -->
        </template>
      </div>
    </div>
  </modal>
</template>

<script>
import Modal from '../../components/Modal';

export default {
  components: {
    Modal,
  },
  props: {
    event: {
      type: Object,
      required: true,
    },
  },
  computed: {
  },
  data() {
    return {
      signingUp: false,
      completedFoodoraOrder: false,
      confirmedAttendance: false,
      foodoraOrder: [],
    };
  },
  methods: {
    close() {
      this.$emit('close');
    },
    signUp() {
      this.confirmedAttendance = true;
      this.signingUp = true;
      // TODO - HTTP POST
    },
  },
};
</script>

<style lang="scss" scoped>
.sign-up {
  padding: 1em;
  text-align: center;
}
</style>
