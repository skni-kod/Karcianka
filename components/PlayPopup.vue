<template>
    <transition>
        <div class="playPopup" v-if="open">
            <div class="gameSection">
                <input type="text" class="nickname" name="nickname" maxlength="20" placeholder="Podaj nickname"/>
                <p class="gameButton">dołącz do gry</p>
                <p class="gameButton">stwórz grę</p>
            </div>
            <div class="accountSection">
                <form class="loginForm">
                    <fieldset>
                        <input type="text" class="nickname formInput" name="nickname" maxlength="20" placeholder="Nickname" required />
                    </fieldset>
                    <fieldset>
                        <input type="password" class="password formInput" name="password" maxlength="30" placeholder="Hasło" required />
                    </fieldset>
                    <button class="loginButton" @click="loginUser">Zaloguj się</button>
                </form>
                <p class="text">lub</p>
                <p class="toRegisterButton">Załóż konto</p>
            </div>
            <div class="closePopup" @click="$emit('close-play-popup')"></div>
        </div> 
    </transition>
</template>

<script>
    export default {
        props: ['open'],
        methods:{
            loginUser(e){
                e.preventDefault();
            }
        }
    }
</script>

<style lang="scss" scoped>  
    $pink-color: rgb(255, 0, 234);
    $blue-color: rgb(0, 164, 230); 
    *{
        color: black;
        box-sizing: border-box;
    }
    .playPopup{
        z-index: 100;   
        position: fixed;
        top: 0;
        left: 0;
        right: 0;
        bottom: 0;
        background-color: rgb(230, 230, 230);
        display: grid;
        grid-template-columns: repeat(2,1fr);
        grid-template-rows: repeat(1,1fr);

        .gameSection, .accountSection{
            display: flex;
            justify-content: center;
            align-items: center;
            flex-direction: column;
        }

        .gameSection{
            .nickname{
                margin: 1em;
                width: 40%;
                height: 3em;
                text-indent: .4em;
                font-size: 1.3em;
                font-family: NeonFontButtons2;
                letter-spacing: .1em;
                background-color: transparent;
                border: .15em solid rgba(0, 0, 0, 0.4);
                transition: all .1s ease;
                text-align: center;
            }

            .nickname:focus{
                outline: none;
                color:rgb(20, 216, 255);
                text-shadow: 1px 0px 4px $blue-color, 2px 0px 4px $blue-color, 2px 0px 3px $blue-color,
				    2px 3px 15px $blue-color, 2px 0px 15px $blue-color, 2px 0px 20px $blue-color, 2px 0px 20px $blue-color, 5px 0px 125px $blue-color,
				    20px 0vw 200px ;
                border-color: rgb(255, 0, 234);
                box-shadow: 0px 0px 10px 2px $pink-color, inset 0px 0px 10px 2px $pink-color;
            }

            .nickname::placeholder{
                text-shadow: 0 0 0 rgb(230, 230, 230);
                text-align: center;
            }

            .gameButton{
                height: 2.3em;
                width: 40%;
                font-size: 2em;
                text-transform: uppercase;
                font-family: NeonFontButtons2;
                margin: .5em;
                display: flex;
                justify-content: center;
                align-items: center;
                letter-spacing: .07em;
                border: .15em solid rgba(0, 0, 0, 0.4);
                transition: all .1s ease;
            }

/*
            .gameButton::before{
                content: '';
                position: absolute;
                top: 0;
                left: -.15em;
                right: -.15em;
                height: .1em;
                background-color: transparent;
            }
            .gameButton::after{
                content: '';
                position: absolute;
                bottom: 0;
                left: -.15em;
                right: -.15em;
                height: .08em;
                background-color: rgb(230, 230, 230);
            }
*/
            .gameButton:hover{
                color:rgb(20, 216, 255);
                text-shadow: 1px 0px 4px $blue-color, 2px 0px 4px $blue-color, 2px 0px 3px $blue-color,
				2px 3px 15px $blue-color, 2px 0px 15px $blue-color, 2px 0px 20px $blue-color, 2px 0px 20px $blue-color, 5px 0px 125px $blue-color,
				20px 0vw 200px ;
                border-color: rgb(255, 0, 234);
                box-shadow: 0px 0px 10px 2px $pink-color, inset 0px 0px 10px 2px $pink-color; 
            }
        }

        .accountSection{
            .loginForm{
                width: 40%;

                fieldset{
                    border: none;
                    margin: 1em 0;
                    display: flex;
                    justify-content: center;
                    align-items: center;
                }

                .formInput{
                    width: 100%;
                    height: 2.5em;
                    font-size: 1.5em;
                    text-indent: .4em;
                    font-family: NeonFontButtons2;
                    letter-spacing: .1em;
                    background-color: transparent;
                    border: .15em solid rgba(0, 0, 0, 0.4);
                    transition: all .1s ease;
                    text-align: center;
                }

                .formInput:focus{
                    outline: none;
                    color:rgb(20, 216, 255);
                    text-shadow: 1px 0px 4px $blue-color, 2px 0px 4px $blue-color, 2px 0px 3px $blue-color,
				        2px 3px 15px $blue-color, 2px 0px 15px $blue-color, 2px 0px 20px $blue-color, 2px 0px 20px $blue-color, 5px 0px 125px $blue-color,
				        20px 0vw 200px ;
                    border-color: rgb(255, 0, 234);
                    box-shadow: 0px 0px 10px 2px $pink-color, inset 0px 0px 10px 2px $pink-color;
                }

                .formInput::placeholder{
                    text-shadow: 0 0 0 rgb(230, 230, 230);
                    text-align: center;
                }

                .loginButton{
                    width: 100%;
                    height: 2.2em;
                    margin: .8em 0 .4em 0;
                    font-size: 2em;
                    text-transform: uppercase;
                    font-family: NeonFontButtons2;
                    display: flex;
                    justify-content: center;
                    align-items: center;
                    letter-spacing: .07em;
                    border: .15em solid rgba(0, 0, 0, 0.4);
                    transition: all .1s ease;
                }
                .loginButton:hover{
                    color:rgb(20, 216, 255);
                    text-shadow: 1px 0px 4px $blue-color, 2px 0px 4px $blue-color, 2px 0px 3px $blue-color,
				        2px 3px 15px $blue-color, 2px 0px 15px $blue-color, 2px 0px 20px $blue-color, 2px 0px 20px $blue-color, 5px 0px 125px $blue-color,
				        20px 0vw 200px ;
                    border-color: rgb(255, 0, 234);
                    box-shadow: 0px 0px 10px 2px $pink-color, inset 0px 0px 10px 2px $pink-color;
                    cursor: pointer;
                }
            }
            
            .text{
                width: 40%;
                text-transform: uppercase;
                font-family: NeonFontButtons2;
                letter-spacing: .1em;
                font-size: 1.8em;
                text-align: center;
            }
            .toRegisterButton{
                width: 40%;
                height: 2.2em;
                margin: .8em 0 .4em 0;
                font-size: 2em;
                text-transform: uppercase;
                font-family: NeonFontButtons2;
                display: flex;
                justify-content: center;
                align-items: center;
                letter-spacing: .07em;
                border: .15em solid rgba(0, 0, 0, 0.4);
                transition: all .1s ease;
            }
            .toRegisterButton:hover{
                color:rgb(20, 216, 255);
                text-shadow: 1px 0px 4px $blue-color, 2px 0px 4px $blue-color, 2px 0px 3px $blue-color,
				    2px 3px 15px $blue-color, 2px 0px 15px $blue-color, 2px 0px 20px $blue-color, 2px 0px 20px $blue-color, 5px 0px 125px $blue-color,
				    20px 0vw 200px ;
                border-color: rgb(255, 0, 234);
                box-shadow: 0px 0px 10px 2px $pink-color, inset 0px 0px 10px 2px $pink-color;
                cursor: pointer;
            }
        }

        .closePopup{
            position: absolute;
            width: 4vh;
            height: 4vh;
            top: .7em;
            left: .7em;
            background: url("@/assets/img/x-lg.svg");
            background-position: center;
            background-repeat: no-repeat;
            background-size: 100%;
            cursor: pointer;
        }
    }

    .v-enter{
        transform: translateY(100vh);
        opacity: 0.3;
    }
    .v-enter-to{
        transform: translateY(0);
        opacity: 1;
    }
    .v-enter-active{
        transition: all .5s ease;
    }
    .v-leave-from{
        transform: translateY(0);
        opacity: 1;
    }
    .v-leave-to{
        transform: translateY(100vh);
        opacity: 0.3;
    }
    .v-leave-active{
        transition: all .5s ease; 
    }
</style>