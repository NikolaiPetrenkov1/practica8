using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RangeArray
{
    
    int[] b; 
    int minIndex; 
    int maxIndex; 
    public int Length { get; private set; }
  
    public bool Error { get; private set; }
    
    public RangeArray(int low, int high)
    {
        high++;

        if (high <= low)
        {
            Console.WriteLine("Неверные индексы");
            high = 1; 
            low = 0;
        }
        b = new int[high - low];
        Length = high - low;
        minIndex = low;
        maxIndex = --high;
    }
    
    public int this[int index]
    {
        
        get
        {
            if (Ok(index))
            {
                Error = false;
                return b[index - minIndex];
            }
            else
            {
                Error = true;
                return 0;
            }
        }
        
        set
        {
            if (Ok(index))
            {
                b[index - minIndex] = value;
                Error = false;
            }
            else Error = true;
        }
    }
    
    private bool Ok(int index)
    {
        if (index >= minIndex & index <= maxIndex) return true;
        return false;
    }
}

class RangeArrayDemo
{
    static void Main()
    {
        RangeArray mas1 = new RangeArray(-5, 5);
        RangeArray mas2 = new RangeArray(1, 10);
        RangeArray mas3 = new RangeArray(-20, -12);
        
        Console.WriteLine("Длина массива mas1: " + mas1.Length);
        for (int i = -5; i <= 5; i++)

            mas1[i] = i;
        Console.Write("Содержимое массива mas1: ");
        for (int i = -5; i <= 5; i++)
            Console.Write(mas1[i] + " ");
        Console.WriteLine("\n");
        
        Console.WriteLine("Длина массива mas2: " + mas2.Length);
        for (int i = 1; i <= 10; i++)
            mas2[i] = i;
        Console.Write("Содержимое массива mas2: ");
        for (int i = 1; i <= 10; i++)
            Console.Write(mas2[i] + " ");
        Console.WriteLine("\n");
        
        Console.WriteLine("Длина массива mas3: " + mas3.Length);
        for (int i = -20; i <= -12; i++)
            mas3[i] = i;
        Console.Write("Содержимое массива mas3: ");
        for (int i = -20; i <= -12; i++)
            Console.Write(mas3[i] + " ");
        Console.WriteLine("\n");
        Console.ReadLine();
    }
}



