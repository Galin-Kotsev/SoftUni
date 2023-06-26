function solve(a, d) {

    let startChar = a;
    let endChar = d;
    text = [];

    if (a.charCodeAt(0) < d.charCodeAt(0)) {
        for (let c = startChar.charCodeAt(0) + 1; c < endChar.charCodeAt(0); c++) {

            text.push(String.fromCharCode(c));
        }
    }
    else{
        for (let c = endChar.charCodeAt(0)+1; c < startChar.charCodeAt(0); c++) {

            text.push(String.fromCharCode(c));
        }
    }
    console.log(text.join(" "));
}

solve('a', 'd');
solve('#', ':');
solve('C', '#');