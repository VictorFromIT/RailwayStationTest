using RailwayLibrary;
using RailwayLibrary.Classes;


namespace RailwayStation.Tests
{
	[TestClass]
	public class RailwayStationTests
	{
		[TestMethod]
		public void FindShortestPath_FromA1ToB1_ReturnsCorrectPath()
		{
			// ��������
			List<Segment> segments = new List<Segment>
			{
				new Segment(1, new Point(1,"A1",1,1), new Point(2,"A2",1,1)),
				new Segment(2, new Point(2,"A2",1,1), new Point(3,"A3",1,1)),
				new Segment(3, new Point(3,"A3",1,1), new Point(4,"A4",1,1)),
				new Segment(4, new Point(5,"B1",1,1), new Point(6,"B2",1,1)),
				new Segment(5, new Point(3,"A3",1,1), new Point(5,"B1",1,1)),
			};

			string start = "A1";
			string end = "B1";

			// ���������� ������
			var shortestPath = RailwayProcesses.FindShortestPath(segments, start, end);

			// ��������
			Assert.AreEqual(4, shortestPath.Count);
			Assert.AreEqual("A1", shortestPath[1].StartPoint.Name);
			Assert.AreEqual("A2", shortestPath[1].EndPoint.Name);
			Assert.AreEqual("A2", shortestPath[2].StartPoint.Name);
			Assert.AreEqual("A3", shortestPath[2].EndPoint.Name);
			Assert.AreEqual("A3", shortestPath[3].StartPoint.Name);
			Assert.AreEqual("B1", shortestPath[3].EndPoint.Name);
		}

		[TestMethod]
		public void FindShortestPath_FromB1ToA1_ReturnsCorrectPath()
		{
			// ��������
			List<Segment> segments = new List<Segment>
			{
				new Segment(1, new Point(1,"A1",1,1), new Point(2,"A2",1,1)),
				new Segment(2, new Point(2,"A2",1,1), new Point(3,"A3",1,1)),
				new Segment(3, new Point(3,"A3",1,1), new Point(4,"A4",1,1)),
				new Segment(4, new Point(5,"B1",1,1), new Point(6,"B2",1,1)),
				new Segment(5, new Point(3,"A3",1,1), new Point(5,"B1",1,1)),
			};

			string start = "B1";
			string end = "A1";

			// ���������� ������
			var shortestPath = RailwayProcesses.FindShortestPath(segments, start, end);

			// ��������
			Assert.AreEqual(4, shortestPath.Count);
			Assert.AreEqual("B1", shortestPath[1].StartPoint.Name);
			Assert.AreEqual("A3", shortestPath[1].EndPoint.Name);
			Assert.AreEqual("A3", shortestPath[2].StartPoint.Name);
			Assert.AreEqual("A2", shortestPath[2].EndPoint.Name);
			Assert.AreEqual("A2", shortestPath[3].StartPoint.Name);
			Assert.AreEqual("A1", shortestPath[3].EndPoint.Name);
		}

		[TestMethod]
		public void ViewRailways_ReturnCorrectRailways()
		{
			// ��������
			List<Segment> segments = new List<Segment>
			{
				new Segment(1, new Point(1,"A1",1,1), new Point(2,"A2",1,1)),
				new Segment(2, new Point(2,"A2",1,1), new Point(3,"A3",1,1)),
				new Segment(3, new Point(3,"A3",1,1), new Point(4,"A4",1,1)),
				new Segment(4, new Point(5,"B1",1,1), new Point(6,"B2",1,1)),
				new Segment(5, new Point(3,"A3",1,1), new Point(5,"B1",1,1)),
			};
			//C����� �������� �������� ��� ������� �� �����
			var lisfWay1 = new List<int>() { 1 };
			var lisfWay2 = new List<int>() { 2, 3 };
			var lisfWay3 = new List<int>() { 4, 5 };

			//�������� � ���������� 3-� �����
			var way1 = new Way("���� 1", segments.Where(x => lisfWay1.Contains(x.Index)).ToList());
			var way2 = new Way("���� 2", segments.Where(x => lisfWay2.Contains(x.Index)).ToList());
			var way3 = new Way("���� 3", segments.Where(x => lisfWay3.Contains(x.Index)).ToList());

			//�������� � ���������� ������
			var park1 = new Park("���� 1", new List<Way> { way2, way3 });
			var park2 = new Park("���� 2", new List<Way> { way1, way2 });

			//���������� ������ ������
			var parks = new List<Park>
			{
				park1,
				park2
			};

			// ���������� ������
			var parkPeaks = RailwayProcesses.ViewRailways(parks);

			// ��������
			Assert.AreEqual(2, parkPeaks.Count);
			Assert.AreEqual("A2", parkPeaks[0][0]);
			Assert.AreEqual("A3", parkPeaks[0][3]);
			Assert.AreEqual("A1", parkPeaks[1][0]);
			Assert.AreEqual("A3", parkPeaks[1][2]);
		}

		[TestMethod]
		public void GetParks_ReturnCorrectParks()
		{
			// ��������
			Segments ls = new Segments();
			ls.SegmentsList.Clear();
			ls.SegmentsList = new List<Segment>()
			{
				new(1, new Point(1,"A1",1,1), new Point(2,"A2",1,1)),
				new(2, new Point(2,"A2",1,1), new Point(3,"A3",1,1)),
				new(3, new Point(3,"A3",1,1), new Point(4,"A4",1,1)),
				new(4, new Point(5,"B1",1,1), new Point(6,"B2",1,1)),
				new(5, new Point(3,"A3",1,1), new Point(5,"B1",1,1)),
			};

			// ���������� ������
			var parks = RailwayProcesses.GetParks(ls);

			// ��������
			Assert.AreEqual(2, parks.Count);
			Assert.AreEqual("A3", parks[1].Ways[0].Segments[0].StartPoint.Name);
		}
	}
}