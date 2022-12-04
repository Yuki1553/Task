Console.Clear();
Console.WriteLine("Enter first numbers: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second numbers: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Clear();

if (a < b)
 Console.WriteLine ($"{a} < {b}");
else if (a > b)
 Console.WriteLine ($"{b} > {a}");
else if (a == b)
 Console.WriteLine ($"{b} = {a}");

