function solve(groupSize, groupType, day) {

    let totalPrice = 0;

    if (groupType === "Students") {
        if (day === "Friday") {
            if (groupSize >= 30) {
                totalPrice = (groupSize * 8.45) - ((groupSize * 8.45) * 0.15);
            }

            totalPrice = groupSize * 8.45;
        }
        else if (day === "Saturday") {
            if (groupSize >= 30) {
                totalPrice = (groupSize * 9.80) - ((groupSize * 9.80) * 0.15);
            }

            totalPrice = groupSize * 9.80;
        }
        else if (day === "Sunday") {
            if (groupSize >= 30) {
                totalPrice = (groupSize * 10.46) - ((groupSize * 10.46) * 0.15);
            }
            else {
                totalPrice = groupSize * 10.46;
            }
        }
    }
    else if (groupType === "Business") {
        if (day === "Friday") {
            if (groupSize >= 100) {
                totalPrice = ((groupSize - 10) * 10.90);
            }
            else {
                totalPrice = groupSize * 10.90;
            }
        }
        else if (day === "Saturday") {
            if (groupSize >= 100) {
                totalPrice = ((groupSize - 10) * 15.60);
            }
            else {
                totalPrice = groupSize * 15.60;
            }
        }
        else if (day === "Sunday") {
            if (groupSize >= 100) {
                totalPrice = ((groupSize - 10) * 16);
            }
            else {
                totalPrice = groupSize * 16;
            }
        }
    }
    else if (groupType === "Regular") {
        if (day === "Friday") {
            if (groupSize >= 10 && groupSize <= 20){
                totalPrice = (groupSize * 15) - ((groupSize * 15) * 0.05);
            }
            else{
                totalPrice = groupSize*15;
            }
        }
        else if (day === "Saturday") {
            if (groupSize >= 10 && groupSize <= 20){
                totalPrice = (groupSize * 20) - ((groupSize * 20) * 0.05);
            }
            else{
                totalPrice = groupSize*20;
            }
        }
        else if (day === "Sunday") {
            if (groupSize >= 10 && groupSize <= 20){
                totalPrice = (groupSize * 22.50) - ((groupSize * 22.50) * 0.05);
            }
            else{
                totalPrice = groupSize*22.50;
            }
        }
    }
    console.log(`Total price: ${totalPrice.toFixed(2)}`)
}

solve(30, "Students", "Sunday");
solve(40, "Regular", "Saturday")
