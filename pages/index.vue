<template>
    <div class="container" onselectstart="return false;">
        <AppLoader />
        <div class="title">
            <span class="letter whiteLetter">cyber</span>
            <span class="letter pinkLetter flashAnimation">karty</span>
        </div>

        <div class="main">
            <TopPlayersList />

            <div class="buttonsBox">
                <div class="box">
                    <span class="button" @click="showPlayPopup = true"
                        >graj</span
                    >
                </div>

                <div class="box">
                    <span class="button" @click="showRulesPopup = true">
                        Zasady gry
                    </span>
                </div>

                <div class="box">
                    <span class="button" @click="showRankingPopup = true">
                        Rankingi Graczy
                    </span>
                </div>
            </div>
            <LastestPatchNotes />
            <PlayPopup
                :open="showPlayPopup"
                @close-play-popup="showPlayPopup = false"
            />
            <RankingPopup
                :open="showRankingPopup"
                @close-ranking-popup="showRankingPopup = false"
            />
            <RulesPopup
                :open="showRulesPopup"
                @close-rules-popup="showRulesPopup = false"
            />
        </div>
    </div>
</template>

<script>
export default {
    head() {
        return {
            title: 'CYBERKARTY',
        }
    },
    data: () => {
        return {
            showPlayPopup: false,
            showRankingPopup: false,
            showRulesPopup: false,
        }
    },
}
</script>

<style lang="scss" scoped>
$white-color: rgb(236, 235, 235);
$pink-color: rgb(255, 0, 234);
$green-color: rgb(124, 255, 2);

* {
    font-size: 16px;
}
.container {
    position: fixed;
    top: 0;
    left: 0;
    right: 0;
    bottom: 0;
    background-color: rgb(5, 5, 5);
}
.title {
    width: 100%;
    text-align: center;
    margin: 3rem auto 7rem auto;

    .letter {
        font-family: NeonFontTitle;
        font-size: 8.5rem;
        text-transform: uppercase;
        letter-spacing: 0.8rem;
    }

    .whiteLetter {
        color: white;
        text-shadow: 0 0 5px $white-color, 0 0 10px $white-color,
            0 0 15px $white-color, 0 0 20px $white-color, 0 0 30px $white-color,
            0 0 45px $white-color, 0 0 60px $white-color, 0 0 75px $white-color,
            0 0 90px $white-color;
    }

    .pinkLetter {
        color: rgb(194, 28, 172);
        text-shadow: 0 0 3px $pink-color, 0 0 6px $pink-color,
            0 0 15px $pink-color, 0 0 30px $pink-color, 0 0 45px $pink-color,
            0 0 60px $pink-color, 0 0 75px $pink-color, 0 0 90px $pink-color,
            0 0 120px $pink-color;
    }

    .flashAnimation {
        animation: letter_falsh 3.5s linear infinite;
    }
}

.main {
    display: grid;
    grid-template-columns: 1fr 2fr 1fr;
    grid-template-rows: 1fr;

    .buttonsBox {
        width: 100%;
        grid-column: 2/3;
        padding: 3rem 0 0 0;

        .box {
            width: 100%;
            height: 6rem;
            display: flex;
            justify-content: center;
            align-items: center;

            * {
                text-decoration: none;
                text-transform: uppercase;
                font-family: NeonFontButtons2;
                letter-spacing: 0.1rem;
                font-size: 3rem;
                opacity: 0.1;
            }

            .button:hover {
                color: rgb(94, 255, 0);
                text-shadow: 0 0 5px $green-color, 0 0 10px $green-color,
                    0 0 15px $green-color;
                opacity: 1;
            }
        }
    }
}

@keyframes letter_falsh {
    0%,
    19.999%,
    22%,
    62.999%,
    64%,
    64.999%,
    70%,
    100% {
        opacity: 0.99;
    }
    20%,
    21.999%,
    63%,
    63.999%,
    65%,
    69.999% {
        opacity: 0.4;
    }
}
@media (min-width: 300px) and (max-width: 699px) {
    .container {
        overflow-y: auto;
    }
    .title {
        margin: 2rem auto;

        .letter {
            font-size: 3.5rem;
            letter-spacing: 0.3rem;
        }
    }
    .main {
        display: grid;
        grid-template-rows: 14rem 30rem 30rem;
        width: 100%;

        .buttonsBox {
            grid-row: 1;
            width: 100%;

            .box {
                width: 100%;
                height: 4rem;
                text-align: center;

                .button {
                    font-size: 2rem;
                }
            }
        }
    }
}
@media (min-width: 700px) and (max-width: 1499px) {
    .container {
        overflow-y: auto;
    }
    .title {
        margin: 3rem auto;

        .letter {
            font-size: 6rem;
            letter-spacing: 0.6rem;
        }
    }
    .main {
        display: grid;
        grid-template-columns: repeat(2, 1fr);
        grid-template-rows: 18rem 32rem;
        width: 100%;

        .buttonsBox {
            grid-row: 1;
            grid-column: 1/3;
            width: 100%;

            .box {
                width: 100%;
                height: 5.2rem;
                text-align: center;

                .button {
                    font-size: 3rem;
                }
            }
        }
    }
}

@media (min-width: 1500px) and (max-width: 1700px) {
    .title {
        margin: 4rem auto 6rem auto;

        .letter {
            font-size: 7.5rem;
        }
    }
}
</style>
