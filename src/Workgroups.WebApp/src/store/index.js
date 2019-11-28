import Vue from 'vue';
import Vuex from 'vuex';
import axios from 'axios';

Vue.use(Vuex);

// State
const rootState = {
  xsrf: null,
  loadedXsrf: false,
  error: null,
  jumboElement: null,
};

// Mutations
const mutations = {
  xsrfTokenFetched(state, token) {
    state.xsrf = token;
    state.loadedXsrf = true;
  },
  error(state, err) {
    console.error('An error occured and was committed!', err);
    state.error = err;
  },
  errorCleared(state) {
    state.error = null;
  },
  jumboElementChanged(state, element) {
    state.jumboElement = element;
  },
};

// Actions
const actions = {
  async getXsrfToken({ commit }) {
    try {
      const response = await axios.get('/api/xsrf');
      commit('xsrfTokenFetched', response.data);
    } catch (err) {
      commit('error', err);
    }
  },
  async setJumboElement({ commit }, element) {
    commit('jumboElementChanged', element);
  }
};

// Getters
const getters = {
  api: (state) => axios.create({
    headers: {
      RequestVerificationToken: state.xsrf && state.xsrf.token,
    },
  }),
};

export default new Vuex.Store({
  state: rootState,
  mutations,
  actions,
  getters,
  modules: {
  },
});
