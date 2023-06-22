function solve(word, startIndex, count) {
    if (startIndex >= 0 && count <= word.length - 1) {
        let result = "";

        for (let i = startIndex; i <= count; i++) {
            result += word[i];
        }

        console.log(result);
    }
}

solve('ASentence', 1, 8)
solve('SkipWord', 4, 7)