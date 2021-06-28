sing System;

namespace praktic3
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            int[] ork = { 3, -6, 12, -23, 55, -98 };
            for (int i = 0; i < ork.Length; i++)
            {
                int o = 0;
                for (int j = 0; j < ork.Length; j++)
                {
                    if (Math.Abs(ork[i]) < Math.Abs(ork[j]))
                    {
                        o++;
                        if (o == ork.Length - 1)
                        {
                            Console.WriteLine("1) Минимальный по модулю: " + ork[i]);
                            break;
                        }
                    }
                }
            }
            //2
            int[] ogr = { 3, 3, 1, 1, 6, 7, 8, 9, 9 };
            string ot = "";
            for (int i = 0; i < ogr.Length; i++)
            {
                bool n = false;
                for (int j = 0; j < ogr.Length; j++)
                {
                    if (ogr[i] == ogr[j] && i != j)
                    {
                        n = true;
                    }

                }
                if (!n)
                {
                    ot = ot + ogr[i] + ", ";
                }
            }
            Console.WriteLine("2) Уникальные элементы: " + ot);
            //3
            int[] random = { 7, 6, -5, -3, 1, 123, -567, 976745, -32 };
            string a = "";
            string b = "";
            for (int i = 0; i < random.Length; i++)
            {
                if (i == random.Length - 1)
                {
                    a = a + random[i];
                }
                else
                {
                    a = a + random[i] + ", ";
                }
            }
            Console.WriteLine("3) Массив: " + a);
            for (int i = 0; i < random.Length; i++)
            {
                if (random[i] >= 0)
                {
                    if (i == random.Length - 1)
                    {
                        b = b + random[i];
                    }
                    else
                    {
                        b = b + random[i] + ", ";
                    }
                }
            }
            Console.WriteLine("3) Массив: " + b);
        }
    }
}