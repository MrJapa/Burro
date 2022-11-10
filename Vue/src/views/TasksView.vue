<template >
    <div class="grid-container">
        <div class="Grid">
            <h1 class="StateList">Backlog</h1>
            <TaskLists title="Backlog" :List="Backlog"></TaskLists>
        </div>
        <div class="Grid">
            <h1 class="StateList">ToDo</h1>
            <TaskLists title="ToDo" :List="ToDo"></TaskLists>
        </div>
        <div class="Grid">
            <h1 class="StateList">In Progress</h1>
            <TaskLists title="In Progress" :List="InProgress"></TaskLists>
        </div>
        <div class="Grid">
            <h1 class="StateList">Review</h1>
            <TaskLists title="Review" :List="Review"></TaskLists>
        </div>
        <div class="Grid">
            <h1 class="StateList">Done</h1>
            <TaskLists title="Done" :List="Done"></TaskLists>
        </div>
    </div>
</template>
<script>
import TaskLists from '@/components/TaskLists.vue';
import TaskItem from '@/components/TaskItem.vue';
import axios from "axios"
import { VueDraggableNext } from 'vue-draggable-next';
export default {
    data() {
        return {
            Backlog: [{}],
            ToDo: [{}],
            InProgress: [{}],
            Review: [{}],
            Done: [{}]
        }
    },
    async mounted() {
        let result = await axios.get("https://localhost:7176/Todo/GetAllTasksByID");
        let BacklogResult = result.data.filter(t => t.state.stateID == 1)
        let ToDoResult = result.data.filter(t => t.state.stateID == 2)
        let InProgressResult = result.data.filter(t => t.state.stateID == 3)
        let ReviewResult = result.data.filter(t => t.state.stateID == 4)
        let DoneResult = result.data.filter(t => t.state.stateID == 5)
        this.Backlog = BacklogResult
        this.ToDo = ToDoResult
        this.InProgress = InProgressResult
        this.Review = ReviewResult
        this.Done = DoneResult
    },
    components: {
        TaskLists,
        TaskItem,
        draggable: VueDraggableNext,
    }
}
</script>
<style lang="css">
.Tasks {
    justify-content: center;
    margin: 50px 0;
    align-items: flex-start;
    float: left;
}

.Grid {
    background-color: rgba(19, 100, 51);
    border-radius: 7.5px;
    text-align: center;
}

.grid-container {
    top: 75px;
    align-items: center;
    display: grid;
    gap: 20px 50px;
    grid-template-columns: repeat(5);
    grid-auto-flow: column;
    padding: 10px;
    align-items: flex-start;
    border-radius: 10px;
}

.column {
    display: flex;
    float: left;
    width: 20%;
    padding: 5px;
}

.row:after {
    content: "";
    display: table;
    clear: both;
}

.grid-container {
    display: grid;
    gap: 20px;
    padding: 10px;
}

.grid-item {
    z-index: 1;
    background-color: #bec5c2;
    border: 1px solid black;
    text-align: left;
    border-radius: 15px;
    color: black;
}

.StateList{
    color: white;
    background-color: transparent;
}
</style>