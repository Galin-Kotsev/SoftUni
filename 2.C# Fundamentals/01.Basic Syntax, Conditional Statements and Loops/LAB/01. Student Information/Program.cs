namespace _01._Student_Information
{
    using System;
    class Program
    {
       
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());

            Console.Write($"Name: {name}, Age: {age}, Grade: {grade:f2}");

        }
    }
}
