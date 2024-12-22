<script setup lang="ts">
defineProps({
  title: String,
  subtitle: String,
})
</script>
<template>
  <footer class="w-full">
    <div class="text-white bg-slate-900 box-border w-screen px-8 py-4">
      <div class="flex flex-col">
        <div class="">{{ title }}</div>
        <div class="">{{subtitle}}</div>
      </div>
    </div>
  </footer>
</template>
