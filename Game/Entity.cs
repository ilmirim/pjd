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
        private int hp;
        private int damage;
        private int hpMax;
        public enum EntityType
        { 
            player, enemy
        }
        private EntityType type;
        public EntityType Type => type;
        public int Damage => damage;
        public int HP => hp;
        public Entity(EntityType _type = EntityType.enemy, int _hp = 1, int _damage = 1)
        {
            hp = _hp;
            hpMax = _hp;
            damage = _damage;
            type = _type;
        }
        public void TakeDamage(int _damage)
        {
            hp -= _damage;
        }
    }
}
