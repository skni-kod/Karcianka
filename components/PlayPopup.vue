<template>
    <transition name="popup">
        <div
            class="playPopup"
            v-if="$store.state.showPlayPopup"
            onselectstart="return false;"
        >
            <div class="gameSection">
                <input
                    type="text"
                    class="nickname"
                    name="nickname"
                    maxlength="20"
                    placeholder="Podaj nickname"
                />
                <p class="gameButton">graj</p>
            </div>
            <div class="accountSection">
                <transition name="form">
                    <div class="loginBox" v-if="!registerFormActive">
                        <form class="loginForm" @submit.prevent="loginUser">
                            <fieldset>
                                <input
                                    type="text"
                                    class="nickname formInput"
                                    name="username"
                                    v-model="username"
                                    maxlength="15"
                                    placeholder="Nickname"
                                    required
                                />
                            </fieldset>
                            <fieldset>
                                <input
                                    type="password"
                                    class="password formInput"
                                    name="password"
                                    v-model="passwd"
                                    maxlength="30"
                                    placeholder="Hasło"
                                    required
                                />
                            </fieldset>
                            <button v-if="!logging" class="loginButton">
                                Zaloguj się
                            </button>
                            <button v-else class="loginButton">
                                Logowanie ...
                            </button>
                        </form>
                        <p class="text">lub</p>
                        <p
                            class="toRegisterButton"
                            @click="registerFormActive = true"
                        >
                            Załóż konto
                        </p>
                    </div>
                </transition>
                <transition name="form">
                    <div class="registerBox" v-if="registerFormActive">
                        <form
                            class="registerForm"
                            @submit.prevent="registerUser"
                        >
                            <fieldset>
                                <input
                                    type="text"
                                    class="username formInput"
                                    name="username"
                                    v-model="username"
                                    maxlength="20"
                                    placeholder="Nickname"
                                    required
                                />
                            </fieldset>
                            <fieldset>
                                <input
                                    type="email"
                                    class="email formInput"
                                    name="email"
                                    v-model="email"
                                    maxlength="70"
                                    placeholder="Email"
                                    required
                                />
                            </fieldset>
                            <fieldset>
                                <input
                                    type="password"
                                    class="password formInput"
                                    name="password"
                                    v-model="passwd"
                                    maxlength="30"
                                    placeholder="Hasło"
                                    required
                                />
                                <input
                                    type="password"
                                    class="confirmPassword formInput"
                                    name="confirmPassword"
                                    v-model="confirmPasswd"
                                    maxlength="30"
                                    placeholder="Powtórz hasło"
                                    required
                                />
                            </fieldset>
                            <input
                                type="checkbox"
                                class="terms"
                                name="terms"
                                required
                            />
                            <label
                                >Akcpetuję warunki korzystania z serwisu i
                                politykę prywatności</label
                            >
                            <button v-if="sending" class="registerButton">
                                Rejestrowanie...
                            </button>
                            <button v-else class="registerButton">
                                Załóż konto
                            </button>
                        </form>
                        <p class="text">lub</p>
                        <p
                            class="toRegisterButton"
                            @click="registerFormActive = false"
                        >
                            Zaloguj się
                        </p>
                    </div>
                </transition>
            </div>
            <div
                class="closePopup"
                @click="$store.dispatch('closePlayPopup')"
            ></div>
        </div>
    </transition>
</template>

<script>
export default {
    props: ['open'],
    methods: {
        async loginUser() {
            this.logging = true
            this.$axios
                .$post(`/login`, {
                    username: this.username,
                    passwd: this.passwd,
                })
                .then((response) => {
                    this.successApi.push(response)
                    console.log(this.successApi)
                    this.$store.dispatch('setUserToken', response)
                    this.logging = false
                    this.$router.push('hub')
                })
                .catch((response) => {
                    this.errorsApi.push(response)
                    console.log(this.errorsApi)
                    this.logging = false
                })
        },
        async registerUser() {
            this.sending = true
            if (this.passwd === this.confirmPasswd) {
                this.$axios
                    .$post(`/register`, {
                        username: this.username,
                        email: this.email,
                        passwd: this.passwd,
                    })
                    .then((response) => {
                        this.successApi.push(response)
                        console.log(this.successApi)
                        this.sending = false
                        this.passwd = ''
                        this.confirmPasswd = ''
                    })
                    .catch((response) => {
                        this.errorsApi.push(response)
                        console.log(this.errorsApi)
                        this.sending = false
                    })
            } else {
                console.log('Złe hasła')
            }
        },
    },
    data() {
        return {
            username: '',
            email: '',
            passwd: '',
            confirmPasswd: '',
            sending: false,
            logging: false,
            successApi: [],
            errorsApi: [],
            registerFormActive: false,
        }
    },
}
</script>

