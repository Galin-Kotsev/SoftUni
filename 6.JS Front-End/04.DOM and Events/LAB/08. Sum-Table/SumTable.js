function sumTable() {

    const price = Array.from(document.querySelectorAll("td:nth-child(even)"));

    let sum = 0;

    for (let index = 0; index < price.length; index++) {
        sum += Number(price[index].textContent);
    }

    document.querySelector("#sum").textContent = sum;
}