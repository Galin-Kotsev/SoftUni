function calculate(a,b,operator){

    if(operator === "multiply"){
        console.log(a*b);
    }
    else if(operator === "divide"){
        console.log(a/b);
    }
    else if(operator === "add"){
        console.log(a+b);
    }
    else if(operator === "subtract"){
        console.log(a-b);
    }
}

calculate(5,5,'multiply');
calculate(40,8,'divide');
calculate(12,19,'add');
calculate(50,13,'subtract');