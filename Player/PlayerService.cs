using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class PlayerService : WeaponService
    {
      Player player = new Player();

        
       
        public void intro()
        {
        Console.WriteLine("Welcome in the most archaic RPG in whole world!");
            Console.WriteLine("So how do you think what do you able to do here? Press any key...");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Ooh come on... Really? That's all?");
            Console.WriteLine("If You have only one finger it could be a problem with your weapon...");

            Console.WriteLine("So... use it to type your name");
            player.Name = Console.ReadLine();
        Console.WriteLine("How tall are you?");
            player.Height = Console.ReadLine();
        Console.WriteLine("What color are your hair?");
            player.Hair = Console.ReadLine();
            Console.WriteLine("How much you weight?");
            player.Weight = Console.ReadLine();
        Console.Clear();
            Console.WriteLine($"Nice to meet you {player.Height} tall, {player.Hair}-haired, {player.Weight} weights {player.Name}!");
            Console.WriteLine("I'm Dor-Yan and I will be your guide in that freaking world so...");
            Console.ReadKey();
            Console.WriteLine("Don't expect to much:D");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Ok, if you really have nothing better to do and want to go further just tap something");
            Console.WriteLine("(we already know that you are good at it)");
            Console.ReadKey();
            Console.Clear();
            }
    }
}
