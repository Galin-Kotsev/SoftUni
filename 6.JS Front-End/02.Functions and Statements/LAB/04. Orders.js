function solve(item, quantity) {

    result = 0;

    if (item === "coffee") {
        result = 1.50 * quantity;
    }
    else if (item === "water") {
        result = 1.00 * quantity;
    }
    else if (item === "coke") {
        result = 1.40 * quantity;
    }
    else if (item === "snacks") {
        result = 2 * quantity;
    }

    console.log(result.toFixed(2));
}


solve("water", 5);
solve("coffee", 2);
solve("snacks", 2);
solve("coke", 2);