<template>
    <transition>
        <div class="popupOverlay">
            <div class="registerPopup">
                <p>register</p>
                <div class="closePopup" @click="$emit('close-register-popup')"><p>X</p></div>
            </div>  
        </div>
    </transition>
</template>

<script>
    export default {}
</script>

<style lang="scss" scoped>
    .popupOverlay{
        position: fixed;
        top: 0;
        bottom: 0;
        left: 0;
        right: 0;
        background-color: rgba(0, 0, 0,0.6);
        display: flex;
        justify-content: center;
        align-items: center;        
        z-index: 100;   
        transition: all 1s ease-out;
            
        .registerPopup{
            z-index: 100;   
            width: 80vw;
            height: 80vh;
            background: white;
            font-size: 2em;
        }
        .registerPopup > *{
            color: black;
        }
        .closePopup > *{
            color: black;
        }
    }
    .popupStart{
        transform: translateY(100vh);
    }
    .popupMove{
        transform: translateY(0);
    }
    .popupOpen{

    }
</style>