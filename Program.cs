//Разработать приложение, в котором бы сравнивалось 
//население трёх столиц из разных стран. Причём страна бы обозначалась пространством имён, а город — 
//классом в данном пространстве

using ConsoleTown;
using Greece;
using Russia;
using Turkey;

class Program
{
    static void Main()
    {
        List <Capital> capitals = new List<Capital>();
        
        Russia.Moscow moscow = new Moscow();
        capitals.Add(moscow);
        Turkey.Ankara ankara = new Ankara();
        capitals.Add(ankara);
        Greece.Athens athens = new Athens();
        capitals.Add(athens);

        Capital cMaxPopulation=capitals.MaxBy(c=>c.Population );
        Console.WriteLine("Наибольшее население в столице " + cMaxPopulation.Country+" "+cMaxPopulation.Name+" "
                          +cMaxPopulation.Population);
      
        Capital cMinPopulation=capitals.MinBy(c=>c.Population );
        Console.WriteLine("Наименьшее население в столице " + cMinPopulation.Country+" "+cMinPopulation.Name+" "
                          +cMinPopulation.Population);

    }

}