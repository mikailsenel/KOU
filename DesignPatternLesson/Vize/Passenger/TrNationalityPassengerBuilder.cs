namespace Vize.Passenger;

internal class TrNationalityPassengerBuilder : NationalityPassengerBuilder
{
    public TrNationalityPassengerBuilder()
    {
        _passenger = new Passenger();
    }
    public override void SetNationality()
    {
        _passenger.Nationality = Nationalities.TR;
    }
}
