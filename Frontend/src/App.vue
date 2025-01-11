<script setup lang="ts">
import { ref, computed } from 'vue'
import Header from './components/Header.vue'
import Home from '@/views/Home.vue'
import About from '@/views/About.vue'
import Dogs from '@/views/Dogs.vue'
import Contact from '@/views/Contact.vue'
import Footer from '@/components/Footer.vue'

const currentPath = ref(window.location.hash)

window.addEventListener('hashchange', () => {
  currentPath.value = window.location.hash
})

interface Routes {
  [key: string]: any
}
const routes: Routes = {
  '/': Home,
  '/dogs': Dogs,
  '/about': About,
  '/contact': Contact,
}

const currentView = computed(() => {
  return routes[currentPath.value.slice(1) || '/' || 'Not found']
})

const orgTitle = 'Dog Rehoming'
const subTitle = 'Finding nice homes for the nicest dogs'
</script>

<template>
  <Header :title="`${orgTitle}`" :subtitle="`${subTitle}`"></Header>

  <main class="container">
    <div class="mx-8 my-10">
      <component :is="currentView" />
    </div>
  </main>

  <Footer :title="`${orgTitle}`" :subtitle="`${subTitle}`"></Footer>
</template>
