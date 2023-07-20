function solve() {
  const input = document.querySelector("#input").value.split(".");
  input.pop();
  const output = document.querySelector("#output");

  while (input.length > 0) {

    const p = document.createElement("p");
    p.textContent = input.splice(0, 3).join(".").trim();
    output.appendChild(p);

  }
}




