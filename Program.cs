namespace Feladatok
{
    internal class Program
    {
        static Random r = new Random();
        static void feladat5()
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
            for (int i = tomb.Length-1; i >= 0; i--)
            {
                Console.WriteLine($"A(z) {i}. szám: {tomb[i]}");
            }
            for(int i = 1;i < tomb.Length; i+=2)
            {
                Console.WriteLine(tomb[i]);
            }
            Console.WriteLine("Hanyadik számot kéred?: ");
            int valasz = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Az a: " + tomb[valasz-1]);
        }
        static void feladat14()
        {
            Console.WriteLine("Kérek egy egész számot: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] tomb = new int[N];

            Console.WriteLine("milyen 2 intervallumból töltsük fel a számokat?");
            Console.WriteLine("a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            for (int item = 0; item < N; item++)
            {
                tomb[item] = r.Next(a, b);
            }
            for (int i = 0; i < N; i++) 
            { 
            Console.WriteLine($"A(z){i + 1} szam: {tomb[i]}");
            }
        }
        static void Main(string[] args)
        {
            //feladat5();    
            feladat14();
        }
    }
}
