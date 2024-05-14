// See https://aka.ms/new-console-template for more information
using static TestPoints.ShortestPathFinder;

Console.WriteLine("Hello, World!");
List<Segment> segments = new List<Segment>
		{
			/*new Segment('A', 'B'),
			new Segment('B', 'C'),
			new Segment('C', 'D'),
			new Segment('C', 'E'),
			new Segment('E', 'F'),
			new Segment('F', 'O'),
			new Segment('O', 'P'),
			new Segment('G', 'K'),
			new Segment('K', 'T'),
			new Segment('K', 'L')*/
			new Segment("A1", "A2"),
			new Segment("A2", "A3"),
			new Segment("A3", "A4"),
			new Segment("A3", "B2"),
			new Segment("B1", "B2"),
		};

string start = "A1";
string end = "B1";

List<Segment> shortestPath = FindShortestPath(segments, start, end);

Console.WriteLine("Кратчайший путь:");
foreach (var segment in shortestPath)
{
	Console.WriteLine($"({segment.Start}, {segment.End})");
}