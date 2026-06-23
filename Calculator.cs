class Calculator
{
    public static void RunCalc()
    {
        int num1 = CustomMethods.GetInt("Enter first number: ");
        int num2 = CustomMethods.GetInt("Enter Second number: ");


        char op = CustomMethods.GetOperator();

        if (op == '/' && num2 == 0)
        {
            Console.WriteLine("Cannot divide by zero.");
            return;
        }

        double result = op switch
        {
            '+' => num1 + num2,
            '-' => num1 - num2,
            '*' => num1 * num2,
            '/' => (double)num1 / num2,
            _ => 0
        };

        Console.WriteLine($"Result: {num1} {op} {num2} = {result}");
    }

    public static int ReadInt(string message)
    {
        while (true)
        {
            Console.Write(message);
            string? input = Console.ReadLine();

            if (int.TryParse(input, out int value))
            {
                return value;
            }
            Console.WriteLine("Invalid number");
        }
    }

    static char ReadOperator()
    {
        while (true)
        {
            Console.Write("Enter operator (+, -, *,/):");
            String? input = Console.ReadLine();

            if (input is "+" or "-" or "*" or "/")
            {
                return input[0];
            }
            Console.WriteLine("Please enter a valid operator.");
        }
    }


}