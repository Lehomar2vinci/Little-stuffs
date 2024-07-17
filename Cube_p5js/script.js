let angleX = 0;
let angleY = 0;
let prevMouseX, prevMouseY;
let drag = false;
let faceColors;
let targetColors;
let lerpAmt = 0.01; // Vitesse de transition des couleurs
let rotationSpeed = 0.01; // Vitesse de rotation

function setup() {
  createCanvas(400, 400, WEBGL);
  // Init les couleurs
  faceColors = new Array(6)
    .fill()
    .map(() => color(random(255), random(255), random(255)));
  targetColors = [...faceColors];
  // Contrôles
  document
    .getElementById("rotationSpeed")
    .addEventListener("input", function () {
      rotationSpeed = this.value;
    });
  document.getElementById("colorSpeed").addEventListener("input", function () {
    lerpAmt = this.value;
  });
  document.getElementById("resetCube").addEventListener("click", function () {
    angleX = 0;
    angleY = 0;
    for (let i = 0; i < targetColors.length; i++) {
      targetColors[i] = color(random(255), random(255), random(255));
    }
  });
}

function draw() {
  background(50);
  ambientLight(100);
  directionalLight(255, 255, 255, 0.25, 0.25, -1);
  if (drag) {
    angleY += (mouseX - prevMouseX) * rotationSpeed;
    angleX += (mouseY - prevMouseY) * rotationSpeed;
  }
  prevMouseX = mouseX;
  prevMouseY = mouseY;

  rotateX(angleX);
  rotateY(angleY);

  // Mise à jour et dessin des faces
  for (let i = 0; i < faceColors.length; i++) {
    faceColors[i] = lerpColor(faceColors[i], targetColors[i], lerpAmt);
  }
  drawCube();
}

function drawCube() {
  for (let i = 0; i < 6; i++) {
    push();
    if (i === 0) translate(0, 0, 50);
    else if (i === 1) translate(0, 0, -50);
    else if (i === 2) {
      rotateY(HALF_PI);
      translate(0, 0, 50);
    } else if (i === 3) {
      rotateY(HALF_PI);
      translate(0, 0, -50);
    } else if (i === 4) {
      rotateX(HALF_PI);
      translate(0, 0, 50);
    } else if (i === 5) {
      rotateX(HALF_PI);
      translate(0, 0, -50);
    }
    fill(faceColors[i]);
    rect(-50, -50, 100, 100);
    pop();
  }
}

function mousePressed() {
  if (mouseX > 0 && mouseX < width && mouseY > 0 && mouseY < height) {
    drag = true;
    prevMouseX = mouseX;
    prevMouseY = mouseY;
  }
}

function mouseReleased() {
  drag = false;
  // Nouvelles couleurs cibles
  for (let i = 0; i < targetColors.length; i++) {
    targetColors[i] = color(random(255), random(255), random(255));
  }
}
