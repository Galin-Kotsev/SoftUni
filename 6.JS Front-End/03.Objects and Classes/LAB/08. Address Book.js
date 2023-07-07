function solve(input) {

    addressBook = {};

    list = input.toString();
    list = list.split(",");

    for (let index = 0; index < list.length; index++) {

        const personInfo = list[index];
        information = personInfo.split(":");

        name =  information[0];
        address =  information[1];

        addressBook[name] = address;
    }

    Object.entries(addressBook).sort().forEach(([key, value]) => {
        console.log(`${key} -> ${value}`)
    });
}

solve(['Tim:Doe Crossing',
    'Bill:Nelson Place',
    'Peter:Carlyle Ave',
    'Bill:Ornery Rd']);