using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vize.Plane;

namespace Vize.Tower;

internal abstract class Tower
{
    protected void AllowLanding(Plane.Plane plane)
    {
        Console.WriteLine(String.Format("{0} - Allow Landing", plane.AircraftName));

    }

    protected void DoNotAllowLanding(Plane.Plane plane)
    {
        Console.WriteLine(String.Format("{0} - Do Not Allow Landing", plane.AircraftName));
    }

    public abstract void RequestLandingClearance(Plane.Plane plane);

}
