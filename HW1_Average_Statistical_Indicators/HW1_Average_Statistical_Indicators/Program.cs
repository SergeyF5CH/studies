using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите кол-во чисел: ");
        int count_val = Convert.ToInt32(Console.ReadLine());
        float[] set_num = new float[count_val];

        for (int i = 0; i < count_val; i++)
        {
            Console.WriteLine($"Введите число {i+1}");
            set_num[i] = Convert.ToSingle(Console.ReadLine().Replace('.', ','));
        }

        Console.WriteLine("\nВведены числа: ");
        foreach (float i in set_num)
        {
            Console.Write($"{i} ");
        }


        float s2 = Dispersion(set_num);

        Console.WriteLine($"\n \nДисперсия: {s2}");
        Console.WriteLine($"\nСреднеквадратическое отклонение: {MeanSquare(s2)}");
        Console.WriteLine($"\nМедиана: {Mediana(set_num)}");
        Console.WriteLine($"\nМода: {Mode(set_num)}");





    }

    static float Dispersion(float[] set_num)
    {
        float x = 0;
        float n = set_num.Length;
        foreach (float i in set_num)
        {
            x += i;            
        }

        float mean = x / n;
        
        float S = 0;
        foreach (float i in set_num)
        {
            S += (i - mean) * (i - mean);
        }         

        return S / (n - 1);
        
    }

    static float MeanSquare(float S)
    {
        float _meanSqare = Convert.ToSingle(Math.Sqrt(S));
        return _meanSqare;
    }

    static float Mediana(float[] set_num)
    {
        float mean = 0;
        int index = 0;
        int _lengthArr = set_num.Length;

        for (int i = 0; i < set_num.Length; i++)
        {
            for (int j = i + 1; j < set_num.Length; j++)
            {
                if (set_num[i] > set_num[j])
                {
                    float tmp = set_num[i];
                    set_num[i] = set_num[j];
                    set_num[j] = tmp;
                }
            }

        }

        if (_lengthArr % 2 == 0)
        {
            index = _lengthArr / 2;
            mean = (set_num[index] + set_num[index-1]) / 2;

        }
        else 
        {
            index = _lengthArr / 2;
            mean = set_num[index];

        }

        return mean;
    }

    static float Mode(float[] set_num)
    {
        for (int i = 0; i < set_num.Length; i++)
        {
            for (int j = i + 1; j < set_num.Length; j++)
            {
                if (set_num[i] > set_num[j])
                {
                    float tmp = set_num[i];
                    set_num[i] = set_num[j];
                    set_num[j] = tmp;
                }
            }

        }
        Dictionary<float, int> modeCounter = new Dictionary<float, int>();
                        
        for (int i = 0; i < set_num.Length; i++)
        {

            if (modeCounter.ContainsKey(set_num[i]))
            {
                int count = modeCounter[set_num[i]] + 1;
                modeCounter[set_num[i]] = count;

            }
            else
            {
                int count = 1;
                modeCounter.Add(set_num[i], count);
            }
            
        }

        int max_Value = 0;
        float _mode = 0;
        
        foreach(int i in modeCounter.Keys)
        {
            if (modeCounter[i] > max_Value)
            {
                max_Value = modeCounter[i];
                _mode = i;
            }
        }
                
        return _mode;
    }


}


//int _count = 0;
//
//{
//    if (set_num[i] == set_num[j])
//    {
//        _count++;

//    }
//}
//modeCounter.Add(i, _count);