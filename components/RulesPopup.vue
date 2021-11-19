<template>
    <transition>
        <div class="rulesPopup" v-if="open" onselectstart="return false;">
            <div class="header">
                <p class="title">Zasady</p>
                <div
                    class="closePopup"
                    @click="$emit('close-rules-popup')"
                ></div>
            </div>
            <div class="gamesList">
                <ul class="list">
                    <li class="game" @click="rulesDisplay = 1">Game 1</li>
                    <li class="game" @click="rulesDisplay = 2">Game 2</li>
                    <li class="game" @click="rulesDisplay = 3">Game 3</li>
                    <li class="game" @click="rulesDisplay = 4">Game 4</li>
                    <li class="game" @click="rulesDisplay = 5">Game 5</li>
                </ul>
            </div>
            <div class="gameRules">
                <transition-group name="rulesLists">
                    <div class="rules" v-if="rulesDisplay === 1" key="1">
                        <ul class="rulesList">
                            <li class="rule">Zasady 1</li>
                            <li class="rule">
                                1.Lorem ipsum dolor sit amet, consectetur
                                adipiscing elit. Sed faucibus tellus nibh, et
                                maximus odio molestie vitae. Phasellus eget
                                rhoncus nunc. Nullam imperdiet vel sapien
                                gravida iaculis. Morbi enim dolor.
                            </li>
                            <li class="rule">
                                2.Lorem ipsum dolor sit amet, consectetur
                                adipiscing elit. Sed faucibus tellus nibh, et
                                maximus odio molestie vitae. Phasellus eget
                                rhoncus nunc. Nullam imperdiet vel sapien
                                gravida iaculis. Morbi enim dolor.
                            </li>
                            <li class="rule">
                                3.Lorem ipsum dolor sit amet, consectetur
                                adipiscing elit. Sed faucibus tellus nibh, et
                                maximus odio molestie vitae. Phasellus eget
                                rhoncus nunc. Nullam imperdiet vel sapien
                                gravida iaculis. Morbi enim dolor.
                            </li>
                            <li class="rule">
                                4.Lorem ipsum dolor sit amet, consectetur
                                adipiscing elit. Sed faucibus tellus nibh, et
                                maximus odio molestie vitae. Phasellus eget
                                rhoncus nunc. Nullam imperdiet vel sapien
                                gravida iaculis. Morbi enim dolor.
                            </li>
                            <li class="rule">
                                5.Lorem ipsum dolor sit amet, consectetur
                                adipiscing elit. Sed faucibus tellus nibh, et
                                maximus odio molestie vitae. Phasellus eget
                                rhoncus nunc. Nullam imperdiet vel sapien
                                gravida iaculis. Morbi enim dolor.
                            </li>
                            <li class="rule">
                                6.Lorem ipsum dolor sit amet, consectetur
                                adipiscing elit. Sed faucibus tellus nibh, et
                                maximus odio molestie vitae. Phasellus eget
                                rhoncus nunc. Nullam imperdiet vel sapien
                                gravida iaculis. Morbi enim dolor.
                            </li>
                            <li class="rule">
                                7.Lorem ipsum dolor sit amet, consectetur
                                adipiscing elit. Sed faucibus tellus nibh, et
                                maximus odio molestie vitae. Phasellus eget
                                rhoncus nunc. Nullam imperdiet vel sapien
                                gravida iaculis. Morbi enim dolor.
                            </li>
                            <li class="rule">
                                8.Lorem ipsum dolor sit amet, consectetur
                                adipiscing elit. Sed faucibus tellus nibh, et
                                maximus odio molestie vitae. Phasellus eget
                                rhoncus nunc. Nullam imperdiet vel sapien
                                gravida iaculis. Morbi enim dolor.
                            </li>
                        </ul>
                    </div>
                    <div class="rules" v-if="rulesDisplay === 2" key="2">
                        <ul class="rulesList">
                            <li class="rule">Zasady 2</li>
                            <li class="rule">
                                1.Lorem ipsum dolor sit amet, consectetur
                                adipiscing elit. Sed faucibus tellus nibh, et
                                maximus odio molestie vitae. Phasellus eget
                                rhoncus nunc. Nullam imperdiet vel sapien
                                gravida iaculis. Morbi enim dolor.
                            </li>
                            <li class="rule">
                                2.Lorem ipsum dolor sit amet, consectetur
                                adipiscing elit. Sed faucibus tellus nibh, et
                                maximus odio molestie vitae. Phasellus eget
                                rhoncus nunc. Nullam imperdiet vel sapien
                                gravida iaculis. Morbi enim dolor.
                            </li>
                            <li class="rule">
                                3.Lorem ipsum dolor sit amet, consectetur
                                adipiscing elit. Sed faucibus tellus nibh, et
                                maximus odio molestie vitae. Phasellus eget
                                rhoncus nunc. Nullam imperdiet vel sapien
                                gravida iaculis. Morbi enim dolor.
                            </li>
                            <li class="rule">
                                4.Lorem ipsum dolor sit amet, consectetur
                                adipiscing elit. Sed faucibus tellus nibh, et
                                maximus odio molestie vitae. Phasellus eget
                                rhoncus nunc. Nullam imperdiet vel sapien
                                gravida iaculis. Morbi enim dolor.
                            </li>
                        </ul>
                    </div>
                    <div class="rules" v-if="rulesDisplay === 3" key="3">
                        <ul class="rulesList">
                            <li class="rule">Zasady 3</li>
                            <li class="rule">
                                1.Lorem ipsum dolor sit amet, consectetur
                                adipiscing elit. Sed faucibus tellus nibh, et
                                maximus odio molestie vitae. Phasellus eget
                                rhoncus nunc. Nullam imperdiet vel sapien
                                gravida iaculis. Morbi enim dolor.
                            </li>
                            <li class="rule">
                                2.Lorem ipsum dolor sit amet, consectetur
                                adipiscing elit. Sed faucibus tellus nibh, et
                                maximus odio molestie vitae. Phasellus eget
                                rhoncus nunc. Nullam imperdiet vel sapien
                                gravida iaculis. Morbi enim dolor.
                            </li>
                            <li class="rule">
                                3.Lorem ipsum dolor sit amet, consectetur
                                adipiscing elit. Sed faucibus tellus nibh, et
                                maximus odio molestie vitae. Phasellus eget
                                rhoncus nunc. Nullam imperdiet vel sapien
                                gravida iaculis. Morbi enim dolor.
                            </li>
                            <li class="rule">
                                4.Lorem ipsum dolor sit amet, consectetur
                                adipiscing elit. Sed faucibus tellus nibh, et
                                maximus odio molestie vitae. Phasellus eget
                                rhoncus nunc. Nullam imperdiet vel sapien
                                gravida iaculis. Morbi enim dolor.
                            </li>
                            <li class="rule">
                                5.Lorem ipsum dolor sit amet, consectetur
                                adipiscing elit. Sed faucibus tellus nibh, et
                                maximus odio molestie vitae. Phasellus eget
                                rhoncus nunc. Nullam imperdiet vel sapien
                                gravida iaculis. Morbi enim dolor.
                            </li>
                            <li class="rule">
                                6.Lorem ipsum dolor sit amet, consectetur
                                adipiscing elit. Sed faucibus tellus nibh, et
                                maximus odio molestie vitae. Phasellus eget
                                rhoncus nunc. Nullam imperdiet vel sapien
                                gravida iaculis. Morbi enim dolor.
                            </li>
                            <li class="rule">
                                7.Lorem ipsum dolor sit amet, consectetur
                                adipiscing elit. Sed faucibus tellus nibh, et
                                maximus odio molestie vitae. Phasellus eget
                                rhoncus nunc. Nullam imperdiet vel sapien
                                gravida iaculis. Morbi enim dolor.
                            </li>
                            <li class="rule">
                                8.Lorem ipsum dolor sit amet, consectetur
                                adipiscing elit. Sed faucibus tellus nibh, et
                                maximus odio molestie vitae. Phasellus eget
                                rhoncus nunc. Nullam imperdiet vel sapien
                                gravida iaculis. Morbi enim dolor.
                            </li>
                            <li class="rule">
                                9.Lorem ipsum dolor sit amet, consectetur
                                adipiscing elit. Sed faucibus tellus nibh, et
                                maximus odio molestie vitae. Phasellus eget
                                rhoncus nunc. Nullam imperdiet vel sapien
                                gravida iaculis. Morbi enim dolor.
                            </li>
                        </ul>
                    </div>
                    <div class="rules" v-if="rulesDisplay === 4" key="4">
                        <ul class="rulesList">
                            <li class="rule">Zasady 4</li>
                            <li class="rule">
                                1.Lorem ipsum dolor sit amet, consectetur
                                adipiscing elit. Sed faucibus tellus nibh, et
                                maximus odio molestie vitae. Phasellus eget
                                rhoncus nunc. Nullam imperdiet vel sapien
                                gravida iaculis. Morbi enim dolor.
                            </li>
                            <li class="rule">
                                2.Lorem ipsum dolor sit amet, consectetur
                                adipiscing elit. Sed faucibus tellus nibh, et
                                maximus odio molestie vitae. Phasellus eget
                                rhoncus nunc. Nullam imperdiet vel sapien
                                gravida iaculis. Morbi enim dolor.
                            </li>
                            <li class="rule">
                                3.Lorem ipsum dolor sit amet, consectetur
                                adipiscing elit. Sed faucibus tellus nibh, et
                                maximus odio molestie vitae. Phasellus eget
                                rhoncus nunc. Nullam imperdiet vel sapien
                                gravida iaculis. Morbi enim dolor.
                            </li>
                        </ul>
                    </div>
                    <div class="rules" v-if="rulesDisplay === 5" key="5">
                        <ul class="rulesList">
                            <li class="rule">Zasady 5</li>
                            <li class="rule">
                                1.Lorem ipsum dolor sit amet, consectetur
                                adipiscing elit. Sed faucibus tellus nibh, et
                                maximus odio molestie vitae. Phasellus eget
                                rhoncus nunc. Nullam imperdiet vel sapien
                                gravida iaculis. Morbi enim dolor.
                            </li>
                            <li class="rule">
                                2.Lorem ipsum dolor sit amet, consectetur
                                adipiscing elit. Sed faucibus tellus nibh, et
                                maximus odio molestie vitae. Phasellus eget
                                rhoncus nunc. Nullam imperdiet vel sapien
                                gravida iaculis. Morbi enim dolor.
                            </li>
                            <li class="rule">
                                3.Lorem ipsum dolor sit amet, consectetur
                                adipiscing elit. Sed faucibus tellus nibh, et
                                maximus odio molestie vitae. Phasellus eget
                                rhoncus nunc. Nullam imperdiet vel sapien
                                gravida iaculis. Morbi enim dolor.
                            </li>
                            <li class="rule">
                                4.Lorem ipsum dolor sit amet, consectetur
                                adipiscing elit. Sed faucibus tellus nibh, et
                                maximus odio molestie vitae. Phasellus eget
                                rhoncus nunc. Nullam imperdiet vel sapien
                                gravida iaculis. Morbi enim dolor.
                            </li>
                            <li class="rule">
                                5.Lorem ipsum dolor sit amet, consectetur
                                adipiscing elit. Sed faucibus tellus nibh, et
                                maximus odio molestie vitae. Phasellus eget
                                rhoncus nunc. Nullam imperdiet vel sapien
                                gravida iaculis. Morbi enim dolor.
                            </li>
                        </ul>
                    </div>
                </transition-group>
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
}
</script>

