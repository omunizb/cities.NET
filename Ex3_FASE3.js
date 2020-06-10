var city1, city2, city3, city4, city5, city6;

console.log("Write the name of six cities:");

city1 = prompt("First city:", "Barcelona").replace('a', '4').replace('A', '4');
city2 = prompt("Second city:", "Madrid").replace('a', '4').replace('A', '4');
city3 = prompt("Third city:", "Valencia").replace('a', '4').replace('A', '4');
city4 = prompt("Fourth city:", "Malaga").replace('a', '4').replace('A', '4');
city5 = prompt("Fifth city:", "Cadiz").replace('a', '4').replace('A', '4');
city6 = prompt("Sixth city:", "Santander").replace('a', '4').replace('A', '4');

var arrModCities = [city1, city2, city3, city4, city5, city6];

arrModCities.sort();

console.log("These are your chosen cities in alphabetical order, with 'a' replaced with 4:");

arrModCities.forEach(function(city) {
    console.log(city);
});