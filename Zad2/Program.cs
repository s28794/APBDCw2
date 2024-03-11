

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public float CalculateAverage(int[] array)
    {
        var tmp = 0;
        foreach (var i in array)
        {
            tmp += i;
        }
        var length = (float)(array.Length);
        return (tmp / length);
    }


    public int GetMaximumValue(int[] array)
    {
        int tmp = 0;
        if (array.Length > 0)
        {
            for (int i = 0; i < array.Length; i++) 
            {
                if (i == 0)
                {
                    tmp = array[i];
                }
                if (array[i] == 0)
                {
                    isZero = true;
                }

                if (array[i] > tmp || array[i] == tmp)
                {
                    tmp = array[i];
                }
            }
            return tmp;  
        }
        Console.WriteLine("Empty array");
        return 0; 
        
    }