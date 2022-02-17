using System;

namespace ConsoleApp1
{
    public class HW1
    {
        public static long QueueTime(int[] customers, int count)
        {
            int[] kassa = new int[count];
            int time = 0;
            int c = 0;
            int kassanool = 0;
            int sum = 0;
            int kolvolud = customers.Length;
            int kolvokass = kassa.Length;

            Console.WriteLine(" ");
            for (int i = 0; i < kolvolud; i++)
            {
                for (int j = 0; j < kolvokass; j++)
                {
                    if (kassa[j] == 0)
                    {
                        kassa[j] = customers[i];
                        for (int k = 0; k < kolvokass; k++)
                        {
                            Console.WriteLine(kassa[k]);
                        }
                        break;
                    }
                }
                Console.WriteLine(" ");
            }

            for (int n = count; n <= kolvolud; n++)
            {
                if (n == kolvolud)
                {
                    for (int j = 0; j < kolvokass; j++)
                    {
                        if (kassa[j] > sum) sum = kassa[j] - 1;
                    }
                }

                c = 0;
                while (true)
                {
                    if (n < kolvolud)
                    {
                        for (int j = 0; j < kolvokass; j++)
                        {
                            kassa[j] = kassa[j] - 1;
                            if (kassa[j] == 0)
                            {
                                c = 1;
                                kassanool = j;
                            }
                        }
                        time++;
                    }
                    else
                    {

                        for (int j = 0; j < kolvokass; j++)
                        {
                            if (kassa[j] > 0)
                            {
                                kassa[j] = kassa[j] - 1;

                            }
                            if (sum == 0)
                            {
                                c = 1;
                                kassanool = j;
                            }
                        }
                        time++;
                        sum--;
                    }
                    for (int k = 0; k < kolvokass; k++)
                    {
                        Console.WriteLine(kassa[k]);
                    }
                    if (c == 1) break;
                }

                Console.WriteLine(" ");
                if (n < kolvolud) kassa[kassanool] = customers[n];

                for (int k = 0; k < kolvokass; k++)
                {
                    Console.WriteLine(kassa[k]);
                }

            }
            Console.WriteLine("time= ");
            Console.WriteLine(time);


            return 0;

        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int n = 0;
            Console.WriteLine("Input count of customers");
            n = Convert.ToInt32(Console.ReadLine());
            int[] customers = new int[n];
            Console.WriteLine("Input count of threads");
            count = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Input customers");
                customers[i] = Convert.ToInt32(Console.ReadLine());
            }
            HW1.QueueTime(customers, count);
        }
    }
}