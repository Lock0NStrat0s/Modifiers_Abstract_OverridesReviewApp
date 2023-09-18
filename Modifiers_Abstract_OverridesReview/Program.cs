namespace Modifiers_Abstract_OverridesReview;

class Program
{
    static void Main(string[] args)
    {
        List<Monster> monsters = new List<Monster>();
        monsters.Add(new Charmander { Name = "Charmander", Type = "Fire", Power = 4, MoveList = { "Ember", "Fire Blast" } });
        monsters.Add(new Bulbasaur { Name = "Bulbasaur", Type = "Grass", Power = 2, MoveList = { "Vine Whip", "Solar Beam"} });
        monsters.Add(new Squirtle { Name = "Squirtle", Type = "Water", Power = 3, MoveList = { "Water Gun", "Hydro Pump" } });

        foreach (Monster monster in monsters)
        {
            Console.WriteLine(monster.ToString());
        }

        Console.ReadLine();
    }
}

public interface IStats
{
    string Name { get; set; }
    string Type { get; set; }
    int Power { get; set; }
}

public abstract class Monster : IStats
{
    public string Name { get; set; }
    public string Type { get; set; }
    public int Power { get; set; }
    public abstract List<string> MoveList { get; set; }
    public override string ToString()
    {
        return $"Name is {Name}.\tType is {Type}.\tPower level: {Power}.\tIt's moveset: {MoveList}";
    }
}

public class Charmander : Monster
{
    public override List<string> MoveList { get; set; } = new List<string>(2);
}

public class Bulbasaur : Monster
{
    public override List<string> MoveList { get; set; } = new List<string>(2);
}

public class Squirtle : Monster
{
    public override List<string> MoveList { get; set; } = new List<string>(2);
}