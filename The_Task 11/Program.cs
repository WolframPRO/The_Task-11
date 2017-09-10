using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Task_11
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] code = new char[27, 2];

            code[0, 0] = 'q';
            code[1, 0] = 'w';
            code[2, 0] = 'e';
            code[3, 0] = 'r';
            code[4, 0] = 't';
            code[5, 0] = 'y';
            code[6, 0] = 'u';
            code[7, 0] = 'i';
            code[8, 0] = 'o';
            code[9, 0] = 'p';
            code[10, 0] = 'a';
            code[11, 0] = 's';
            code[12, 0] = 'd';
            code[13, 0] = 'f';
            code[14, 0] = 'g';
            code[15, 0] = 'h';
            code[16, 0] = 'j';
            code[17, 0] = 'k';
            code[18, 0] = 'l';
            code[19, 0] = 'z';
            code[20, 0] = 'x';
            code[21, 0] = 'c';
            code[22, 0] = 'v';
            code[23, 0] = 'b';
            code[24, 0] = 'n';
            code[25, 0] = 'm';
            code[26, 0] = ' ';

            code[0, 1] = 't';
            code[1, 1] = 'w';
            code[2, 1] = 'b';
            code[3, 1] = 'z';
            code[4, 1] = 's';
            code[5, 1] = '9';
            code[6, 1] = '1';
            code[7, 1] = '_';
            code[8, 1] = '+';
            code[9, 1] = 'a';
            code[10, 1] = '!';
            code[11, 1] = '7';
            code[12, 1] = 'c';
            code[13, 1] = '[';
            code[14, 1] = ')';
            code[15, 1] = 'd';
            code[16, 1] = '6';
            code[17, 1] = '2';
            code[18, 1] = 'v';
            code[19, 1] = ' ';
            code[20, 1] = '?';
            code[21, 1] = ',';
            code[22, 1] = ':';
            code[23, 1] = '0';
            code[24, 1] = '.';
            code[25, 1] = '=';
            code[26, 0] = '-';

            Console.WriteLine(
                "Я умею шифровать текст и расшифровывать английский текст\n 1) Зашифровать\n 2) Расшифровать \n 3) Выход");
            int r;
            bool ok;
            do
            {
                do
                {
                    ok = Int32.TryParse(Console.ReadLine(), out r);


                    if (!ok) Console.WriteLine("Некорректный выбор, ожидаю решения: ");
                    if (r > 3 || r < 1)
                    {
                        Console.WriteLine("Выберите нужный вариант: ");
                        ok = false;
                    }
                } while (!ok);

                switch (r)
                {
                    case 1:
                        Console.WriteLine("Кодируем! Введите текст: ");
                        string a;
                        a = Console.ReadLine();

                        char[] b = new char[a.Length];
                        for (int i = 0; i < a.Length; i++)
                            b[i] = a[i];




                        for (int n = 0; n < b.Length; n++)
                        for (int i = 0; i < 27; i++)
                            if (b[n] == code[i, 0])
                            {
                                b[n] = code[i, 1];
                                break;
                            }

                        foreach (char x in b)
                            Console.Write(x);
                        break;
                    case 2:
                        Console.WriteLine("Будем декодировать, введите зашифрованный мной текст: ");

                        string a1;
                        a1 = Console.ReadLine();

                        char[] b1 = new char[a1.Length];
                        for (int i = 0; i < a1.Length; i++)
                            b1[i] = a1[i];

                        
                        for (int n = 0; n < b1.Length; n++)
                        for (int i = 0; i < 27; i++)
                            if (b1[n] == code[i, 1])
                            {
                                b1[n] = code[i, 0];
                                break;
                            }

                        foreach (char x in b1)
                            Console.Write(x);
                        break;
                    case 3:
                        goto x;
                        
                }
                Console.WriteLine();
                Console.WriteLine("Продолжим работу, \n 1) Зашифровать\n 2) Расшифровать \n 3) Выход");
            } while (3 == 3);

        x:  Console.WriteLine();
        }
    }
}
