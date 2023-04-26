using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vize.Tower;

namespace Vize.Plane;

internal abstract class Plane
{
    protected readonly Tower.Tower _tower;

    public Plane(Tower.Tower tower)
    {
        _tower = tower;
    }

    public abstract int PassengerCapacity { get; set; }
    public abstract decimal LoadingCapacity { get; set; }
    public abstract decimal MaximumSpeed { get; set; }
    public abstract string AircraftName { get; }
    public abstract PlaneTypes Type { get; }

    public abstract void RequestLandingClearance();
}

