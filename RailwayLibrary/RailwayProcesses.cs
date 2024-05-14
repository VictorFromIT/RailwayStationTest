using RailwayLibrary.Classes;
using System.Collections.ObjectModel;

namespace RailwayLibrary
{
	public class RailwayProcesses
	{
		//Метод заполнения данных
		public static List<Park> GetParks(Segments ls)
		{
			//Cписки индексов отрезков для каждого из путей
			var lisfWay1 = new List<int>() { 3 };
			var lisfWay2 = new List<int>() { 7, 8 };
			var lisfWay3 = new List<int>() { 15, 16, 17 };

			//Создание и заполнение 3-х путей
			var way1 = new Way("Путь 1", ls.SegmentsList.Where(x => lisfWay1.Contains(x.Index)).ToList());
			var way2 = new Way("Путь 2", ls.SegmentsList.Where(x => lisfWay2.Contains(x.Index)).ToList());
			var way3 = new Way("Путь 3", ls.SegmentsList.Where(x => lisfWay3.Contains(x.Index)).ToList());

			//Создание и заполнение парков
			var park1 = new Park("Парк 1", new List<Way> { way2, way3 });
			var park2 = new Park("Парк 2", new List<Way> { way1, way2 });

			//Заполнение списка парков
			return new List<Park>
			{
				park1,
				park2
			};
		}

		//Метод вывода в виде списка доступных парков
		public static List<List<string>> ViewRailways(List<Park> parks)
		{
			var peaks = new List<string>();
			var parkPeaks = new List<List<string>>();
			foreach (var park in parks)
			{
				Console.WriteLine("\nДоступен парк: {0}", park.Name);
				Console.WriteLine("Список вершин, описывающих парк:");
				foreach (var way in park.Ways)
				{
					foreach (var segment in way.Segments)
					{
						Console.WriteLine("[{0}]", segment.StartPoint.Name);
						peaks.Add(segment.StartPoint.Name);
					}
				}
				//Заполняет список вершин для парка и очищает список
				parkPeaks.Add(new List<string>(peaks));
				peaks.Clear();
			}
			return parkPeaks;
		}

		// Метод для нахождения кратчайшего пути
		public static List<Segment> FindShortestPath(List<Segment> segments, string start, string end)
		{
			// Создаем словарь для хранения предшественников каждой вершины
			Dictionary<string, string> predecessors = new Dictionary<string, string>();

			// Очередь для обхода в ширину
			Queue<string> queue = new Queue<string>();
			queue.Enqueue(start);

			// Начальная вершина без предшественника
			predecessors[start] = "\0";

			// Пока очередь не пустая
			while (queue.Count > 0)
			{
				string current = queue.Dequeue();

				// Если достигнута конечная вершина, завершаем поиск
				if (current == end)
				{
					break;
				}

				// Поиск смежных вершин
				foreach (var segment in segments)
				{
					if (segment.StartPoint.Name == current && !predecessors.ContainsKey(segment.EndPoint.Name))
					{
						queue.Enqueue(segment.EndPoint.Name);
						predecessors[segment.EndPoint.Name] = segment.StartPoint.Name;
					}
					else if (segment.EndPoint.Name == current && !predecessors.ContainsKey(segment.StartPoint.Name))
					{
						queue.Enqueue(segment.StartPoint.Name);
						predecessors[segment.StartPoint.Name] = segment.EndPoint.Name;
					}
				}
			}

			// Восстановление пути
			List<Segment> shortestPath = new List<Segment>();
			string currentVertex = end;

			//Проверка на существование пути
			if (!predecessors.ContainsKey(currentVertex))
			{
				Console.WriteLine("Пути не существует.");
				return null;
			}
			while (currentVertex != "\0")
			{
				string predecessor = predecessors[currentVertex];
				shortestPath.Insert(0, new Segment(1, new Point(1, predecessor, 1, 1), new Point(1, currentVertex, 1, 1)));
				currentVertex = predecessor;
			}

			return shortestPath;
		}
	}
}
