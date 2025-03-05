Console.WriteLine("Podaj pierwszą liczbę: ");
string buffer = Console.ReadLine() ?? "0";
double a = double.Parse(buffer);
Console.WriteLine("Podaj drugą liczbę: ");
buffer = Console.ReadLine() ?? "0";
double b = double.Parse(buffer);
double result = a + b;
Console.WriteLine("Wynik dodawania liczb " + a + " i " + b + " wynosi: " + result);
