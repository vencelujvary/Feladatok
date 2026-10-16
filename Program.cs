namespace Feladatok
{
    internal class Program
    {
        static void feladat1()
        {

            int[] tomb = new int[5];
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.WriteLine($"Kérem a(z) {i+1}. számot: ");
                tomb[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("");
            foreach (int item in tomb)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");
            for (int i = 5; i > 0; i--)
            {
                Console.WriteLine($"A(z) {i}. szám: {tomb[i - 1]}");
            }
            for(int i = 0;i < tomb.Length; i+=2)
            {
                Console.WriteLine(tomb[i]);
            }
            Console.WriteLine("Hanyadik számot kéred?: ");
            int valasz = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Az a: " + tomb[valasz-1]);
        }
        static void Main(string[] args)
        {
            feladat1();    
        }
    }
}
