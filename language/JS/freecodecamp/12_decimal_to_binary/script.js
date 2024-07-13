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


const numberInput = document.getElementById("number-input");
const convertBtn = document.getElementById("convert-btn");
const result = document.getElementById("result");

const animationData = [
    {
        inputVal: 5,
        marginTop: 300,
        addElDelay: 1000,
    }, {
        inputVal: 2,
        marginTop: -200,
        addElDelay: 1500,
    }, {
        inputVal: 1,
        marginTop: -200,
        addElDelay: 2000,
    }
];

const decimalToBinary = (input) => {
    // using arrays
    /**
    const inputs = [];
    const quotients = [];
    const remainders = [];

    if (input === 0) {
        result.innerText = "0"
        return;
    }

    while (input > 0) {
        const quotient = Math.floor(input / 2);
        const remainder = input % 2;

        inputs.push(input);
        quotients.push(quotient);
        remainders.push(remainder);

        input = quotient;
    }
    console.log("Inputs: ", inputs);
    console.log("Quotients: ", quotients);
    console.log("Remainders: ", remainders);

    result.innerText = remainders.reverse().join("");
     */

    // using string concatenation
    /**
    let binary = "";

    if (input === 0) {
        binary = "0";
    }

    while (input > 0) {
        binary = (input % 2) + binary;
        input = Math.floor(input / 2);
    }

    result.innerText = binary;
     */

    // using Recursion
    if (input === 0 || input === 1) {
        return String(input);
    } else {
        return decimalToBinary(Math.floor(input / 2)) + (input % 2);
    }
};

const showAnimation = () => {
    setTimeout(() => {
        console.log("free");
    }, 500);
    setTimeout(() => {
        console.log("Code");
    }, 1000);
    setTimeout(() => {
        console.log("Camp");
    }, 1500);
};

function checkUserInput() {
    const inputInt = parseInt(numberInput.value);

    if (!numberInput.value || isNaN(inputInt) || inputInt < 0) {
        alert("Please provide a decimal number greater than or equal to 0");
        return;
    }

    if (inputInt === 5) {
        showAnimation();
        return;
    }
    result.textContent = decimalToBinary(inputInt);
    numberInput.value = "";
}

convertBtn.addEventListener("click", checkUserInput);
numberInput.addEventListener("keydown", (e) => {
    if (e.key === "Enter") {
        checkUserInput();
        numberInput.value = ""
    }
});
