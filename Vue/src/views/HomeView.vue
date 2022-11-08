<script setup>

</script>

<template>
  <main>
    <div>
      <h2 class="welcome1">Welcome to</h2>
      <h1 class="welcome2">Burro</h1>
  </div>
  </main>
</template>

<style>
.welcome1{
  color: #fff;
  font-size: 4em;
  text-align: center;
}
.welcome2{
  color: #30fe81;
  text-shadow: #fff;
  font-size: 5em;
  text-align: center;
  -webkit-animation: glow 5s ease-in-out infinite alternate;
  -moz-animation: glow 5s ease-in-out infinite alternate;
  animation: glow 5s ease-in-out infinite alternate;
}

@-webkit-keyframes glow {
  from {
    text-shadow: 0 0 5px #30fe81, 0 0 10px #30fe81;
  }
  to {
    text-shadow: 0 0 5px #91e6ad, 0 0 12px #91e6ad;
  }
}</style>
