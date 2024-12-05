namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = [ 1, 2, 3, 4, 5, 6, 7, 8, 9 ];

            var myQuery = from num in numbers
                          where num > 5
                          select num;

            numbers.Add(20);

            foreach(int num in myQuery)
            {
                Console.WriteLine(num);
            }
        }
    }
}
