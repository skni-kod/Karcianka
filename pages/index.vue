<template>
  <div>
    <AppLoader />
    <div class="title">
        <span class="letter whiteLetter">cyber</span>
        <span class="letter pinkLetter flashAnimation">karty</span>
    </div>

    <div class="main">
    
        <div class="rankingBox">
            <p class="panelTitle">TOP 5 GRACZY</p>
            <RankedPlayer 
                v-for="player in 5"
                :key="player"
            />
        </div>

        <div class="buttonsBox">
            <div class = "box">
                <NuxtLink to="/login">
                    <span class="button">Zaloguj się</span>
                </NuxtLink>
            </div>

            <div class = "box">
                <NuxtLink to="/register">
                    <span class="button"> Zarejstruj się</span>
                </NuxtLink>
            </div>

            <div class = "box">
                <NuxtLink to="/ranking">
                    <span class="button"> Rankingi Graczy </span>
                </NuxtLink>
            </div>

            <div class = "box">
                <NuxtLink to="/zasady">
                    <span class="button"> Zasady gry </span>
                </NuxtLink>
            </div>

            <div class = "box">
                <a href="">
                    <span class="button"> O grze </span>
                </a>
            </div>
        </div>

        <div class="patchNotesBox">
            <p class="panelTitle">PATCH NOTES</p>
            <PatchNote 
                v-for="note in 5"
                :key="note"
            />
        </div>

    </div>
  </div>
</template>

<script>
export default {}
</script>

<style lang="scss" scoped>
.title {
	width: 100%;
	text-align: center;
	margin: 6em auto;

	.letter {
		font-family: NeonFontTitle;
		font-size: 7em;
		text-transform: uppercase;
		letter-spacing: .1em;
	}

	.whiteLetter {
		color: white;
		text-shadow: 0 0 5px rgb(236, 235, 235), 0 0 10px rgb(241, 241, 241), 0 0 15px rgb(241, 241, 241),
			0 0 20px rgb(241, 241, 241), 0 0 30px rgb(241, 241, 241), 0 0 45px rgb(241, 241, 241),
			0 0 60px rgb(241, 241, 241), 0 0 75px rgb(241, 241, 241), 0 0 90px rgb(241, 241, 241),
			0 0 110px rgb(241, 241, 241);
	}

	.pinkLetter {
		color: rgb(194, 28, 172);
		text-shadow: 0 0 3px rgb(255, 0, 234), 0 0 6px rgb(255, 0, 234), 0 0 15px rgb(255, 0, 234),
			0 0 30px rgb(255, 0, 234), 0 0 45px rgb(255, 0, 234), 0 0 60px rgb(218, 0, 199), 0 0 75px rgb(218, 0, 199),
			0 0 90px rgb(218, 0, 199), 0 0 120px rgb(218, 0, 199);
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
	height: 100%;

	.rankingBox {
		width: 25%;
		padding: 0 0 0 1em;
		display: flex;
		justify-content: center;
		align-items: center;
		flex-direction: column;

		.panelTitle {
			font-family: NeonFontTitle;
			text-align: center;
			font-size: 3em;
			margin: 0 0 .5em 0;
			letter-spacing: .1em;
			color: rgba(255, 115, 0, 0.897);
			text-shadow: 0 0 5px rgb(255, 139, 6), 0 0 10px rgb(255, 139, 6), 0 0 15px rgb(255, 139, 6),
				0 0 20px rgb(255, 139, 6), 0 0 30px rgb(255, 139, 6);
		}
	}
	.buttonsBox {
		width: 50%;
	}

	.box {
		width: 100%;
		height: 2.5em;
		display: flex;
		justify-content: center;
		align-items: center;
		font-size: 2.5em;

		* {
			text-decoration: none;
			text-transform: uppercase;
			font-family: NeonFontButtons;
			letter-spacing: .1em;
		}
		.button:hover {
			text-shadow: 1px 0px 4px rgb(255, 213, 255), 2px 0px 4px rgb(255, 213, 255), 2px 0px 3px rgb(250, 255, 0),
				2px 3px 15px rgb(250, 255, 0), 2px 0px 15px rgb(250, 255, 0), 5px 0px 125px rgb(250, 255, 0),
				20px 0vw 200px rgb(250, 255, 0), 40px 0vw 200px rgb(250, 255, 0);
		}
	}
	.patchNotesBox {
		width: 25%;
		padding: 0 1em 0 0;
		display: flex;
		justify-content: center;
		align-items: center;
		flex-direction: column;

		.panelTitle {
			font-family: NeonFontTitle;
			text-align: center;
			font-size: 3em;
			margin: 0 0 .5em 0;
			letter-spacing: .1em;
			color: rgba(255, 115, 0, 0.897);
			text-shadow: 0 0 5px rgb(255, 139, 6), 0 0 10px rgb(255, 139, 6), 0 0 15px rgb(255, 139, 6),
				0 0 20px rgb(255, 139, 6), 0 0 30px rgb(255, 139, 6);
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
		opacity: .99;
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
</style>