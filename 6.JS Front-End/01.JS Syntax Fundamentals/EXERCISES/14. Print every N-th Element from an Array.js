function solve(array, skip) {

    nElementArray = [];

    for (let index = 0; index < array.length; index++) {

        if (index % skip === 0) {
            nElementArray.push(String(array[index]));
        }
    }

    return(nElementArray);
}


solve(['5', '20', '31', '4', '20'], 2);
solve(['dsa','asd','test','tset'],2);
solve(['1','2','3','4','5'],6);