<script setup>
  import { useSlideContext } from '@slidev/client'
  import { useHead } from '@unhead/vue'
  
  const { $slidev } = useSlideContext()

  useHead({
    script: [
      {
        type: 'application/ld+json',
        innerHTML: $slidev.configs?.bioschemas ?? {}
      },
    ],
  })

  let license = $slidev.configs?.license ?? null
  console.log($slidev.configs.license)
  let licensePath;
  if (license) {
    if ($slidev.configs?.license === 'cc-by') {
      licensePath = new URL('./assets/cc/by.png', import.meta.url).href;
    } else if ($slidev.configs?.license === 'cc-by-sa') {
      licensePath = new URL('./assets/cc/by-sa.png', import.meta.url).href;
    } else if ($slidev.configs?.license === 'cc-by-nd') {
      licensePath = new URL('./assets/cc/by-nd.png', import.meta.url).href;
    } else if ($slidev.configs?.license === 'cc-by-nc') {
      licensePath = new URL('./assets/cc/by-nc.eu.png', import.meta.url).href;
    } else if ($slidev.configs?.license === 'cc-by-nc-sa') {
      licensePath = new URL('./assets/cc/by-nc-sa.eu.png', import.meta.url).href;
    } else if ($slidev.configs?.license === 'cc-by-nc-nd') {
      licensePath = new URL('./assets/cc/by-nc-nd.eu.png', import.meta.url).href;
    } else {
      licensePath = null;
    }
  }
</script>

<template>
  <div class="slidev-layout statement">
    <div class="my-auto">
      <slot />
    </div>
    <footer v-if="!$slidev.nav.currentLayout.includes('cover') && !$slidev.nav.currentLayout.includes('section')" style="bottom: 0; left: 0; position: absolute">
      <div 
        v-if="!['image-left', 'iframe-left'].includes($slidev.nav.currentLayout)"
        class="absolute bottom-2 right-1 w-12">
        <img v-if="licensePath" :src="licensePath" alt="Creative Commons Attribution" />
      </div>  
      <div v-else class="absolute bottom-2 left-1 w-12">
        <img :src="licensePath" alt="Creative Commons Attribution" />
      </div>  
      <img
          v-if="!['image-left', 'iframe-left'].includes($slidev.nav.currentLayout)"
          src="./assets/dataplant-footer.png"
      />
      <img
          v-else
          src="./assets/dataplant-footer-right.png"
      />
    </footer>
    <footer v-else class="absolute bottom-2 right-1 w-12">
      <img :src="licensePath" alt="Creative Commons Attribution" />
    </footer>
  </div>
</template>