

//using LibraryForD1;
//using LibraryForD1.DifNameInLibrary;

//Console.WriteLine("hellow world");
//Class1 class1 = new Class1();
//HelperFromLibrary helperFromLibrary = new HelperFromLibrary();

namespace ConsoleDay1;
public class Program
{
    public static void Main()
    {
        //int, char, string, double, float, decimal, bool
        //Strongly typed language, case sensitive
        int i = 0;
        string str = "Hello people";
        char chr = 'a'; //ASCII
        double dub = 3.1423434d;
        decimal deci = 3.142343m;
        float flo = 3.142342f;

        //bool b = true;

        int inte = (int)deci;
        string intToString = Convert.ToString(inte);

        string stringConcat = "" + inte;

        string interpol = $"the value for deci = {deci + 31.23m}";

        var assumption = 'e';

        int qwert;
        qwert = 100;

        //arr can only hold 3 integers in its array
        int[] arr = new int[3];
        arr[0] = 1;

        //arr2 can only hold 4 integers
        var arr2 = new int[] { 1, 2, 3, 4 };
        arr2[3] = 1;

        //arr3
        var arr3 = new int[3] { 1, 2, 3 };

        //Data type is necessary instead of var for arr4 but the right show only contents
        int[] arr4 = { 1, 2, 3 };

        //matrixes
        int[,] arr5 = new int[2, 3];
        //two rows, 3 columns
        int[,] arr6 = { { 1, 2, 3 }, { 4, 5, 6 } };

        //Value vs referece type
        Array.Sort(arr4);

        var lp = new LearningParameters();
        int a = 10;
        int b = 20;
        int result = lp.PassByValue(a, b);
        Console.WriteLine($"a = {a}, b = {b} sum = {a + b} outside function");
        Console.WriteLine();

        int result1 = lp.PassByReference(ref a, ref b);
        Console.WriteLine($"a = {a}, b = {b} sum = {a + b} outside function");

        string msg = "";
        bool result3 = lp.Author("bob", "billy", out msg);
        Console.WriteLine( result3 + " " + msg);

        lp.ParamsLearning(a:1, str :"AnyString", 1, 2, 3, 4, 5, 6, 6, 3, 2, 1, 3, 4); //Actual parameters
    }

    //Classes, OOP including Constructors getters and setters and all of that.
    //Leet Code 1 (Two sum) + Other leetcode questions + Conceptual Questions

    //
}