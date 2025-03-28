using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGame
{
    public class Enemy
    {
        private string name;
        private float health;
        private float shield;

        public Enemy(string name)
        {
            SetName(name); 
            health = 100;
            shield = 0;
        }


        public string GetName()
        {
            return name;
        }


        public float GetHealth()
        {
            return health;
        }


        public float GetShield()
        {
            return shield;
        }


        public void SetName(string newName)
        {
            if (newName.Length > 8)
            {
                name = newName.Substring(0, 8);
            }
            else
            {
                name = newName;
            }
        }


        public void TakeDamage(float damage)
        {
            shield -= damage;
            if (shield < 0)
            {
                float damageStillToInflict = -shield;
                shield = 0;
                health -= damageStillToInflict;
                if (health < 0) health = 0;
            }
        }

        public void PickupPowerUp(PowerUp power, float value)
        {
            switch (power)
            {
                case PowerUp.Health:
                    health = Math.Min(health + value, 100);
                    break;
                case PowerUp.Shield:
                    shield = Math.Min(shield + value, 100);
                    break;
            }
        }
    }
}