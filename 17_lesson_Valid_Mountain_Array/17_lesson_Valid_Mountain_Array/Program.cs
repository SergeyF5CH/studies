class Program
{
    static void Main()
    {
        Console.WriteLine("Введите кол-во чисел в массиве: ");
        int x = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[x];

        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine($"Введите число {i + 1}");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        
        bool isValidMountain = ValidMountainArray(arr);

        
        if (isValidMountain)
        {
            Console.WriteLine("Массив является горным.");
        }
        else
        {
            Console.WriteLine("Массив не является горным.");
        }

    }

    static bool ValidMountainArray(int[] arr)
    {
        int n = arr.Length;
        int x = 0;

        if(n <= 3)
        {
            return false;
        }

        while (x < n - 1 && arr[x] < arr[x + 1])
        {
            x++;
        }

        if (x == 0 ||  x == n - 1)
        {
            return false;
        }

        while (x < n - 1 && arr[x] > arr[x + 1])
        {
            x++;
        }
        return x == n - 1; 

    }
    
}