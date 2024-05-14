using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayLibrary.Classes;
public class Segments
{
	public List<Segment> SegmentsList { get; set; } = new List<Segment>();

	public Segments()
	{
        var points = new Scheme();

		// Добавление вершин по умолчанию
		SegmentsList.Add(new(1, points.PointsList[0], points.PointsList[1]));
		SegmentsList.Add(new(2, points.PointsList[1], points.PointsList[2]));
		SegmentsList.Add(new(3, points.PointsList[2], points.PointsList[3]));
		SegmentsList.Add(new(4, points.PointsList[3], points.PointsList[4]));
		SegmentsList.Add(new(5, points.PointsList[5], points.PointsList[6]));
		SegmentsList.Add(new(6, points.PointsList[6], points.PointsList[7]));
		SegmentsList.Add(new(7, points.PointsList[7], points.PointsList[8]));
		SegmentsList.Add(new(8, points.PointsList[8], points.PointsList[9]));
		SegmentsList.Add(new(9, points.PointsList[9], points.PointsList[10]));
		SegmentsList.Add(new(10, points.PointsList[10], points.PointsList[11]));
		SegmentsList.Add(new(11, points.PointsList[7], points.PointsList[14]));
		SegmentsList.Add(new(12, points.PointsList[9], points.PointsList[17]));
		SegmentsList.Add(new(13, points.PointsList[12], points.PointsList[13]));
		SegmentsList.Add(new(14, points.PointsList[13], points.PointsList[14]));
		SegmentsList.Add(new(15, points.PointsList[14], points.PointsList[15]));
		SegmentsList.Add(new(16, points.PointsList[15], points.PointsList[16]));
		SegmentsList.Add(new(17, points.PointsList[16], points.PointsList[17]));
		SegmentsList.Add(new(18, points.PointsList[17], points.PointsList[18]));
		SegmentsList.Add(new(19, points.PointsList[18], points.PointsList[19]));
	}
}
