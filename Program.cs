using TestMaxNumOf3Var;

namespace TestMAxNumOf3Var
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("****** Welcome to Find the Max Num of 3 Variables Program ******");

            int X = 9;
            int Y = 22;
            int Z = 35;

            int obj = FindMax<int>.MaxOfString(X, Y, Z);
            Console.WriteLine("The greater Int Num is " + obj);

            float A = 8.3F;
            float B = 3.4F;
            float C = 1.2F;

            float val = FindMax<float>.MaxOfString(A, B, C);
            Console.WriteLine("The greater Float Num  is " + val);


            string L = "Apple";
            string M = "Peach";
            string N = "Banana";

            string val7 = FindMax<string>.MaxOfString(L, M, N);
            Console.WriteLine("The greater String is " + val7);
        }
    }
}