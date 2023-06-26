function solve(number) {

    numbers = number.toString();
    sumOdd = 0;
    sumEven = 0;

    for (let index = 0; index < numbers.length; index++) {
        a = Number(numbers[index]);
        if ( a % 2 === 0) {
            sumEven += a;
        }
        else {
            sumOdd += a;
        }
    }
    console.log(`Odd sum = ${sumOdd}, Even sum = ${sumEven}`);
}

solve(1000435);
solve(3495892137259234);
