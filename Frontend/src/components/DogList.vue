<script setup lang="ts">
import DogCard from './DogCard.vue'
import { fetchDogs } from '@/api/fetchDogs'
import { ref, onMounted } from 'vue'
const dogs = ref<string[]>([])

onMounted(async () => {
  dogs.value = await fetchDogs()
})
</script>

<template>
  <div>
    <ul class="grid grid-cols-3 gap-10 my-10">
      <li v-for="dog in dogs" :key="dog.id">
        <DogCard :name="dog.name" :photoUrl="dog.url" />
      </li>
    </ul>
  </div>
</template>
