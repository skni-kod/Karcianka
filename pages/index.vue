<template>
  <div>
    <NuxtLogo />
    <div>
        <h1>Cyberkarty</h1>
    </div>

    <div class="main">
      <h2>Wpisz pseudonim</h2>
      <form action="/action_page">
        <input type="text" id="nick" name="nick">
          <br><br>
          <br><br>
        </form>
    
        <div class="main_box">
            <div class = "content">
                <a href="">
                <h3> Graj </h3></a>
            </div>
        </div>

        <div class = "box">
            <div class = "content">
                <a href="">
                <h3> Ustawienia </h3></a>
            </div>
        </div>

        <div class = "box">
            <div class = "content">
                <a href="">
                <h3> Zasady gry </h3></a>
            </div>
        </div>

        <div class = "box">
            <div class = "content">
                <a href="">
                <h3> O grze </h3></a>
            </div>
        </div>

        <div class = "box">
            <div class = "content">
                <a href="Logging">
                <h3> Zaloguj </h3></a>
            </div>
        </div>
    </div>
  </div>
</template>

<script>
export default {}
</script>

<style lang="scss" scoped>
</style>