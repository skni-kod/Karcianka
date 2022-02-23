<template>
    <transition>
        <div class="rulesPopup" v-if="open" onselectstart="return false;">
            <div class="header">
                <p class="title">Zasady gier</p>
                <div
                    class="closePopup"
                    @click="$emit('close-rules-popup')"
                ></div>
            </div>
            <div class="rulesContainer">
                <div class="gameList">
                    <ul class="list">
                        <li class="listElement" @click="rulesDisplay = 1">
                            Game 1
                        </li>
                        <li class="listElement" @click="rulesDisplay = 2">
                            Game 2
                        </li>
                        <li class="listElement" @click="rulesDisplay = 3">
                            Game 3
                        </li>
                        <li class="listElement" @click="rulesDisplay = 4">
                            Game 4
                        </li>
                        <li class="listElement" @click="rulesDisplay = 5">
                            Game 5
                        </li>
                    </ul>
                </div>
                <div class="rulesContent">
                    <transition-group name="rulesLists">
                        <div class="rule" v-if="rulesDisplay === 1" key="1">
                            <p class="gameTitle">Game 1</p>
                            <ul class="rulesList">
                                <li class="listElement">
                                    1. Lorem ipsum dolor sit amet, consectetur
                                    adipiscing elit. Sed faucibus tellus nibh,
                                    et maximus odio molestie vitae. Phasellus
                                    eget rhoncus nunc. Nullam imperdiet vel
                                    sapien gravida iaculis. Morbi enim dolor.
                                    Lorem ipsum dolor sit amet, consectetur
                                    adipiscing elit.
                                </li>
                                <li class="listElement">
                                    2. Sed faucibus tellus nibh, et maximus odio
                                    molestie vitae. Phasellus eget rhoncus nunc.
                                    Nullam imperdiet vel sapien gravida iaculis.
                                    Morbi enim dolor.
                                </li>
                            </ul>
                        </div>
                        <div class="rule" v-if="rulesDisplay === 2" key="2">
                            <p class="gameTitle">Game 1</p>

                            <ul class="rulesList">
                                <li class="listElement">
                                    2. Lorem ipsum dolor sit amet, consectetur
                                    adipiscing elit. Sed faucibus tellus nibh,
                                    et maximus odio molestie vitae. Phasellus
                                    eget rhoncus nunc. Nullam imperdiet vel
                                    sapien gravida iaculis. Morbi enim dolor.
                                    Lorem ipsum dolor sit amet, consectetur
                                    adipiscing elit.
                                </li>
                                <li class="listElement">
                                    2. Sed faucibus tellus nibh, et maximus odio
                                    molestie vitae. Phasellus eget rhoncus nunc.
                                    Nullam imperdiet vel sapien gravida iaculis.
                                    Morbi enim dolor.
                                </li>
                            </ul>
                        </div>
                        <div class="rule" v-if="rulesDisplay === 3" key="3">
                            <p class="gameTitle">Game 1</p>

                            <ul class="rulesList">
                                <li class="listElement">
                                    3. Lorem ipsum dolor sit amet, consectetur
                                    adipiscing elit. Sed faucibus tellus nibh,
                                    et maximus odio molestie vitae. Phasellus
                                    eget rhoncus nunc. Nullam imperdiet vel
                                    sapien gravida iaculis. Morbi enim dolor.
                                    Lorem ipsum dolor sit amet, consectetur
                                    adipiscing elit.
                                </li>
                                <li class="listElement">
                                    2. Sed faucibus tellus nibh, et maximus odio
                                    molestie vitae. Phasellus eget rhoncus nunc.
                                    Nullam imperdiet vel sapien gravida iaculis.
                                    Morbi enim dolor.
                                </li>
                            </ul>
                        </div>
                        <div class="rule" v-if="rulesDisplay === 4" key="4">
                            <p class="gameTitle">Game 1</p>

                            <ul class="rulesList">
                                <li class="listElement">
                                    4. Lorem ipsum dolor sit amet, consectetur
                                    adipiscing elit. Sed faucibus tellus nibh,
                                    et maximus odio molestie vitae. Phasellus
                                    eget rhoncus nunc. Nullam imperdiet vel
                                    sapien gravida iaculis. Morbi enim dolor.
                                    Lorem ipsum dolor sit amet, consectetur
                                    adipiscing elit.
                                </li>
                                <li class="listElement">
                                    2. Sed faucibus tellus nibh, et maximus odio
                                    molestie vitae. Phasellus eget rhoncus nunc.
                                    Nullam imperdiet vel sapien gravida iaculis.
                                    Morbi enim dolor.
                                </li>
                            </ul>
                        </div>
                        <div class="rule" v-if="rulesDisplay === 5" key="5">
                            <p class="gameTitle">Game 1</p>

                            <ul class="rulesList">
                                <li class="listElement">
                                    5. Lorem ipsum dolor sit amet, consectetur
                                    adipiscing elit. Sed faucibus tellus nibh,
                                    et maximus odio molestie vitae. Phasellus
                                    eget rhoncus nunc. Nullam imperdiet vel
                                    sapien gravida iaculis. Morbi enim dolor.
                                    Lorem ipsum dolor sit amet, consectetur
                                    adipiscing elit.
                                </li>
                                <li class="listElement">
                                    2. Sed faucibus tellus nibh, et maximus odio
                                    molestie vitae. Phasellus eget rhoncus nunc.
                                    Nullam imperdiet vel sapien gravida iaculis.
                                    Morbi enim dolor.
                                </li>
                            </ul>
                        </div>
                    </transition-group>
                </div>
            </div>
        </div>
    </transition>
