<template>
    <div v-if="!isLoaded" class="loader">
        <div class="circle"></div>
    </div>
</template>

<script>
    export default {
        data: ()=>{
            return{
                isLoaded: false
            }
        },
        mounted(){
            document.onreadystatechange = () =>{
                if(document.readyState === "complete"){
                    this.isLoaded = true;
                } 
            }
            if(document.readyState === "complete"){
                this.isLoaded = true;
            } 
        }
    }
</script>

<style lang="scss" scoped>
    .loader{
        position: fixed;
        left: 0;
        right: 0;
        top: 0;
        bottom: 0;
        z-index: 100;
        background: rgb(0, 22, 82);
        color: white;
        font-size: 10em;
        text-transform: uppercase;
        display: flex;
        justify-content: center;
        align-items: center;

        .circle{
            z-index: 100;
            width: 1em;
            height: 1em;
            border: .1em solid rgb(230, 230, 230);
            border-radius: 50%;
            border-color: transparent rgb(230, 230, 230) transparent rgb(230, 230, 230);
            animation: circle-rotate 1s infinite;    
        }

        @keyframes circle-rotate {
            100%{
                transform: rotate(360deg);
            }
        }
    }
</style>