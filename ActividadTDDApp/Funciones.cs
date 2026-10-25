using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ActividadTDDApp
{
    public class Funciones
    {

        public static long CalcularFactorial(int numero)
        {
            //Si el número es negativo, dev -1. 
            if (numero < 0)
                return -1;

            long resultado = 1;
            //Calcula directamente * 2. 
            //Si el número es 0, no entra en el bucle y dev 1. 
            for (int i = 2; i <= numero; i++)
            {
                resultado *= i;
            }

            return resultado;
        }

        public static bool EsContrasenyaValida(string? contrasenya)
        {
            throw new NotImplementedException();
        }
    }
}
