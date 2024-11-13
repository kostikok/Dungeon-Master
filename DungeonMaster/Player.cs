using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonMaster
{
    public class Player
    {
        public string name;
        public int health;
        public int maxHealth;
        public Aid aid;
        public Weapon weapon;
        public int point;
        public Player(string n)
        {
            this.name = n;
            this.health = 100;
            this.maxHealth = 100;
            this.aid = new Aid("Бинт", 5, 1);
            this.weapon = new Weapon("Ржавый кортик", 15);
            this.point = 0;
        }
    }
}
