class Araays
{
    public static void PrintAllElements()
    {
        int[] studentMarks = CustomMethods.GetArray();
        // for (int i = 0; i < studentMarks.Length; i++)
        // {
        //     Console.WriteLine($"The student marks are :{studentMarks[i]}");
        // }
        foreach (int marks in studentMarks)
        {
            Console.WriteLine(marks);
        }
    }

    public static void SumOfArray()
    {

        int[] num = CustomMethods.GetArray();
        int sum = 0;
        foreach (int numbers in num)
        {
            sum += numbers;
        }
        Console.WriteLine($"The sum of your array is  : {sum}");
    }

    public static void LargestInArray()
    {
        int[] num = CustomMethods.GetArray();
        int largest = 0;
        foreach (int number in num)
        {
            if (number > largest)
            {
                largest = number;
            }
        }
        Console.WriteLine($"The largest number in an ARRAY is : {largest}");
    }

    public static void SmallestInArray()
    {
        int[] num = CustomMethods.GetArray();
        int smallest = num[0];
        foreach (int number in num)
        {
            if (number < smallest)
            {
                smallest = number;
            }
        }
        Console.WriteLine($"The Smallest number in an ARRAY is : {smallest}");
    }

    public static void NumberExistInArray()
    {
        int num = CustomMethods.GetInt("Enter the number to find in an ARRYA : ");
        int[] ary = CustomMethods.GetArray();
        foreach (int i in ary)
        {
            if (i == num)
            {
                Console.Write($"Number {num}  EXIST in an ARRAY");
                return;
            }
        }
        Console.Write($"Number {num} dosen't EXIST in an ARRAY");
    }
    public static void FindIndex()
    {
        int num = CustomMethods.GetInt("Enter the number to find there INDEX in an ARRYA : ");
        int[] ary = CustomMethods.GetArray();
        int index = -1;
        foreach (int i in ary)
        {
            index += 1;
            if (i == num)
            {
                Console.Write($"The index of your array is : {index}");
                return;
            }
        }
        Console.Write($"Number {num} dosen't EXIST in an ARRAY");
    }

    public static void ReverseAnArray()
    {
        int[] arr = CustomMethods.GetArray();

        //Version 1:
        // int size = arr.Length;
        // int[] reverse = new int[size];
        // foreach (int num in arr)
        // {
        //     size -= 1;
        //     reverse[size] = num;
        // }
        // Console.WriteLine($"Your Reversed array is :");
        // foreach (int i in reverse)
        // {
        //     Console.Write(i + " ");
        // }

        //Using Inbuid Methods
        CustomMethods.PrintArray(arr);
        Console.Write("/ ");
        Array.Reverse(arr);
        CustomMethods.PrintArray(arr);
    }
    //Linear Search Alogorithm
    public static void SecondLargestInArray()
    {
        int[] arr = CustomMethods.GetArray();

        //Method 1:
        //Array.Sort(arr);
        //Console.Write($"The Second largest number in a array is {arr[^2]}");
        // In C#, ^2 is a from-the-end index:
        // ^1 → last element
        // ^2 → second last element

        //Method 2:
        int largest = int.MinValue;
        int secondLargest = int.MinValue;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > largest)
            {
                largest = arr[i];
                secondLargest = largest;
            }
            else if (arr[i] > secondLargest)
            {
                secondLargest = arr[i];
            }
        }
        Console.Write($"The Second largest number in a array is {secondLargest}");
    }

    public static void BubbleSort()
    {
        int[] arr = CustomMethods.GetArray();
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = 0; j < arr.Length - 1 - i; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
        Console.WriteLine("Your Sorted Array is:");
        CustomMethods.PrintArray(arr);


    }


}