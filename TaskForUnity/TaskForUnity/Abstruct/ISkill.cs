using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskForUnity.Abstruct
{
    public interface ISkill
    {
        public string Name { get; }

        public int Damage { get; }

        public int RadiusDamage { get; }

        public int ExploitSkill();
    }
}
