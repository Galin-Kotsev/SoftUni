function solve (name, lastName , hairColor){

    person = {
        name: name, 
        lastName: lastName,
        hairColor: hairColor}

    console.log(JSON.stringify(person))
}

solve('George', 'Jones', 'Brown')