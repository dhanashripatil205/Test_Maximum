using TestMaxNumOf3Var;

namespace TestMAxNumOf3Var
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("****** Welcome to Find the Max Num of 3 Variables Program ******");

            int num = FindMax<int>.MaxNumber(99, 48, 28);
            Console.WriteLine("The greater Integer number is : " + num);

        }
    }
}