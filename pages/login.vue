<template>
<div>
    <div class="logo">
        <p class="loginLogo">Logowanie</p>
    </div>

    <div class="formBox">
        <form class="loginForm">
            <fieldset>
                <input type="text" maxlength="20" class="loginField" name="username" placeholder="Nazwa użytkownika" required/>
            </fieldset>
            <fieldset>
                <input type="password" maxlength="30" class="loginField" name="password" placeholder="Hasło" required/>
            </fieldset>
            <button class="btn" @click="loginUser">Zaloguj się</button>
        </form>
    </div>

</div>
</template>
<script>
export default {
    methods:{
        loginUser(e){
            e.preventDefault();

            try{
                    
            }catch(err){
                console.log(err);
            }

        }
    }
}
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
    .formBox{
        width: 100%;
        display: flex;
        justify-content: center;
        align-items: center;

        .loginForm{
            width: 70%;
            display: flex;
            justify-content: center;
            align-items: center;
            flex-direction: column;

            fieldset{
                width: 100%;
                border: none;
                text-align: center;
                margin: 1em auto;
            }

            fieldset::before{
                content: '';
                position: absolute;
                display: block;
                left: 24.7%;
                bottom: -.3em;
                height: 3.2em;
                width: 49.5%;
                border: .3em solid rgb(43, 255, 0);
                border-color: rgb(43, 255, 0) transparent rgb(43, 255, 0) transparent;
                opacity: 0.4;
            }

            fieldset::after{
                content: '';
                position: absolute;
                display: block;
                left: 24%;
                bottom: -.3em;
                height: 3.2em;
                width: 51%;
                border: .3em solid rgb(43, 255, 0);
                border-color: transparent rgb(43, 255, 0)  transparent rgb(43, 255, 0) ;
                opacity: 0.4;
            }

            .loginField{
                width: 50%;
                font-size: 1.3em;
                height: 2.5em;
                text-indent: .3em;
                background-color: transparent;
                border: none;
            }
            .loginField:focus{
                outline: none;
            }

            .btn{
                width: 50%;
                border: none;
                outline: none;
                color: black;
                font-size: 1.3em;
                height: 2.5em;
                margin: 1.5em auto;
            }
        }
    }
</style>