using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vize.Employee;

internal class Pilot : AircraftEmployee
{
    public override string Name { get; set; }
    public override string Surname { get; set; }
    public override int Age { get; set; }
    public override void IncreaseAge()
    {
        Age += 1;
    }
    public override void ProcessRequest(int izinGunSayisi)
    {
        Console.WriteLine(String.Format("Permission granted by {0}.", this.Name));
    }
}
