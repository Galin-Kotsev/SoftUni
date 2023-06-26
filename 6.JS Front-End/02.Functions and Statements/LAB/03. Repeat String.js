function repeat(text, count) {

    result = "";

    for (let index = 0; index < count; index++) {

        result += `${text}`;
    }

    console.log(result);
}

repeat("abc", 3);
repeat("String", 2)