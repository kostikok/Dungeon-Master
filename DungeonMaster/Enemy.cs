using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonMaster
{
    internal class Enemy
    {
        public string name;
        public int health;
        public int maxHealth;
        public Weapon weapon;
        public int pointsaward;

        public Enemy(string n, int h, int mh, int pa)
        {
            this.name = n;
            this.health = h;
            this.maxHealth = mh;
            this.pointsaward = pa;
        }
    }
}
