using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskForUnity.Abstruct;

namespace TaskForUnity
{
    public class FreezeSkill : ISkill
    {
        public string Name { get; }
        public int Damage { get; }
        public int RadiusDamage { get; }
        public int RechargeTime { get; }
        public FrostColor IceColor { get; }

        public FreezeSkill(string name, int damage, int radiusDamage, int rechargeTime, FrostColor iceColor)
        {
            Name= name;
            Damage= damage;
            RadiusDamage= radiusDamage;
            RechargeTime= rechargeTime;
            IceColor= iceColor;
        }

        public int ExploitSkill()
        {
            return Damage;
        }

        public enum FrostColor
        {
            Blue,
            Green,
            red,
        }
    }
}
