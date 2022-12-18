Console.WriteLine("Input number A: ");
int numA = int.Parse(Console.ReadLine());

Console.WriteLine("Input number B: ");
int numB = int.Parse(Console.ReadLine());

if (numA > numB)
{
    Console.WriteLine($"First number {numA} is more than second one {numB}" );
}
else 
{
    Console.WriteLine($"Second number {numB} is more than first one {numA}" );
}

