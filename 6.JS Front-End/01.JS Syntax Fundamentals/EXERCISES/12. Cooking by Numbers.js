function solve(number, ...commands) {

    result = Number(number);

    for (let index = 0; index < commands.length; index++) {
        const command = commands[index];

        if (command === "chop") {
            result /= 2;
        }
        else if (command === "spice"){
            result += 1;
        }
        else if (command === "fillet"){
            result -= (result*0.20);
        }
        else if (command === "bake"){
            result *= 3;
        }
        else if (command === "dice"){
            result = Math.sqrt(result);
        }
            
        console.log(result)
    }
}

solve('32', 'chop', 'chop', 'chop', 'chop', 'chop')
solve('9', 'dice', 'spice', 'chop', 'bake', 'fillet');