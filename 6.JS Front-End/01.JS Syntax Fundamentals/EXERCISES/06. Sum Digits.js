function digitSum(number) {

    number = number.toString();

    numbers = [];

    let sum = 0;

    for (let index = 0; index < number.length; index++) {

        numbers.push(Number(number[index]));
    }

    console.log(numbers.reduce((a, b) => a + b, 0));
}

digitSum(245678);
digitSum(97561);
digitSum(543);