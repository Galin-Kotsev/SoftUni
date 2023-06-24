function solve (start , end){

    const numbersCount =[];
    let sum = 0;

    for (let index = start; index <= end; index++) {
        numbersCount.push(index);
        sum = sum+index;
    }

    console.log(numbersCount.join(" "));
    console.log(`Sum: ${sum}`);

}


solve(5,10);
solve(0,26);