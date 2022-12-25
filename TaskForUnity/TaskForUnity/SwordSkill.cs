using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskForUnity.Abstruct;

namespace TaskForUnity
{
    public class SwordSkill : ISwordSkill
    {
        public string Name { get; }
        public int Damage { get; }
        public int RadiusDamage { get; }
        public int MultiplyingDamage {get;}
        public ILogger Logger { get; }

        private string _message;

        public SwordSkill(string name, int damage, int radiusDamage, int multiplyingDamage, ILogger logger)
        {
            Name = name;
            Damage = damage;
            RadiusDamage = radiusDamage;
            MultiplyingDamage = multiplyingDamage;
            Logger = logger;
        }

        public int ExploitSkill()
        {
            int totalDamage = MultiplyingDamage * Damage;
            PrintMessage(_message);
            return totalDamage;
        }

        public void PrintMessage(string printMessage)
        {
            printMessage = "";
            _message = printMessage;
        }
    }
}
