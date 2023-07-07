function solve(arr) {

    class Cat {
        constructor(name, age) {
            this.name = name;
            this.age = age;
        }
    
        meow() {
            console.log(`${this.name}, age ${this.age} says Meow`)
        };
    }

    cats = [];

    for (let index = 0; index < arr.length; index++) {

        catData = arr[index].split(' ');
        let name, age;
        [name, age] = [catData[0], catData[1]];
        cats.push(new Cat(name, age));
    }

    cats.forEach(element => {

       return element.meow();
        
    });
}

solve(['Mellow 2', 'Tom 5'])
solve(['Candy 1', 'Poppy 3', 'Nyx 2'])