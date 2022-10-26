// See https://aka.ms/new-console-template for more information
using sdc1_knowledge_check_2;

Console.WriteLine("How many records do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine());

var recordList = new List<Cat>();
for (int i = 0; i < numberOfRecords; i++)
{
    var myClass = new Cat();


    Console.WriteLine("Enter the value for name");
    myClass.Name = Console.ReadLine();

    Console.WriteLine("Enter the value for color");
    myClass.Color = Console.ReadLine();


    recordList.Add(myClass);
}
foreach (var item in recordList)
{
    Console.WriteLine($"Cat Name: {item.Name} Cat Color:{item.Color}.");
}