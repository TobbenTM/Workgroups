import Vue from 'vue'
import { sync } from 'vuex-router-sync';
import App from './App.vue'
import router from './router';
import store from './store';

Vue.config.productionTip = false

sync(store, router);

new Vue({
  store,
  router,
  render: h => h(App),
}).$mount('#app')