<style lang="scss" scoped>
* {
    color: black;
    font-family: NeonFontButtons2;
}
.playPopup {
    z-index: 100;
    position: fixed;
    top: 0;
    left: 0;
    right: 0;
    bottom: 0;
    background-color: rgb(230, 230, 230);
    display: grid;
    grid-template-columns: repeat(2, 1fr);
    grid-template-rows: repeat(1, 1fr);

    .gameSection,
    .accountSection {
        display: flex;
        justify-content: center;
        align-items: center;
        flex-direction: column;
    }

    .gameSection {
        .nickname {
            margin: 1.5rem;
            width: 40%;
            height: 4rem;
            text-indent: 0.4rem;
            font-size: 1.5rem;
            letter-spacing: 0.1rem;
            background-color: transparent;
            border: 0.2rem solid rgba(0, 0, 0, 0.4);
            transition: all 0.1s ease;
            text-align: center;

            &:focus {
                outline: none;
                color: rgb(20, 216, 255);
                text-shadow: 1px 0px 4px var(--blue), 2px 0px 4px var(--blue),
                    2px 0px 3px var(--blue), 2px 3px 15px var(--blue),
                    2px 0px 15px var(--blue), 2px 0px 20px var(--blue),
                    2px 0px 20px var(--blue), 5px 0px 125px var(--blue),
                    20px 0vw 200px;
                border-color: rgb(255, 0, 234);
                box-shadow: 0px 0px 10px 2px var(--pink),
                    inset 0px 0px 10px 2px var(--pink);
            }
            &::placeholder {
                text-shadow: 0 0 0 rgb(230, 230, 230);
                text-align: center;
            }
        }

        .gameButton {
            height: 4rem;
            width: 40%;
            font-size: 2rem;
            letter-spacing: 0.3rem;
            text-transform: uppercase;
            margin: 0.5rem;
            display: flex;
            justify-content: center;
            align-items: center;
            border: 0.2rem solid rgba(0, 0, 0, 0.4);
            transition: all 0.1s ease;

            &:hover {
                color: rgb(20, 216, 255);
                text-shadow: 1px 0px 4px var(--blue), 2px 0px 4px var(--blue),
                    2px 0px 3px var(--blue), 2px 3px 15px var(--blue),
                    2px 0px 15px var(--blue), 2px 0px 20px var(--blue),
                    2px 0px 20px var(--blue), 5px 0px 125px var(--blue),
                    20px 0vw 200px;
                border-color: rgb(255, 0, 234);
                box-shadow: 0px 0px 10px 2px var(--pink),
                    inset 0px 0px 10px 2px var(--pink);
            }
        }
    }

    .loginBox {
        width: 100%;
        display: flex;
        justify-content: center;
        align-items: center;
        flex-direction: column;

        .loginForm {
            width: 50%;

            fieldset {
                border: none;
                margin: 1.5rem 0;
                display: flex;
                justify-content: center;
                align-items: center;
            }

            .formInput {
                width: 100%;
                height: 4rem;
                font-size: 1.8rem;
                text-indent: 0.4rem;
                letter-spacing: 0.1rem;
                background-color: transparent;
                border: 0.2rem solid rgba(0, 0, 0, 0.4);
                transition: all 0.1s ease;
                text-align: center;

                &:focus {
                    outline: none;
                    color: rgb(20, 216, 255);
                    text-shadow: 1px 0px 4px var(--blue),
                        2px 0px 4px var(--blue), 2px 0px 3px var(--blue),
                        2px 3px 15px var(--blue), 2px 0px 15px var(--blue),
                        2px 0px 20px var(--blue), 2px 0px 20px var(--blue),
                        5px 0px 125px var(--blue), 20px 0vw 200px;
                    border-color: rgb(255, 0, 234);
                    box-shadow: 0px 0px 10px 2px var(--pink),
                        inset 0px 0px 10px 2px var(--pink);
                }
                &::placeholder {
                    text-shadow: 0 0 0 rgb(230, 230, 230);
                    text-align: center;
                }
            }

            .loginButton {
                width: 100%;
                height: 3.5rem;
                margin: 0.8rem 0 0.4rem 0;
                font-size: 2rem;
                text-transform: uppercase;
                display: flex;
                justify-content: center;
                align-items: center;
                letter-spacing: 0.2rem;
                border: 0.2rem solid rgba(0, 0, 0, 0.4);
                transition: all 0.1s ease;

                &:hover {
                    color: rgb(20, 216, 255);
                    text-shadow: 1px 0px 4px var(--blue),
                        2px 0px 4px var(--blue), 2px 0px 3px var(--blue),
                        2px 3px 15px var(--blue), 2px 0px 15px var(--blue),
                        2px 0px 20px var(--blue), 2px 0px 20px var(--blue),
                        5px 0px 125px var(--blue), 20px 0vw 200px;
                    border-color: rgb(255, 0, 234);
                    box-shadow: 0px 0px 10px 2px var(--pink),
                        inset 0px 0px 10px 2px var(--pink);
                    cursor: pointer;
                }
            }
        }
    }

    .registerBox {
        width: 100%;
        display: flex;
        justify-content: center;
        align-items: center;
        flex-direction: column;
        position: absolute;

        .registerForm {
            width: 50%;

            fieldset {
                border: none;
                margin: 1.5rem 0;
                display: flex;
                justify-content: center;
                align-items: center;
                flex-direction: column;
            }

            .formInput {
                width: 100%;
                height: 4rem;
                font-size: 1.8rem;
                text-indent: 0.4rem;
                letter-spacing: 0.1rem;
                background-color: transparent;
                border: 0.2rem solid rgba(0, 0, 0, 0.4);
                transition: all 0.1s ease;
                text-align: center;

                &:focus {
                    outline: none;
                    color: rgb(20, 216, 255);
                    text-shadow: 1px 0px 4px var(--blue),
                        2px 0px 4px var(--blue), 2px 0px 3px var(--blue),
                        2px 3px 15px var(--blue), 2px 0px 15px var(--blue),
                        2px 0px 20px var(--blue), 2px 0px 20px var(--blue),
                        5px 0px 125px var(--blue), 20px 0vw 200px;
                    border-color: rgb(255, 0, 234);
                    box-shadow: 0px 0px 10px 2px var(--pink),
                        inset 0px 0px 10px 2px var(--pink);
                }
                &::placeholder {
                    text-shadow: 0 0 0 rgb(230, 230, 230);
                    text-align: center;
                }
            }

            .errorFormInput {
                border-color: rgb(255, 23, 10);
                box-shadow: 0px 0px 10px 2px var(--red),
                    inset 0px 0px 10px 2px var(--red);
            }

            .password {
                margin: 0 0 1rem 0;
            }

            .registerButton {
                width: 100%;
                height: 3.5rem;
                margin: 0.8rem 0 0.4rem 0;
                font-size: 2rem;
                text-transform: uppercase;
                display: flex;
                justify-content: center;
                align-items: center;
                letter-spacing: 0.2rem;
                border: 0.2rem solid rgba(0, 0, 0, 0.4);
                transition: all 0.1s ease;

                &:hover {
                    color: rgb(20, 216, 255);
                    text-shadow: 1px 0px 4px var(--blue),
                        2px 0px 4px var(--blue), 2px 0px 3px var(--blue),
                        2px 3px 15px var(--blue), 2px 0px 15px var(--blue),
                        2px 0px 20px var(--blue), 2px 0px 20px var(--blue),
                        5px 0px 125px var(--blue), 20px 0vw 200px;
                    border-color: rgb(255, 0, 234);
                    box-shadow: 0px 0px 10px 2px var(--pink),
                        inset 0px 0px 10px 2px var(--pink);
                    cursor: pointer;
                }
            }
        }
    }

    .text {
        width: 40%;
        text-transform: uppercase;
        letter-spacing: 0.1rem;
        font-size: 1.8rem;
        text-align: center;
    }
    .toRegisterButton {
        width: 50%;
        height: 3.5rem;
        margin: 0.8rem 0 0.4rem 0;
        font-size: 2rem;
        text-transform: uppercase;
        display: flex;
        justify-content: center;
        align-items: center;
        letter-spacing: 0.2rem;
        border: 0.2rem solid rgba(0, 0, 0, 0.4);
        transition: all 0.1s ease;

        &:hover {
            color: rgb(20, 216, 255);
            text-shadow: 1px 0px 4px var(--blue), 2px 0px 4px var(--blue),
                2px 0px 3px var(--blue), 2px 3px 15px var(--blue),
                2px 0px 15px var(--blue), 2px 0px 20px var(--blue),
                2px 0px 20px var(--blue), 5px 0px 125px var(--blue),
                20px 0vw 200px;
            border-color: rgb(255, 0, 234);
            box-shadow: 0px 0px 10px 2px var(--pink),
                inset 0px 0px 10px 2px var(--pink);
            cursor: pointer;
        }
    }
}

