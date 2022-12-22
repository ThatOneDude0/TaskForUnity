using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskForUnity.Abstruct;

namespace TaskForUnity
{
    public abstract class Hero : IHero
    {
        public string Name { get; }

        private readonly IList<ISkill> _skills;

        protected Hero(string name, IList<ISkill> skills)
        {
            Name = name;
            _skills = skills;
        }

        public void Attack(IHero hero)
        {
            int damage = _skills.Sum(skills => skills.ExploitSkill());
            hero.TakeDamage(damage, hero);
        }

        public void TakeDamage(int damage, IHero hero)
        {
            throw new NotImplementedException();
        }
    }
}
