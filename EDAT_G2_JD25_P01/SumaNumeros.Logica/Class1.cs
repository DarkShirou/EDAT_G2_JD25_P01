namespace SumaNumeros.Logica
{
    public class Recursivos
    {
        
        public int SumaN(int n)
        {
            if (n <= 1) return n <= 0 ? 0 : 1;
            return SumaN(n - 1) + n;
        }
    }
}