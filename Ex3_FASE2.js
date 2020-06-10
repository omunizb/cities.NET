var city1, city2, city3, city4, city5, city6;

console.log("Write the name of six cities:");

city1 = prompt("First city:", "Barcelona");
city2 = prompt("Second city:", "Madrid");
city3 = prompt("Third city:", "Valencia");
city4 = prompt("Fourth city:", "Malaga");
city5 = prompt("Fifth city:", "Cadiz");
city6 = prompt("Sixth city:", "Santander");

var arrayCities = [city1, city2, city3, city4, city5, city6];

arrayCities.sort();

console.log("These are your chosen cities in alphabetical order:");

arrayCities.forEach(function(city) {
    console.log(city);
});