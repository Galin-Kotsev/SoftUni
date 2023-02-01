namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
            //Person person 
                //= new Person("Peter", 20);
            //Person person2 
               // = new Person("George", 19);
            //Person person3 
                //= new Person("Jose", 43);
                
           
            int n = int.Parse(Console.ReadLine());

            Family family = new Family();

            for (int i = 0; i < n; i++)
            {
                family.AddMember();
            }

            family.GetOldestMembers();
        }
    }

}