function speedRadar(speed, area) {
    if (area === "motorway") {
        if (speed > 130) {

            let speedOver = Math.abs(130 - speed);
            let status = "";

            if (speedOver > 0 && speedOver <= 20) {
                status = 'speeding';
            }
            else if (speedOver > 20 && speedOver <= 40) {
                status = 'excessive speeding';
            }
            else {
                status = 'reckless driving';
            }

            console.log(`The speed is ${speedOver} km/h faster than the allowed speed of ${130} - ${status}`)
        }
        else if (speed <= 130) {
            console.log(`Driving ${speed} km/h in a 130 zone`)
        }
    }
    else if (area === "interstate") {
        if (speed > 90) {

            let speedOver = Math.abs(90 - speed);
            let status = "";

            if (speedOver > 0 && speedOver <= 20) {
                status = 'speeding';
            }
            else if (speedOver > 20 && speedOver <= 40) {
                status = 'excessive speeding';
            }
            else {
                status = 'reckless driving';
            }

            console.log(`The speed is ${speedOver} km/h faster than the allowed speed of 90 - ${status}`)
        }
        else if (speed <= 90) {
            console.log(`Driving ${speed} km/h in a 90 zone`)
        }
    }
    else if (area === "city") {
        if (speed > 50) {

            let speedOver = Math.abs(50 - speed);
            let status = "";

            if (speedOver > 0 && speedOver <= 20) {
                status = 'speeding';
            }
            else if (speedOver > 20 && speedOver <= 40) {
                status = 'excessive speeding';
            }
            else {
                status = 'reckless driving';
            }

            console.log(`The speed is ${speedOver} km/h faster than the allowed speed of 50 - ${status}`)
        }
        else if (speed <= 50) {
            console.log(`Driving ${speed} km/h in a 50 zone`)
        }
    }
    else if (area === "residential") {
        if (speed > 20) {

            let speedOver = Math.abs(20 - speed);
            let status = "";

            if (speedOver > 0 && speedOver <= 20) {
                status = 'speeding';
            }
            else if (speedOver > 20 && speedOver <= 40) {
                status = 'excessive speeding';
            }
            else {
                status = 'reckless driving';
            }

            console.log(`The speed is ${speedOver} km/h faster than the allowed speed of 20 - ${status}`)
        }
        else if (speed <= 20) {
            console.log(`Driving ${speed} km/h in a 20 zone`)
        }
    }
}

speedRadar(40, 'city');
speedRadar(21, 'residential');
speedRadar(120, 'interstate');
speedRadar(200, 'motorway');