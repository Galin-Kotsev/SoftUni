function palindrome(input) {

    input.toString();

    for (let index = 0; index < input.length; index++) {

        number = Number(input[index]);
        toReverse = number.toString();
        reversedNumber = "";

        for (let index = toReverse.length - 1; index >= 0; index--) {
            reversedNumber += toReverse[index];
        }

        reversedNumber = Number(reversedNumber);

        result = number === reversedNumber ? `true` : `false`;
        
        console.log(result);
    }
}

palindrome([123, 323, 421, 121]);