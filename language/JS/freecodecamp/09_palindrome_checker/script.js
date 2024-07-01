const textInput = document.getElementById("text-input");
const checkButton = document.getElementById("check-btn");
const result = document.getElementById("result");

const checkText = text => {
    if (text === '') {
        alert("Please input a value");
        return;
    };
    result.replaceChildren();

    const lowerText = text.replace(/[^A-Za-z0-9]/gi, "").toLowerCase();
    const answer = lowerText === [...lowerText].reverse().join("") ? 'is' : 'is not';
    let resultMsg = `<p class="user-input">
                    "<strong>${text}</strong>
                    ${answer} a palindrome"
                </p>`;
    result.innerHTML = resultMsg;
    result.classList.remove('hidden');
};

checkButton.addEventListener('click', () => {
    checkText(textInput.value);
    textInput.value = '';
});
textInput.addEventListener('keydown', e => {
    if (e.key === "Enter") {
        checkText(textInput.value);
        textInput.value = '';
    }
});