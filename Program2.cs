using System;


class vehicle 
{
    private int x;
    private int y;
    private int z;
    private long price;
    private int speed;
    private int year;

    public vehicle(int x, int y, int z, long price, int speed, int year)
    {
        this.x = x;
        this.y = y;
        this.z = z;
        this.price = price;
        this.speed = speed;
        this.year = year;
    }

    public void Print() 
    {
        Console.WriteLine($"Название:{this.ToString()} Координаты: X={x} Y={y} Z={z} Цена:{price}руб Скорость:{speed}км/ч Год выпуска:{year}");
    }
}

class Plane : vehicle
{
    private int height;
    private int passengers;

    public Plane(int x, int y, int z, long price, int speed, int year, int height, int passengers) : base(x, y, z, price, speed, year)
    {
        this.height = height;
        this.passengers = passengers;
    }

    public void Print()
    {
        base.Print();
        Console.WriteLine($"Вес:{height}кг Кол-во пассажиров:{passengers}");
    }
}

class Car : vehicle
{
    public Car(int x, int y, int z, long price, int speed, int year) : base(x, y, z, price, speed, year) { }
    public void Print()
    {
        base.Print();
    }
}

class Ship : vehicle
{
    private int passengers;
    private string port;
    public Ship(int x, int y, int z, long price, int speed, int year, int passengers, string port) : base(x, y, z, price, speed, year)
    {
        this.passengers = passengers;
        this.port = port;
    }

    public void Print()
    {
        base.Print();
        Console.WriteLine($"Кол-во пассажиров:{passengers} Название порта:{port}");
    }
}

namespace Task2
{
    public class Program
    {
        static void Main()
        {
            Plane plane = new Plane(55, 36, 151, 190000000, 650, 2000, 600000, 600);
            plane.Print();
            Console.WriteLine("");
            Car car = new Car(32, 4, 151, 3000000, 150, 2003);
            car.Print();
            Console.WriteLine("");
            Ship ship = new Ship(68, 33, 36, 8075000000, 60, 1999, 5000, "Мурманск");
            ship.Print();
        }
    }
}