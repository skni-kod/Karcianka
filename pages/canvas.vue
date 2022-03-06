<template>
  <div class="main">
    <canvas id="canvas" class="canvas" width="800px" height="800px"></canvas>
  </div>
</template>
<script>
export default {
  mounted: () => {
    const canvas = document.getElementById('canvas')
    const ctx = canvas.getContext('2d')
    ctx.strokeStyle = 'rgb(0,0,0)'
    ctx.lineJoin = 'round'
    ctx.lineCap = 'round'
    ctx.lineWidth = 15

    let isDrawing = false
    let lastX = 0
    let lastY = 0
    let direction = true

    function draw(e) {
      if (!isDrawing) return
      ctx.beginPath()
      ctx.moveTo(lastX, lastY)
      ctx.lineTo(e.offsetX, e.offsetY)
      ctx.stroke()
      ;[lastX, lastY] = [e.offsetX, e.offsetY]

      if (ctx.lineWidth >= 100 || ctx.lineWidth <= 1) {
        direction = !direction
      }
    }

    canvas.addEventListener('mousedown', (e) => {
      isDrawing = true
      ;[lastX, lastY] = [e.offsetX, e.offsetY]
    })

    canvas.addEventListener('mousemove', draw)
    canvas.addEventListener('mouseup', () => (isDrawing = false))
    canvas.addEventListener('mouseout', () => (isDrawing = false))
  },
}
</script>
<style lang="scss" scoped>
.main {
  position: fixed;
  top: 0;
  left: 0;
  bottom: 0;
  right: 0;
  display: flex;
  justify-content: center;
  align-items: center;

  .canvas {
    background: white;
  }
}
</style>
