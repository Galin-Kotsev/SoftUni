function solve(text, wordSearched) {
    words = text.split(' ');
    count = 0;

    for (let index = 0; index < words.length; index++) {

        if (words[index] === wordSearched) {
            count++;
        }
    }
    console.log(count);
}

solve('This is a word and it also is a sentence', 'is')