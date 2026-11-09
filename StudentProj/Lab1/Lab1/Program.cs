namespace Lab1;

internal class Program
{
    public static void Main()
    {
        Console.WriteLine("Создайте свой профиль");
        Console.Write("Введите ваш имя: ");
        string name = Console.ReadLine(); //имя
        Console.Write("Введите ваш возраст: ");
        int age = int.Parse(Console.ReadLine()); //возраст
        Console.Write("Введите ваш пол: ");
        string gender = Console.ReadLine(); //пол
        Console.Write("Расскажите о себе: ");
        string about = Console.ReadLine(); //о себе

        // финальный профиль
        Console.WriteLine("........................................................................................................................");
        Console.WriteLine("........................................................................................................................");
        Console.WriteLine("........................................................................................................................");
        Console.WriteLine($"Имя: {name}");
        Console.WriteLine($"Возраст: {age}");
        Console.WriteLine($"Пол: {gender}");
        Console.WriteLine($"О себе: {about}");
    }
}

