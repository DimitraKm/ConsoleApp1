namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            goblini g1 = new goblini("Asparuh", 16543, 16, 4);
            goblini g2 = new goblini("Galena", 83743, 15, 6);
            goblini g3 = new goblini("Stefka", 47293, 16, 5);

            Console.WriteLine(g1.Name + " " + g1.ID + " " + g1.Age + " " + g1.Grade);
            Console.WriteLine(g2.Name + " " + g2.ID + " " + g2.Age + " " + g2.Grade);
            Console.WriteLine(g3.Name + " " + g3.ID + " " + g3.Age + " " + g3.Grade);

            if (g1.Grade > g2.Grade && g1.Grade > g3.Grade)
            {
                Console.WriteLine(g1.Name + " " + g1.ID);
            }
            if (g2.Grade > g1.Grade && g2.Grade > g3.Grade)
            {
                Console.WriteLine(g2.Name + " " + g2.ID);
            }
            if (g3.Grade > g1.Grade && g3.Grade > g2.Grade)
            {
                Console.WriteLine(g3.Name + " " + g3.ID);
            }
        }
    }
}