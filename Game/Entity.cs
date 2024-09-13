using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public class Entity
    {
        private int hp 
        {
            get
            {
                return hp;
            }
            set
            {
                if(value > hpMax)
                {
                    hp = hpMax;
                    return;
                }
                hp = value;
            }
        }
        private int damage;
        private int hpMax;
        public int Damage => damage;
        public int HP => hp;
        public Entity(int _hp = 1, int _damage = 1)
        {
            hp = _hp;
            hpMax = _hp;
            damage = _damage;
        }
        public void TakeDamage(int _damage)
        {
            hp -= _damage;
        }
    }
}
