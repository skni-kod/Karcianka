<template>
  <div class="rankingBox">
    <p class="panelTitle">TOP 5 GRACZY</p>
    <ul class="playersList">
      <li class="playerElement" v-for="player in players" :key="player.id">
        <div class="dataSection">
          <img class="iamge" src="~/assets/img/user.svg" />
          <p class="nickname">{{ player.name }}</p>
        </div>
        <div class="pointsSection">
          <p class="points">Points: {{ player.points }}</p>
        </div>
      </li>
    </ul>
  </div>
</template>
<script>
export default {
  data: () => {
    return {
      players: [
        { id: '1', name: 'Arek', points: '400' },
        { id: '2', name: 'Jakub', points: '390' },
        { id: '3', name: 'Mateusz', points: '300' },
        { id: '4', name: 'Bartosz', points: '240' },
        { id: '5', name: 'Michał', points: '180' },
      ],
    }
  },
}
</script>
<style lang="scss" scoped>
$pink-color: rgb(255, 0, 234);
$green-color: rgb(124, 255, 2);

.rankingBox {
  grid-column: 1/2;
  width: 100%;
  padding: 2rem 0 1rem 2rem;
  display: flex;
  justify-content: center;
  align-items: center;
  flex-direction: column;

  &::before {
    content: '';
    position: absolute;
    top: 0.4rem;
    left: 2.4rem;
    right: 0.4rem;
    bottom: 0.4rem;
    border: 0.15rem solid white;
    border-radius: 10px;
    box-shadow: 0px 0px 10px 0px white, inset 0px 0px 10px 0px white;
  }

  &::after {
    content: '';
    position: absolute;
    top: 0;
    left: 2rem;
    right: 0;
    bottom: 0;
    border: 0.15rem solid white;
    border-radius: 15px;
    box-shadow: 0px 0px 15px 0px white, inset 0px 0px 15px 0px white;
  }

  .panelTitle {
    font-family: NeonFontTitle;
    text-align: center;
    font-size: 3rem;
    margin: 0 0 1.5rem 0;
    letter-spacing: 0.1rem;
    color: rgb(94, 255, 0);
    text-shadow: 0 0 5px $green-color, 0 0 10px $green-color,
      0 0 15px $green-color;
  }
  .playersList {
    list-style-type: none;
    width: 100%;
    height: 25rem;
    display: grid;
    grid-template-rows: repeat(5, 1fr);

    .playerElement {
      font-family: NeonFontButtons2;
      display: flex;
      justify-content: center;
      align-items: center;
      flex-direction: column;
      letter-spacing: 0.1rem;

      .dataSection {
        display: grid;
        grid-template-columns: repeat(10, 1fr);
        height: 2.5rem;
        width: 100%;

        .iamge {
          grid-column: 2/3;
          width: 100%;
          height: 100%;
        }

        .nickname {
          grid-column: 3/8;
          display: flex;
          align-items: center;
          padding: 0 0 0 1rem;
        }
      }
      .pointsSection {
        width: 100%;
        height: 2.5rem;
        display: grid;
        grid-template-columns: repeat(10, 1fr);

        .points {
          grid-column: 6/11;
          font-size: 1rem;
        }
      }
    }
  }
}
@media (min-width: 300px) and (max-width: 699px) {
  .rankingBox {
    grid-row: 2;
    width: 100%;
    font-size: 1rem;

    .panelTitle {
      font-size: 2.5rem;
    }
  }
}
@media (min-width: 700px) and (max-width: 1499px) {
  .rankingBox {
    grid-row: 2;
    grid-column: 1/2;
    width: 100%;
    font-size: 2.5rem;

    .panelTitle {
      font-size: 2.8rem;
    }
  }
}
</style>
