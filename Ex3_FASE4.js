var city1, city2, city3, city4, city5, city6;

console.log("Write the name of six cities:");

city1 = prompt("First city:", "Barcelona");
city2 = prompt("Second city:", "Madrid");
city3 = prompt("Third city:", "Valencia");
city4 = prompt("Fourth city:", "Malaga");
city5 = prompt("Fifth city:", "Cadiz");
city6 = prompt("Sixth city:", "Santander");

var arrCity1 = [], arrCity2 = [], arrCity3 = [], arrCity4 = [], arrCity5 = [], arrCity6 = [];

function InvertPrint(city, arrCity) {
    var counter = 0; 
    for (let i = city.length - 1; i >= 0; i--) {
        arrCity[counter] = city.charAt(i);
        counter++;
    }
    
    var inverted = "";
    for (let i = 0; i < arrCity.length; i++) {
        inverted += arrCity[i];
    }
    console.log(inverted);
}

console.log("These are the inverted cities you have chosen:");

InvertPrint(city1, arrCity1);
InvertPrint(city2, arrCity2);
InvertPrint(city3, arrCity3);
InvertPrint(city4, arrCity4);
InvertPrint(city5, arrCity5);
InvertPrint(city6, arrCity6);