<template lang="">
    <div>
        <div class="image"></div>
        <div class="description">
            <span class="head">{{name}}</span><br>
            <div class="priceTag" v-if="discount > price">
                {{price}},- DKK
            </div>
            <div v-else>
                <p class="priceTagDiscounted">{{price}},- DKK</p>
                <p class="discounted">{{discount}},- DKK</p>
            </div>
            <div>
                <button v-on:click="onBuy"
                    @click="onBuy">
                    Buy
                </button>
            </div>
        </div>
    </div>
</template>
<script>
export default {
    props: ["name","price","discount"]
}
methods: {
    onBuy()
    {
        this.$emit("buying",this.p)
    }
props:["p"]
emits:["buying"]


</script>
<style lang="css">
    div.image{
        display: inline-block;
        background-color: aliceblue;
        width: 128px;
        height: 128px;
        vertical-align: top;
        clear: both;
        margin: 5px;
    }
    span.head{
        font-weight: bold;
        font-size: 20px;
        color: aliceblue;
        text-shadow: 1px 1px #41B883;
        
    }
    p.priceTag{
        color: #41B883;
        font-size: 16px;
        font-weight: bold;
    }
    p.priceTagDiscounted{
        color: #41B883;
        font-size: 16px;
        font-weight: bold;
        text-decoration-line: line-through;
    }
    p.discounted{
        color: #d84551;
        font-size: 16px;
        font-weight: bold;
    }
    div.description{
        display: inline-block;
        margin-left: 10px;
    }
    div.product{
        margin: 10px;
    }
</style>