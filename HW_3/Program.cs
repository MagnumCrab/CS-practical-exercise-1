// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

            int number = 10;

            Console.WriteLine("Введите число:");

            number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 1)
            {
                Console.WriteLine("Число " + number + " нечётное");
            }
            else
            {
                Console.WriteLine("Число " + number + " чётное");
            }