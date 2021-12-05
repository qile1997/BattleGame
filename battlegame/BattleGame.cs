using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace battlegame
{
    public class BattleGame
    {
        public void Execute()
        {
            {
                Random r = new Random();
                Console.WriteLine("Enter hero 1:");
                Hero hero1 = new Hero(Console.ReadLine());
                Console.WriteLine("Enter hero 2:");
                Hero hero2 = new Hero(Console.ReadLine());

                while (hero1.Life > 0 && hero2.Life > 0)
                {
                    int whoAttack = r.Next(0, 2);

                    switch (whoAttack)
                    {
                        case 0:
                            hero1.Attack(hero2);
                            break;
                        case 1:
                            hero2.Attack(hero1);
                            break;
                        default:
                            break;
                    }
                    Thread.Sleep(1000);
                }
                CheckEndGame(hero1, hero2);
            }
        }

        private void CheckEndGame(Hero _hero, Hero _enemy)
        {
            if (_hero.Life > 0 && _enemy.Life == 0)
            {
                Console.WriteLine($"{_hero.Name} won.");
            }
            else
            {
                Console.WriteLine($"{_enemy.Name} won.");
            }
        }
    }
}
