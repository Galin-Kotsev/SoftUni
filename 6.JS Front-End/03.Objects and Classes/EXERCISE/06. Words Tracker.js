function solve(input) {

    forSearch = input.shift();
    words = forSearch.split(" ");

    const wordsList = [];

    for (let index = 0; index < words.length; index++) {

        word1 = 0;

        for (let index2 = 0; index2 < input.length; index2++) {

            if (words[index] === input[index2]) {
                word1++;
            }
            
        }

        wordsList[words[index]] = [word1];
    }

    for (const [key, value] of Object.entries(wordsList).sort(([, b], [, a]) => a - b)) {
        console.log(`${key} - ${value}`);
    }
}

solve([
    'this sentence',
    'In', 'this', 'sentence', 'you', 'have',
    'to', 'count', 'the', 'occurrences', 'of',
    'the', 'words', 'this', 'and', 'sentence',
    'because', 'this', 'is', 'your', 'task'
]
)

solve([
    'is the',
    'first', 'sentence', 'Here', 'is',
    'another', 'the', 'And', 'finally', 'the',
    'the', 'sentence']
)