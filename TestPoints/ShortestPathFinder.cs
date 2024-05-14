using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPoints
{
	internal class ShortestPathFinder
	{
		public struct Segment
		{
			public string Start;
			public string End;

			public Segment(string start, string end)
			{
				Start = start;
				End = end;
			}
		}
		// Метод для нахождения кратчайшего пути с помощью BFS
		public static List<Segment> FindShortestPath(List<Segment> segments, string start, string end)
		{
			// Создаем словарь для хранения предшественников каждой вершины
			Dictionary<string, string> predecessors = new Dictionary<string, string>();

			// Очередь для обхода в ширину
			Queue<string> queue = new Queue<string>();
			queue.Enqueue(start);

			// Начальная вершина не имеет предшественника
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
					if (segment.Start == current && !predecessors.ContainsKey(segment.End))
					{
						queue.Enqueue(segment.End);
						predecessors[segment.End] = segment.Start;
					}
					else if (segment.End == current && !predecessors.ContainsKey(segment.Start))
					{
						queue.Enqueue(segment.Start);
						predecessors[segment.Start] = segment.End;
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
				shortestPath.Insert(0, new Segment(predecessor, currentVertex));
				currentVertex = predecessor;
			}

			return shortestPath;
		}

	}
}
