﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RPG
{
    public class WeaponService
    {

        
        public interface IWeapon
        {
            string WeaponInfo();
            int Attack();
            int Speed();
            int Range();
        }

        public class Fist : IWeapon
        {
            public string WeaponInfo() { return "Fist"; }
            public int Attack() { return 1; }
            public int Speed() { return 1; }
            public int Range() { return 1; }
        }


        
        public class Blades : IWeapon
        {
            public string WeaponInfo() {return "1. Sword"; }
            public int Attack() { return 100; }
            public int Speed() { return 30; }
            public int Range() { return 1; }
        }

        public class Fire : IWeapon
        {
            public string WeaponInfo() { return "2. Gun"; }
            public int Attack() { return 500; }
            public int Speed() { return 50; }
            public int Range() { return 100; }
        }

        public class Booms : IWeapon
        {
            public string WeaponInfo() { return "3. Bomb"; }
            public int Attack() { return 500; }
            public int Speed() { return 10; }
            public int Range() { return 10; }
        }

        public class Player
        {
            public Player()
            {
                EquipedWeapon = new Fist();
                Xp = new List<int>();

            }

                
            public string Height { get; set; }
            public string Hair { get; set; }
            public string Weight { get; set; }
            public string Name { get; set; }
            public IWeapon EquipedWeapon { get; set; }

            public List<int> Xp;
        }

    }
}
