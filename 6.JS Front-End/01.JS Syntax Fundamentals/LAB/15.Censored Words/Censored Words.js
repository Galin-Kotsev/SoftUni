function solve(text, word) {
    censoredWord = "*".repeat(word.length);

    while (text.includes(word)) {
        text = text.replace(word, censoredWord)
    }
    console.log(text);
}

solve('Find the hidden word', 'hidden')