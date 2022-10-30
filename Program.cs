namespace Girafee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number 1: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter a number 2: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n\n");
            Console.WriteLine(num1 + num2);

            //  Console.ReadLine(); if needed pause the console(screen)



            // mad lib
            string color;
            string pluralNoun;
            string celebrity;

            Console.Write("Enter a color: ");
            color = Console.ReadLine();


            Console.Write("Enter a plural noun: ");
            pluralNoun = Console.ReadLine();

            Console.Write("Enter a celebrity: ");
            celebrity = Console.ReadLine();



            Console.WriteLine("Roses are " + color);

            Console.WriteLine( pluralNoun  + " are blue");
            Console.WriteLine("I love " + celebrity);


        }
    }
}