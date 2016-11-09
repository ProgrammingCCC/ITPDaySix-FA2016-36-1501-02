using System;

namespace Newbrak
{
    class Location
    {
        public string Name;
        public string Description;
        public int Population;
        public string[] Items = { "", "", "" };

        Person firstStranger;
        Person secondStranger;

        public Location()
        {
        }

        public Location(string name, string description, int population)
        {
            Name = name;
            Description = description;
            Population = population;
            Items = fillItems();
            generatePeople();
            About();
        }

        public string[] fillItems()
        {
            if(Name == "Sedonia")
            {
                Items[0] = "Gold";
                Items[1] = "Donut";
                Items[2] = "Finest Silk";
            }
            if (Name == "Shara")
            {
                Items[0] = "Fish";
                Items[1] = "Spacefish";
                Items[2] = "Seaweed";
            }
            if (Name == "Stim")
            {
                Items[0] = "Explosives";
                Items[1] = "Gems";
                Items[2] = "Glass";
            }

            return Items;
        }

        public void generatePeople()
        {
            if (Name == "Sedonia")
            {
                firstStranger = new Person("Lord Kalok");
                secondStranger = new Person("Jake from State Farm");
            }
            if (Name == "Shara")
            {
                firstStranger = new Person("Trader Dave");
                secondStranger = new Person("Dan the old fisherman");
            }
            if (Name == "Stim")
            {
                firstStranger = new Person("Sir Tim");
                secondStranger = new Person("Chewbacca");

            }
        }

        public void About()
        {
            Console.WriteLine("Welcome to " + Name + ", " + Description + ". Population: " + Population);

            Console.WriteLine("Our exports are");
            for(int x = 0; x < Items.Length; x++)
            {
                Console.WriteLine(Items[x]);
            }

            Console.WriteLine("During your stay here in "+ Name +" You may meet " + firstStranger.Name + " or " + secondStranger.Name);
        }
    }
}
