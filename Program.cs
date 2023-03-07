using SDC1KnowledgeCheck2;

Console.WriteLine("How many records do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine());

var recordList = new List<Tickets>();
for (int i = 0; i < numberOfRecords; i++)
{

    var Tickets = new Tickets();

    Console.WriteLine("What is the name of the movie you would like to see? ");
    Tickets.Name = Console.ReadLine();

    Console.WriteLine("How many tickets?");
    Tickets.NumberOfTickets = int.Parse(Console.ReadLine());

    Console.WriteLine("Are the tickest for children, adults, or seniors?");
    Tickets.Type = Console.ReadLine();



    recordList.Add(Tickets);
}
foreach (var item in recordList)
{
    Console.WriteLine($"Movie Name: {item.Name} Number of Tickets: {item.NumberOfTickets} Type of Tickets: {item.Type}");
}


