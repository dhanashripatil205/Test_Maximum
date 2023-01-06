using TestMaxNumOf3Var;

namespace TestMAxNumOf3Var
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("****** Welcome to Find the Max Num of 3 Variables Program ******");

            string X = "Dhanashri";
            string Y = "Vandana";
            string Z = "Patil";

            string val = FindMax<string>.MaxOfString(X, Y, Z);
            Console.WriteLine("The greater String is " + val);
        }
    }
}