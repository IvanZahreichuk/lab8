using Lab08;

var loopBreak = true;
while (loopBreak)
{
    Console.WriteLine("Select the problem(1-10) or exit(0):");

    switch (int.Parse(Console.ReadLine()))
    {
        case 1:
            Problem1_2();
            break;
        case 2:
            Problem1_2();
            break;
        case 3:
            Problem3_4();
            break;
        case 4:
            Problem3_4();
            break;
        case 5:
            Problem5_6();
            break;
        case 6:
            Problem5_6();
            break;
        case 7:
            Problem7_8_9();
            break;
        case 8:
            Problem7_8_9();
            break;
        case 9:
            Problem7_8_9();
            break;
        case 10:
            Problem10();
            break;
        default:
            Console.WriteLine("Exiting the Lab 8...");
            loopBreak = false;
            break;
    }

    if (!loopBreak) break;
}

// Problem 1 & 2
void Problem1_2()
{
    Console.WriteLine("Problem 1 & 2");
    Console.WriteLine("1 - string; 2 - int");
    var flag = int.Parse(Console.ReadLine());
    if (flag == 1)
    {
        Console.WriteLine("Count of boxes(string):");

        var count = int.Parse(Console.ReadLine());
        for (int i = 0; i < count; i++)
        {
            var element = new Box<string>(Console.ReadLine());
            Console.WriteLine(element);
        }
    }
    else
    {
        Console.WriteLine("Count of boxes(int):");

        var count = int.Parse(Console.ReadLine());
        for (int i = 0; i < count; i++)
        {
            var element = new Box<int>(int.Parse(Console.ReadLine()));
            Console.WriteLine(element);
        }
    }
}

// Problem 3 & 4
void Problem3_4()
{
    Console.WriteLine("Problem 3 & 4");
    Console.WriteLine("1 - string; 2 - int");
    var flag = int.Parse(Console.ReadLine());
    if (flag == 1)
    {
        var myList = new BoxProblem3_4<string>();
        Console.WriteLine("Input count: ");
        var count = int.Parse(Console.ReadLine());
        for (int i = 0; i < count; i++)
        {
            var input = Console.ReadLine();
            myList.Add(input);
        }

        Console.WriteLine("Input indexes: ");
        var indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
        myList.Swap(indexes[0], indexes[1]);

        Console.WriteLine(myList);
    }
    else
    {
        var myList = new BoxProblem3_4<int>();
        Console.WriteLine("Input count: ");
        var count = int.Parse(Console.ReadLine());
        for (int i = 0; i < count; i++)
        {
            var input = Console.ReadLine();
            myList.Add(int.Parse(input));
        }

        Console.WriteLine("Input indexes: ");
        var indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
        myList.Swap(indexes[0], indexes[1]);

        Console.WriteLine(myList);
    }
}

// Problem 5 & 6
void Problem5_6()
{
    Console.WriteLine("Problem 5 & 6");

    Console.WriteLine("Problem 5 & 6");
    Console.WriteLine("1 - string; 2 - double");
    var flag = int.Parse(Console.ReadLine());
    if (flag == 1)
    {
        Console.WriteLine("Input counter: ");
        var myData = new BoxProblem5_6<string>();
        var counter = int.Parse(Console.ReadLine());
        for (int i = 0; i < counter; i++)
        {
            myData.Add(Console.ReadLine());
        }

        Console.WriteLine(myData.Compare(myData.Data, Console.ReadLine()));
    }
    else
    {
        Console.WriteLine("Input counter: ");
        var myData = new BoxProblem5_6<double>();
        var counter = int.Parse(Console.ReadLine());
        for (int i = 0; i < counter; i++)
        {
            myData.Add(double.Parse(Console.ReadLine()));
        }

        Console.WriteLine(myData.Compare(myData.Data, double.Parse(Console.ReadLine())));
    }
}

// Problem 7 & 8 & 9
void Problem7_8_9()
{
    Console.WriteLine("Problem 7 & 8 & 9");

    ICustomList<string> myList = new CustomList<string>();

    var command = Console.ReadLine();
    while (!command.Equals("END"))
    {
        Execute(command, myList);
        command = Console.ReadLine();
    }
}

void Execute(string command, ICustomList<string> myList)
{
    var commandArgs = command.Split();
    switch (commandArgs[0])
    {
        case "Add":
            myList.Add(commandArgs[1]);
            break;
        case "Remove":
            myList.Remove(int.Parse(commandArgs[1]));
            break;
        case "Contains":
            Console.WriteLine(myList.Contains(commandArgs[1]));
            break;
        case "Swap":
            myList.Swap(int.Parse(commandArgs[1]), int.Parse(commandArgs[2]));
            break;
        case "Greater":
            Console.WriteLine(myList.CountGreaterThan(commandArgs[1]));
            break;
        case "Min":
            Console.WriteLine(myList.Min());
            break;
        case "Max":
            Console.WriteLine(myList.Max());
            break;
        case "Print":
            Console.WriteLine(string.Join(Environment.NewLine, myList));
            break;
        case "Sort":
            myList.Sort();
            break;
        default:
            break;
    }
}

// Problem 10
void Problem10()
{
    Console.WriteLine("Problem 10");

    var input = Console.ReadLine().Split();
    var name = $"{input[0]} {input[1]}";
    var address = input[2];

    Console.WriteLine(new TupleProblem10<string, string>(name, address));

    input = Console.ReadLine().Split();
    name = input[0];
    var litersOfBeer = int.Parse(input[1]);

    Console.WriteLine(new TupleProblem10<string, int>(name, litersOfBeer));

    input = Console.ReadLine().Split();
    var integer = int.Parse(input[0]);
    var doubleValue = double.Parse(input[1]);

    Console.WriteLine(new TupleProblem10<int, double>(integer, doubleValue));
}