class Song
{
    public string TypeList { get; set; }
    public string Name { get; set; }
    public string Time { get; set; }

    public Song(string typeList, string name, string time)
    {
        TypeList = typeList;
        Name = name;
        Time = time;
    }
}

class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var songs = new List<Song>();

        for (int i = 0; i < n; i++)
        {
            var songData = Console.ReadLine().Split('_');
            var typeList = songData[0];
            var name = songData[1];
            var time = songData[2];

            songs.Add(new Song(typeList, name, time));
        }

        var command = Console.ReadLine();

        if (command == "all")
        {
            foreach (var song in songs)
                Console.WriteLine(song.Name);
        }

        else
        {
            foreach (var song in songs)
                if (song.TypeList == command)
                    Console.WriteLine(song.Name);
        }
    }
}
