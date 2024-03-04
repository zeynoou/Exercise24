namespace Exercise24
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please write somthing:");
            string a = Console.ReadLine();
            var result = FindWords(a);
            Console.WriteLine(result);
        }

        public static string FindWords(string a)
        {
            if (a.Contains("bomb") || a.Contains("BOMB") || a.Contains("Bomb"))
                return "Duck";
            else
                return "There is no bomb, Relax";
        }
    }

}