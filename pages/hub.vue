<template>
    <div class="main">
        <div v-if="isAuth === false">
            <p>Nie jesteś zalogowany!</p>
        </div>
        <div class="main" v-if="isAuth === true">
            <p>Dostęp przyznany</p>
        </div>
    </div>
</template>
<script>
export default {
    data: () => {
        return {
            isAuth: true,
        }
    },
    /*
        mounted() {
        if (process.client) {
            if (localStorage.getItem('token') !== null) {
                fetch('http://localhost:5000/auth', {
                    method: 'POST',
                    headers: { 'Content-Type': 'application/json' },
                    body: JSON.stringify({
                        token: localStorage.getItem('token'),
                    }),
                })
                    .then((response) => response.json())
                    .then((data) => {
                        console.log(data)
                        this.isAuth = true
                    })
            }
        }
        console.log(this.isAuth)
        //if (this.isAuth === false) this.$router.push('/')
    },
     */
}
</script>
<style lang="scss" scoped>
.main {
    width: 100%;
    height: 100vh;
}
</style>
