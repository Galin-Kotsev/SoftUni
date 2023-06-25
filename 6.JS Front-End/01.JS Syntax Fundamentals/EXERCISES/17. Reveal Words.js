function solve(word, sentance) {

    word = word.split(", ");
    sentance = sentance.split(" ");
    newArray = [];

    for (let index2 = 0; index2 < word.length; index2++) {

        for (let index = 0; index < sentance.length; index++) {

            if (word.length === sentance.length){
                break;
            }

            if (sentance[index].includes("*")) {

                if (sentance[index].length == word[index2].length) {

                    newArray.push(word[index2]);
                    word.shift(0);
                }
            }
            else {
                newArray.push(sentance[index]);
            }

        }
    }
    console.log(newArray.join(" "));
}

solve('great', 'softuni is ***** place for learning new programming languages');
solve('great, learning', 'softuni is ***** place for ******** new programming languages');