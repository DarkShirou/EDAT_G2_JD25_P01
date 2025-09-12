using System;

namespace Recursividad.Logica
{
    public class Recursivos
    {
        
        public int Vocales(string cadena)
        {
            if (string.IsNullOrEmpty(cadena)) return 0;
            return VocalesRec(cadena.ToLower(), 0);
        }

        private int VocalesRec(string cadena, int index)
        {
            if (index >= cadena.Length) return 0;
            char c = cadena[index];
            int suma = ("aeiou".IndexOf(c) >= 0) ? 1 : 0;
            return suma + VocalesRec(cadena, index + 1);
        }

        
        public int SumaDigitos(int numero)
        {
            numero = Math.Abs(numero);
            if (numero == 0) return 0;
            return (numero % 10) + SumaDigitos(numero / 10);
        }

        
        public int SumaN(int n)
        {
            if (n <= 1) return n <= 0 ? 0 : 1;
            return SumaN(n - 1) + n;
        }
    }
}