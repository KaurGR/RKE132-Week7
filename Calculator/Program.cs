Console.WriteLine("Enter the operation (+/-):"); 
char userOperator = Char.Parse(Console.ReadLine());
Console.WriteLine("Enter first number:");
int num1 = Int32.Parse(Console.ReadLine()); 
Console.WriteLine("Enter second number:");
int num2 = Int32.Parse(Console.ReadLine());

switch (userOperator)
{
    case '+':
        Addition(num1, num2);
        break;
    case '-':
        Subtraction(num1, num2);
        break;
    default:
        Console.WriteLine("invalid operator");
        break;
}    

static void Addition(int a, int b)
{
    Console.WriteLine($"{a} + {b} = {a + b}");
}
static void Subtraction(int a, int b)
{
    Console.WriteLine($"{a} - {b} = {a - b}");
}