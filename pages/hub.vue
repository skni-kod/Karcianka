<template>
    <div class="main">
        <div class="main" v-if="$store.getters.getUserToken">
            <p>Dostęp przyznany</p>
            <p>Witaj {{ $store.getters.getIsAuth }}</p>
        </div>
        <div v-else>
            <p>Nie jesteś zalogowany!</p>
        </div>
    </div>
</template>
<script>
export default {
    mounted() {
        this.$store.dispatch('isAuth', this.$store.getters.getUserToken)
    },
}
</script>
<style lang="scss" scoped>
.main {
    width: 100%;
    height: 100vh;
    p {
        color: black;
    }
}
</style>
