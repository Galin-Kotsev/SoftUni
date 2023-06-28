function solve(input) {

    input = input.toUpperCase();
    input = input.replaceAll(", ", " ");
    input = input.split(/[,.?!^\s+$]/);

    let result = [];

    for (let index = 0; index < input.length; index++) {
        result.push(input[index]);

    }

    console.log(result.join(", "));
}

solve('Hi, how are you?');
solve('hello');