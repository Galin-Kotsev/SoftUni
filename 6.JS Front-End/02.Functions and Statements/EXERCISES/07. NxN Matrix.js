function drow(n) {

    for (let index = 0; index < n; index++) {

        string = "";

        for (let index2 = 0; index2 < n; index2++) {
           string+=`${n} `;
        }
        console.log(string);
    }
}

drow(3);