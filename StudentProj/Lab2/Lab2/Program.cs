namespace lab_1
{
    internal class Program
    {
        static void Main()
        {
            string gameVersion = "1.41-beta";
            ushort playersCount = 129;
            int maxPlayersCount = 200;
            ushort ping = 76;
            
            Console.WriteLine("Добро пожаловать на сервер");
            Console.WriteLine($"Версия игры: {gameVersion}");
            Console.WriteLine($"Количество игроков: {playersCount} из {maxPlayersCount}");
            Console.WriteLine($"Пинг сервера: {ping}");
        }
    }
}
