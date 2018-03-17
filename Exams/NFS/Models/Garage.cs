using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Garage
{
    public IList<Car> ParkedCars { get; set; } = new List<Car>();
}