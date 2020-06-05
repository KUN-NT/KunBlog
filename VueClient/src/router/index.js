import Vue from 'vue'
import Router from 'vue-router'
import Login from '@/views/Login'
import Home from '@/views/Home'
import ArticleDetail from '@/views/ArticleDetail'
import About from '@/views/About'
import BlogHistory from '@/views/History'
import Search from '@/views/Search'

Vue.use(Router)

export default new Router({
  mode:'history',
  routes: [
    {
      path: '/',
      name: 'Root',
      component: Home
    },
    {
      path: '/home/:userId',
      name: 'Home',
      component: Home
    },
    {
      path: '/login',
      name: 'Login',
      component: Login
    },
    {
      path: '/article/:articleId',
      name: 'ArticleDetail',
      component: ArticleDetail
    },
    {
      path: '/about',
      name: 'About',
      component: About
    },
    {
      path: '/history',
      name: 'History',
      component: BlogHistory
    },
    {
      path: '/search/:type/:value',
      name: 'Search',
      component: Search
    }
  ]
})
