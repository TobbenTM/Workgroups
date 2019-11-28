<template>
  <div class="summary">
    <h2>Summary</h2>
    <ul>
      <li>
        Time: {{ event.startsAt }}
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
