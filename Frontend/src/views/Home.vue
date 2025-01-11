<script setup lang="ts">
import { defineAsyncComponent } from 'vue'

const Doglist = defineAsyncComponent(() => import('@/components/DogList.vue'))
</script>

<template>
  <div>
    <img src="" />
    <h1 class="font-semibold text-5xl mb-4">Give a Dog a home</h1>
    <div class="w-2/3">
      <p>
        Lorem ipsum dolor sit, amet consectetur adipisicing elit. Sit vero, nihil eum fugit commodi
        perspiciatis et delectus deleniti quod porro, eos, at animi beatae ipsam tempore vitae
        soluta illum velit!
      </p>
    </div>
  </div>
  <div>
    <Suspense>
      <Doglist></Doglist>
    </Suspense>
  </div>
</template>
