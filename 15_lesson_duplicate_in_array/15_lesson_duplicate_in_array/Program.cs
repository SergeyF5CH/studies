using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите кол-во чисел в массиве: ");
        int x = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[x];

        for(int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine($"Введите число {i+1}");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        for(int i = 0;  i < arr.Length; i++)
        {
            for(int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] > arr[j])
                {
                    int tmp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = tmp;
                }
            }
        }

        //Console.WriteLine("Число для удаления: ");
        //int val = Convert.ToInt32(Console.ReadLine());
        int k = RemoveElem(arr);

        
        for(int i = 0; i < k; i++)
        {
            Console.Write(arr[i] + " ");
        }

    }

    static int RemoveElem(int[] arr)
    {
        int k = 1;

        for(int i = 0; i < arr.Length; i++)
        {
            if(arr[i] != arr[k-1])
            {
                arr[k] = arr[i];
                k++;
            }
        }
        return k;
    }
}