using System;

namespace HeroVsMonster {
    static class Program {
        static void Main(string[] args) {
            Random dice = new Random();

            int heroHealth = 10;
            int monsterHealth = 10;

            do {
                int attackValue = dice.Next(1, 11);
                monsterHealth -= attackValue;
                Console.WriteLine( $"Monster was damaged and lost {10 - monsterHealth } health and now has {monsterHealth} health.");
                if (monsterHealth <= 0) continue;
                attackValue = dice.Next(1, 11);
                heroHealth -= attackValue;
                Console.WriteLine( $"Hero was damaged and lost {10 - heroHealth } health and now has {heroHealth} health.");
            } while (monsterHealth > 0 && heroHealth > 0);

            Console.WriteLine( heroHealth > monsterHealth ? "Hero wins" : "Monster wins" );
        }
    }
}