namespace Telephony
{
    public class StationaryPhone : IPhone
    {
        public string Calling(string number)
        {
            return $"Dialing... {number} ";
        }
    }
}
