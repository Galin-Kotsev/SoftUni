function solve(firstName, lastName, age) {

    person = {
        firstName: firstName,
        lastName: lastName,
        age: age,
    };

   Object.entries(person).forEach(function([key]){
    return `${key}: ${person[key]}`
   });
}

solve("Peter", "Pan", "20")