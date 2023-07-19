function subtract() {
    const first = Number(document.querySelector("#firstNumber").value);
    const second = Number(document.querySelector("#secondNumber").value);

    const result = document.querySelector("#result");

    result.textContent = first-second;
}