using System;
using System.Collections.Generic;
using System.Linq;

namespace Raiding
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<BaseHero> raid = new List<BaseHero>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                string type = Console.ReadLine();

                try
                {
                    switch (type)
                    {
                        case "Druid":
                            raid.Add(new Druid(name));
                            break;
                        case "Paladin":
                            raid.Add(new Paladin(name));
                            break;
                        case "Rogue":
                            raid.Add(new Rogue(name));
                            break;
                        case "Warrior":
                            raid.Add(new Warrior(name));
                            break;
                        default:
                            throw new Exception("Invalid hero!");
                            break;
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }

            int bossPower = int.Parse(Console.ReadLine());
            int totalPower = 0;
            raid.ForEach(x => { Console.WriteLine(x.CastAbility()); totalPower += x.Power; });

            if (totalPower >= bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }

        }
    }
}
