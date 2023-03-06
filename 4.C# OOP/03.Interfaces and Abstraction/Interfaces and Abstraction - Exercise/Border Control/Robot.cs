namespace BorderControl
{
    public class Robot : IRobot,IIdentifable
    {
        public Robot(string model, string id)
        {
            Model = model;
            Id = id;
        }

        public string Model { get; set; }
        public string Id { get; set; }

        public override string ToString()
        {
            return Id.ToString();
        }
    }
}
