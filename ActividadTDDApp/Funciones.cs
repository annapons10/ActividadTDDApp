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

        //Declaro las variables para usarlas en la función: 
        private const int LONGITUD_MINIMA_CONTRASENYA = 8;
        private const char CARACTER_OBLIGATORIO = '#';

        public static bool EsContrasenyaValida(string? contrasenya)
        {
            //Aqui hago la evaluación de todas las condiciones para que pueda devolv o true o false. 
            return !string.IsNullOrEmpty(contrasenya)
            && contrasenya.Length >= LONGITUD_MINIMA_CONTRASENYA
            && contrasenya.Contains(CARACTER_OBLIGATORIO);
        }
    }
}
