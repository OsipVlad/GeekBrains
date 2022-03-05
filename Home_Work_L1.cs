using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



 
class Lesson_1
{
    internal class Home_Work_L1
    {
        static void Main(string[] args)
        {
            Help_for_HW pause_go_next = new Help_for_HW();//Использование Созданного класса и метода для помощи в ДЗ

            #region Задача №1 Анкета
            /*
            Осипенко В.О.
            Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
            а) используя  склеивание;
            б) используя форматированный вывод;
            в) используя вывод со знаком $.
            */
            Console.WriteLine("Программа Анкета, выводит три результата разными способами\n");

            Console.Write("Введите ваше имя: ");
            var name = Console.ReadLine();
            Console.Write("Введите вашу фамилию: ");
            var last_name = Console.ReadLine();
            Console.Write("Введите ваш возраст: ");
            var age = Console.ReadLine();
            Console.Write("Введите ваш рост: ");
            var growth = Console.ReadLine();
            Console.Write("Введите ваш вес: ");
            var weight = Console.ReadLine();


            Console.WriteLine("\nПриветствую " + name + " " + last_name + ", которому " + age + " лет.\n" +
                "При росте " + growth + " см, Вы весите " + weight + " килограмм.");
            Console.WriteLine("\nПриветствую {0} {1}, которому {2} лет.\n" +
                "При росте {3} см, Вы весите {4} килограмм.", name, last_name, age, growth, weight);
            Console.WriteLine($"\nПриветствую {name} {last_name}, которому {age} лет.\n" +
                $"При росте {growth} см, Вы весите {weight} килограмм.");

            pause_go_next.Pause();

            #endregion

            #region Задача №2 Индекс массы тела
            /*
            Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h);
            где m — масса тела в килограммах, h — рост в метрах.
            */
            Console.WriteLine("Программа Рассчитывает индекс массы тела.\n");
            Console.Write("Введите ваш вес в КГ: ");
            float m = float.Parse(Console.ReadLine());

            Console.Write("Введите ваш рост в метрах(через запятую, например - 1,82): ");
            float h = float.Parse(Console.ReadLine());

            float rezult = index_Mass(m, h);
            Console.Write("\nСправочная информация:\n" +
                "16,00 — 18,49	Недостаточная (дефицит) масса тела\n" +
                "18,50 — 24,99   Норма\n" +
                "25,00 — 29,99   Избыточная масса тела(предожирение)\n" +
                "30,00 — 34,99   Ожирение первой степени\n");
            Console.WriteLine($"\nИндекс массы вашего тела равен {rezult:F2}");


            pause_go_next.Pause();
            #endregion

            #region Задача № 3 Подсчет расстояния между точками
            /*
             Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле
             r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
            б) Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
            */
            Console.WriteLine("Программа расчитывает расстояние мужду точками по оси координат Х и У\n");


            Console.Write("Введите координаты х1: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Введите координаты х2: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("Введите координаты y1: ");
            double y1 = double.Parse(Console.ReadLine());
            Console.Write("Введите координаты y2: ");
            double y2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"Расстояние между введенными координатами = {DistancePoint(x1, x2, y1, y2):F2}");


            pause_go_next.Pause();
            #endregion

            #region Задача № 4 Обмен значениями двух переменных
            /*
             Написать программу обмена значениями двух переменных типа int без использования вспомогательных методов.
             */
            Console.WriteLine("Программа поменяет введеные значения ваших переменных.\n");

            Console.Write("Введите значение a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите значение b: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"значение а = {Value_exchange(a, b)}, значение b = {Value_exchange(b, a)}");


            pause_go_next.Pause();
            #endregion

            #region Задача № 5 Вывод Имени, Фамилии и Города по центру
            /*
              а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
              б) Сделать задание, только вывод организовать в центре экрана.
              в) *Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y).
             */
            Console.WriteLine("Программа выводит введеные вами данные по центру экрана\n");

            Console.Write("Введите ваше имя: ");
            string name_for_centr = Console.ReadLine();
            Console.Write("Введите вашу фамилию: ");
            string surname = Console.ReadLine();
            Console.Write("Введите ваш город проживания: ");
            string sity = Console.ReadLine();

            Console.WriteLine(Title_FIO(name, surname, sity));

            pause_go_next.Pause();
            #endregion
        }//Выполненые задач


        static float index_Mass(float m, float h)
        {
            return m / (h * h);
        } //Формула по подсчету индекса массы тела.

        
        static double DistancePoint(double x1, double x2, double y1, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        } //Формула нахождения расстояния между точками
        
        
        static int Value_exchange(int a, int b)//Обмен значениями
        {
            return a = b;
        }

        static string Title_FIO(string name_for_centr, string surname, string sity)//Вывод информации о себе по центру
        {
            return $"\n\n\n\n\n\t\t\t\t\tМеня завут {name_for_centr} {surname}\n" +
                   $"\t\t\t\t\tЯ из города, под названием {sity}";
        }
    }
       
}
public class Help_for_HW //Задача № 6 Для помощи себе в дз
{
    public void Pause()
    {
        /*
         Помогает однйо командой информировать пользователя о продолжении при нажатии Enter
         Сохраняет паузу между задачами
         Отчищает консоль от предидущей задачи
       */
        Console.WriteLine("\nНажмите Enter, что бы Продолжить.");
        Console.ReadLine();
        Console.Clear();
    }
}
