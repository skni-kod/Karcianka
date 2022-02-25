<template>
    <div class="container" onselectstart="return false;">
        <AppLoader />
        <div class="title">
            <span class="letter whiteLetter">cyber</span>
            <span class="letter pinkLetter flashAnimation">karty</span>
        </div>

        <div class="main">
            <div class="rankingBox">
                <p class="panelTitle">TOP 5 GRACZY</p>
                <RankedPlayer v-for="player in 5" :key="player" />
            </div>

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

            <div class="patchNotesBox">
                <p class="panelTitle">PATCH NOTES</p>
                <PatchNote v-for="note in 5" :key="note" />
            </div>
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

* {
    font-size: 16px;
}
.container {
    position: fixed;
    top: 0;
    left: 0;
    right: 0;
    bottom: 0;
}
.title {
    width: 100%;
    text-align: center;
    margin: 4rem auto 8rem auto;

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
            0 0 90px $white-color, 0 0 110px $white-color;
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
    display: flex;
    flex-wrap: wrap;
    align-items: center;
    width: 100%;

    .rankingBox {
        width: 25%;
        padding: 0 0 0 1rem;
        display: flex;
        justify-content: center;
        align-items: center;
        flex-direction: column;

        .panelTitle {
            font-family: NeonFontTitle;
            text-align: center;
            font-size: 3rem;
            margin: 0 0 0.5rem 0;
            letter-spacing: 0.1rem;
            color: rgba(255, 115, 0, 0.897);
            text-shadow: 0 0 5px rgb(255, 139, 6), 0 0 10px rgb(255, 139, 6),
                0 0 15px rgb(255, 139, 6), 0 0 20px rgb(255, 139, 6),
                0 0 30px rgb(255, 139, 6);
        }
    }
    .buttonsBox {
        width: 50%;

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
            }

            .button:hover {
                color: rgb(233, 210, 0);
                text-shadow: 1px 0px 4px rgb(255, 213, 255),
                    2px 0px 4px rgb(255, 213, 255), 2px 0px 3px rgb(250, 255, 0),
                    2px 3px 15px rgb(250, 255, 0), 2px 0px 15px rgb(250, 255, 0),
                    5px 0px 125px rgb(250, 255, 0), 20px 0vw 200px;
            }
        }
    }

    .patchNotesBox {
        width: 25%;
        padding: 0 1rem 0 0;
        display: flex;
        justify-content: center;
        align-items: center;
        flex-direction: column;

        .panelTitle {
            font-family: NeonFontTitle;
            text-align: center;
            font-size: 3rem;
            margin: 0 0 0.5rem 0;
            letter-spacing: 0.1em;
            color: rgba(255, 115, 0, 0.897);
            text-shadow: 0 0 5px rgb(255, 139, 6), 0 0 10px rgb(255, 139, 6),
                0 0 15px rgb(255, 139, 6), 0 0 20px rgb(255, 139, 6),
                0 0 30px rgb(255, 139, 6);
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

        .rankingBox {
            grid-row: 2;
            width: 100%;
            font-size: 1rem;

            .panelTitle {
                font-size: 2.5rem;
            }
        }
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
        .patchNotesBox {
            grid-row: 3;
            width: 100%;
            font-size: 1rem;

            .panelTitle {
                font-size: 2.5rem;
            }
        }
    }
}
@media (min-width: 700px) and (max-width: 1365px) {
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

        .rankingBox {
            grid-row: 2;
            grid-column: 1/2;
            width: 100%;
            font-size: 2.5rem;

            .panelTitle {
                font-size: 2.8rem;
            }
        }
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
        .patchNotesBox {
            grid-row: 2;
            grid-column: 2/3;
            width: 100%;
            font-size: 2.5rem;

            .panelTitle {
                font-size: 2.8rem;
            }
        }
    }
}

@media (min-width: 1366px) and (max-width: 1700px) {
    .title {
        margin: 4rem auto 6rem auto;

        .letter {
            font-size: 7.5rem;
        }
    }
}
</style>
