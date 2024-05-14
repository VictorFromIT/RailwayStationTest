// See https://aka.ms/new-console-template for more information
using RailwayLibrary;
using RailwayLibrary.Classes;

var ls = new Segments();

//Заполнение данных и получение списка парков
var parks = RailwayProcesses.GetParks(ls);

while (true) // Цикл пользовательского интерфейса
{
    Console.WriteLine("Выберите режим: [NumPad1] - отобразить доступные парки, [NumPad2] - поиск кратчайшего пути, [Escape] - закрыть приложение");
    ConsoleKeyInfo keyInfo = Console.ReadKey();

    // Проверяем, была ли нажата клавиша Q для выхода из программы
    if (keyInfo.Key == ConsoleKey.Escape) {
        break; // Выход из цикла при нажатии клавиши Q
    }
    else if (keyInfo.Key == ConsoleKey.NumPad1) {
        //Отображаем доступные парки
        var parkPeaks = RailwayProcesses.ViewRailways(parks);
    }
    else if (keyInfo.Key == ConsoleKey.NumPad2) {
        //Вывод списка всех участков схемы станции
        Console.WriteLine("\nCписок всех участков схемы станции:");
        for (int i = 0; i < ls.SegmentsList.Count; i++) {
            Console.WriteLine("[{0}].[{1},{2}]", ls.SegmentsList[i].Index, ls.SegmentsList[i].StartPoint.Name, ls.SegmentsList[i].EndPoint.Name);
        }

        //Вывод списка путей между выбранными отрезками
        Console.WriteLine("Введите порядковый номер участка начала:");
        int.TryParse(Console.ReadLine(), out int startSegment);

        Console.WriteLine("Введите порядковый номер участка конца:");
        int.TryParse(Console.ReadLine(), out int endSegment);

        //Проверка на непустой список вершин
        string startX = ls.SegmentsList?.FirstOrDefault(x => x.Index == startSegment).StartPoint.Name;
        string endX = ls.SegmentsList?.FirstOrDefault(x => x.Index == endSegment).StartPoint.Name;

        List<Segment> shortestPath = RailwayProcesses.FindShortestPath(ls.SegmentsList, startX, endX);
        if (shortestPath != null) {
            //Очистка начальной вершины
            shortestPath.RemoveRange(0, 1);

            Console.WriteLine("Кратчайший путь:");
            foreach (var segment in shortestPath) 
            {
                Console.WriteLine($"({segment.StartPoint.Name}, {segment.EndPoint.Name})");
            }
        }

    }
}


