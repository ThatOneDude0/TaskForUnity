using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskForUnity.Abstruct;

namespace TaskForUnity
{
    public class FireSkill : ISkill
    {
        public string Name { get; }
        public int Damage { get; }
        public int RadiusDamage { get; }
        public int BurnTIme { get; }

        public FireSkill(string name, int damage, int radiusDamage, int burnTime)
        {
            Name = name;
            Damage = damage;
            RadiusDamage = radiusDamage;
            BurnTIme = burnTime;
        }

        public int ExploitSkill()
        {          
            return Damage;
        }
    }
}
