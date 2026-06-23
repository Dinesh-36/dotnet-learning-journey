using System.Transactions;

class CustomMethods
{
    public static int GetInt(String message)
    {
        while (true)
        {
            Console.Write(message);
            string? input = Console.ReadLine();
            if (int.TryParse(input, out int num))
            {
                return num;
            }
            Console.Write("Enter a valid Number.");
        }


    }
    public static string GetString(string message)
    {
        while (true)
        {
            Console.Write(message);
            string? name = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(name))
            {
                return name;
            }
            Console.Write("Please enter one or more words");
        }
    }
    public static char GetCharacter(string message)
    {
        while (true)
        {
            Console.Write(message);
            string? name = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(name))
            {
                return name[0];
            }
            Console.Write("Please enter one Character");
        }
    }

    public static char GetOperator()
    {
        while (true)
        {
            Console.WriteLine("Enter your Operator +, *, -, / : ");
            string? op = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(op) && (op[0] == '+' || op[0] == '-' || op[0] == '*' || op[0] == '/'))
            {
                return op[0];
            }
            Console.WriteLine("Please Enter valid Operator !");
        }
    }


}