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
            for (int i = 0;i < tomb.Length; i++)
            {
                Console.WriteLine($"A(z) {i + 1}. szám: {tomb[i]}");
            }
        }
        static void Main(string[] args)
        {
            feladat1();    
        }
    }
}
