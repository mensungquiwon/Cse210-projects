using System;

namespace MyApp
{
    class Blind
    {
        public double _width;
        public double _height;
        public string _color;
         public double GetArea()
        {

            return _width * _height;
        }
        public Blind()
        {

        }
    public class House
        {
            public string _owner = "";
            public Blind _kitchen = new Blind();
            public Blind _window = new Blind();
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            House quiwonHome = new House();
            quiwonHome._owner = "Quiwon Family";

            quiwonHome._window._width = 120.5;
            quiwonHome._window._height = 200.0;
            quiwonHome._window._color = "Blue";

            double materialAmount1 = quiwonHome._window.GetArea();
            Console.WriteLine($"Window's area: {materialAmount1}cm");
            
            Blind kitchen = new Blind();
            kitchen._width = 150.0;
            kitchen._height = 250.0;
            kitchen._color = "Red";

            double materialAmount = kitchen.GetArea();

            Console.WriteLine($"kitchen's area: {materialAmount}cm");



        }
       }
    }




// class Program
// {
//     static void Main(string[] args)
//     {
//         // Ask user for their name and greet them
//         Console.WriteLine("Hello World! This is the Exercise1 Project.");

//         Console.Write("What is your first name? ");
//         string firstName = Console.ReadLine();
//         Console.Write("What is your last name? ");
//         string lastName = Console.ReadLine(); 

//         Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");  

//     }
// }
