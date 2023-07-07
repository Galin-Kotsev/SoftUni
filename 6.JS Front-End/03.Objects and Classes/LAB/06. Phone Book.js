function phoneBook(number) {

    phoneList = {};
    number = number.toString();
    let numbers = number.split(",");

    for (let index = 0; index < numbers.length; index++) {

        const contacts = numbers[index];
        contact = contacts.split(" ");

        name = contact[0];
        number = contact[1];

        phoneList[name] = number;
    }

   Object.entries(phoneList).forEach(([key,value]) => {
    console.log(`${key} -> ${value}`)
   });
}

phoneBook(['Tim 0834212554', 'Peter 0877547887',
    'Bill 0896543112', 'Tim 0876566344']);