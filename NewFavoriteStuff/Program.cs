using System;

namespace NewFavoriteStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            var zelda1 = new NESGame("The Legend of Zelda", "Action/RPG", 1987);

            var megaman2 = new NESGame("Mega Man 2", "Action/Adventure", 1989);

            var punchout = new NesGame("Mike Tyson's Punch Out", "Sports", 1987);

            var robocop = new Movies("Robocop", "Sci-Fi/Action", 1987);

            var pulpfiction = new Movies("Pulp Fiction", "Drama", 1994);

            var threeamigos = new Movies("Three Amigos", "Comedy", 1986);

            var wutang = new Bands("Wu-Tang Clan", "HipHop", "Enter The 36 Chambers");

            var midnight = new Bands("The Midnight", "SynthWave", "Endless Summer");

            var prince = new Bands("Prince", "Pop", "Purple Rain");

            var batman = new Comics("Batman", "DC", "Justice League");

            var punisher = new Comics("The Punisher", "Marvel", "Defenders");

            var wolverine = new Comics("Wolverine", "Marvel", "X-Men");

            // Calling The NES Games //
            Console.WriteLine("These are a few of my favorite NES games:");
            Console.WriteLine(zelda1.Name + " is a " + zelda1.Genre + " game released in " + zelda1.Year);
            Console.WriteLine(megaman2.Name + " is a " + megaman2.Genre + " game released in " + megaman2.Year);
            Console.WriteLine(punchout.Name + " is a " + punchout.Genre + " game released in " + punchout.Year);
            Console.WriteLine("");

            // Calling The Movies //
            Console.WriteLine("These are a few of my favorite movies:");
            Console.WriteLine(robocop.Name + " is an " + robocop.Genre + " movie released in " + robocop.Year);
            Console.WriteLine(pulpfiction.Name + " is an " + pulpfiction.Genre + " movie released in " + pulpfiction.Year);
            Console.WriteLine(threeamigos.Name + " is an " + threeamigos.Genre + " movie released in " + threeamigos.Year);
            Console.WriteLine("");

            // Calling The Artists //
            Console.WriteLine("These are a few of my favorite artists:");
            Console.WriteLine(wutang.Name + " is a " + wutang.Genre + " artist. " + wutang.Album + " is my favorite album.");
            Console.WriteLine(midnight.Name + " is a " + midnight.Genre + " artist. " + midnight.Album + " is my favorite album.");
            Console.WriteLine(prince.Name + " is a " + prince.Genre + " artist. " + prince.Album + " is my favorite album.");
            Console.WriteLine("");

            // Calling The Comics //
            Console.WriteLine("These are a few of my favorite comics:");
            Console.WriteLine(batman.Name + " is a " + batman.Brand + " comic. The " + batman.Affilation + " is his affilation.");
            Console.WriteLine(punisher.Name + " is a " + punisher.Brand + " comic. The " + punisher.Affilation + " is his affilation.");
            Console.WriteLine(wolverine.Name + " is a " + wolverine.Brand + " comic. The " + wolverine.Affilation + " is his affilation.");

            Console.ReadKey();

        }
    }
}