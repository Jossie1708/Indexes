namespace indexes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Testing the information
            Students st = new Students("st0111@gmail.come", "ST0111", "BCAD", "Reece", "Smith");
            st[2] = "Chad";
            Console.WriteLine(st[0]);
            Console.WriteLine(st[1]);
            Console.WriteLine(st[2]);
            Console.WriteLine(st[3]);
            Console.WriteLine(st[4]);
            st["email"] = "st0222@gmail.come";
            Console.WriteLine("Employee Student Number: " + st["stNumber"]);
            Console.WriteLine("Employee Degree: " + st["degree"]);
            Console.WriteLine("Employee Name: " + st["name"]);
            Console.WriteLine("Employee Surname: " + st["surname"]);
            Console.WriteLine("Employee Email: " + st["email"]);
        }
    }
}
