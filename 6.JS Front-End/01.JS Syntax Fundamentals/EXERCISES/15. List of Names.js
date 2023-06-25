function solve(input) {

    input.sort((a,b) => a.toLowerCase().localeCompare(b.toLowerCase()));
    count = 1;

    for (let index = 0; index < input.length; index++) {
        console.log(`${count}.${input[index].trim()}`)
        count++;
    }
}

solve(["John", "Bob", "Christina", "Ema"])
solve([`1`, `2`, `5`, `7`])