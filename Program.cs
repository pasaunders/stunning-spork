using System;

namespace human
{
    public class Human {
        public String name;
        public int strength = 3;
        public int dexterity = 3;
        public int intellegence = 3;
        public int health = 100;

        public Human(String initName){
            name = initName;
        }
        public Human(String initName, int initStrength, int initDexterity, int initIntellegence, int initHealth){
            name = initName;
            strength = initStrength;
            dexterity = initDexterity;
            intellegence = initIntellegence;
            health = initHealth;
        }
        public void Attack(Human victim){
            if (victim is Human)
            {
                victim.health -= 5*strength;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Human bob = new Human("bob");
            Human fred = new Human("fred");
            bob.Attack(fred);
        }
    }
}
