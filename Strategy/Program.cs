using System;
using System.Collections.Generic;

namespace Strategy
{
    enum Actors
    {
        King,
        Queen,
        Troll
    }

    class Program
    {
        static void Main(string[] args)
        {
            var characters = new Dictionary<Actors, Character>()
            {
                { Actors.King, new King(new SwordBehavior()) },
                { Actors.Queen, new Queen(new BowAndArrowBehavior()) },
                { Actors.Troll, new Troll() }
            };

            characters[Actors.King].Display();
            characters[Actors.King].Fight();
            Console.WriteLine("Switch weapon (strategy in runtime).");
            characters[Actors.King].SetStrategy(new AxeBehavior());
            characters[Actors.King].Fight();
            Console.WriteLine();

            characters[Actors.Queen].Display();
            characters[Actors.Queen].Fight();
            Console.WriteLine();

            characters[Actors.Troll].Display();
            characters[Actors.Troll].Fight();
            Console.WriteLine("Picking weapon (strategy in runtime).");
            characters[Actors.Troll].SetStrategy(new ClubBehavior());
            characters[Actors.Troll].Fight();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
