using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskForUnity.Abstruct;

namespace TaskForUnity
{
    public class FireSkill : IFireSkill
    {
        public string Name { get; }
        public int Damage { get; }
        public int RadiusDamage { get; }
        public int BurnTIme { get; }
        public ILogger Logger { get; }

        private string _message;

        public FireSkill(string name, int damage, int radiusDamage, int burnTime, ILogger logger)
        {
            Name = name;
            Damage = damage;
            RadiusDamage = radiusDamage;
            BurnTIme = burnTime;
            Logger = logger;
        }

        public int ExploitSkill()
        {
            PrintMessage(_message);
            return Damage;
        }

        public void PrintMessage(string printMessage)
        {
            printMessage = "";
            _message = printMessage;
        }
    }
}
