function solve (n,input){

   newArrey = input.slice(0,n);
   console.log(newArrey.reverse().join(" "));
}

solve(3,[10, 20, 30, 40, 50])