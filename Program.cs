using System;
using CarLibrary;

namespace CarApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller carCtrlr = new Controller();


            ConsoleKeyInfo key;

            do
            {
                Console.Clear();
                Console.WriteLine("1. Завести/заглушить двигатель автомобиля.");
                Console.WriteLine("2. Увеличить скорость скорость.");
                Console.WriteLine("3. Уменьшить скорость.");
                Console.WriteLine("\nq. Выход.\n");
                carCtrlr.SowCarState();
                key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.D1:
                        carCtrlr.StartStopEngine();
                        break;
                    case ConsoleKey.D2:
                        carCtrlr.Fastly();
                        break;
                    case ConsoleKey.D3:
                        carCtrlr.Slowly();
                        break;
                }


                
            } while (key.KeyChar.ToString().ToLower() != "q");

        }
    }
}
