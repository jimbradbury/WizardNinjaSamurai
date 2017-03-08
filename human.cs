using System;

namespace WizardNinjaSamurai
{
    public class Human
    {
       public string name = "";
       public int strength = 3;             // default: 3
       public int intelligence = 3;        // default: 3
       public int dexterity = 3;           // default: 3
       public int health = 100;            // default: 100


       //constructor - one arg.
       public Human(string in_name)
       {
            name = in_name;
       }

        //constructor - five args.
       public Human(string in_name, int in_strenght, int in_intelligence, int in_dexterity, int in_health)
       {
            name = in_name;
            strength = in_strenght;
            intelligence = in_intelligence;
            dexterity = in_dexterity;
            health = in_health;
       }

       //method to change name
       public void SetName(string newName)
       {
            name = newName;
       }


       //method to change name
       public void Attack(object in_enemy)
       {

           // Now add a new method called attack, which when invoked, should attack another Human object that is passed as a parameter. 
           // The damage done should be 5 * strength (5 points of damage to the attacked, for each 1 point of strength of the attacker).
            Human enemy = in_enemy as Human;
            if(enemy == null)
            {
                Console.WriteLine("Failed Attack");
            }
            else
            {
                Console.WriteLine("{0} ZAAAAPPPPED!!!", enemy.name);
                enemy.health -= strength *5;
            }

       }

    }
}
