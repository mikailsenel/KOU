using Vize.Employee;

namespace Vize.Passenger;

internal class EnNationalityPassengerBuilder : NationalityPassengerBuilder
{
    public EnNationalityPassengerBuilder()
    {
        _passenger = new Passenger();
    }
    public override void SetNationality()
    {
        _passenger.Nationality = Nationalities.EN;
    }
}
