using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



// Чудинов Никита
//1. Написать программу “Анкета”. Последовательно задаются вопросы (имя, фамилия, возраст,
//рост, вес). В результате вся информация выводится в одну строчку.
//а) используя склеивание;
//б) используя форматированный вывод;
//в) * используя вывод со знаком $.
//2. Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле
//I=m/(h* h); где m-масса тела в килограммах, h - рост в метрах
//3. а) Написать программу, которая подсчитывает расстояние между точками с координатами x1,
//y1 и x2,y2 по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).Вывести результат
//используя спецификатор формата .2f(с двумя знаками после запятой);
//© geekbrains.ru 20
//б) * Выполните предыдущее задание оформив вычисления расстояния между точками в виде
// метода;
//4. Написать программу обмена значениями двух переменных:
//а) с использованием третьей переменной;
//б) * без использования третьей переменной.
//5. а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
//б) * Сделать задание, только вывод организуйте в центре экрана
//в) ** Сделать задание б с использованием собственных методов(например, Print(string ms, int
// x, int y)
// 6. *Создать класс с методами, которые могут пригодиться в вашей учебе(Print, Pause).


namespace MySecondApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер задачи: ");
            int tskNmbr = Convert.ToInt32(Console.ReadLine());

            switch (tskNmbr)
            {
                case 1:
                    Task_1();
                    break;
                case 2:
                    Task_2();
                    break;
                case 3:
                    Task_3();
                    break;
                case 4:
                    Task_4();
                    break;
                case 5:
                    Task_5();
                    break;
                default:
                    Console.WriteLine("Введите номер от 1 до 5.");
                    break;
            }

            Console.ReadLine();
        }

        static void Task_1()
        {
            Console.WriteLine("Анкета");

            Console.Write("Имя: ");
            string name = Console.ReadLine();

            Console.Write("Фамилия: ");
            string surname = Console.ReadLine();

            Console.Write("Возраст: ");
            string age = Console.ReadLine();

            Console.Write("Рост: ");
            string h = Console.ReadLine();

            Console.Write("Вес: ");
            string m = Console.ReadLine();

            Console.WriteLine("Имя: " + name + " Фамилия: " + surname + " Возраст: " + age + " Рост: " + h + " Вес: " + m);
            Console.WriteLine("{0} {1} {2} {3} {4}", name, surname, age, h, m);
            Console.WriteLine($"{name} {surname} {age} {h} {m}");
        }


        static void Task_2()
        {
            Console.WriteLine("Рост в метрах: ");
            double h = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Вес в килограммах: ");
            double m = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("ИМТ = " + m / (h * h));
        }


        static void Task_3()
        {
            Console.Write("x1 = ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y1 = ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x2 = ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y2 = ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("{0:F2}", r);
            Console.WriteLine("{0:F2}", Distance(x1, y1, x2, y2));
        }

        static double Distance(double x1, double y1, double x2, double y2)
        {
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return r;
        }

        static void Task_4()
        {
            int a = 1;
            int b = 2;
            Console.WriteLine(a + " " + b);

            int t = a;
            a = b; 
            b = t; 
            Console.WriteLine(a + " " + b);

            b = a + b;
            a = b - a; 
            b = b - a; 
            Console.WriteLine(a + " " + b);
        }

        static void Task_5()
        {
            string surname = "Чудинов";
            string name = "Никита";
            string city = "Пермь";

            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);

            Console.WriteLine("{0} {1} {2}", name, surname, city);
            PrintInCenter(name + " " + surname + " " + city, Console.WindowWidth / 2, Console.WindowHeight / 2);
        }

        static void PrintInCenter(string message, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(message);
        }

        
    }

    

    
        }
    
