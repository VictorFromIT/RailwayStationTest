using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayLibrary.Classes;
public class Point
{
	public int Index { get; set; }
	public string Name { get; set; }
	public int X { get; set; }
	public int Y { get; set; }
	public Point(int index, string name, int x, int y) {  
		Index = index;
		Name = name;
		X = x; 
		Y = y; 
	}	

}
