function perfectNumber(num) {

    const checkPerfectNumber = (num = 1) => {
        if (num === 1) {
            return false;
        };
        let sum = 1;
        for (let i = 2; i <= Math.floor(Math.sqrt(num)); i++) {
            if (num % i === 0) {
                sum = sum + i + num / i; if (sum > num) {
                    return `It's not so perfect.`;
                }
            };
        };
        return `We have a perfect number!`;
    };
    console.log(checkPerfectNumber(num));
}

perfectNumber(6);
perfectNumber(28);
perfectNumber(1236498);