<template>
    <div class="Task-List">
        <draggable :list="List" group="taskapp" animation="400" :emptyInsertThreshold="25">
                <TaskItem v-for="task in List" :key="task.id" :item="task"></TaskItem>
        </draggable>
        <draggable :list="ToDo" group="taskapp" ghostClass="on-drag" animation="400" :emptyInsertThreshold="25">
                <TaskItem v-for="task in ToDo" :key="task.id" :item="task"></TaskItem>
        </draggable>
        <draggable :list="InProgress" group="taskapp" ghostClass="on-drag" animation="400" :emptyInsertThreshold="25">
                <TaskItem v-for="task in InProgress" :key="task.id" :item="task"></TaskItem>
        </draggable>
        <draggable :list="Review" group="taskapp" ghostClass="on-drag" animation="400" :emptyInsertThreshold="25">
                <TaskItem v-for="task in Review" :key="task.id" :item="task"><h1>test</h1></TaskItem>
        </draggable>
        <draggable :list="Done" group="taskapp" ghostClass="on-drag" animation="400" :emptyInsertThreshold="25">
                <TaskItem v-for="task in Done" :key="task.id" :item="task"></TaskItem>
        </draggable>
    </div>
</template>
<script>
import {VueDraggableNext} from 'vue-draggable-next';
import TaskItem from '@/components/TaskItem.vue';
export default {
    props : ['List'],
    data(){
        return{
            
        }
    },
    components: {
        TaskItem,
        draggable:VueDraggableNext,
    }
}
</script>
<style lang="css">
    .Task-List{
        padding: 10px 20px;
        margin: 0 10px;
        border: 1px solid rgb(255, 255, 255);
        text-align: center;
    }
    .title{
        padding: 10px;
        font-size: 20px;
        font-weight: 600;
        margin-bottom: 10px;
    }
</style>