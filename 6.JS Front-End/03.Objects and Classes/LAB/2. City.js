function solve(city){

   for (const key in city) {
    console.log(key +" -> "+ city[key])
    
   }
}

const city = {name: "Sofia", area: 492, population: 1238438, country: "Bulgaria",
postCode: "1000"};

solve(city)