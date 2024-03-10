Console.WriteLine("Which Month it is? ");
string? month = Console.ReadLine();

switch (month)
{
    case "January":
        Console.WriteLine("Its January yey! Happy New Year");
        break;
        case "February":
        Console.WriteLine("Its February woo-hoo! ");
        break;
        case "March":
        Console.WriteLine("Its March? Npc month tbh");
        break;
        case "April":
        Console.WriteLine(" Your eyes fell off, Aprilili!");
        break;
        case "May":
        Console.WriteLine("First May, Best Day.");
        break;    
        case "June":
        Console.WriteLine("BESTH MONTH EVER.");
        break;
        case "July":
        Console.WriteLine("July! More like ju why? :>");
        break;
        case "August":
        Console.WriteLine("Mehh.,.");
        break;
        case "September":
        Console.WriteLine(":((((");
        break;
        case "October":
        Console.WriteLine("OctoberFest TIME!!!");
        break;
        case "November":
        Console.WriteLine("NNN! Stay Strong King");
        break;
        case "December":
        Console.WriteLine("Winter is coming!");
        break;

        default :
        Console.WriteLine(month + " IS NOT A MONTH!");
        break;
}

// Calculator App
char op;
double first, second, result;

Console.WriteLine("Enter first number: ");
first = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter a second number: ");
second = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter Operator (+, -, *, /): ");
op = (char)Console.Read();

switch (op)
{
    case '+':
    result = first + second;
    Console.WriteLine($"{first} + {second} = {result}");
    break;
    case '-':
    result = first - second;
    Console.WriteLine($"{first} - {second} = {result}");
    break;
    case '*':
    result = first * second;
    Console.WriteLine($"{first} * {second} = {result}");
    break;
    case '/':
    result = first / second;
    Console.WriteLine($"{first} / {second} = {result}");
    break;
    default:
    Console.WriteLine($"{op} is not a valid operator! Please enter valid operator");
    break;
}