</template>

<script>
export default {
    props: ['open'],
    data: () => {
        return {
            rulesDisplay: 1,
        }
    },
    methods: {},
}
</script>

<style lang="scss" scoped>
* {
    color: black;
    font-family: NeonFontButtons2;
    box-sizing: border-box;
}

.rulesPopup {
    z-index: 100;
    position: fixed;
    top: 0;
    left: 0;
    right: 0;
    bottom: 0;
    background-color: rgb(230, 230, 230);

    .header {
        width: 100%;
        position: sticky;
        top: 0;
        z-index: 100;
        padding: 0 0 1em 0;

        .closePopup {
            position: absolute;
            width: 2em;
            height: 2em;
            top: 1em;
            left: 1em;
            background: url('@/assets/img/x-lg.svg');
            background-position: center;
            background-repeat: no-repeat;
            background-size: 100%;
            cursor: pointer;
        }

        .title {
            width: 100%;
            font-size: 2.2em;
            text-transform: uppercase;
            text-align: center;
            letter-spacing: 0.1em;
        }
    }

    .rulesContainer {
        width: 100%;
        height: 100vh;

        .gameList {
            text-align: center;
            overflow-y: auto;
            width: 40%;
            float: left;
            height: 100%;

            .list {
                top: 5em;

                .listElement {
                    display: grid;
                    align-items: center;
                    height: 2.2em;
                    font-size: 2em;
                    letter-spacing: 0.1em;
                }
            }
        }

        .rulesContent {
            grid-column-start: 2;
            text-align: center;
            overflow-y: auto;
            width: 60%;
            height: 100%;

            .rule {
                .gameTitle {
                    position: absolute;
                    top: 0;
                    height: 2em;
                    width: 100%;
                    font-size: 2.3em;
                    letter-spacing: 0.1em;
                }
                .rulesList {
                    list-style-type: none;
                    text-align: left;
                    padding: 0 1.5em 0 0;
                    top: 5em;

                    .listElement {
                        padding: 0.5em 0;
                    }
                }
            }
        }
    }
}

.v-enter,
.v-leave-to {
    transform: translateY(100vh);
    opacity: 0.3;
}
.v-enter-to,
.v-leave-from {
    transform: translateY(0);
    opacity: 1;
}
.v-enter-active,
.v-leave-active {
    transition: all 0.5s ease;
}

.rulesLists-enter,
.rulesLists-leave-to {
    opacity: 0;
}
.rulesLists-enter-to,
.rulesLists-leave {
    opacity: 1;
}
</style>
