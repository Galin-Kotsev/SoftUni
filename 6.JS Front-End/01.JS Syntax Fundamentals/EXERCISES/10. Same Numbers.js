function solve(numbers) {

    numbers = numbers.toString();

    sum = [];
    same = true;

    for (let index = 0; index <= numbers.length - 1; index++) {
        sum.push(Number(numbers[index]));

        if (sum[0] === (Number(numbers[index]))) {
            same = true;
        }
        else {
            same = false;
        }
    }
    
    console.log(same);
    console.log(sum.reduce((a, b) => a + b, 0))

}

solve(1234);
solve(2222222);