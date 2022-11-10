<template>
    <div class="Task-Item">
        <h1 class="ItemName">{{item.name}}</h1>
    </div>
</template>
<script>

export default {
    props: ['item'],
    data(){
        return{

        }
    }
}
</script>
<style lang="css">
    .Task-Item{
        padding: 10px 20px;
        border: 1px solid #ddd;
        background-color: #ddd;
        border-radius: 10px;
        color: black;
        margin-top: 10px;
        min-height: 100px;
    }
    .Task-Item:hover{
        cursor:move;
    }

    .ItemName{
        color: black;
        font-size: 24px;
    }
</style>