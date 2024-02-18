using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            double operand1, operand2, result=0; //а какой смысл от калькулятора, если значения произвольные и пользователь не вводит их сам...?
            string sign, weather; 

            Console.WriteLine("Первое число: ");
            operand1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Второе число: ");
            operand2 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Выберите операцию: +, -, *, / ");
            sign = Console.ReadLine();
            switch (sign)
            {
                case "+":
                    result = operand1 + operand2;
                    Console.WriteLine(result);
                  
                    
                    break;
                case "-":
                    result = operand1 - operand2;
                    Console.WriteLine(result);
                    
                    
                    break;
                case "*":
                    result = operand1 * operand2;
                    Console.WriteLine(result);

                    break;
                    
                case "/":
                    
                    if (operand2 == 0)
                        Console.WriteLine("На ноль делить нельзя, братан...");
                    else
                        result = operand1 / operand2;
                    Console.WriteLine(result);
                    break;
                default:
                    Console.WriteLine("Неизвестная команда,повторите попытку!");
                    break;

            }
            // Проверка на диапазон
            if (result >= 0 && result <= 14)
                Console.WriteLine("Число находится в диапазоне [0-14]");
            else if (result >= 15 && result <= 35)
                Console.WriteLine("Число находится в диапазоне [15-35]");
            else if (result >= 36 && result <= 50)
                Console.WriteLine("Число находится в диапазоне [36-50]");
            else if (result >= 51 && result <= 100)
                Console.WriteLine("Число находится в диапазоне [51-100]");
            else
                Console.WriteLine("Число преисполнилось в своём познании и вышло за пределы отслеживаемых диапазонов");
            //Проверка на чётность
            if (result % 2 == 0)
                Console.WriteLine("Число чётное");
            else
                Console.WriteLine("Число нечётное");
            /* if (result & 1==0) если бы число могло бы быть только целым, то есть это уже не тип double
                 Console.WriteLine("Число чётное");
             else
                 Console.WriteLine("Число нечётное");*/
            Console.WriteLine("Узнайте как сказать англичанину какая сегодня погода! Введите слово на русском:");
            weather = Console.ReadLine();
            switch (weather)
            {
                case "Солнечно":
                    Console.WriteLine("Sunny");
                    break;
                case "Дождливо":
                    Console.WriteLine("Rainy");
                    break;
                case "Тепло":
                    Console.WriteLine("Warm");
                    break;
                case "Морозно":
                    Console.WriteLine("Frostly");
                    break;
                case "Ветрено":
                    Console.WriteLine("Windy");
                    break;
                case "Туманно":
                    Console.WriteLine("Foggy");
                    break;
                case "Облачно":
                    Console.WriteLine("Cloudly");
                    break;
                case "Холодно":
                    Console.WriteLine("Cold");
                    break;
                case "Жарко":
                    Console.WriteLine("Hot");
                    break;
                case "Прохладно":
                    Console.WriteLine("Chilly");
                    break;
                default:
                    Console.WriteLine("Перевод отсутствует(");
                    break;



            }

            Console.ReadKey();
        }
    }
}
