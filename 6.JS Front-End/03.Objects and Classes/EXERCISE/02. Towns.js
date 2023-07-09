function solve(input) {

    const inputs = input.slice(",");

    for (const city of inputs) {

        cityInfo = city.split(" | ")

        townInfo = {
            town: cityInfo[0],
            latitude: Number(cityInfo[1]).toFixed(2),
            longitude: Number(cityInfo[2]).toFixed(2),
        }

        console.log(townInfo)
    }
}

solve(['Sofia | 42.696552 | 23.32601', 'Beijing | 39.913818 | 116.363625'])