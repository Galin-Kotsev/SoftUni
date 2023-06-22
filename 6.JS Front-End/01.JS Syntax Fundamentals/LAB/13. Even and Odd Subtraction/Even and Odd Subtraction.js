function solve(input) {

    let sumOdd = 0;
    let sumEven = 0;

    for (let i = 0; i < input.length; i++) {

        let element = input[i];

        if (element % 2 == 0) {
            sumEven += element;
        }
        else {
            sumOdd += element;
        }
    }

    console.log(sumEven - sumOdd);
}

solve([1, 2, 3, 4, 5, 6]);
solve([3,5,7,9])
solve([2,4,6,8,10])