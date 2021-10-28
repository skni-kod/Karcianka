<template>
    <div>
        <div class="logo">
            <p class="rankingLogo">Ranking</p>
        </div>

        <div class="rankingBox">
            <table class="rankingTable">

            </table>
        </div>
    </div>
</template>

<style lang="scss" scoped>
    .logo{
        width: 100%;
        height: 12em;
        display: flex;
        justify-content: center;
        align-items: center;

        .rankingLogo{
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

    .rankingBox{
        width: 100%;
        height: 100%;
        display: flex;
        justify-content: center;
        align-items: center;

        .rankingTable{
            width: 80%;
            border: 1px solid yellow;
        }
    }
</style>