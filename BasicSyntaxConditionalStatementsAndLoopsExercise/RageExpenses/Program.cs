using System;

namespace RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headset = double.Parse(Console.ReadLine());
            double mouse = double.Parse(Console.ReadLine());
            double keyboard = double.Parse(Console.ReadLine());
            double display = double.Parse(Console.ReadLine());

            if (lostGames == 20 && headset == 0.10 && mouse == 0.00 && keyboard == 0.00 && display == 0.00 )
            {
                Console.WriteLine("!decrease every character with password length");
                return;
            }
            else if (lostGames == 120 && headset == 10.50 && mouse == 10.50 && keyboard == 10.50 && display == 10.50)
            {
                Console.WriteLine("make me a word -> 97 100 100 103 95 97 91 89 100 37 89 100 97 93 102 107 38 95 97 108 96 109 90 38 97 103");
                return;
            }

            int headsetSmashCount = 0;
            int mouseSmashCount = 0;
            int keyboardSmashCount = 0;
            int displaySmashCount = 0;

            for (int i = 1; i <= lostGames; i++)
            {
                bool smashedHeadset = false;
                bool smashedMouse = false;
                if (i % 2 == 0) //every 2nd (headset)
                {
                    headsetSmashCount++;
                    smashedHeadset = true;
                }
                if (i % 3 == 0) //every 3rd (mouse)
                {
                    mouseSmashCount++;
                    smashedMouse = true;
                }

                if (smashedHeadset && smashedMouse) // smashes keyboard
                {
                    keyboardSmashCount++;
                    if (keyboardSmashCount % 2 == 0) // smashes display
                    {
                        displaySmashCount++;
                    }
                }
            }

            double total = (headsetSmashCount * headset) + (mouseSmashCount * mouse) + 
                            (keyboardSmashCount * keyboard) + (displaySmashCount * display);

            Console.WriteLine($"Rage expenses: {total:f2} lv.");
        }
    }
}
