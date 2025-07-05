Console.WriteLine("welcome to Islam's Carpet Cleaning Service");

Console.WriteLine("Number of small carpet");
int smallCarpets = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Number of large carpets:");
int largeCarpets = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Price per small room: $25");
Console.WriteLine("Price per large room: $35");
int cost = (smallCarpets * 25) + (largeCarpets * 35);
Console.WriteLine($"Total cost: ${cost}");
Console.WriteLine("Tax: $6.6");
double Tax = cost * 0.06;
Console.WriteLine($"Total estimate : ${cost + Tax}");
Console.WriteLine("This estimate is valid for 30 days");

