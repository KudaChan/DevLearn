# JAVASCRIPT

## Project-1 : Pyramid Generator
---

### <u>**Day-1:** *18-June-2024*</u>

### __**Print:**__
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

### __**Variable :**__
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


---
### __**Data Types**__
---
JavaScript has seven primitive data types, with **String** being one of them. In JavaScript, a string represents a sequence of characters and can be enclosed in either single (') or double (") quotes.

**Number :** With number datatype, we can perform mathematical operations, like addition and multiplication. When using a number value, we do not use quotes.

For example:

`let num = 10;`

---

### __**Data Structure**__
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

**String :**

#### ___array.methods___
- ___.repeat accepts___ method accepts a number as a an argument, specifying the number of times to repeat the target string. <br> For example, using *.repeat()* to generate the string *"code! code! code!"*: <br> `const activity = "code! ";` <br> `activity.repeat(3);`

---
### __**Loops**__
---

Loops are used to execute a block of code repeatedly for a specified number of times.

#### <u>__***for loop :***__</u>

```
for (iterator; condition; iteration) {
  logic;
}
```

- ***Iterator -*** The iterator is a variable we can declare specifically in your *for* loop to control how the loop iterates or gos through our logic. <br> It is common convention to use *i* as out iterator variable in a loop. A *for* loop allows us to declare this in the parentheses ().<br>For example, here is a *for* loop that declares an *index* variable and assigns it the value *100*.<br>
`for (let index = 100; "second"; "third") {}`

- ***Condition -*** The *condition* of a *for* loop tells the loop how many times it should iterate. When the *condition* becomes false, the loop will stop.

- ***Iteration -*** Our *iteration* statement tell our loop what to do with the iterator after each run.

#### <u>__***for...of loop :***__</u>

```
for (const value of iterable) {

}
```

A *for...of* loop iterates over each item in an iterable object and temporarily assign it to a variable.

Note that we can use *const* because the variable only exists for a single iteration, not during the entire loop.


---
### __**Functions**__
---

A *function* is a block of code that can be reused throughout your application. Functions are declared with the following syntax: