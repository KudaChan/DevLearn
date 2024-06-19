// let character = "Hello";
const character = "#";

// console.log(character);
// character = 'World';
// console.log(character);

// let secondCharacter;
// secondCharacter = "Test";
// secondCharacter = character;
// console.log(secondCharacter);

// let profession = "teacher";
// let age;
// console.log(profession);
// console.log(age);

// let count = 8;
const count = 8;
// let rows = [];
const rows = [];
// rows[rows.length - 1] = 10;
// console.log(rows);

// let cities = ["London", "New York", "Mumbai"];
// console.log(cities);
// cities[cities.length - 1] = "Mexico City";
// console.log(cities);

// let pushed = rows.push("freeCodeCamp");
// console.log(pushed);
// let popped = rows.pop();
// console.log(popped);
// console.log(rows);

for (let i = 0; i < count; i = i + 1) {
    rows.push(character.repeat(i+1));
}

let result = "";

for (const row of rows) {
    result = result + "\n" + row;
}

console.log(result);