function solve(input, input2) {

    const storeProducts = {};

    for (let index = 0; index < input.length; index += 2) {

        product = input[index];
        quantity = Number(input[index + 1]);

        storeProducts[product] = quantity;
    }

    for (let index = 0; index < input2.length; index += 2) {

        product = input2[index];
        quantity = Number(input2[index + 1]);

        if (storeProducts.hasOwnProperty(product)) {
            storeProducts[product] += quantity;
        }
        else {
            storeProducts[product] = quantity;
        }
    }

    for (const [key, value] of Object.entries(storeProducts)) {
        console.log(`${key} -> ${value}`);

    }
}

    solve(['Chips', '5', 'CocaCola', '9', 'Bananas',
        '14', 'Pasta', '4', 'Beer', '2'],
        ['Flour', '44', 'Oil', '12', 'Pasta', '7',
            'Tomatoes', '70', 'Bananas', '30'])