<template>
  <nav class="navbar">
    <router-link to="/home" class="navbar__logo">Workgroups</router-link>
    <router-link to="/events">Events</router-link>
    <router-link to="/groups">Groups</router-link>
    <a href="/login" v-on:click.prevent="logIn" class="navbar__user">Log in</a>
  </nav>
</template>

<script>
export default {

}
</script>

<style lang="scss">
@import "../style/variables.scss";
@import "../style/mixins.scss";

.navbar {
  color: gray;
  padding: .5em 0 1em 0;
  font-size: 1.1em;

  a {
    padding-right: 1em;
    text-decoration: none;
    color: #aaa;
    transition: color .4s ease-in-out;

    &__logo {
      color: #ccc;
    }

    &:hover, &.router-link-active {
      color: #eee;
    }
  }

  &__logo {
    font-weight: 900;
    font-size: 1.2em;
    font-family: 'Segoe UI SemiLight', sans-serif;
  }

  &__user {
    float: right;
  }

  &__content {
    @include content;
  }
}
</style>
