//zmienna przechowująca obrazek
var image = document.getElementById('image');

//funkcja pokazująca obrazek
function showImage(){
	image.style.opacity = '1';
}

// przekazywanie buttona
showButton = document.getElementById("show-button");

// dodanie słuchacza do buttona
showButton.addEventListener("click",showImage);