using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskForUnity.Abstruct;

namespace TaskForUnity
{
    public class SwordSkill : ISkill
    {
        public string Name { get; }
        public int Damage { get; }
        public int RadiusDamage { get; }
        public int MultiplyingDamage {get;}

        public SwordSkill(string name, int damage, int radiusDamage, int multiplyingDamage)
        {
            Name= name;
            Damage= damage;
            RadiusDamage= radiusDamage;
            MultiplyingDamage= multiplyingDamage;
        }

        public int ExploitSkill()
        {
            int totalDamage = MultiplyingDamage * Damage;
            return totalDamage;
        }
    }
}
