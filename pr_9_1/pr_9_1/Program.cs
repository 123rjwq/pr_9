using System;

// Интерфейс для управления транспортным средством
interface IVehicle
{
    void ChangeGear(int newGear);
    // Метод смены передачи
    void Accelerate(int speed);
    // Метод ускорения
    void Decelerate(int speed);
    // Метод замедления
    void Refuel(string fuelType);
    // Метод заправки топливом
    void Service();
    // Метод технического обслуживания
    void TurnLeft();
    // Метод поворота налево
    void TurnRight();
    // Метод поворота направо
    void ShowInfo();
    // Метод вывода информации
}

// Базовый класс для транспортных средств
abstract class Transport : IVehicle
{
    protected int speed;
    // Скорость транспорта
    protected int gear;
    // Текущая передача

    public void ChangeGear(int newGear)
    {
        gear = newGear;
        Console.WriteLine($"Переключена передача на {gear}.");
    }

    public void Accelerate(int increaseSpeed)
    {
        speed += increaseSpeed;
        Console.WriteLine($"Ускорение до {speed} км/ч.");
    }

    public void Decelerate(int decreaseSpeed)
    {
        speed -= decreaseSpeed;
        Console.WriteLine($"Замедление до {speed} км/ч.");
    }

    public abstract void Refuel(string fuelType);

    public abstract void Service();

    public abstract void TurnLeft();

    public abstract void TurnRight();

    public void ShowInfo()
    {
        Console.WriteLine($"Текущая скорость: {speed} км/ч, Текущая передача: {gear}");
    }
}

// Класс для легкового автомобиля с бензиновым двигателем
class GasolineCar : Transport
{
    public override void Refuel(string fuelType)
    {
        if (fuelType == "бензин")
            Console.WriteLine("Заправлено бензином.");
        else
            Console.WriteLine("Неверный тип топлива для бензинового автомобиля.");
    }

    public override void Service()
    {
        Console.WriteLine("Выполнено техническое обслуживание для бензинового автомобиля");
    }

    public override void TurnLeft()
    {
        Console.WriteLine("Поворот налево поворотом передних колес.");
    }

    public override void TurnRight()
    {
        Console.WriteLine("Поворот направо поворотом передних колес.");
    }
}

// Класс для легкового автомобиля с дизельным двигателем
class DieselCar : Transport
{
    public override void Refuel(string fuelType)
    {
        if (fuelType == "дизель")
            Console.WriteLine("Заправлено дизельным топливом.");
        else
            Console.WriteLine("Неверный тип топлива для дизельного автомобиля.");
    }

    public override void Service()
    {
        Console.WriteLine("Выполнено техническое обслуживание для дизельного автомобиля. Поменяно масло и фильтры в двигателе");
    }

    public override void TurnLeft()
    {
        Console.WriteLine("Поворот налево поворотом передних колес.");
    }

    public override void TurnRight()
    {
        Console.WriteLine("Поворот направо поворотом передних колес.");
    }
}

class Program
{
    static void Main()
    {
        GasolineCar gasolineCar = new GasolineCar();
        // Создание объекта бензиновый автомобиль
        DieselCar dieselCar = new DieselCar();
        // Создание объекта дизельный автомобиль

        // Пример использования методов
        gasolineCar.ChangeGear(2);
        // Смена передачи
        gasolineCar.Accelerate(50);
        // Ускорение
        gasolineCar.TurnLeft();
        // Поворот налево
        gasolineCar.Refuel("бензин");
        // Заправка бензином
        gasolineCar.Service();
        // Техническое обслуживание
        gasolineCar.ShowInfo();
        // Вывод информации

        dieselCar.ChangeGear(1);
        // Смена передачи
        dieselCar.Decelerate(10);
        // Замедление
        dieselCar.TurnRight();
        // Поворот направо
        dieselCar.Refuel("дизель");
        // Заправка дизельным топливом
        dieselCar.Service();
        // Техническое обслуживание
        dieselCar.ShowInfo();
        // Вывод информации
    }
}
