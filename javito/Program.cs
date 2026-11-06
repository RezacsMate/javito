namespace javito
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Friend!");

            List<Airplane> airplanes = new List<Airplane>()
{
    new Airplane("Boeing", "737 MAX 8","Ryanair"){ Rating = 8.5 },
    new Airplane("Boeing", "787-9",  "Lufthansa"){Rating = 9.3 },
    new Airplane("Boeing", "777-300ER",  "Emirates"){Rating = 9.1 },

    new Airplane("Airbus", "A320",  "Wizz Air"){Rating = 8.4 },
    new Airplane("Airbus", "A320neo",  "Lufthansa"){Rating = 8.8 },
    new Airplane("Airbus", "A380-800",  "Emirates"){Rating = 9.6 },

    new Airplane("Embraer", "E195-E2",  "KLM"){Rating = 8.9 },
    
    new Airplane("Bombardier", "CRJ900",  "Lufthansa"){Rating = 8.1 },

    new Airplane("ATR", "ATR 42-600",  "Air France"){Rating = 7.7 },

    new Airplane("COMAC", "ARJ21",  "China Eastern"){Rating = 7.5 }
};
            airplanes[0].SetPrice(121);
            airplanes[1].SetPrice(292);
            airplanes[2].SetPrice(375);
            airplanes[3].SetPrice(101);
            airplanes[4].SetPrice(110);
            airplanes[5].SetPrice(445);
            airplanes[6].SetPrice(65);
            airplanes[7].SetPrice(48);
            airplanes[8].SetPrice(20);
            airplanes[9].SetPrice(38);
            airplanes[0].SetCapacity(178);
            airplanes[1].SetCapacity(290);
            airplanes[2].SetCapacity(396);
            airplanes[3].SetCapacity(180);
            airplanes[4].SetCapacity(186);
            airplanes[5].SetCapacity(615);
            airplanes[6].SetCapacity(146);
            airplanes[7].SetCapacity(90);
            airplanes[8].SetCapacity(50);
            airplanes[9].SetCapacity(90);
            airplanes[0].SetRange(6570);
            airplanes[1].SetRange(14010);
            airplanes[2].SetRange(13649);
            airplanes[3].SetRange(6150);
            airplanes[4].SetRange(6300);
            airplanes[5].SetRange(15200);
            airplanes[6].SetRange(4815);
            airplanes[7].SetRange(2956);
            airplanes[8].SetRange(1326);
            airplanes[9].SetRange(3700);


            Console.WriteLine("--------------");
            Console.WriteLine(airplanes.Where(x => x.Manufacturer == "Boeing").Count());
            Console.WriteLine("--------------");
            Console.WriteLine(airplanes.Where(x=>x.GetPrice()>100).Sum(x=>x.GetPrice()));
            Console.WriteLine("--------------");
            Console.WriteLine(airplanes.Where(x=>x.Manufacturer == "Airbus" && x.Rating > 8.5).Average(x=>x.GetCapacity()));
            Console.WriteLine("--------------");
            Console.WriteLine(airplanes.Where(x => x.GetRange() > 10000).OrderByDescending(x => x.GetPrice()).First().Model.ToString());
            Console.WriteLine("--------------");
            airplanes.Where(x => x.Rating >= 8.5).Select(x => x.Manufacturer).Distinct().ToList().ForEach(x=> Console.WriteLine(x));
            Console.WriteLine("--------------");
            // 6. feladat
            // LINQ segítségével add vissza gyártónként, hogy hány legalább 150 fős utaskapacitású repülőgép tartozik az adott gyártóhoz!
            Dictionary<string, int> manufacturerCapacityCount = airplanes.Where(x => x.GetCapacity() >= 150).GroupBy(x => x.Manufacturer).ToDictionary(g => g.Key, g => g.Count());
            foreach (var x in manufacturerCapacityCount)
            {
                Console.WriteLine($"{x.Key}: {x.Value}");
            }
            Console.WriteLine("--------------");
            Dictionary<string, int> feledat7 = airplanes.Where(x => x.GetPrice() >= 100).GroupBy(x => x.Manufacturer).ToDictionary(g => g.Key, g => g.Sum(x=>x.GetPrice()));
            foreach (var x in feledat7)
            {
                Console.WriteLine($"{x.Key}: {x.Value}");
            }
            Console.WriteLine("--------------");
            Dictionary<string, double> feledat8 = airplanes.Where(x => x.GetPrice() >= 100).GroupBy(x => x.Manufacturer).ToDictionary(g => g.Key, g => g.Average(x=>x.GetPrice()));
            foreach (var x in feledat8)
            {
                Console.WriteLine($"{x.Key}: {x.Value}");
            }
            Console.WriteLine("--------------");
            Dictionary<string, string> feledat9 = airplanes.OrderByDescending(x => x.Rating).Where(x => x.GetCapacity() >= 150).GroupBy(x => x.Manufacturer).ToDictionary(g => g.Key, g => g.First().Model.ToString());
            foreach (var x in feledat9)
            {
                Console.WriteLine($"{x.Key}: {x.Value}");
            }
            Console.WriteLine("--------------");
            Dictionary<string, string> feledat10 = airplanes.OrderByDescending(x => x.GetPrice()).Where(x => x.GetPrice() >= 100).GroupBy(x => x.Manufacturer).ToDictionary(g => g.Key, g => g.First().Model.ToString());
            foreach (var x in feledat10)
            {
                Console.WriteLine($"{x.Key}: {x.Value}");
            }
            Console.WriteLine("--------------");
            Dictionary<string, double> feledat11 = airplanes.Where(x => x.Rating >= 8.5).GroupBy(x => x.Manufacturer).ToDictionary(g => g.Key, g => g.Average(x => x.GetPrice()));
            foreach (var x in feledat11)
            {
                Console.WriteLine($"{x.Key}: {x.Value}");
            }
            Console.WriteLine("--------------");
            Dictionary<string, double> feledat12 = airplanes.Where(x => x.GetCapacity() >= 150).GroupBy(x => x.Manufacturer).ToDictionary(g => g.Key, g => g.Average(x => x.GetCapacity()));
            foreach (var x in feledat12)
            {
                Console.WriteLine($"{x.Key}: {x.Value}");
            }
            
            
            Console.WriteLine("--------------");
            Console.WriteLine("--------------");
            Console.WriteLine("--------------");

        }
    }
}
