using System;

namespace COWnBYK
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = "0123456789";
            string answr = "";
            string inputxt = "";
            int i, b;
            int ch = 0;
            Random r = new Random();
            for (i = 0; i <= 3; i++)
            {
                do
                {
                    ch = r.Next(0, 10);
                }
                while (number[ch] == 'a');
                answr = answr + number[ch];
                number = number.Remove(ch, 1).Insert(ch, 'a'.ToString());
            }
            Console.Write("Быки и коровы — логическая игра, в ходе которой за несколько попыток игрок должен определить, что задумал компьютер (другой игрок). Я загадал число и вам нужно угадать число которое я загадал. Как вы думаете какое это число?");
            Console.WriteLine();
            Console.Write("Правильный ответ:????");
            Console.WriteLine();
            Console.Write("Введите число:");
            Console.WriteLine();
            number = "0123456789";
            do
            {
                b = 0;
                int k = 0;
                inputxt = Console.ReadLine();
                if (inputxt.Length != 4 || check(inputxt) != 0 || symb(inputxt) != 0)
                {
                    Console.Write("Неверный ввод");
                    Console.WriteLine();
                }
                else
                {
                    k = cow(inputxt, answr);
                    b = bull(inputxt, answr);
                    Console.Write(k); Console.Write(" Коров ");
                    Console.Write(b); Console.Write(" Быков ");
                    Console.WriteLine();
                }
            } while (b != inputxt.Length);
            Console.WriteLine("Ура, Вы угадали число которое я загадал!!");
            Console.ReadKey();
        }
        static int check(string inputxt)
        {
            int o = 0;
            for (int i = 0; i < inputxt.Length; i++)
            {
                for (int j = 0; j < inputxt.Length; j++)
                {
                    if (i != j)
                    {
                        if (inputxt[i] == inputxt[j])
                        {
                            o++;
                        }
                    }
                }
            }
            return o;
        }
        static int cow(string inputxt, string answr)
        {
            int k = 0;
            for (int i = 0; i < inputxt.Length; i++)
            {
                for (int j = 0; j < inputxt.Length; j++)
                {
                    if (j != i)
                    {
                        if (inputxt[i] == answr[j])
                        {
                            k++;
                        }
                    }
                }
            }
            return k;
        }
        static int bull(string inputxt, string answr)
        {
            int b = 0;
            for (int i = 0; i < inputxt.Length; i++)
            {
                if (inputxt[i] == answr[i])
                {
                    b++;
                }
            }
            return b;
        }
        static int symb(string inputxt)
        {
            int sym = 0;
            for (int i = 0; i < inputxt.Length; i++)
            {
                if (!Char.IsNumber(inputxt[i]))
                {
                    sym++;
                }
            }
            return sym;
        }
    }
}