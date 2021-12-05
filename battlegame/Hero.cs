using System;
using System.Collections.Generic;
using System.Text;

namespace battlegame
{
    public class Hero
    {
        public string Name { get; private set; }
        public int Life { get; set; }
        public Hero(string Name)
        {
            this.Name = Name;
            this.Life = 10;
        }
        public void Attack(Hero _enemy)
        {
         
            Random r = new Random();
            int damage = r.Next(0, 4);
            switch (damage)
            {
                case 0:
                    Console.WriteLine($"{this.Name} attack {_enemy.Name} but {_enemy.Name} avoided");
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{this.Name} received critical damage!");
                    Console.ResetColor();
                    break;
                default:
                    Console.WriteLine($"{this.Name} attacks {_enemy.Name} with {damage} damage.");
                    break;
            }

            _enemy.Life = _enemy.Life - damage;
            Console.WriteLine($"{_enemy.Name} Life: " + _enemy.Life);
        }
    }
}
