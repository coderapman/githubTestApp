namespace githubTestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dette er et testprogram!!
            //

            Console.WriteLine("Hello, World!");
            Console.WriteLine("Dette er en test af github");
            for (int a = 1; a <= 10; a++)
            {
                Console.WriteLine(a);
            }
            Person person = new Person();
            Console.WriteLine($"Mit navn er {person.Name} og jeg er fra {person.City}");
        }
    }
}