<style lang="scss" scoped>
* {
    color: black;
    font-family: NeonFontButtons2;
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
        height: 10vh;
        position: absolute;
        top: 0;

        .closePopup {
            position: absolute;
            width: 4vh;
            height: 4vh;
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
            font-size: 3em;
            padding: 0 0 0 15vw;
            text-transform: uppercase;
        }
    }
    .gamesList {
        float: left;
        position: sticky;
        top: 25vh;
        left: 0;
        width: 45vw;

        .list {
            .game {
                text-align: center;
                padding: 0.5em 0;
                transition: all 0.5s ease;
                margin: 0.2em 0;
                font-size: 1.5em;

                &:hover {
                    background-color: rgb(150, 150, 150);
                    font-size: 1.9em;
                }
            }
        }
    }
    .gameRules {
        position: absolute;
        top: 0;
        width: 55vw;
        right: 0;
        overflow-y: auto;
        overflow-x: hidden;
        bottom: 0;
        background-color: rgb(200, 200, 200);

        .rules {
            position: absolute;
            padding: 1.5em 2em;

            .rulesList {
                list-style-type: none;
                width: 100%;

                .rule {
                    display: flex;
                    justify-content: center;
                    align-items: center;
                    margin: 0.6em 0;
                    width: 100%;
                    width: 50vw;
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
    transform: translateX(100vw);
    opacity: 0.3;
}
.rulesLists-enter-to,
.rulesLists-leave-from {
    transform: translateX(0);
    opacity: 1;
}
.rulesLists-enter-active,
.rulesLists-leave-active {
    transition: all 0.5s ease;
}
</style>
