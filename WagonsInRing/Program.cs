namespace WagonsInRing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int CountWagons = new Random().Next(1000);

            int Position = new Random().Next(CountWagons + 1);

            Console.WriteLine($"Начальные данные: Вагонов - {CountWagons}, Позиция для отсчета - {(CountWagons == 0 ? 0 : Position == 0 ? 1 : Position)}");

            // Создаем поезд с заданным количеством вагонов
            Train train = new Train(CountWagons);
            Observer observer = new Observer(train, Position);

            // Подсчитываем количество вагонов
            int count = observer.CountWagons();

            Console.WriteLine($"Количество вагонов в поезде(вычисленное): {count}");

            Console.ReadKey();
        }
    }
}