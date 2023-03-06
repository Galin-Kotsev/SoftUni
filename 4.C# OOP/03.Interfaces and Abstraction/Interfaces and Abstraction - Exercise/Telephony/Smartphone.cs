namespace Telephony
{
    public class Smartphone : IPhone,IWeb
    {
        public string Calling(string number)
        {
            return $"Calling... {number} ";
        }
        public string Browsing(string site)
        {
            return $"Browsing: {site}!";
        }
    }
}
