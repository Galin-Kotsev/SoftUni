function solve(input) {
    input.slice(",")

    heroList = [];
    heroList2 = [];


    for (let index = 0; index < input.length; index++) {

        inputs = input[index].split(" / ")

        heroInfo = {

            hero: inputs[0],
            level: Number(inputs[1]),
            items: inputs[2]
        }

        name = inputs[0],
        level = Number(inputs[1]),
        items = inputs[2]

        heroList2.push([name, level, items]);
    }
    console.log(heroList2[1]);

}




solve([
    'Isacc / 25 / Apple, GravityGun',
    'Derek / 12 / BarrelVest, DestructionSword',
    'Hes / 1 / Desolator, Sentinel, Antara'
]
)