function deleteByEmail() {
    const email = document.querySelector(`input[name="email"]`).value;

    const emailBox = Array.from(document.querySelectorAll("td:nth-child(even)"));

    const result = document.querySelector("#result");

    const toRemove = emailBox.find((x) => x.textContent === email)

    if (toRemove) {
        toRemove.parentElement.remove();
        result.textContent = "Deleted."
    }
    else {
        result.textContent = "Not found."
    }


}