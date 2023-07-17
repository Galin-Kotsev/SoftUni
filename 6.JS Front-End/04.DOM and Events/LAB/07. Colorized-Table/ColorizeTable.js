function colorize() {
    const item = Array.from(document.querySelectorAll("tr:nth-child(even)"));

    item.forEach(element => {
        element.style.background = "teal"
    });
}