function solve(input) {

    scheduleList = {};

    list = input.toString();
    list = list.split(",");

    for (let index = 0; index < list.length; index++) {

        const dayOfWeek = list[index];
        date = dayOfWeek.split(" ");

        day = date[0];
        name = date[1];

        if(scheduleList.hasOwnProperty(day)){
            console.log(`Conflict on ${day}!`)
        }
        else{
            scheduleList[day] = name;
            console.log(`Scheduled for ${day}`)
        }
    }

   Object.entries(scheduleList).forEach(([key,value]) => {
    console.log(`${key} -> ${value}`)
   });
}


solve(['Friday Bob','Saturday Ted',
'Monday Bill','Monday John','Wednesday George'])