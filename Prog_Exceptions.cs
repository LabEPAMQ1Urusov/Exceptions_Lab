using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace Exceptions_Lab
{
    [Dev(123456789, "Yegor", "Urusov")]
    class Prog_Exceptions
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public static void GetAttr(Type t)
        {
            DevAttribute MyAttr =
             (DevAttribute)Attribute.GetCustomAttribute(t, typeof(DevAttribute));

            if (MyAttr == null)
            {
                Console.WriteLine("Atrribute is not found.");
            }
            else
            {
                Console.WriteLine("Developer: {0} " + "{1}", MyAttr.FirstName, MyAttr.LastName);
                Console.WriteLine("Identifier: {0} \n", MyAttr.ID);
            }
        }
        

        static void Main(string[] args)
        {
            GetAttr(typeof(Prog_Exceptions));

            do
            { Start(); }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
        }

        static void Start()
        {
            logger.Info("Начало выполнения программы");
            
            Tiger tiger = new Tiger(95, 200, 55, "Tiger");
            tiger.Description();

            Lion lion = new Lion(120, 190, 70, "Lion");
            lion.Description();

            Leopard leopard = new Leopard(65, 31, 50, "Leopard");
            leopard.Description();

            Console.WriteLine("\n" + "Попробуй запомнить вес какой-либо кошки и нажми любую клавишу");
            Console.ReadLine();
            Console.Clear();

            int selection = Select();

            switch (selection)
            {
                case 1:
                    double tw = TigerWeight();
                    if (tw == tiger.weight)
                    { Console.WriteLine("Верный ответ"); }
                    else { Console.WriteLine("К сожалению, ответ не верный"); }
                    Console.WriteLine("Для выхода нажми Escape или любую другую клавишу чтобы продолжить");
                    break;
                case 2:
                    double lw = LionWeight();
                    if (lw == lion.weight)
                    { Console.WriteLine("Верный ответ"); }
                    else { Console.WriteLine("К сожалению, ответ не верный"); }
                    Console.WriteLine("Для выхода нажми Escape или любую другую клавишу чтобы продолжить");
                    break;
                case 3:
                    double leow = LeopardWeight();
                    if (leow == lion.weight)
                    { Console.WriteLine("Верный ответ"); }
                    else { Console.WriteLine("К сожалению, ответ не верный"); }
                    Console.WriteLine("Для выхода нажми Escape или любую другую клавишу чтобы продолжить");
                    break;
                default:
                    Console.WriteLine("Для выбора необходимо было ввести любое число из: 1, 2, 3");
                    logger.Warn("Введено число не соответствующее выбору");
                    Console.WriteLine("Для выхода нажми Escape или любую другую клавишу чтобы продолжить");
                    break;
            }
            logger.Info("Выполнение программы завершено");
        }

        static int Select()
        {
            Console.WriteLine("\n" + "Вес какой из кошек ты запомнил?");
            Console.WriteLine(" Если ты помнишь вес тигра, введи 1");
            Console.WriteLine(" Если ты помнишь вес льва, введи 2");
            Console.WriteLine(" Если ты помнишь вес леопарда, введи 3");
            try { return Convert.ToInt32(Console.ReadLine()); }
            catch
            {
                Console.WriteLine("Необходимо ввести числовое значение");
                logger.Error("Некорректный ввод");
                return Select();
            }        
        }

        static double TigerWeight()
        {
            Console.Write("Введи вес тигра: ");
            try { return Convert.ToDouble(Console.ReadLine()); }
            catch
            {
                Console.WriteLine("Необходимо ввести числовое значение");
                logger.Error("Некорректный ввод");
                return TigerWeight();
            }
        }

        static double LionWeight()
        {
            Console.Write("Введи вес льва: ");
            try { return Convert.ToDouble(Console.ReadLine()); }
            catch
            {
                Console.WriteLine("Необходимо ввести числовое значение");
                logger.Error("Некорректный ввод");
                return LionWeight();
            }
        }

        static double LeopardWeight()
        {
            Console.Write("Введи вес леопарда: ");
            try { return Convert.ToDouble(Console.ReadLine()); }
            catch
            {
                Console.WriteLine("Необходимо ввести числовое значение");
                logger.Error("Некорректный ввод");
                return LeopardWeight();
            }
        }

    }

        
    
}
