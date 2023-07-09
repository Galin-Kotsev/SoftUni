function solve(inputs) {

    for (let index = 0; index < inputs.length; index++) {

        let name = inputs[index];
        let number = inputs[index].length;

        console.log(`Name: ${name} -- Personal Number: ${number}`)
    }
}

solve(['Silas Butler', 'Adnaan Buckley', 'Juan Peterson', 'Brendan Villarreal'])
