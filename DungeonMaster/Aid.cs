using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonMaster
{
    public class Aid
    {
        public string name;
        public int healthRestore;
        public int value;
        public Aid(string n, int hr, int v)
        {
            name = n;
            healthRestore = hr;
            value = v;
        }
    }
}
