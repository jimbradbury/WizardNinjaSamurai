using System;

namespace WizardNinjaSamurai {   
    public class Samurai : Human {
        public Samurai(string n) : base(n) {
            health = 200;
        }

        public void Meditate() {
            health = 200;
        }

        public void DeathBlow(object target){
            Human enemy = target as Human;
            if(enemy != null) {
                if(enemy.health < 50)
                {
                    enemy.health = 0;
                }
            }
        }
    }
}