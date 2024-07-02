# JAVASCRIPT

## __**Print:**__
---
The console allows us to print and view JavaScript output. we can send information to the console using **console.log()**.

For example, this code will print "Naomi" to the console:

```
console.log("Naomi");
```

```
let developer = "Naomi";
console.log(developer);
```
---

## __**Variable :**__
---
JavaScript is the programming language that powers the web. Unlike the HTML and CSS you have learned previously, JavaScript is most commonly used to write logic instead of markup.

One of the most important concepts in programming is variables. A variable points to a specific memory address that stores a value. Variables are given a name which can be used throughout your code to access that value.

Declaring a variable means giving it a name. In JavaScript, this is often done with the **let** keyword.

For example, here is how we would declare a hello variable:

`let hello;`

we can assign a value using the assignment operator **=**.

For example:

`let character = "Hello";`

When a variable is declared with the **let** keyword, we can reassign (or change the value of) that variable later on.

In this example, the value of programmer is changed from "Naomi" to "CamperChan".

```
let programmer = "Naomi";
programmer = "CamperChan";
```
The default value of an uninitialized variable is **undefined**. This is a special data type that represents a value that does not have a definition yet.

You can still assign a value to an uninitialized variable.

Here is an example:

```
let uninitialized;
uninitialized = "assigned";
```
We can also assign the value of a variable to another variable.

For example:

```
let first = "Hello";
let second = "Hello World";
let first = second;
```
Declaring a variable with the ***let*** keyword allows it to be reassigned. This means we can change it later to be a completely different value.

If we are sure that the declared variable will not gonna be changed then we then use ***const*** keyword to declare them. ***const*** variable are special.

`const variable = value;`

A ***const*** variable cannot be uninitialized. This example code will throw error.

`const firstname;`

A ***const*** variable cannot be reassigned like a ***let*** variable. This code example would throw an error:

```
const firstname = "Naomi"
firstname = "CamperChan";
```
Variables in JS are available in a specific *scope*. In other words, where a variable is declared determines where in our code it can be used.

___Global Scope :___ The first scope is the global scope. Variable that are declared outside of any "block" like a function and for loop are in the *global scope*.

When a variable is in the global scope, a function can access it in its definition. Here is an example of a function using a global *title* variable.

```
const title = "Professor ";
function demo(name) {
  return title + name;
}
demo("Naomi")
```
___Local Scope or Block Scope :___ Variable can also be declared inside a function. These variables are considered to be in the *local scope*, or *block scope*. A variable declared inside a function can only be used inside that function. If we try to access it outside of the function, we got a reference error.


