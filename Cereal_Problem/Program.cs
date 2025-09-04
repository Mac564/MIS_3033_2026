using Cereal_Problem;
using System.Security;

//Cereal c = new Cereal();
//c.Manufacturer = "General Mills";
//c.Name = Console.ReadLine();
//c.Cups = 5;
//c.Calories = 28.2;

//Cereal c1 = new Cereal();
//c.Manufacturer = "General Mills";
//c.Name = Console.ReadLine();
//c.Cups = 5;
//c.Calories = 28.2;

//string fileContents = File.ReadAllText("Cereal_Data.txt");

List <Cereal> allCereals = new List<Cereal>();
string[] linesOfFile = File.ReadAllLines("Cereal_Data.txt");

for (int i = 1; i < linesOfFile.Length; i++)
{
 
    //"name | manufacturer | calories | cups"
    string line = linesOfFile[i];
    String[] parts = line.Split("|");
    Cereal c = new Cereal();
    c.Name = parts[0].Trim();
    c.Manufacturer = parts[1].Trim();
    c.Calories = Convert.ToDouble(parts[2].Trim());
    c.Cups = Convert.ToDouble(parts[3].Trim());
    allCereals.Add(c);
}

foreach (var cereal in allCereals)
{
    if (cereal.Cups >= 1)
    {
        Console.WriteLine(cereal);
    }
}
        
