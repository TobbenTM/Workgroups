import Vue from 'vue';
import VueRouter from 'vue-router';

Vue.use(VueRouter);

const router = new VueRouter({
  mode: 'history',
  routes: [
    {
      path: '',
      redirect: 'home',
    },
    {
      path: '/home',
      name: 'home',
      component: () => import(/* webpackChunkName: "home" */ './views/Home'),
      meta: {
        order: 0,
      },
    },
    {
      path: '/events',
      component: () => import(/* webpackChunkName: "events" */ './views/Events'),
      meta: {
        order: 1,
      },
      children: [
        {
          path: '',
          name: 'events',
          component: () => import(/* webpackChunkName: "event-overview" */ './views/EventOverview'),
        },
        {
          path: ':eventId',
          name: 'event',
          component: () => import(/* webpackChunkName: "event" */ './views/Event'),
        },
      ],
    },
    {
      path: '/groups',
      component: () => import(/* webpackChunkName: "groups" */ './views/Groups'),
      meta: {
        order: 2,
      },
      children: [
        {
          path: '',
          name: 'groups',
          component: () => import(/* webpackChunkName: "group-overview" */ './views/GroupOverview'),
        },
        {
          path: ':groupId',
          name: 'group',
          component: () => import(/* webpackChunkName: "group" */ './views/Group'),
        },
      ],
    },
  ],
});

export default router;
