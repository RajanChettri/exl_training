namespace Day5
{

    // Inheritance 
    // What is Inheritance ?
    // Inheritance Refers the Practice of Acquiring the Members of Base class in 
    // derived Class

    class Father
    {
       public void foodHabit()
        {
            Console.WriteLine("I Like Salty");
        }
    }
    class Son : Father
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Son gopal = new Son();
            gopal.foodHabit();
        }
    }
}