using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RPG
{
    public class Actions : WeaponService
    {
        WeaponService weaponService = new WeaponService();
        public int endPoint = 0;

        Player player = new Player();
        public void Monster(int result)
        {
            
            if (result == 1)
            {
                if (weaponService != null)
                {
                    Console.WriteLine("WOW!!!");
                    Console.WriteLine("You defeated the Monster using your weapon!");
                    player.Xp.Add(100);
                    Console.ReadKey();
                    Console.Clear();
                }

                else 
                {
                    Console.WriteLine("Did you really think you would defeat a monster with only one finger?");
                    Console.WriteLine();
                    Console.WriteLine("                     __|__");
                    Console.WriteLine("                       |  ");
                    Console.WriteLine("                       |");
                    Console.WriteLine("                     R.I.P.");
                    endPoint += 1;
                }
            }

            else if (result == 2)
            {
                Console.WriteLine();
                Console.WriteLine("Usain Bolt could learn from you...");
                Console.WriteLine();
                Console.WriteLine("1 XP gained");
                player.Xp.Add(1);

                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Come on... you're a smart guy...");
                Console.WriteLine();
                Console.WriteLine("1. Fight!");
                Console.WriteLine("or");
                Console.WriteLine("2. Run away!");
                Console.WriteLine();
                Monster(int.Parse(Console.ReadLine()));
                Console.WriteLine();
            }
        }

        public void Wizard(int result)
        {
            if (result == 4)
            {
                Console.WriteLine("You are a person of a great wisdom!");
                Console.WriteLine("You can pass!");
                Console.WriteLine();
                Console.WriteLine("10 XP gained");
                player.Xp.Add(10);
                Console.WriteLine();
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("You know what... speak to the monster!");
                Console.WriteLine();
                Console.WriteLine("10 XP lost");
                player.Xp.Add(-10);
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Ugly monster is atacking you!!!");
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("1. Fight!");
                Console.WriteLine("2. Run away!");

                Monster(int.Parse(Console.ReadLine()));

            }
        }

        public void Bridge (int result)
        {
            int sum = result;
            for (int i = 0; sum <= 1000; i++)
            {
                Console.WriteLine("MORE!!!");
                Console.WriteLine("100, 300 or 500?");
                result = int.Parse(Console.ReadLine());
                sum += result;
            }
            Console.WriteLine();
            Console.WriteLine("That's enough - we have a promotion...");
            Console.WriteLine("You can go");
            Console.WriteLine();
            Console.WriteLine("50 XP gained");
            player.Xp.Add(50);
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Wait!");
            Console.WriteLine("You can't go further with only one finger!");
            Console.WriteLine();
            Console.WriteLine("Choose your weapon:");

            IWeapon blade = new Blades();
            Console.WriteLine(blade.WeaponInfo());
            IWeapon fire = new Fire();
            Console.WriteLine(fire.WeaponInfo());
            IWeapon booms = new Booms();
            Console.WriteLine(booms.WeaponInfo());
            
            string choose = Console.ReadLine();

            switch (choose)
            {
                case "1":
                    Console.WriteLine("You have a sword!");

                    player.EquipedWeapon = blade;
                    break;
                case "2":
                    Console.WriteLine("You have a gun!");
                    player.EquipedWeapon = fire;
                    break;
                case "3":
                    Console.WriteLine("You have a bomb!");
                    player.EquipedWeapon = booms;
                    break;
            }


            Console.ReadKey();
        }

        public void Diamond (int star)
        {
            if (star < 100 && star%2!=0)
            {
                int st = 1;

                int st2 = 0;
                int st3 = 0;
                while (st <= star)
                {

                    for (int idy = star; idy >= st2; idy--)
                    {
                        Console.Write(" ");
                    }
                    st2 = st2 + 2;

                    for (int idx = 0; idx < st; idx++)
                    {
                        Console.Write("* ");
                    }

                    Console.WriteLine();
                    Console.WriteLine();
                    st = st + 2;
                }

                while (st3 <= star)
                {

                    for (int idy = star - 2; idy <= st2; idy++)
                    {
                        Console.Write(" ");
                    }
                    st2 = st2 + 2;

                    for (int idx = star - 2; idx > st3; idx--)
                    {

                        Console.Write("* ");

                    }

                    Console.WriteLine();
                    Console.WriteLine();
                    st3 = st3 + 2;
                }
                Console.WriteLine($"{star} XP gained");
                Console.WriteLine();
                player.Xp.Add(star);
                Console.ReadKey();
                Console.Clear();
            }
            else if (star < 100 && star%2 ==0)
            {
                Console.WriteLine();
                Console.WriteLine("I said odd!!!");
                Console.WriteLine();
                Diamond(int.Parse(Console.ReadLine()));
                
                Console.Clear();
            }
            else if (star > 100)
            {
                Console.WriteLine();
                Console.WriteLine("Come on... you wouldn't even lift it");
                Console.WriteLine();
                Console.ReadKey();
                Console.Clear();
            }
        }

       
        public void appearance (string height, string weight, string hair)
        {
            Player appearance = new Player() { Height = height, Weight = weight, Hair = hair};
          
        }
      

    }
}
