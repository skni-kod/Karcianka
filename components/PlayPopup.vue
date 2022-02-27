<template>
    <transition name="popup">
        <div class="playPopup" v-if="open" onselectstart="return false;">
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
                        <form class="loginForm">
                            <fieldset>
                                <input
                                    type="text"
                                    class="nickname formInput"
                                    name="username"
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
                                    maxlength="30"
                                    placeholder="Hasło"
                                    required
                                />
                            </fieldset>
                            <button class="loginButton" @click="loginUser">
                                Zaloguj się
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
                        <form class="registerForm">
                            <fieldset>
                                <input
                                    type="text"
                                    class="username formInput"
                                    name="username"
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
                                    maxlength="30"
                                    placeholder="Hasło"
                                    required
                                />
                                <input
                                    type="password"
                                    class="confirmPassword formInput"
                                    name="confirmPassword"
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
                            <button
                                class="registerButton"
                                @click="registerUser"
                            >
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
            <div class="closePopup" @click="$emit('close-play-popup')"></div>
        </div>
    </transition>
</template>

<script>
export default {
    props: ['open'],
    methods: {
        async loginUser(e) {
            e.preventDefault()
            try {
                await fetch('http://localhost:5000/login', {
                    method: 'POST',
                    headers: { 'Content-Type': 'application/json' },
                    body: JSON.stringify({
                        username:
                            document.querySelector("[name='username']").value,
                        passwd: document.querySelector("[name='password']")
                            .value,
                    }),
                })
                    .then((response) => response.json())
                    .then((data) => {
                        localStorage.setItem('token', data)
                        this.$router.push('/games')
                    })
            } catch (err) {
                console.log(err)
            }
        },
        async registerUser(e) {
            e.preventDefault()
            let username = false,
                email = false,
                password = false,
                confirmPassword = false,
                terms = document.querySelector('.terms').checked

            if (
                /^[A-Za-z0-9-_]{4,15}$/.test(
                    document.querySelector("[name='username']").value
                )
            )
                username = true
            if (
                /^\S+@\S+$/.test(document.querySelector("[name='email']").value)
            )
                email = true
            if (
                /^(?=.*[0-9])(?=.*[A-Z])(?=.*[a-z])(?=.*[!@#$^&*-]).{8,30}$/.test(
                    document.querySelector("[name='password']").value
                )
            )
                password = true
            if (
                document.querySelector("[name='password']").value ===
                    document.querySelector("[name='confirmPassword']").value &&
                document.querySelector("[name='confirmPassword']").value
                    .length !== 0
            )
                confirmPassword = true

            if (username && email && password && confirmPassword && terms) {
                try {
                    await fetch('http://localhost:5000/register', {
                        method: 'POST',
                        headers: {
                            'Content-Type': 'application/json',
                        },
                        body: JSON.stringify({
                            username:
                                document.querySelector("[name='username']")
                                    .value,
                            email: document.querySelector("[name='email']")
                                .value,
                            passwd: document.querySelector("[name='password']")
                                .value,
                        }),
                    }).then((data) => {
                        if (data.status == 200) {
                            this.$router.push('/games')
                        }
                    })
                } catch (err) {
                    console.log(err)
                }
            } else {
                if (!username) {
                    document
                        .querySelector("[name='username']")
                        .classList.add('errorFormInput')
                } else {
                    document
                        .querySelector("[name='username']")
                        .classList.remove('errorFormInput')
                }
                if (!email) {
                    document
                        .querySelector("[name='email']")
                        .classList.add('errorFormInput')
                } else {
                    document
                        .querySelector("[name='email']")
                        .classList.remove('errorFormInput')
                }
                if (!password) {
                    document
                        .querySelector("[name='password']")
                        .classList.add('errorFormInput')
                } else {
                    document
                        .querySelector("[name='password']")
                        .classList.remove('errorFormInput')
                }
                if (!confirmPassword) {
                    document
                        .querySelector("[name='confirmPassword']")
                        .classList.add('errorFormInput')
                } else {
                    document
                        .querySelector("[name='confirmPassword']")
                        .classList.remove('errorFormInput')
                }
                if (!terms) {
                    document
                        .querySelector('.terms')
                        .classList.add('errorFormInput')
                } else {
                    document
                        .querySelector('.terms')
                        .classList.remove('errorFormInput')
                }
            }
        },
    },
    data: () => {
        return {
            registerFormActive: false,
        }
    },
}
</script>

<style lang="scss" scoped>
$pink-color: rgb(255, 0, 234);
$blue-color: rgb(0, 164, 230);
$red-color: rgb(255, 0, 0);

* {
    color: black;
    font-family: NeonFontButtons2;
    font-size: 16px;
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
                text-shadow: 1px 0px 4px $blue-color, 2px 0px 4px $blue-color,
                    2px 0px 3px $blue-color, 2px 3px 15px $blue-color,
                    2px 0px 15px $blue-color, 2px 0px 20px $blue-color,
                    2px 0px 20px $blue-color, 5px 0px 125px $blue-color,
                    20px 0vw 200px;
                border-color: rgb(255, 0, 234);
                box-shadow: 0px 0px 10px 2px $pink-color,
                    inset 0px 0px 10px 2px $pink-color;
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
                text-shadow: 1px 0px 4px $blue-color, 2px 0px 4px $blue-color,
                    2px 0px 3px $blue-color, 2px 3px 15px $blue-color,
                    2px 0px 15px $blue-color, 2px 0px 20px $blue-color,
                    2px 0px 20px $blue-color, 5px 0px 125px $blue-color,
                    20px 0vw 200px;
                border-color: rgb(255, 0, 234);
                box-shadow: 0px 0px 10px 2px $pink-color,
                    inset 0px 0px 10px 2px $pink-color;
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
                    text-shadow: 1px 0px 4px $blue-color,
                        2px 0px 4px $blue-color, 2px 0px 3px $blue-color,
                        2px 3px 15px $blue-color, 2px 0px 15px $blue-color,
                        2px 0px 20px $blue-color, 2px 0px 20px $blue-color,
                        5px 0px 125px $blue-color, 20px 0vw 200px;
                    border-color: rgb(255, 0, 234);
                    box-shadow: 0px 0px 10px 2px $pink-color,
                        inset 0px 0px 10px 2px $pink-color;
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
                    text-shadow: 1px 0px 4px $blue-color,
                        2px 0px 4px $blue-color, 2px 0px 3px $blue-color,
                        2px 3px 15px $blue-color, 2px 0px 15px $blue-color,
                        2px 0px 20px $blue-color, 2px 0px 20px $blue-color,
                        5px 0px 125px $blue-color, 20px 0vw 200px;
                    border-color: rgb(255, 0, 234);
                    box-shadow: 0px 0px 10px 2px $pink-color,
                        inset 0px 0px 10px 2px $pink-color;
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
                    text-shadow: 1px 0px 4px $blue-color,
                        2px 0px 4px $blue-color, 2px 0px 3px $blue-color,
                        2px 3px 15px $blue-color, 2px 0px 15px $blue-color,
                        2px 0px 20px $blue-color, 2px 0px 20px $blue-color,
                        5px 0px 125px $blue-color, 20px 0vw 200px;
                    border-color: rgb(255, 0, 234);
                    box-shadow: 0px 0px 10px 2px $pink-color,
                        inset 0px 0px 10px 2px $pink-color;
                }
                &::placeholder {
                    text-shadow: 0 0 0 rgb(230, 230, 230);
                    text-align: center;
                }
            }

            .errorFormInput {
                border-color: rgb(255, 23, 10);
                box-shadow: 0px 0px 10px 2px $red-color,
                    inset 0px 0px 10px 2px $red-color;
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
                    text-shadow: 1px 0px 4px $blue-color,
                        2px 0px 4px $blue-color, 2px 0px 3px $blue-color,
                        2px 3px 15px $blue-color, 2px 0px 15px $blue-color,
                        2px 0px 20px $blue-color, 2px 0px 20px $blue-color,
                        5px 0px 125px $blue-color, 20px 0vw 200px;
                    border-color: rgb(255, 0, 234);
                    box-shadow: 0px 0px 10px 2px $pink-color,
                        inset 0px 0px 10px 2px $pink-color;
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
            text-shadow: 1px 0px 4px $blue-color, 2px 0px 4px $blue-color,
                2px 0px 3px $blue-color, 2px 3px 15px $blue-color,
                2px 0px 15px $blue-color, 2px 0px 20px $blue-color,
                2px 0px 20px $blue-color, 5px 0px 125px $blue-color,
                20px 0vw 200px;
            border-color: rgb(255, 0, 234);
            box-shadow: 0px 0px 10px 2px $pink-color,
                inset 0px 0px 10px 2px $pink-color;
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
