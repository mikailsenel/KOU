using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vize.Plane;

namespace Vize.Passenger;
internal class Passenger: ProtoTypePassenger
{
    public int Age { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public Genders Gender { get; set; }
    public Nationalities Nationality { get; set; }

    public Passenger(int age, string name, string surname, Genders gender, Nationalities nationality)
    {
        Age = age;
        Name = name;
        Surname = surname;
        Gender = gender;
        Nationality = nationality;
    }
    public Passenger()
    {
        
    }

    public override ProtoTypePassenger Clone()
    {
        return this.MemberwiseClone() as ProtoTypePassenger;
    }
}
