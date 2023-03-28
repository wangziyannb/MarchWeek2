using System.Text;
using ConsoleAppD2.Abstraction;

namespace ConsoleAppD2;

class Program
{
    public static void Main()
    {
        // Stringbuilder
        // Garbage Collector

        string str = "hello";
        str = "a1";
        //str[5] = 'W';
        str += " another thing attached";

        // str = "hello another string attached";
        str = str + " a3";

        StringBuilder stringBuilder = new StringBuilder("Hello World");

        stringBuilder[0] = 'W';
        Console.WriteLine(stringBuilder);

        //List
        var emp = new Employee(3);
        emp.Id = 4;

        var fullEmp = new FullTime(1, "Sam", "Sam@Sam.com");
        fullEmp.DoWork();
        Console.WriteLine(  "------------------------");
        Console.WriteLine( emp.DoWork("Dishes") );
        Console.WriteLine( fullEmp.DoWork("Dishes") );

        //var shapeInst = Shapes();

        //Boxing and unboxing
        //Wrap a value type into a reference type
        int box = 0;

        object ob = (object)box; //heap

        int unbox = (int)ob;

        //upcasting
        //Parent is limited to the declarations made in the parent class not the child class
        Shapes shape = new Square();
        var shapeSq = (Square)shape;

        IArithmetic arithmetic = new Arithmetic();


        Employee emp1 = new Employee();
        Employee empfull = new FullTime();
        FullTime fulFull = new FullTime();
        Console.WriteLine("-----------------------");
        emp1.Hiding();
        empfull.Hiding();
        fulFull.Hiding();

        Console.WriteLine("------------------------");
        Console.WriteLine(emp1.DoWork("Dishes"));
        Console.WriteLine(empfull.DoWork("Dishes"));
        Console.WriteLine(fulFull.DoWork("Dishes"));

        // ICar car = new Honda();
        // ICar car2 = new Kia();
        IArithmetic arithmetic2 = new Arithmetic();
        IArithmetic arithmetic3 = new AnotherArithmetic();

        IArithmetic result = ReturnsArithObject(1);

        if(result is Arithmetic)
        {
            Console.WriteLine("The upcasted object was Arithmetic");
            
        }
    }

    // Factory Design Pattern
    public static IArithmetic ReturnsArithObject(int i)
    {
        switch (i)
        {
            case (1):
                return new AnotherArithmetic();
                break;
            default:
                return new Arithmetic();
                break;
        }

        Console.WriteLine( Arithmetic.MathHelper(100, 10000));
        int recieved = Arithmetic.Qwerty;
        Arithmetic.Qwerty = 1;
        

    }

    // Static:
    // Belongs to the class level meaning it becomes an available global instance
    // We can access static methods without making an instance of these classes.

    // Static Constructors, Extention Methods
}