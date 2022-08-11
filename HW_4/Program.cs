// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

            int A = 1;

            bool not = true;

            Console.WriteLine("Введите число");

            Console.WriteLine("Введите колличество чисел");

            int number = Convert.ToInt32(Console.ReadLine());

            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Чётные числа от 1 до " + number);

            while (A <= number)
            {
                if (A % 2 != 1)
                {
                    Console.Write(A + ", ");
                    not = false;
                }
                A++;
            }
            if (not)
            {
                Console.WriteLine("Нет чётных чисел!");
            }