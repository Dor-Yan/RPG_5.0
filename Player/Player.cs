using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RPG
{
    public class Player : WeaponService
    {

        public Player()
        {
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

