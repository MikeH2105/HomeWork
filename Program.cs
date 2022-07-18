/*Пользователь вводит с клавиатуры число в диапа-
зоне от 1 до 100. Если число кратно 3 (делится на 3 без
остатка) нужно вывести слово Fizz. Если число кратно 5
нужно вывести слово Buzz. Если число кратно 3 и 5 нужно
вывести Fizz Buzz. Если число не кратно не 3 и 5 нужно
вывести само число.
Если пользователь ввел значение не в диапазоне от 1
до 100 требуется вывести сообщение об ошибке.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Доброго дня!\nВведіть будь-ласка число");
            string numberString = Console.ReadLine();
            int number = Convert.ToInt32(numberString);
            if (number > 100 && number < 1)
            {
                Console.WriteLine("Ви ввели значення яке не входить в діапазон від 1 до 100");
            }
            if (number % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            if (number % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else if (number % 5 != 0 || number % 3 != 0)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("Дякуємо!!!");
            Console.ReadKey();//Затримуємо консоль...

        }
    }
}