.closePopup {
    position: absolute;
    width: 2.5rem;
    height: 2.5rem;
    top: 1rem;
    left: 1rem;
    background: url('@/assets/img/x-lg.svg');
    background-position: center;
    background-repeat: no-repeat;
    background-size: 100%;
    cursor: pointer;
}

.popup-enter,
.popup-leave-to {
    transform: translateY(100vh);
    opacity: 0.3;
}
.popup-enter-to,
.popup-leave-from {
    transform: translateY(0);
    opacity: 1;
}
.popup-enter-active,
.popup-leave-active {
    transition: all 0.5s ease;
}

.form-enter,
.form-leave-to {
    transform: translateX(100vw);
    opacity: 0.3;
}
.form-enter-to,
.form-leave-from {
    transform: translateX(0);
    opacity: 1;
}
.form-enter-active,
.form-leave-active {
    transition: all 0.5s ease;
}

@media (min-width: 300px) and (max-width: 699px) {
    .playPopup {
        display: grid;
        grid-template-columns: 1fr;
        grid-template-rows: 15rem 1fr;
        overflow-y: auto;

        .gameSection {
            grid-row: 1;
            padding: 4rem 0 0 0;

            .nickname {
                margin: 0.5rem;
                width: 80%;
                font-size: 1.5rem;
            }

            .gameButton {
                width: 80%;
                letter-spacing: 0.5rem;
            }
        }

        .accountSection {
            grid-row: 2;
            justify-content: unset;
            .loginBox {
                .loginForm {
                    width: 80%;
                    margin: 1rem 0 0 0;

                    fieldset {
                        margin: 1rem 0;
                    }

                    .formInput {
                        font-size: 1.5rem;
                    }

                    .loginButton {
                        height: 4rem;
                        margin: 0.5rem 0;
                        font-size: 1.5rem;
                    }
                }
            }

            .registerBox {
                top: 0;

                .registerForm {
                    width: 80%;
                    margin: 1rem 0 0 0;

                    fieldset {
                        margin: 1rem 0;
                    }

                    .formInput {
                        font-size: 1.5rem;
                    }

                    .registerButton {
                        height: 4rem;
                        margin: 0.5rem 0;
                        font-size: 1.5rem;
                    }
                }
            }
        }

        .text {
            width: 40%;
            text-transform: uppercase;
            letter-spacing: 0.1rem;
            font-size: 1.5rem;
            text-align: center;
        }
        .toRegisterButton {
            width: 80%;
            height: 4rem;
            margin: 0.5rem;
            font-size: 1.5rem;
            letter-spacing: 0.15rem;
        }
    }
    .closePopup {
        width: 2rem;
        height: 2rem;
    }
}

@media (min-width: 700px) and (max-width: 1365px) {
    .playPopup {
        .gameSection {
            .nickname {
                width: 90%;
                font-size: 1.4rem;
            }

            .gameButton {
                width: 90%;
                font-size: 1.7rem;
                letter-spacing: 0.3rem;
            }
        }
        .loginBox {
            .loginForm {
                width: 90%;

                .formInput {
                    font-size: 1.7rem;
                }

                .loginButton {
                    height: 4rem;
                    font-size: 1.7rem;
                }
            }
        }
        .registerBox {
            width: 100%;
            display: flex;
            justify-content: center;
            align-items: center;
            flex-direction: column;
            position: absolute;

            .registerForm {
                width: 90%;

                .formInput {
                    font-size: 1.4rem;
                }

                .registerButton {
                    margin: 0.6rem 0;
                    font-size: 1.6rem;
                }
            }
        }
        .toRegisterButton {
            width: 90%;
            margin: 0.6rem 0;
            font-size: 1.6rem;
        }
    }
}
</style>
