function solve(input) {

    input.slice(",");
    movieList = [];

    for (let index = 0; index < input.length; index++) {

        string = input[index];

        if (string.includes("addMovie")) {
            string = string.split("addMovie ");

            name = string[1].trim();

            movieList.push({ name });
        }
        else if (string.includes("directedBy")) {
            string = string.split(" directedBy ");

            movieName = string[0]
            directorName = string[1]

            const movie = movieList.find((m) => m.name === movieName);

            if (movie) {
                movie.director = directorName;
            }
        }
        else if (string.includes("onDate")) {
            string = string.split(" onDate ");

            movieName = string[0]
            date = string[1]

            const movie = movieList.find((m) => m.name === movieName);

            if (movie) {
                movie.date = date;
            }
        }

    }
    
    movieList
        .filter((m) => m.name && m.director && m.date)
        .forEach((m) => console.log(JSON.stringify(m)));
}

solve([
    'addMovie Fast and Furious',
    'addMovie Godfather', 'Inception directedBy Christopher Nolan',
    'Godfather directedBy Francis Ford Coppola',
    'Godfather onDate 29.07.2018',
    'Fast and Furious onDate 30.07.2018',
    'Batman onDate 01.08.2018',
    'Fast and Furious directedBy Rob Cohen'
])

