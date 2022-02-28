<template>
    <transition>
        <div
            class="rankingPopup"
            v-if="$store.state.showRankingPopup"
            onselectstart="return false;"
        >
            <p class="title">RankingPopup</p>
            <div
                class="closePopup"
                @click="$store.dispatch('closeRankingPopup')"
            ></div>
        </div>
    </transition>
</template>

<script>
export default {}
</script>

<style lang="scss" scoped>
* {
    color: black;
    font-family: NeonFontButtons2;
}

.rankingPopup {
    z-index: 100;
    position: fixed;
    top: 0;
    left: 0;
    right: 0;
    bottom: 0;
    background-color: rgb(230, 230, 230);

    .closePopup {
        position: absolute;
        width: 4vh;
        height: 4vh;
        top: 0.7em;
        left: 0.7em;
        background: url('@/assets/img/x-lg.svg');
        background-position: center;
        background-repeat: no-repeat;
        background-size: 100%;
        cursor: pointer;
    }

    .title {
        width: 100%;
        font-size: 2em;
        text-align: center;
    }
}
.v-enter {
    transform: translateY(100vh);
    opacity: 0.3;
}
.v-enter-to {
    transform: translateY(0);
    opacity: 1;
}
.v-enter-active {
    transition: all 0.5s ease;
}
.v-leave-from {
    transform: translateY(0);
    opacity: 1;
}
.v-leave-to {
    transform: translateY(100vh);
    opacity: 0.3;
}
.v-leave-active {
    transition: all 0.5s ease;
}
</style>
