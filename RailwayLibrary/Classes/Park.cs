using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayLibrary.Classes;
public class Park
{
	public string Name { get; set; }
	public List<Way> Ways { get; set; }
	public Park(string name, List<Way> ways) {
        Name = name;
        Ways = ways;
    }
}
