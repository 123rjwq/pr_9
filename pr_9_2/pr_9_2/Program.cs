using System;

namespace pr_9_2
{
    class Program
    {

        // Интерфейс для движения
        interface IMovable
        {
            const int MinimumSpeed = 0;
            // Минимальная скорость
            static int MaximumSpeed = 60;
            // Максимальная скорость

            void Move();
            // Метод движения

            string Name { get; set; }
            // Свойство имени

            delegate void MoveHandler(string message);
            // Определение делегата для события

            event MoveHandler MoveEvent;
            // Событие движения
        }

        static void Main(string[] args)
        {
            Console.WriteLine(IMovable.MaximumSpeed);
            // Вывод максимальной скорости
            Console.WriteLine(IMovable.MinimumSpeed);
            // Вывод минимальной скорости
        }
    }
}