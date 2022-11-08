<template lang="">
    <div>
        <div class="column">
        <div class="grid-container">
            <div class="grid-item" v-for="(item, index) in list" v-bind:key="item.Id">
                <h1>{{item.name}}</h1>
                <ul>
                    <div v-for="todo in item.toDo">
                        <div v-if="todo.isComplete == 0">
                            <li class="InComplete">{{todo.name}}</li>
                        </div>
                        <div v-else>
                            <li class="IsComplete">{{todo.name}}</li>
                        </div>
                    </div>
                </ul>
            </div>
        </div>
        </div>
    </div>
</template>
<script>
import axios from "axios"
export default {
    name: "Task",
    data() {
        return {
            list: [{}]
        }
    },
    async mounted() {
        let result = await axios.get("https://localhost:7176/Todo/GetTaskTodo");
        console.warn(result.data)
        this.list = result.data
    }
};
</script>
<style lang="css">
@import url(https://fonts.googleapis.com/css?family=Poppins:300,400,500,600,700,800,900&display=swap);
*
    * {
        box-sizing: border-box;
    }
    .column{
        float: left;
        width: 20%;
        padding: 5px;
    }

    .row:after{
        content: "";
        display: table;
        clear: both;
    }
    .grid-container{
        display: grid;
        gap: 20px;
        background-color: transparent;
        padding: 10px;
    }

    li.InComplete::before{
        content: '❌';
        list-style-type: none;
        margin-left: -25px; 
        margin-right: 10px;
    }

    li.IsComplete::before{
        content: '✅';
        list-style-type: none;
        margin-left: -25px; 
        margin-right: 10px;
    }

    ul{
        list-style-type: none;
    }

    .grid-item{
        z-index: 1;
        background-color: #bec5c2;
        border: 1px solid black;
        text-align: left;
        border-radius: 15px;
        color: black;
    }
</style>