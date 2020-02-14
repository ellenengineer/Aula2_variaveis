using System;

namespace Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            clsExercicio objExercicio = new clsExercicio();

            Console.WriteLine("Exercicio 1 : " + objExercicio.Expressao());

            Console.WriteLine("Exercicio 2 : " + objExercicio.IsInt(4));

            int numero = 15;
            Console.WriteLine("Exercicio 3 : " + objExercicio.ParOuImpar(numero));


        }
    }

    class clsExercicio
    {
        public  double  Expressao()
        {
            int var1 = 9;
            int var2 = 3;
            double var3 = 5.6;

            return var1 / var2 + var2 * var3;
        }

        public bool IsInt(object obj)
        {
            int resultado = 0;

            string retorno = obj != null ? obj.ToString() : "A";
            return int.TryParse(retorno, out resultado);

        }

        public string ParOuImpar(int Numero)
        {
            string resultado = Numero % 2 == 0 ? "Par" : "Impar";
            return resultado;

        }
    }
}
