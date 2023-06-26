function checkValidation(password) {

    passLength = false;
    onlyLettersAndDigits = false;
    twoDigits = false;

    if (password.length >= 6 && password.length <= 10) {
        passLength = true;
    }
    else {
        console.log(`Password must be between 6 and 10 characters`)
        passLength = false;
    }

    pattern = /^[0-9a-zA-Z]+$/;

    if (password.match(pattern)) {

        onlyLettersAndDigits = true;
    }
    else {
        console.log(`Password must consist only of letters and digits`);
        onlyLettersAndDigits = false;
    }

    if (password.replace(/[^0-9]/g,"").length >= 2) {

        twoDigits = true;
    }
    else {
        console.log(`Password must have at least 2 digits`);
        twoDigits = false;
    }
    
    if(passLength && onlyLettersAndDigits && twoDigits){
        console.log(`Password is valid`);
    }
}

checkValidation(`logIn`);
checkValidation(`MyPass123`);
checkValidation(`Pa$s$s`);


