using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayLibrary.Classes;
public class Way
{
	public string Name { get; set; }
	public List<Segment> Segments { get; set;}

	public Way(string name, List<Segment> segments) {
        Name = name;
        Segments = segments;
    }
}
