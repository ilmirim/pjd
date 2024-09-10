using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Entity
    {
        private int hp;
        private int damage;
        public int Damage => damage;
        public int HP => hp;
        public Entity(int _hp = 1, int _damage = 1)
        {
            hp = _hp;
            damage = _damage;
        }
        public void TakeDamage(int _damage)
        {
            hp -= _damage;
        }
    }
}
