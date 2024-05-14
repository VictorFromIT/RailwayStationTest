using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayLibrary.Classes;
internal class Scheme
{
	public List<Point> PointsList { get; set; } = new List<Point>();

	public Scheme()
	{
        // Добавление точек по умолчанию
        PointsList.Add(new Point(1, "A1", 1, 1));
        PointsList.Add(new Point(2, "A2", 1, 1));
        PointsList.Add(new Point(3, "A3", 1, 1));
        PointsList.Add(new Point(4, "A4", 1, 1));
        PointsList.Add(new Point(5, "A5", 1, 1));
        PointsList.Add(new Point(6, "B1", 1, 1));
        PointsList.Add(new Point(7, "B2", 1, 1));
        PointsList.Add(new Point(8, "B3", 1, 1));
        PointsList.Add(new Point(9, "B4", 1, 1));
        PointsList.Add(new Point(10, "B5", 1, 1));
        PointsList.Add(new Point(11, "B6", 1, 1));
        PointsList.Add(new Point(12, "B7", 1, 1));
        PointsList.Add(new Point(13, "C1", 1, 1));
        PointsList.Add(new Point(14, "C2", 1, 1));
        PointsList.Add(new Point(15, "C3", 1, 1));
        PointsList.Add(new Point(16, "C4", 1, 1));
        PointsList.Add(new Point(17, "C5", 1, 1));
        PointsList.Add(new Point(18, "C6", 1, 1));
        PointsList.Add(new Point(19, "C7", 1, 1));
        PointsList.Add(new Point(20, "C8", 1, 1));
    }
}
