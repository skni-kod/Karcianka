<template>
    <transition>
        <div class="popupOverlay">
            <div class="loginPopup">
                <p class="title">logowanie</p>
                <div class="closePopup" @click="$emit('close-login-popup')"></div>
                <span class="text">Nie masz konta?</span>
                <p class="registerBtn">Załóż konto</p>
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
            
        .loginPopup{
            z-index: 100;   
            width: 80vw;
            height: 80vh;
            background-color: rgb(41, 41, 41);
            background-repeat: no-repeat;
            background-position: center;
            background-size: 100%;
            font-size: 2em;
            display: flex;
            align-items: center;
            flex-direction: column;
        }
        .loginPopup > *{
            color: black;
        }
        .title{
            height: 33.3333%;
            width: 100%;
            text-transform: uppercase;
            font-family: NeonFontTitle;
            font-size: 2.5em;
            text-align: center;
            padding: .5em 0 0 0;
            letter-spacing: .05em;
        }
        .closePopup{
            position: absolute;
            width: 3vh;
            height: 3vh;
            top: .5em;
            left: .5em;
            background: url("@/assets/img/x-lg.svg");
            background-position: center;
            background-repeat: no-repeat;
            background-size: 100%;
            cursor: pointer;
        }
        .title{

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