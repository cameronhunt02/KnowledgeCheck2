using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

Console.WriteLine("How many Monsters do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine());
var recordList = new List<Monster>();

for (int i = 0; i < numberOfRecords; i++)
{
    // In this loop, populate the object's properties using Console.ReadLine()
    var monster = new Monster();

    Console.WriteLine("Enter the type of monster ");
    monster.Name = Console.ReadLine();


    recordList.Add(monster);
}
foreach (var record in recordList)
{
    Console.WriteLine($"New monster name: {record.Name}");
}
   
    
    



// Print out the list of records using Console.WriteLine()

class Monster
{
    public int Hp { get; set; }
    public string? Name { get; set; }
}
class Skeleton : Monster
{
    public Skeleton()
    {
        Name = "Skeleton";
    }
}



