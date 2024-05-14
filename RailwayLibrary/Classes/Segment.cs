namespace RailwayLibrary.Classes;

public class Segment
{
    public int Index { get; set; }
    public Point StartPoint { get; set; }
    public Point EndPoint { get; set; }

    public Segment(int index, Point startPoint, Point endPoint) {
        Index = index;
		StartPoint = startPoint;
		EndPoint = endPoint;
    }
}
