using System;

namespace WizardNinjaSamurai {   
    public class Ninja : Human {
        public Ninja(string n) : base(n) {
            dexterity = 175;
        }

        public void GetAway() {
            health += 10;
        }

        public void Steal(object target){
            Human enemy = target as Human;
            if(enemy != null) {
                Attack(enemy);
                health += 10;
            }
        }
    }
}