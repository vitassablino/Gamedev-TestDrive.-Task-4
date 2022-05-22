using System;

    internal class Program
    {
        static void Main(string[] args)
        {
        string name, zodiakSign, jobPlace;
        uint age, yearBorn;
        const int yearNow = 2022;
        Console.WriteLine("Как Вас зовут?"); name = Console.ReadLine();
        Console.WriteLine("Сколько вам лет?"); age = Convert.ToUInt16(Console.ReadLine());
        Console.WriteLine("Какой Ваш знак зодиака"); zodiakSign = Console.ReadLine();
        Console.WriteLine("Где Вы работаете?"); jobPlace = Console.ReadLine();
        yearBorn = yearNow - age;
        Console.WriteLine($"\n\nВас зовут {name}.\nВам {age} лет.\nВы родились в {yearBorn} году.\nВаш знак зодиака - {zodiakSign}.\nВы работаете {jobPlace}");
        }
    }
