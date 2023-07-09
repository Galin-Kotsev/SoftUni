function solve(input) {

    input.slice(",");

    parkingLot = new Set();

    for (let index = 0; index < input.length; index++) {

        inputs = input[index].split(", ");

        command = inputs[0];
        number = inputs[1];

        if (command === "IN") {
            parkingLot.add(number)
        }
        else if (command === "OUT") {
            parkingLot.delete(number)
        }
    }

    parkingLot = Array.from(parkingLot).sort();

    if (parkingLot.length === 0) {
        console.log(`Parking Lot is Empty`)
    }
    else {
       parkingLot.forEach(element => {
         
             console.log(element)
         
       });
    }
}

solve(['IN, CA2844AA',
'IN, CA1234TA',
'OUT, CA2844AA',
'IN, CA9999TT',
'IN, CA2866HI',
'OUT, CA1234TA',
'IN, CA2844AA',
'OUT, CA2866HI',
'IN, CA9876HH',
'IN, CA2822UU']
)

solve(['IN, CA2844AA',
    'IN, CA1234TA',
    'OUT, CA2844AA',
    'OUT, CA1234TA']
)