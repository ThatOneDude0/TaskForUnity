using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskForUnity.Abstruct
{
    public interface IFreezeSkill : ISkill
    {
        public string Color { get;}
        public int RechargeTime { get;}
    }
}
