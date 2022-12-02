namespace MethodOverloading
{
    public class Program
    {

        public static void Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }

        public static void Add(decimal x, decimal y)
        {
            Console.WriteLine(x + y);
        }

        public static string Add(int x, int y, bool z)
        {
            if (z == true && x + y == 1)
            {
                var answer = x + y;
                return $"{answer} dollar";
            }
            if (z == true)
            {
                var answer = x + y;
                return $"{answer} dollars";
            }
            else
            {
                return $"The bool value is {z}";
            }
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            var answer = Add(1,2,true);
            Console.WriteLine(answer);
        }
    }
}
