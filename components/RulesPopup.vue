<template>
  <transition>
    <div
      class="rulesPopup"
      v-if="$store.state.showRulesPopup"
      onselectstart="return false;"
    >
      <div class="header">
        <p class="title">Zasady gier</p>
        <div
          class="closePopup"
          @click="$store.dispatch('closeRulesPopup')"
        ></div>
      </div>
      <div class="rulesContainer">
        <div class="gameList">
          <ul class="list">
            <li class="listElement" @click="rulesDisplay = 1">Game 1</li>
            <li class="listElement" @click="rulesDisplay = 2">Game 2</li>
            <li class="listElement" @click="rulesDisplay = 3">Game 3</li>
            <li class="listElement" @click="rulesDisplay = 4">Game 4</li>
            <li class="listElement" @click="rulesDisplay = 5">Game 5</li>
          </ul>
        </div>
        <div class="rulesContent">
          <transition-group name="rulesLists">
            <div class="rule" v-if="rulesDisplay === 1" key="1">
              <p class="gameTitle">Game 1</p>
              <ul class="rulesList">
                <li class="listElement">
                  1. Lorem ipsum dolor sit amet, consectetur adipiscing elit.
                  Sed faucibus tellus nibh, et maximus odio molestie vitae.
                  Phasellus eget rhoncus nunc. Nullam imperdiet vel sapien
                  gravida iaculis. Morbi enim dolor. Lorem ipsum dolor sit amet,
                  consectetur adipiscing elit.
                </li>
                <li class="listElement">
                  2. Sed faucibus tellus nibh, et maximus odio molestie vitae.
                  Phasellus eget rhoncus nunc. Nullam imperdiet vel sapien
                  gravida iaculis. Morbi enim dolor.
                </li>
              </ul>
            </div>
            <div class="rule" v-if="rulesDisplay === 2" key="2">
              <p class="gameTitle">Game 1</p>

              <ul class="rulesList">
                <li class="listElement">
                  2. Lorem ipsum dolor sit amet, consectetur adipiscing elit.
                  Sed faucibus tellus nibh, et maximus odio molestie vitae.
                  Phasellus eget rhoncus nunc. Nullam imperdiet vel sapien
                  gravida iaculis. Morbi enim dolor. Lorem ipsum dolor sit amet,
                  consectetur adipiscing elit.
                </li>
                <li class="listElement">
                  2. Sed faucibus tellus nibh, et maximus odio molestie vitae.
                  Phasellus eget rhoncus nunc. Nullam imperdiet vel sapien
                  gravida iaculis. Morbi enim dolor.
                </li>
              </ul>
            </div>
            <div class="rule" v-if="rulesDisplay === 3" key="3">
              <p class="gameTitle">Game 1</p>

              <ul class="rulesList">
                <li class="listElement">
                  3. Lorem ipsum dolor sit amet, consectetur adipiscing elit.
                  Sed faucibus tellus nibh, et maximus odio molestie vitae.
                  Phasellus eget rhoncus nunc. Nullam imperdiet vel sapien
                  gravida iaculis. Morbi enim dolor. Lorem ipsum dolor sit amet,
                  consectetur adipiscing elit.
                </li>
                <li class="listElement">
                  2. Sed faucibus tellus nibh, et maximus odio molestie vitae.
                  Phasellus eget rhoncus nunc. Nullam imperdiet vel sapien
                  gravida iaculis. Morbi enim dolor.
                </li>
              </ul>
            </div>
            <div class="rule" v-if="rulesDisplay === 4" key="4">
              <p class="gameTitle">Game 1</p>

              <ul class="rulesList">
                <li class="listElement">
                  4. Lorem ipsum dolor sit amet, consectetur adipiscing elit.
                  Sed faucibus tellus nibh, et maximus odio molestie vitae.
                  Phasellus eget rhoncus nunc. Nullam imperdiet vel sapien
                  gravida iaculis. Morbi enim dolor. Lorem ipsum dolor sit amet,
                  consectetur adipiscing elit.
                </li>
                <li class="listElement">
                  2. Sed faucibus tellus nibh, et maximus odio molestie vitae.
                  Phasellus eget rhoncus nunc. Nullam imperdiet vel sapien
                  gravida iaculis. Morbi enim dolor.
                </li>
              </ul>
            </div>
            <div class="rule" v-if="rulesDisplay === 5" key="5">
              <p class="gameTitle">Game 1</p>

              <ul class="rulesList">
                <li class="listElement">
                  5. Lorem ipsum dolor sit amet, consectetur adipiscing elit.
                  Sed faucibus tellus nibh, et maximus odio molestie vitae.
                  Phasellus eget rhoncus nunc. Nullam imperdiet vel sapien
                  gravida iaculis. Morbi enim dolor. Lorem ipsum dolor sit amet,
                  consectetur adipiscing elit.
                </li>
                <li class="listElement">
                  2. Sed faucibus tellus nibh, et maximus odio molestie vitae.
                  Phasellus eget rhoncus nunc. Nullam imperdiet vel sapien
                  gravida iaculis. Morbi enim dolor.
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
  data() {
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
  font-size: 16px;
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
    padding: 0 0 2rem 0;

    .closePopup {
      position: absolute;
      width: 2rem;
      height: 2rem;
      top: 1rem;
      left: 1rem;
      background: url('@/assets/img/x-lg.svg');
      background-position: center;
      background-repeat: no-repeat;
      background-size: 100%;
      cursor: pointer;
    }

    .title {
      width: 100%;
      font-size: 2.2rem;
      text-transform: uppercase;
      text-align: center;
      letter-spacing: 0.2rem;
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
        top: 5rem;

        .listElement {
          display: grid;
          align-items: center;
          height: 4.5rem;
          font-size: 2rem;
          letter-spacing: 0.2rem;
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
          height: 2rem;
          width: 100%;
          font-size: 2.3rem;
          letter-spacing: 0.2rem;
        }
        .rulesList {
          list-style-type: none;
          text-align: left;
          padding: 0 3rem 0 0;
          top: 5rem;

          .listElement {
            padding: 0.5rem 0;
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
@media (min-width: 300px) and (max-width: 699px) {
}

@media (min-width: 700px) and (max-width: 1365px) {
  .rulesPopup {
    .header {
      .title {
        font-size: 2.2rem;
      }
    }

    .rulesContainer {
      .gameList {
        .list {
          top: 4rem;

          .listElement {
            height: 4rem;
            font-size: 1.8rem;
          }
        }
      }

      .rulesContent {
        .rule {
          .gameTitle {
            font-size: 2rem;
            letter-spacing: 0.1rem;
          }

          .rulesList {
            padding: 0 2rem 0 0;
            top: 4rem;
          }
        }
      }
    }
  }
}
</style>
