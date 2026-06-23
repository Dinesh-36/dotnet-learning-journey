class Loop
{
    public static void RunNumber()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.Write(i);
        }
        Console.Write(" ");
        for (int i = 10; i >= 1; i--)
        {
            Console.Write(i);
        }
    }
    public static void SumNumbers()
    {
        int n = Calculator.ReadInt("Enter the number: ");
        int sum = 0;
        if (n < 0)
        {
            Console.Write("enter Positive numbers");
            return;
        }
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }
        Console.Write($"sum = {sum}");
    }
    public static void MultiplicationTable()
    {
        int n = Calculator.ReadInt("Enter the table :");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{i} * {n} = {i * n}");
        }
    }

    public static void Factorial()
    {
        int n = Calculator.ReadInt("Enter the number for Factorial : ");
        int fact = 1;
        for (int i = n; i >= 1; i--)
        {
            fact *= i;
        }
        Console.WriteLine($"The factorial of given number is: {fact}");
    }

    public static void Fibonacci()
    {
        int first = 0;
        int second = 1;
        int n = Calculator.ReadInt("enter the number for Fibonacci : ");
        if (n < 1)
        {
            Console.Write("Enter a valid number");
            return;
        }
        Console.Write($"{first} {second}");

        for (int i = 1; i <= n; i++)
        {
            int result = first + second;
            Console.Write(" " + result);
            first = second;
            second = result;
        }
    }
    public static void PasswordChecker()
    {
        string password = "Db036";
        char userInput;
        do
        {
            string userPassword = CustomMethods.GetString("Enter Your Password : ");
            if (password == userPassword)
            {
                Console.Write("Acess Granted");
                break;
            }
            Console.WriteLine("Worong Password");
            userInput = CustomMethods.GetCharacter("Do you want to continue [Y/N] : ");
        } while (userInput == 'Y' || userInput == 'y');
    }

    public static void DigitCount()
    {
        int num = CustomMethods.GetInt("Enter your Number to Count Digits in it : ");
        String str = num.ToString();
        int len = str.Length;
        Console.Write($"The length of your number is : {len}");
    }
}