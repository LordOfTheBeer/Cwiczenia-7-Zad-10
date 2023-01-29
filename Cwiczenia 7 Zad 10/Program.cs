namespace Cwiczenia_7_Zad_10
{
    class Funkcje
    {
        public int Zamiana(ref int x)
        {
            return x++ * 2;

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b; 
            Funkcje f1 = new Funkcje();
            b = f1.Zamiana(ref a);
            Console.WriteLine(a);
            Console.WriteLine(b);

        }
    }
}
