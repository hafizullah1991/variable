namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string position = "Software Engineer";

            int num = 2;
            char B= 'A';
            bool isTrue = true;
            double year = 0.5;
            decimal netWorth = 1.5m;
            Console.WriteLine($"My biggest dream is to be {position}," +
                $" in next {num} months , in next {year} year I want to " +
                $"work for Google \n, and my net worth well be {netWorth} million dollars\n" +
                $" , it's all {isTrue} also I want to be {B} plus" );
        }
    }
}
