<template lang="">
    <div>
        <ProductItem v-for="p in productList" v-bind:key="p.name"
            :name="p.name"
            :price="p.price"
            :discount="p.discount"
            @buying="product => buyItem(product)">
        </ProductItem>
    </div>
</template>
<script>
import ProductItem from './ProductItem.vue';

export default {
    components: {
        ProductItem
    },
    data() {
        return {
            "productList" : [
                {
                    name: "Othello lagkage",
                    price: 100,
                    discount: 0
                },
                {
                    name: "Kajkage",
                    price: 25,
                    discount: 20
                },
                {
                    name: "Sandkage",
                    price: 20,
                    discount: 17.50
                }
            ]
        }
    },
    methods:{
        buyItem(product){
            console.log("you bought" + product.name)
        }
    }
}
</script>
<style lang="css">

</style>