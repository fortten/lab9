using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    class Program
    {
        // Запросить 2 числа и код операции, вывести ответ. Использовать обработку исключений для защиты от ввода неправильных данных.
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            int operation = 0;             
            try
            {
                #region Инициализация переменных
                Console.Write("Введите первое целое число. X = ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите второе целое число. Y = ");
                y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Выберете код операции:");
                Console.WriteLine("     1 - сложение");
                Console.WriteLine("     2 - вычитание");
                Console.WriteLine("     3 - произведение");
                Console.WriteLine("     4 - частное");
                operation = Convert.ToInt32(Console.ReadLine());
                #endregion
                #region Блок вычислений
                switch (operation)
                {
                    case 1:
                        {                            
                            Console.WriteLine("Результат = {0}", x + y);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Результат = {0}", x - y);
                            break;
                        }
                    case 3:
                        {                          
                            Console.WriteLine("Результат = {0}", x * y);
                            break;
                        }
                    case 4:                                                     
                        {                                                       // Если выводить результат деления с десятичными значениями, то Exception при делении
                            Console.WriteLine("Результат = {0}", x / y);        // на 0 не срабатывает. Ошибку деления на 0 надо будет ловить в case 4 через условный 
                            break;                                              // оператор.
                        }
                    default:
                        {
                            Console.WriteLine("Нет операции с указанным номером");
                            break;
                        }
                }
                #endregion
            }
            catch (DivideByZeroException) when (y == 0 && operation == 4)
            {
                Console.WriteLine("Ошибка! Недопустимо деление на 0");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка!" + ex.Message);
            }
            Console.WriteLine("Для завершения нажмите любую клавишу на клавиатуре");
            Console.ReadKey();
        } 
    }
}

