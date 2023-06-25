function solve (string){

const result = string.split(/(?=[A-Z])/);

console.log(result.join(", "));
}

solve('SplitMeIfYouCanHaHaYouCantOrYouCan');