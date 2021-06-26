﻿using System;

namespace RPG
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int sumXp = 0;
            WeaponService.Player player = new WeaponService.Player();
            
            PlayerService playerService = new PlayerService();

            

           playerService.intro();

            Actions actions = new Actions();
            WeaponService weaponService = new WeaponService();
            while (actions.endPoint==0)
            { 
            Console.WriteLine("Where do you want to go?");

            
            Console.WriteLine("1. Left");
            Console.WriteLine("2. Right");
            Console.WriteLine("3. Straight ahead");
            Console.WriteLine("4. Backward");
                Console.WriteLine("5. Check your XP and armory");
                



                string way = Console.ReadLine();

                switch (way)
                {
                    case "1":

                        Console.WriteLine("Ugly monster is atacking you!!!");
                        Console.WriteLine("What do you want to do?");
                        Console.WriteLine("1. Fight!");
                        Console.WriteLine("2. Run away!");

                        actions.Monster(int.Parse(Console.ReadLine()));
                        break;

                    case "2":
                        Console.WriteLine();
                        Console.WriteLine("You met a great Wizard");
                        Console.WriteLine("He asked you unbelievable dificult question:");
                        Console.WriteLine(" 2 + 2 = ?");

                        actions.Wizard(int.Parse(Console.ReadLine()));
                        break;

                    case "3":
                        Console.WriteLine("You see a guarded bridge");
                        Console.WriteLine("The guard said that you have to pay to pass");
                        Console.WriteLine("How much you want to pay?");
                        Console.WriteLine("100, 300 or 500?");

                        actions.Bridge(int.Parse(Console.ReadLine()));
                        break;

                    case "4":
                        Console.WriteLine("Beautifull princess wants to give you a diamond!");
                        Console.WriteLine("\"How big it should be?\" - she said");
                        Console.WriteLine("Enter odd carats");

                        actions.Diamond(int.Parse(Console.ReadLine()));
                        
                        Console.Clear();
                        break;

                    case "5":
                        
                        Console.WriteLine();
                        Console.WriteLine("Gained: ");
                        Console.WriteLine();
                        foreach (var item in player.Xp)
                        {
                            
                            Console.WriteLine(item);
                            sumXp += item;
                        }
                        Console.WriteLine();
                        Console.WriteLine($"You have {sumXp} XP");
                        Console.WriteLine("and");
                        Console.WriteLine("your armory:");
                        Console.WriteLine(player.EquipedWeapon.WeaponInfo()); 
                        Console.ReadKey();
                        Console.Clear();
                      
                        break;


                    default:
                        Console.WriteLine("There's no other way");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }


        }
    }
}
