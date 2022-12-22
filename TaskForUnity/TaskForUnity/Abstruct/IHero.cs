using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskForUnity.Abstruct
{
    public interface IHero
    {
        string Name { get; }

        void Attack(IHero hero);

        void TakeDamage(int damage, IHero hero);
    }
}