---
## __**Data Types**__
---
JavaScript has seven primitive data types, with **String** being one of them. In JavaScript, a string represents a sequence of characters and can be enclosed in either single (') or double (") quotes.

**Number :** With number datatype, we can perform mathematical operations, like addition and multiplication. When using a number value, we do not use quotes.

For example:

`let num = 10;`

**Objects :** Objects are very important data type in JS. Objects are non primitive data types are mutable data types that are not *undefined*, *null*, *boolean*, *number*, *string* or *symbol*.

For example:
```
{
  key: value
}
```
Objects are similar to arrays, except that instead of using indexes to access and modify their data, you access the data in objects through properties.

Properties consist of a key and a value. The key is the name of the property, and the value is the data stored in the property.

For Example:
```
const obj = {
  name: "Quincy Larson"
};
```
If the property name (key) of an object has a space in it, you will need to use single or double quotes around the name.

Here is an example of an object with a property name that has a space:

For example:
```
const spaceObj = {
  "Space Name": "Kirk",
};
```
If we tried to write a key without the quotes, it would throw an error:

For example:
```
const spaceObj = {
  // Throws an error
  Space Name: "Kirk",
};
```
There are two ways to access the properties of an object: dot notation (.) and bracket notation ([]), similar to an array.

Dot notation is what we use when we know the name of the property you're trying to access ahead of time.

For example:
```
object.property;
```
Here is a sample of using dot notation (.) to read the name property of the developer object:
```
const developer = {
  name: "Jessica",
}

// Output: Jessica
console.log(developer.name);
```
The second way to access the properties of an object is bracket notation ([]). If the property of the object we are trying to access has a space in its name, you will need to use bracket notation.

For example:
```
objectName["property name"];
```
Here is a sample of using bracket notation to read an object's property:
```
const spaceObj = {
  "Space Name": "Kirk",
};

spaceObj["Space Name"]; // "Kirk"
```
The *object destructuring* syntax allows us to unpack values from arrays and objects:
```
const developerObj = {
  name: "Jessica Wilkins",
  isDeveloper: true
};

// Object destructuring
const { name, isDeveloper } = developerObj;
```

---

## __**Data Structure**__
---

In programming, we will often need to work with lots of data. There are many data structures that can help you organize and manage your data. One of the most basic data structures is an array.

**Array :** An array is a non-primitive data type that can hold a series of values. Non-primitive data types differ from primitive data types in that they can hold more complex data. Primitive data types like strings and numbers can only hold one value at a time. Arrays are denoted using square brackets (**[...]**).

Here is an example of a variable with the value of an empty array:

`let array = [];`

When an array holds values, or element, those value are separated by commas.

Here is an array that holds two strings:

`let array = ["first", "second"];`

We can access the values inside an array using the *index* of the value. An index is a number representing the position of the value in the array, starting from 0 for the first value. We can access the value using *bracket notation*, such as **array[0]**.

Arrays are special in that they are considered *mutable*. This means you can change the value at an index directly.

For example, this code would assign the number 25 to the second element in the array:

~~~
let array = [1, 2, 3];
array[1] = 25;
console.log(array); // prints [1, 25, 3]
~~~

Notice how the value inside our array has been changed directly? This is called *mutation*.

Currently, our code accesses the last element in the array with last index. But we may not know how many elements are in an array when we want the last one.

We can make use of __*.length*__ property of an array. This returns the number of elements in the array. To get the last element of any array, we can use the following syntax:

`array[array.length -1];`

#### ___array.methods___

- __*array.length*__ returns the number of elements in the array. By subtracting1, we get the index of the last element in the array. <br> `array.length`

- __*array.push()*__ allows us to **"push"** a value to the end of an array. <br> `array.push(12);`

- ***array.pop()*** remove the last element from an array and returns that element. <br> `array.pop();`

- ***array.unshift()*** method of an array allows us to add a value to the beginning of the array, unlike *.push()* which adds the value at the end of the array. <br> `array.unshift(12);`

- ***array.shift()*** method remove the first element of the array, unlike .pop() which removes the last element. <br> `array.shift();`

- ***array.includes()*** method determines if an array contains an element and will return either *true* or *false*. <br> `array.includes(12);`

- ***array.map()*** method is used to iterate through an array and return a new array. It's helpful when we want to create a new array based on the values of an existing array. <br> `array.map(arrow function);` <br> The `map()` method takes a function as an argument. This is called a **callback function**, which is a function that is passed to another function as an argument.

- ***array.join()*** method is used to concatenate all the elements od an array into a single string. It takes an optional parameter called a *separator* which is used to separate each element of the array. <br> `array.join(" "); //Separator takes a space character`

- ***array.sort()*** method converts elements of an array into strings and sort them into in place based on their value in the *UTF-16* encoding. <br> `array.sort();`

- ***array.find()*** method retrieves the first element within an array that fulfills the conditions specified in the provided callback function. If no element satisfies the condition the condition, the method returns *undefined*. <br> `array.find(callback function)`

- ***array.indexOf()*** method returns the first index at which a given element can be found in the array, or *-1* if the element is not present. <br> `array.indexOf(array-element); // output: index of array-element in the array`

- ***array.forEach()*** method is used to loop through an array and perform a function on each element of the array. <br> `array.forEach(callback function or condition);`

- ***array.filter()*** method to keeps only the elements of an array that satisfy the callback function passed to it. <br> `array.filter(callback function);`

- ***array.split()*** method is used to divide a string into substring based on a specified separator. It then returns these substrings as element of an array. <br> `array.split();` <br> The *split* method takes in a parameter known as a separator. The separator is used to tell the computer where each split should occur.

- ***array.reverse()*** method reverses the order of the elements in the array in place. The first element becomes the last, and the last element becomes the first.<br>
Here is an example of using the *reverse* method:<br>
`[1, 2, 3, 4, 5].reverse();`

- ***array.join()*** method takes an array of elements and joins them into a string. Similar to the *split* method, the *join* method also takes an optional separator. If you don't provide a separator, the default separator is a comma.<br>
Here is an example of using the *join* method:<br>
`[1, 2, 3, 4, 5].join("-");`

***Spread Operator(...)*** allows us to copy all the elements from one array into another. It can also be used to concatenate multiple arrays into one.<br> In example below, both *arr1* and *arr2* hae been spread into *combineArr*:
~~~
const arr1 = [1, 2, 3];
const arr2 = [4, 5, 6];

const combinedArr = [...arr1, ...arr2];
console.log(combinedArr); // Output: [1, 2, 3, 4, 5, 6]
~~~

**String :**
> todo add about string

___template literals :___ allows us to interpolate variables directly within a string. Template literals are denoted with backticks ``, as opposed to single or double quotes. Variables can be passed into a template literal by surrounding the variable with *${}* - the value of the variable will be inserted into the string.<br>
For Example: <br>
~~~
const name = "Naomi";
const templateLiteral = `Hello, my  name is ${name}~!`;
console.log(templateLiteral);
~~~

#### ___string.methods___

- ___.repeat___ method accepts a number as a an argument, specifying the number of times to repeat the target string. <br> For example, using *.repeat()* to generate the string *"code! code! code!"*: <br> `const activity = "code! ";` <br> `activity.repeat(3);`

- ___.replace___ method replace characters in a string with another string. This method accept two argument. The first argument is the character sequence to be replaced, which can be either a string or a regex pattern. The second argument is the string that replaces the matched sequence. <br> Since strings are immutable, the *.replace* method returns a new string with the replaced character. <br> In this example, the *.replace* method is used to replace all instances of the letter *l* with the number *1* in the string *hello*. <br> `"hello".replace(/1/g, "1");`

- ___.match()___ method takes a regex argument. *.match()* will return an array of match result-containing either the first match, or all matches if thr global flag is used. <br>
`
const result = str.match(regex);
` <br> Return the result of the calling the *.match()* method on *str* and passing out *regex* variable as the argument.

- ___.toLowerCase()___ method returns the calling string value converted to lower case. <br>
`
Hello.toLowerCase(); //output: hello
`
---
## ___**Conditional Statement**___
---

 conditional statement, also known as a selection statement, facilitates the making of decisions on the basis of particular conditions. Furthermore, such a statement executes in a sequential manner when there is no condition around the statement. In case some condition is put for a block of statements, change may occur in the execution flow on the basis of the result evaluated by the condition

#### <u>__***if Statement :***__</u>
An *if statement* allows you to run a block of code only when a condition is met.

```
if (condition) {
  logic
}
```

A ***truthy value*** is a value that is considered true when evaluated as a boolean. Most of the values you encounter in JavaScript will be truthy.

Example
```
if ("false") {
  console.log("Condition is true");
}
```

A ***falsy value*** is the opposite - a value considered false when evaluated as a boolean. JavaScript has a defined list of falsy values. Some of them include false, 0, "", null, undefined, and NaN.

Example
```
if (false) {
  console.log("Condition is true");
}
```

#### <u>__***if...else if...else Statement :***__</u>

*if...else if...else statements* allow you to check multiple conditions in a single block of code.

```
if (condition1) {
  // code to run if condition1 is true
} else if (condition2) {
  // code to run if condition2 is true
} else if (condition3) {
  // code to run if condition3 is true
} else {
  // this code will run
  // if the first and second conditions are false
}
```
If the first condition is **false**, JavaScript will check the next condition in the chain. If the second condition is **false**, JavaScript will check the third condition, and so on. An else block will only evaluate if the conditions in the *if* and *else if* blocks are not met.

#### <u>__***switch-case-break-default :***__</u>

*switch* statement is used to compare an expression against multiple possible values and execute different code block based on the match. It's commonly used for branching logic.<br>
For example, here's how to compare the expression *dayOfWeek* against possible values:<br>

```
switch (dayOfWeek) {
  case 1:
    console.log("It's Monday!");
    break;
  case 2:
    console.log("It's Tuesday!");
    break;
  // ...cases for other workdays
  default:
    console.log("It's the weekend!");
}
```

*case* clause in the *switch* statement that checks for a match against the expression *expr*, followed by code to run if there's a match.<br>
Here's an example where the *case* clause checks that *expr* is equal to the string "case123":<br>

```
switch (expr) {
  case 'case123':
    // Write your logic here
}
```

*break* statement will tell the JS interpreter to stop executing statements. Without adding a *break* statement at the end of each *case* block, the program will execute the code for all matching *cases*. <br>
```
switch (someVariable) {
  case 'case123':
    // Write your logic here
    break; // Terminates the switch statement
}
```

*default* case is executed when none of the previous case conditions match the value being evaluated. It serves as a catch-all for any other possible cases.<br>
For example:
```
const dayOfWeek = 7;

switch (dayOfWeek) {
  case 1:
    console.log("It's Monday!");
    break;
  case 2:
    console.log("It's Tuesday!");
    break;
  // ...cases for other workdays
  default:
    console.log("It's the weekend!");
}
```

---
## __**Loops**__
---

Loops are used to execute a block of code repeatedly for a specified number of times.

### <u>__***for loop :***__</u>

```
for (iterator; condition; iteration) {
  logic;
}
```

- ***Iterator -*** The iterator is a variable we can declare specifically in your *for* loop to control how the loop iterates or gos through our logic. <br> It is common convention to use *i* as out iterator variable in a loop. A *for* loop allows us to declare this in the parentheses ().<br>For example, here is a *for* loop that declares an *index* variable and assigns it the value *100*.<br>
`for (let index = 100; "second"; "third") {}`

- ***Condition -*** The *condition* of a *for* loop tells the loop how many times it should iterate. When the *condition* becomes false, the loop will stop.

- ***Iteration -*** Our *iteration* statement tell our loop what to do with the iterator after each run.

### <u>__***for...of loop :***__</u>

```
for (const value of iterable) {

}
```

A *for...of* loop iterates over each item in an iterable object and temporarily assign it to a variable.

Note that we can use *const* because the variable only exists for a single iteration, not during the entire loop.

### <u>__**while loop**__</u>
A *while* loop will run over and over again until the *condition* specified is no longer true.

~~~
while (condition) {
  logic;
}
~~~

If we change *condition* to true, our *while* loop will run forever. This id called *infinite loop*, and we should be careful to avoid these. An *infinite loop* can lock up our system, requiring a full restart to escape.

---
## __**Functions**__
---

A *function* is a block of code that can be reused throughout your application. Functions are declared with the following syntax:

~~~
function name(parameter) {

}
~~~

The *function* keyword tells JS that the *name* variable is going to be a function. *parameter* is a variable that represents a value that us passed into the function when it is used. A function may have as many , or as few, parameters as we like. Like a *for* loop, the space between the curly braces is the function body.

In order to use a function, we need to call it. A *function* call tells our application to run the code from the function whenever we choose to call it. The syntax for a function call is the function name followed by parentheses.

For example, this code defines and calls a *test* function.

```
function test() {

}

test();
```

___Parameter:___ Parameters are special variables that are given a value when you call the function, and can be used in the function's code.

To add a parameter to our function, we need to add a variable name inside the parentheses.

For example, this *demo* function has a *name* parameter:

```
function demo(name) {

}
```

When we pass a value to a function call, that value is referred to as an *argument*. Here is an example of calling *demo* function and passing *"Naomi"* as the argument for the name parameter.

```
function demo(name) {
  return name;
}
demo("Naomi");
```

Values returned out of a function are used by calling the function. you can use the function call directly as the value it returns, or capture the returned value in a variable. This way, we can use the value assigned to a locally scoped variable, outside the function it was created in.

```
function getName() {
  const name = "Camper cat";
  return name;
}

console.log(getName()); // "Camper cat"

const capturedReturnValue = getName();
console.log(capturedReturnValue); // "Camper cat"

console.log(name); // reference error
```
An important thing to know about the *return* keyword is that it does not just define a value to be returned from your function, it also stops the execution of your code inside a function or a block statement. This means any code after a *return* statement will not run.

Function parameters can be initialize with default values. If a function is called without an argument, then the default value will be used.<br>
For example:<br>
```
function greeting(name = "Anonymous") {
  return "Hello " + name;
}

console.log(greeting("John")); // Hello John
console.log(greeting()); // Hello Anonymous
```


---
## __**Regular Expression(regex)**__
---
Regular expressions are patterns used to match character combinations in strings.

Regex in JS is indicated by a pattern wrapped in forward slashes. The following example will match the string literal *"hello"*.

`const regex = /hello/;`

The current pattern will match the exact text "hello".

In regex, shorthand character classes allow us to match specific characters without having to write those characters in our pattern. Shorthand character classes are preceded with backslash. The character class \s will match any whitespace character.

Regex can also take specific flags to alter the pattern matching behavior. Flags are added after the closing */*.

- The **g** flag, which stand for "global", will tell the pattern to continue looking after it has found a match.<br>
For example: <br> `const helloregex = /hello/g;`

- The **e** in a number input can also be an uppercase **E**. Regex has a flag for this which is **i** flag,stand for "insensitive". <br>
For example: <br> `const helloregex = /hello/i;`

- The **+** modifier in a regex allows us to match a pattern that occurs one or more times. To match our digit pattern one or more times. <br>
For example: <br>
`const regex = /[0-9]+/`

**Shorthand Character:**

- *\s* shorthand character class to match any whitespace.
- *\d* shorthand character class to match any digit.


---
## __**Arrow Function**__
---
An arrow function is an anonymous function expression and a shorter way to write functions. Anonymous means that the functions does not have a name. Arrow functions are always anonymous.<br>Here is the basic syntax: <br>`() => {}`

To create a named arrow function , we can assign the function to a variable: <br>
```
const arrowFunction = () => {
  // code goes here
};
```
Just like regex functions, arrow functions can accept multiple parameters. <br>
```
const greet = (firstName, lastName) => {
  console.log(`Hello ${firstName} ${lastName}!`);
}
```
If the function only has one parameter. We can omit the parentheses around the parameter list like this:<br>
```
const greet = name => {
  console.log(`Hello ${name}!`);
  };
```
Just like regex functions, arrow functions can return values.<br>
Here is an example of an arrow function returning the result of multiplying two numbers: <br>
~~~
const multiplyTwoNumber = (num1, num2) => {
  return num1 * num2;
}

// Output: 12
console.log(multiplyTwoNumber(2, 6));
~~~

If the arrow function is returning a simple expression, we can omit the *return* keyword and the curly braces {}. This is called an **implicit return**. <br> `const multiplyTwoNumbers = (num1, num2) => num1 * num2`
If out arrow function has multiple line of code in the function body, then we need to use the `return` keyword and the curly braces `{}`.<br> Example Code: <br>
~~~
const getTax = (price) => {
  const taxRate = 0.08;
  const tax = price * taxRate;
  return tax;
}
~~~

Function parameters can be initialize with default values. If a function is called without an argument, then the default value will be used.<br>
For example:<br>
```
const greeting = (name = "Anonymous") => {
  return "Hello " + name;
}

console.log(greeting("John")); // Hello John
console.log(greeting()); // Hello Anonymous
```