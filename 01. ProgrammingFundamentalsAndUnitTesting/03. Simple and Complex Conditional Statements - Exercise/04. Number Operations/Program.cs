var a = double.Parse(Console.ReadLine());
var b = double.Parse(Console.ReadLine());
var @operator = Console.ReadLine();

var output = 0.0;

switch (@operator)
{
    case "+": output = a + b; break;
    case "-": output = a - b; break;
    case "*": output = a * b; break;
    case "/": output = a / b; break;
}

Console.WriteLine($"{a} {@operator} {b} = {output:F2}");