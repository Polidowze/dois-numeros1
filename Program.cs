Console.Clear();

int numero1;
int numero2;

Console.WriteLine("Digite um numero");
numero1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite outro numero");
numero2 = Convert.ToInt32(Console.ReadLine());

if(numero1 > numero2)
{
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"O numero {numero1} é o maior");

}

else
{
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"O numero {numero2} é o maior");

}
Console.ResetColor();