<script setup>
import { RouterLink, RouterView } from 'vue-router'

</script>

<template>
  <header>
    <div>
     <ul>
        <a><img alt="Vue logo" class="logo" src="@/assets/logo.svg" width="25" height="25"/></a>
        <li><a><RouterLink to="/">Home</RouterLink></a></li>
        <li><a><RouterLink to="/about">About</RouterLink></a></li>
        <li><a><RouterLink to="/products">Products</RouterLink></a></li>
        <li><a><RouterLink to="/Overview">Overview</RouterLink></a></li>
        <li><a><RouterLink to="/tasks">tasks</RouterLink></a></li>
      </ul>
    </div>
  </header>
  <RouterView/>
  <div class="lines">
    <div class="line"></div>
    <div class="line"></div>
    <div class="line"></div>
  </div>
</template>

<style scoped>

header
{
  float: left;
  top: 0;
  width: 100%;
  padding: 25px 100px;
  display: flex;
  justify-content: space-between;
  align-items: center;
  z-index: 10;
  font-size: 1em;
  text-transform: uppercase;
  font-weight: 600;
}
header ul
{
  display: flex;
  justify-content: center;
  align-items: center;
}
header ul li
{
  list-style: none;
  margin-left: 20px;
}
header ul li a
{
  text-decoration: none;
  padding: 5px 15px;    color: #fff;    border-radius: 20px;
}
header ul li a:hover,
header ul li a.active
{
    color:#30fe81;
}

.lines {
  position: absolute;
  top: 0;
  left: 0;
  right: 0;
  height: 950;
  margin: auto;
  width: 75vw;
}
.line {
  position: absolute;
  width: 1px;
  height: 900px;
  top: 0;
  left: 35%;
  background: rgba(255, 255, 255, 0.1);
  overflow: hidden;
}
.line::after {
  content: "";
  display: block;
  position: absolute;
  height: 15vh;
  width: 580;
  top: -50%;
  left: 0;
  background: linear-gradient(to bottom, rgba(255, 255, 255, 0) 0%, #0BFFC8 75%, #0BFFC8 100%);
  -webkit-animation: drop 5s 0s infinite;
          animation: drop 5s 0s infinite;
  -webkit-animation-fill-mode: forwards;
          animation-fill-mode: forwards;
  -webkit-animation-timing-function: cubic-bezier(0.4, 0.26, 0, 0.97);
          animation-timing-function: cubic-bezier(0.4, 0.26, 0, 0.97);
}
.line:nth-child(1) {
  margin-left: -30%;
}
.line:nth-child(1)::after {
  -webkit-animation-delay: 2s;
          animation-delay: 2s;
}
.line:nth-child(3) {
  margin-left: 60%;
}
.line:nth-child(3)::after {
  -webkit-animation-delay: 2.5s;
          animation-delay: 2.5s;
}

</style>
