function solve(word, text) {

    textLower = text.toLowerCase().trim();
    textUpper = text.toUpperCase().trim();

    if (textLower.includes(word) || textUpper.includes(word) || text.includes(word)) {
        console.log(word);
    }
    else {
        console.log(`${word} not found!`)
    }
}

solve('javascript', 'JavaScript is the best programming language');
solve('python', 'JavaScript is the best programming language');