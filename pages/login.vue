<template>
<div>
    <div class="logo">
        <p class="loginLogo">Logowanie</p>
    </div>

    <div class="formBox">
        <form class="loginForm">
            
        </form>
    </div>

</div>
</template>
<script>
export default {}
</script>

<style lang="scss" scoped>
    .logo{
        width: 100%;
        height: 12em;
        display: flex;
        justify-content: center;
        align-items: center;

        .loginLogo{
            font-family: NeonFontTitle;
            text-transform: uppercase;
            font-size: 6em;
            letter-spacing: .1em;
            color: rgb(43, 255, 0);
            text-shadow: 0 0 5px rgb(0, 216, 11), 0 0 10px rgb(0, 216, 11), 0 0 15px rgb(0, 216, 11),
			0 0 20px rgb(0, 216, 11), 0 0 30px rgb(0, 216, 11), 0 0 45px rgb(0, 216, 11),
			0 0 60px rgb(0, 216, 11), 0 0 75px rgb(0, 216, 11), 0 0 90px rgb(0, 216, 11),
			0 0 110px rgb(0, 216, 11), 0 0 140px rgb(0, 216, 11);
        }
    }
</style>