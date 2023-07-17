function calc() {
    const input1 = document.getElementById("num1");
    const input2 =  document.getElementById("num2");
    const sum = Number(input1.value) + Number(input2.value);
    document.getElementById("sum").value = sum;
}
