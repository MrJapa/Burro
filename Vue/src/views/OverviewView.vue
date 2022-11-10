<template lang="">
    <div>
        <h1>Tasks</h1>
        <TaskList></TaskList>
        <TaskList></TaskList>
        <TaskList></TaskList>
        <TaskList></TaskList>
        <TaskList></TaskList>
    </div>
</template>
<script>
import TaskList from '@/components/TaskList.vue';

export default {
    components: {
        TaskList
    }
}
</script>
<style lang="css">

</style>