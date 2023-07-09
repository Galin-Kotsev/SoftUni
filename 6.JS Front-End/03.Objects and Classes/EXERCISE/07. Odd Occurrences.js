function solve(inputs) {

    inputs = inputs.toString();

    inputs = inputs.toLowerCase();

    words = inputs.split(" ");

    const wordsList = [];
    const uniqueChars = [];

    for (let index = 0; index < words.length; index++) {

        word1 = 0;

        for (let index2 = 0; index2 < words.length; index2++) {

            if (words[index] == words[index2]) {
                word1++;
            }
        }

        if(word1 %2 !== 0){

            wordsList.push(words[index])
        }
    }

    wordsList.forEach((c) => {
        if (!uniqueChars.includes(c)) {
            uniqueChars.push(c);
        }
    });
    
    console.log(uniqueChars.join(" "));
}

solve('Java C# Php PHP Java PhP 3 C# 3 1 5 C#')

solve(['Cake IS SWEET is Soft CAKE sweet Food'])