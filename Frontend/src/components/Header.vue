<script setup lang="ts">
import Navbar from './Navbar.vue'

defineProps({
  title: String,
  subtitle: String,
})
</script>

<template>
  <header class="container w-full">
    <div class="text-white bg-slate-900 w-screen box-border px-8 py-4">
      <div class="flex justify-between items-center">
        <div>
          <a href="#/" class="font-bold text-3xl leading-10 text-blue-100 mb-2">{{ title }}</a>
          <h2>{{ subtitle }}</h2>
        </div>
        <Navbar></Navbar>
      </div>
    </div>
  </header>
</template>
