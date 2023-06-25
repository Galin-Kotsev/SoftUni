function solve(input) {

    input = input.split(" ");
    var pattern = /[a-zA-Z]/;

    for (let index = 0; index <= input.length - 1; index++) {

        word = input[index];

        if (isNoNum = word.match(/#[a-zA-Z]+/) ? true : false && word.length > 1) {

            if(isNoNum === true)
            {
                console.log(word.substring(1));
            }
        }
    }
}


solve('Nowadays everyone uses # to tag a #sp2ecial word in #soc2ialMedia #1234');
solve('The symbol # is known #variously in English-speaking #regions as the #number sign');


