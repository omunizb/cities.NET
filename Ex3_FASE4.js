var city1, city2, city3, city4, city5, city6;

console.log("Write the name of six cities:");

city1 = prompt("First city:", "Barcelona");
city2 = prompt("Second city:", "Madrid");
city3 = prompt("Third city:", "Valencia");
city4 = prompt("Fourth city:", "Malaga");
city5 = prompt("Fifth city:", "Cadiz");
city6 = prompt("Sixth city:", "Santander");

var arrCities = [city1, city2, city3, city4, city5, city6];

function CharArray(item) {
    var arrItem = [];

    for (let i = 0; i < item.length; i++) {
        arrItem[i] = item.charAt(i);
    }

    return arrItem;
}

function InvertPrint(arrItem) {
    var inverted = "";
    for (let i = arrItem.length - 1; i >= 0; i--) {
        inverted += arrItem[i];
    }
    console.log(inverted);
}

console.log("These are the cities you have chosen, inverted:");

arrCities.forEach(function(city) {
    InvertPrint(CharArray(city));
});