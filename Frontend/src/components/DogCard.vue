<script setup lang="ts">
defineProps({
  name: String,
  breed: String,
  sex: String,
  photoUrl: String,
  id: String,
})
</script>

<template>
  <div class="bg-slate-200 shadow-md rounded-sm">
    <img class="w-full h-[240px] object-cover rounded-t-sm" :src="`${photoUrl}`" :alt="`${name}`" />
    <div class="p-4 text-black">
      <h2 class="text-xl font-bold">{{ name }}</h2>
      <h3 class="mt-2">{{ breed }}</h3>
      <div class="flex justify-end">
        <a class="bg-blue-800 text-white px-4 py-2 rounded-full" href="#"
          >Find out more about {{ name }}</a
        >
      </div>
    </div>
  </div>
</template>
