// See https://aka.ms/new-console-template for more information
using Week1_IntroductionToClasses;
using Week2_InheritanceAndPolymorphism;
using Week2_InheritanceAndPolymorphism.Example3;

//Point <= Circle <= Sphere <= Cylinder <= Cone


List<Point> shapes = new List<Point>(); //will allow us to store any object of type Point or of any classes which
                                        //inherit from Point i.e.Circle/Sphere/Cylinder
int choice = 9;
do
{
    Console.ResetColor();
    Console.Clear();
    Console.WriteLine("1. Add new shape");
    Console.WriteLine("2. Print details");
    Console.WriteLine("3. Find Areas of all shapes");
    Console.WriteLine("4. Find Perimeters of all shapes");
    Console.WriteLine("5. Find Volumes of all shapes");
    Console.WriteLine("9. Quit");

    Console.WriteLine("Enter choice: ");

    //int choice = int.Parse(Console.ReadLine());
    choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1: //Adding a new shape
            Console.Clear();
            Console.WriteLine("Choose from these shapes");
            Console.WriteLine("1. Point");
            Console.WriteLine("2. Circle");
            Console.WriteLine("3. Sphere");
            Console.WriteLine("4. Cylinder");
            Console.WriteLine("5. Cone");
            Console.WriteLine("Enter choice: ");
            int shape = int.Parse(Console.ReadLine());

            switch (shape)
            {
                case 1: //adding a new point
                    Console.Clear();
                    Console.WriteLine("Input x");
                    int x = int.Parse(Console.ReadLine());
                    Console.WriteLine("Input y");
                    int y = int.Parse(Console.ReadLine());
                    Console.WriteLine("Write the name of the color");
                    ConsoleColor color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), Console.ReadLine());

                    Point p = new Point(x, y, color);
                    shapes.Add(p);
                    break;

                case 2: //adding a circle

                    Console.Clear();
                    Console.WriteLine("Input x");
                    x = int.Parse(Console.ReadLine());
                    Console.WriteLine("Input y");
                    y = int.Parse(Console.ReadLine());
                    Console.WriteLine("Write the name of the color");
                    color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), Console.ReadLine());

                    Console.WriteLine("Input radius for circle");
                    double radius = double.Parse(Console.ReadLine());


                    Circle c = new Circle(x, y, radius, color);
                    shapes.Add(c);

                    break;

                case 3: //adding a circle

                    Console.Clear();
                    Console.WriteLine("Input x");
                    x = int.Parse(Console.ReadLine());
                    Console.WriteLine("Input y");
                    y = int.Parse(Console.ReadLine());
                    Console.WriteLine("Write the name of the color");
                    color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), Console.ReadLine());

                    Console.WriteLine("Input radius for circle");
                    radius = double.Parse(Console.ReadLine());


                    Sphere sp = new Sphere(x, y, 1, radius, color);
                    shapes.Add(sp);

                    break;
            }
            break;

        case 2: //Printing details of saved shapes i.e. calling the Draw()
                //when traversing a list of objects (inheriting from each other) go for the base type in the foreach
            foreach (Point p in shapes)
            {
                Console.WriteLine(p.Draw());
                Console.WriteLine("-----------------------------------");
                Console.WriteLine();
            }
            break;
        case 3:
            //find areas of shapes
            //Point <= Circle <= Sphere ...
            //note: Circle is a Point because it inherits from Point
            //      but Point is not a circle because Point does not inherit from Circle
            foreach (Point s in shapes)
            {
                if (s is Circle)
                {
                    Circle myCircle = (Circle)s; //type-casting
                    
                    Console.WriteLine($"Area of shape {myCircle.GetType().Name} " +
                        $"with radius {myCircle.Radius} is " + myCircle.FindArea());
                }
            }

            break;
        default:
            break;
    }

    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Press any key to continue...");
    Console.ReadKey();

} while (choice != 9);

   


