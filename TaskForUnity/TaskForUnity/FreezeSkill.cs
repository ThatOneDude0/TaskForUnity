using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskForUnity.Abstruct;

namespace TaskForUnity
{
    public class FreezeSkill : IFreezeSkill
    {
        public string Name { get; }
        public int Damage { get; }
        public int RadiusDamage { get; }
        public int RechargeTime { get; }
        public ILogger Logger { get; }
        public string Color { get; }

        private string _message;

        public FreezeSkill(string name, int damage, int radiusDamage, int rechargeTime, ILogger logger, string color)
        {
            Name = name;
            Damage = damage;
            RadiusDamage = radiusDamage;
            RechargeTime = rechargeTime;
            Logger = logger;
            Color = color;
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
