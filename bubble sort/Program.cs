using System;


namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare Variable
            int a;
            int[] storeValue;
            int b;
            int i;
            int j;
            int temp;
            
            {
                    //capture array
                    Console.WriteLine("Enter the number of values to sort.");
                    b = int.Parse(Console.ReadLine());
                    storeValue = new int[b];

                    for (a = 0; a <= storeValue.Length - 1; a++)
                    {
                        Console.WriteLine("Enter next number to sort.");
                        storeValue[a] = int.Parse(Console.ReadLine());
                    }

                    //Sort Array
                    for (j = b - 1; j > 0; j--)
                    {
                        for (i = 0; i < j; i++)
                        {
                            if (storeValue[i] > storeValue[i + 1])
                            {
                                temp = storeValue[i + 1];
                                storeValue[i + 1] = storeValue[i];
                                storeValue[i] = temp;
                            }
                        }
                    }
                    //Output sorted values
                    Console.WriteLine("Sorted:");
                    foreach (int p in storeValue)
                        Console.Write(p + " ");
                   
                    Console.Read();
               
            }
                    } 
    }
}
