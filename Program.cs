using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;

namespace pract_14
{
    class Program
    {
        public static void Main()
        {



            //////Задание 1


            Stack<int> intStack = new Stack<int>();
            Console.WriteLine("Введите количество чисел коллекции");
            int n = int.Parse(Console.ReadLine());
            if (n! <= 0)
            {
                Console.WriteLine("Введите число больше нуля!");
            }
            else
            {
                Console.Write("n = " + n);
                for (int i = 1; i <= n; i++)
                {
                    intStack.Push(i);
                }
                Console.WriteLine("Размерность стека " + intStack.Count());
                Console.WriteLine("Верхний элемент стека " + intStack.Peek());
                Console.WriteLine("Размерность стека " + intStack.Count());
                Console.WriteLine("Содержимое стека: ");
                while (intStack.Count != 0)
                {
                    Console.Write("{0} ", intStack.Pop());
                    Console.WriteLine("\nРазмерность стека " + intStack.Count());
                }
            }




            ////Задание 2.1
            Console.WriteLine("Введите математическое выражение");
            string v = Convert.ToString(Console.ReadLine());
            StreamWriter sw1 = File.AppendText("v.txt");
            sw1.WriteLine(v);
            sw1.Close();

            StreamReader file = new StreamReader("v.txt");
            string line = file.ReadToEnd();
            file.Close();

            Stack skobki = new Stack();
            bool skob = true;
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == '(')

                    skobki.Push(i);

                else if (line[i] == ')')

                {
                    if (skobki.Count == 0)

                    {

                        skob = false;
                        Console.WriteLine("Возможно в позиции " + i + " есть лишняя скобка");

                    }
                    else
                        skobki.Pop();

                }
            }
            if (skobki.Count == 0)
            {
                if (skob)
                    Console.WriteLine("Скобки сбалансированы");

            }
            else
                Console.WriteLine("Баланс скобок нарушен");
            {
                Console.Write("Возможно есть лишняя скобка в позиции:");
                while (skobki.Count != 0)

                {
                    Console.Write("{0} ", (int)skobki.Pop());

                }

                Console.WriteLine();
            }


            ////Задание 2.2
            ///
            Console.WriteLine("Введите математическое выражение");
            string v1 = Convert.ToString(Console.ReadLine());
            StreamWriter sw2 = File.AppendText("t.txt");
            sw2.WriteLine(v1);
            sw2.Close();

            StreamReader file1 = new StreamReader("t.txt");
            Stack<int> skobki1 = new Stack<int>();
            bool skob1 = true;
            string line1 = file1.ReadToEnd();
            file1.Close();
            for (int i = 0; i < line1.Length; i++)

            {
                if (line1[i] == '(')
                {
                    skobki1.Push(i);
                }

                else if (line1[i] == ')')

                {
                    if (skobki1.Count > 0)

                    {
                        skobki1.Pop();

                    }
                    else
                    {
                        line1 = line1.Remove(i, 1);
                        line1 = line1.Insert(i, " ");
                    }
                    
                }
            }
            while (skobki1.Count > 0)
            {
                int ind = skobki1.Pop();
                line1 = line1.Remove(ind, 1);
                line1 = line1.Insert(ind, " ");

            }
            StreamWriter sw3 = File.AppendText("t1.txt");
            sw3.WriteLine(line1);          
            sw3.Close();
            Console.WriteLine("Запись прошла успешно");


        }

    }
}


    
















