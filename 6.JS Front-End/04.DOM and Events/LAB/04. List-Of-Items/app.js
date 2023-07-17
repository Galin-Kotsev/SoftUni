function addItem() {

    const item = document.querySelector("#newItemText").value;

    document.querySelector("ul").innerHTML += `<li>${item}</li>`;
}