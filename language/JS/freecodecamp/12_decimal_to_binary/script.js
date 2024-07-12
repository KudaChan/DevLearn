const numberInput = document.getElementById("number-input");
const convertBtn = document.getElementById("convert-btn");
const result = document.getElementById("result");

const decimalToBinary = (input) => {
    // const inputs = [];
    // const quotients = [];
    // const remainders = [];

    // if (input === 0) {
    //     result.innerText = "0"
    //     return;
    // }

    // while (input > 0) {
    //     const quotient = Math.floor(input / 2);
    //     const remainder = input % 2;

    //     inputs.push(input);
    //     quotients.push(quotient);
    //     remainders.push(remainder);

    //     input = quotient;
    // }
    // console.log("Inputs: ", inputs);
    // console.log("Quotients: ", quotients);
    // console.log("Remainders: ", remainders);

    // result.innerText = remainders.reverse().join("");

    let binary = "";

    if (input === 0) {
        binary = "0";
    }

    while (input > 0) {
        binary = (input % 2) + binary;
        input = Math.floor(input / 2);
    }

    result.innerText = binary;
};

function checkUserInput() {
    if (!numberInput.value || isNaN(parseInt(numberInput.value)) || parseInt(numberInput.value) < 0) {
        alert("Please provide a decimal number greater than or equal to 0");
        return;
    }
    decimalToBinary(parseInt(numberInput.value));
    numberInput.value = "";
}

convertBtn.addEventListener("click", checkUserInput);
numberInput.addEventListener("keydown", (e) => {
    if (e.key === "Enter") {
        checkUserInput();
        numberInput.value = ""
    }
});

const a = () => {
    return "freeCodeCamp " + b();
};

const b = () => {
    return "is " + c();
};

const c = () => {
    return "awesome!";
};

console.log(a());

const callStack = [
    "a(): returns 'freeCodeCamp ' + b()",
    "b(): returns 'is ' + c()",
    "c(): returns 'awesome!'"
];




























// About Binary Numbers
/**
 * Binary are a base 2 number system. Unlike the base-10 or decimal number system
 * we use every day that uses 10 digit(0-9) to form numbers, the binary number system
 * only has two digits 0 and 1.
 * In computer science, these binary digits are called bits, and are the smallest unit of data computers can process.
 * For computer 0 represents false or "off", and 1 represents true or "on".
 *
 * In base-2 number system, the rightmost digit represents the ones place, the next
 *  digit to the left represents the twos place, then the fours place, then the eights
 * place, and so on.
 * 
 */