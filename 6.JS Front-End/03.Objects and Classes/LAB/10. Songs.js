function solve(input) {

    class Songs {
        constructor(type, name, time) {
            this.type = type;
            this.name = name;
            this.time = time;
        }
    }

    n = input.shift();
    typeSearched = input.pop();

    songs = [];

    for (let index = 0; index < n; index++) {

        let [type, name, time] = input[index].split('_');
        song = new Songs(type, name, time);
        songs.push(song);

    }

    if (typeSearched === "all") {
        songs.forEach((i) => console.log(i.name));
    }
    else {
        let filtered = songs.filter((i) => i.type === typeSearched);
        filtered.forEach((i) => console.log(i.name));
    }
}

solve([4,
    'favourite_DownTown_3:14',
    'listenLater_Andalouse_3:24',
    'favourite_In To The Night_3:58',
    'favourite_Live It Up_3:48',
    'listenLater'])

solve([2,
    'like_Replay_3:15',
    'ban_Photoshop_3:48',
    'all']
)

solve([3,
    'favourite_DownTown_3:14',
    'favourite_Kiss_4:16',
    'favourite_Smooth Criminal_4:01',
    'favourite'])