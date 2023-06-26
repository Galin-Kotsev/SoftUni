function solve(a, b, c) {

    sum = 0;

    for (let index = 0; index < Math.abs(a); index++) {

        if (b < 0 || a < 0 ) {
            sum -= b;
        }
        else {
            sum += b;
        }
    }

    a1 = sum;

    for (let index2 = 0; index2 <= Math.abs(c); index2++) {
        if (c < 0 ) {
            sum -= a1;
        }
        else {
            sum += a1;
        }
    }

    if (sum > 0) {
        console.log(`Positive`)
    }
    else {
        console.log(`Negative`)
    }
}

solve(5, 12, -15);
solve(-6, -12, 14);
solve(-1, -2, -3);
solve(-5, 1, 1);
solve(7,-442,184);