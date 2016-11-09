using System;

namespace Newbrak
{
    class Game
    {
        private string Title = "Newbrak Tours!";
        Location theLocation;

        public void Run()
        {
            Console.Title = Title;

            //game
            TitleScreen();
            Menu();

        }

        private void TitleScreen()
        {
            Console.WriteLine(Title);
            Console.WriteLine("Press enter to play..");
            Console.ReadKey();
        }
        private void Menu()
        {
            Console.WriteLine("Where would you like to visit? Sedonia, Shara or Stim? Type the name of your destination:");
            string input = Console.ReadLine();
            Console.Clear();
            switch (input.ToLower())
            {
                case "sedonia":
                   
                    theLocation = new Location("Sedonia", "A rich capital city of a wealthy empire", 9856352);
                    break;

                case "shara":
                    theLocation = new Location("Shara", "A coastal city of a fishing empire", 13);

                    break;


                case "stim":
                    theLocation = new Location("Stim", "A mining outpost in the mountains", 240);

                    break;
            }
            Console.ReadKey();
        }

    }
}
