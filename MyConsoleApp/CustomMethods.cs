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

    public static int[] GetArray()
    {
        int size = CustomMethods.GetInt("Enter the size of your Array : ");
        int[] input = new int[size];
        for (int i = 0; i < size; i++)
        {
            input[i] = CustomMethods.GetInt("Enter yor number : ");
        }
        return input;
    }

    public static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
    }



}