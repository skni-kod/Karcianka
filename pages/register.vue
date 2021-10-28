<template>
<div>
    <div class="logo">
        <p class="loginLogo">Rejstracja</p>
    </div>

    <div class="formBox">
        <form class="registerForm">
            <fieldset>
                <input type="text" class="registerField" name="username" maxlength="20" placeholder="Nazwa użytkownika" required />
            </fieldset>
            <fieldset>
                <input type="email" class="registerField" name="email" maxlength="70" placeholder="Email" required />
            </fieldset>
            <fieldset>
                <input type="password" class="registerField" name="password" maxlength="30" placeholder="Hasło" required />
                <input type="password" class="registerField" name="confirmPassword" maxlength="30" placeholder="Potwierdź hasło" required />
            </fieldset>
            <fieldset>
                <input type="checkbox" class="regCheckbox" name="terms" required/>
                <label>Accepts terms</label>
            </fieldset>
            <button class="btn" @click="registerUser">Zarejstruj się</button>
        </form>
    </div>

</div>
</template>

<script>
export default {
    methods:{
        regisetUser(e){
            e.preventDefault();
            let username = false, email = false, password = false, confirmPassword = false, terms = false;

            if(/^[A-Za-z]$/.test(document.querySelector("[name='username']").value)) username = true;
            if(/\w/.test(document.querySelector("[name='email']").value)) email = true;
            if(/^+[A-Za-z0-9]$]/.test(document.querySelector("[name='password']").value)) password = true;
            if(document.querySelector("[name='password']").value === document.querySelector("[name='confirmPassword']").value) confirmPassword = true;
            if(document.querySelector('.regChechbox').checked) terms=true;

            if(username && email && password && confirmPassword && terms){
                try{

                }catch(err){
                    console.log(err);
                }
            }else{
                alert('Nieprawidłowe dane!');
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
            color: rgb(255, 23, 10);
            text-shadow: 0 0 5px rgb(255, 0, 0), 0 0 10px rgb(255, 0, 0), 0 0 15px rgb(255, 0, 0),
			0 0 20px rgb(255, 0, 0), 0 0 30px rgb(255, 0, 0), 0 0 45px rgb(255, 0, 0),
			0 0 60px rgb(255, 0, 0), 0 0 75px rgb(255, 0, 0), 0 0 90px rgb(255, 0, 0),
			0 0 110px rgb(255, 0, 0), 0 0 140px rgb(255, 0, 0);
        }
    }

    .formBox{
        width: 100%;
        display: flex;
        justify-content: center;
        align-items: center;
    
         .registerForm{
            width: 70%;
            display: flex;
            justify-content: center;
            align-items: center;
            flex-direction: column;

            fieldset{
                width: 100%;
                border: none;
                text-align: center;
                margin: .5em auto;
            }

            .registerField{
                width: 50%;
                font-size: 1.3em;
                height: 2.5em;
                text-indent: .3em;
                color: black;
                border: 3px solid rgb(255, 23, 10);
            }

            .registerField:nth-of-type(2){
                margin: 1em auto;
            }

            .registerField:focus{
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