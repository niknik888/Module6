

using System;
using System.Drawing;

namespace Module6
{
    //class Program
    //{
    //static void Main(string[] args) { }

    // Task 6.2.2
    //---------------
    // Добавьте в класс Pen, указанный ниже, 2 конструктора:
    // - без параметров, когда поля color и cost заполняются значениями Черный и 100.
    // - с 2 параметрами: penColor и penCost.
    //---------------
    /*
    public class Pen
    {
        public string color;
        public int cost;

        public Pen()
        {
            color = "Черный";
            cost = 100;
        }

        public Pen(string penColor, int penCost)
        {
            color = penColor;
            cost = penCost;
        }
    }
    */

    // Task 6.2.8
    //---------------
    // Создайте класс Rectangle для представления прямоугольников удовлетворяющий следующим требованиям:
    // Класс должен содержать целочисленные поля для сторон a и b.
    // Класс должен содержать метод Square, возвращающий площадь прямоугольника (произведение сторон).
    // Класс должен содержать 3 конструктора: с 2 параметрами, когда a != b, с 1 параметром, когда a == b, и конструктор без параметров по умолчанию, в котором стороны будут заполняться как a = 6, b = 4.
    //---------------
    /*
    public class Rectangle
    {
        int a;
        int b;
        public Rectangle(int xA, int xB)
        {
            a = xA;
            b = xB;
        }

        public Rectangle(int xA)
        {
            a = xA;
            b = a;
        }

        public Rectangle() 
        {
            a = 6;
            b = 4;
        }

        public int Square()
        {
            return a * b;            
        }
    */

    // Task 6.3.1
    //---------------
    // Напишите такой код, который бы при типе компании, равному типу "Банк", и городе "Санкт-Петербург"
    // выводил в консоль сообщение "У банка ??? есть отделение в Санкт-Петербурге", где вместо "???" выводилось бы название компании.
    // Если у компании нет названия, вместо него должно быть "Неизвестная компания".
    //---------------
    /*
    class Company
    {
        public string Type;
        public string Name;
    }

    class Department
    {
        public Company Company;
        public City City;
    }

    class City
    {
        public string Name;
    }
    class Program
    {
        static void Main(string[] args)
        {
            var department = GetCurrentDepartment();
        }

        static Department GetCurrentDepartment()
        {   
            var departament = new Department();

            if (departament?.Company?.Type == "Банк" && departament?.City?.Name == "Санкт-Петербург")
            {
                Console.WriteLine("У банка {0} есть отделение в Санкт-Петербурге", departament?.Company?.Name ?? "Неизвестная компания");
            }
            return departament;
        }
    }
    */

    // Task 6.3.2
    //---------------
    // Для класса Bus реализуйте метод PrintStatus, который будет сообщать о количестве пассажиров в автобусе, если они есть.
    // Или сообщать, что автобус пуст.
    //---------------
    /*
    class Bus
    {
        public int? Load;

        public void PrintStatus()
        {
            if (Load != null)
            {
                Console.WriteLine($"{Load} people in bus.");
            }
            else 
            {
                Console.WriteLine("Bus is entity.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Bus bus = new Bus();
            bus.PrintStatus();
        }
    }
    */

    // Task 6.5.2
    //---------------
    // Опишите классы C# для следующих геометрических объектов: треугольник, круг, квадрат.
    // В классах нужно объявить поля для длин сторон(радиус) и методы для получения площади и периметра(длины окружности) без их реализации и без конструкторов.
    //---------------
    /*
    class Triangle
    {
        public double a;
        public double b;
        public double c;
        public double h;

        void square()
        {
            double s = 0.5 * a * h;
        }

        void perimeter() 
        {
            double p = a + b + c;
        }
    }

    class Circle
    {
        public double r;
        public double pi = 3.14;

        void square()
        {
            double s = pi * r * r;
        }

        void perimeter()
        {
            double p = 2 * pi * r;
        }
    }

    class Box
    {
        public double a;

        void square()
        {
            double s = a * a;
        }

        void perimeter()
        {
            double p = 2 * (a + a);
        }
    }
    */
    // Task 6.6.1
    //---------------
    // Напишите класс светофор(TrafficLight) с 2 методами:
    // Закрытый метод ChangeColor, принимающий 1 строковый параметр color.
    // Открытый метод GetColor, который не принимает параметры, но выдает строковое значение цвета.
    // Методы реализовывать не нужно.
    //---------------
    /*
    class TrafficLight
    {
        private void ChangeColor(string color)
        { 
        }

        public string GetColor()
        {
        }
    }
    */
    // Task 6.6.2
    //---------------
    // Добавьте в класс User из примера выше свойства для логина и почты:
    // Поле логина должно быть не менее 3 символов длиной.
    // Поле почты должно содержать знак @.
    //---------------

    class User
    {
        private int age;
        private string login;
        private string email;
        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Возраст должен быть не меньше 18");
                }
                else
                {
                    age = value;
                }
            }
        }

        public string Login
        {
            get
            {
                return login;
            }
            set
            { 
                if (value.Length < 3)
                {
                    Console.WriteLine("Логин должен быть не менее 3х символов");
                }
                else 
                { 
                    login = value;
                }
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                if (value.Contains('@') == false )
                {
                    Console.WriteLine("Емаил должен содержать символ @");
                }
                else
                {
                    email = value;
                }
            }
        }


    }


}



