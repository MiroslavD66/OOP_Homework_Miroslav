using ArenaGameEngine;

namespace ArenaGameConsole
{

    class ConsoleGameEventListener : GameEventListener
    {
        public override void GameRound(Hero attacker, Hero defender, int attack)
        {
            string message = $"{attacker.Name} attacked {defender.Name} for {attack} points";
            if (defender.IsAlive)
            {
                message = message + $" but {defender.Name} survived.";
            }
            else
            {
                message = message + $" and {defender.Name} died.";
            }
            Console.WriteLine(message);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Hero knight = new Knight("Sir John");
            Hero rogue = new Rogue("Slim Shady");
            Hero archer = new Archer("Varus");
            Hero witch = new Witch("Morgana");
            Hero samurai = new Samurai("Miyamoto Musashi");
            Hero ninja = new Ninja("Hanzo Hattori");

            Arena arena1 = new Arena(knight, rogue);
            arena1.EventListener = new ConsoleGameEventListener();
            Console.WriteLine("Battle between Knight and Rogue begins.");
            Hero winner1 = arena1.Battle();
            Console.WriteLine($"Battle ended. Winner is: {winner1.Name}");

            Console.WriteLine();

            Arena arena2 = new Arena(archer, witch);
            arena2.EventListener = new ConsoleGameEventListener();
            Console.WriteLine("Battle between Archer and Witch begins.");
            Hero winner2 = arena2.Battle();
            Console.WriteLine($"Battle ended. Winner is: {winner2.Name}");

            Console.WriteLine();

            Arena arena3 = new Arena(samurai, ninja);
            arena3.EventListener = new ConsoleGameEventListener();
            Console.WriteLine("Battle between Samurai and Ninja begins.");
            Hero winner3 = arena3.Battle();
            Console.WriteLine($"Battle ended. Winner is: {winner3.Name}");
        }
    }
}
