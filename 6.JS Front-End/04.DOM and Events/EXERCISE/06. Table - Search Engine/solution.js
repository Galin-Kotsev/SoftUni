function solve() {
   document.querySelector('#searchBtn').addEventListener('click', onClick);

   function onClick() {
      const searchedText = document.querySelector("#searchField").value;
      const tableList = Array.from(document.querySelectorAll("tbody td"))

      tableList.forEach(word => {
         word.parentElement.classList.remove("select")
      });

      tableList.forEach(word => {
         if (word.textContent.includes(searchedText)) {
            console.log(word)
            word.parentElement.classList.add("select")
         }
      });
   }
}