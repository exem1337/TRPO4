    using System;

    namespace TRPO4
    {
        class Program
        {
            static void Main()
            {
                vInsertValues();
                vCount();
            }

            static double a, b;

            static void vInsertValues()
            {
                Console.WriteLine("Введите a, b");
                try
                {
                    a = Convert.ToDouble(Console.ReadLine());
                    b = Convert.ToDouble(Console.ReadLine());
                    if(a > 999999 || b > 999999 || a < -999999 || b < -999999)
                    {
                        Console.WriteLine("Вы ввели слишком большое / маленькое число");
                        vInsertValues();
                    }
                }
                catch(Exception)
                {
                    Console.WriteLine("Вы ввели не число");
                    vInsertValues();
                }
            }

            static void vCount()
            {
                double sum = 0;
            if(a < b)
                for(double i = a; i <= b; i = i + 0.1)
                {
                    if (i == 6) continue;
                    if (!Double.IsNaN(formula(i)))
                        sum += Convert.ToDouble(formula(i));
                    else Console.WriteLine("При данном значении нет решения: " + i);
                }
            else
            {
                for (double i = b; i <= a; i = i + 0.1)
                {
                    if (i == 6) continue;
                    if (!Double.IsNaN(formula(i)))
                        sum += Convert.ToDouble(formula(i));
                    else Console.WriteLine("При данном значении нет решения: " + i);
                }
            }
                Console.WriteLine("Сумма: " + sum);
            }


            static double formula(double x) => (Math.Sqrt(Math.Pow(x, 2) - 0.81))/(x - 6);


        }
    }
//экстремальная числ = 0
//исключительная <0.81 