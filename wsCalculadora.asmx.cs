using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace calculadora_tarea
{
    /// <summary>
    /// Descripción breve de wsCalculadora
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsCalculadora : System.Web.Services.WebService
    {

        [WebMethod(Description = "CALCULADORA - ACTIVIDAD")]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        [WebMethod(Description = "Suma de dos numeros")]
        public double Sumar(double nro1, double nro2)
        {
            return nro1 + nro2;
        }

        [WebMethod(Description = "Resta de dos numeros")]
        public double Restar(double nro1, double nro2)
        {
            return nro1 - nro2;
        }

        [WebMethod(Description = "Producto de dos numeros")]
        public double Multiplicar(double nro1, double nro2)
        {
            return nro1 * nro2;
        }

        [WebMethod(Description = "Division de dos numeros")]
        public double Dividir(double nro1, double nro2)
        {
            return nro1 / nro2;
        }

        /////////
        private double fact(double n)
        {
            if (n == 0) return 1;
            else return n * fact(n - 1);
        }
        [WebMethod(Description = "Factorial de un numero")]
        public double Factorial(double n)
        {
            return fact(n);
        }

        /////////
        private double potenciaB(double a, double b)
        {
            double rpta = 1;
            while (b >= 1)
            {
                rpta = rpta * a;

                b = b - 1;
            }
            return rpta;

        }

        [WebMethod(Description = "Potencia")]
        public double potencia(double a, double b)

        {
            return potenciaB(a, b);

        }

        /////////SENO
        private double SenoB(double angulo)
        {
            angulo = angulo * Math.PI / 180;
            return (int)Math.Sin(angulo);
        }

        [WebMethod(Description = "Seno")]
        public double Seno(double angulo)
        {
            return SenoB(angulo);

        }


        /////////   tangente
        private double TangenteB(double angulo)
        {
            angulo = angulo * Math.PI / 180;
            return (int)Math.Tan(angulo);
        }

        [WebMethod(Description = "Tangente")]
        public double Tangente(double angulo)
        {
            return TangenteB(angulo);

        }


        /////////   Raiz cudrada
        private double RaizCuadradaB(double numero)
        {
            numero = Math.Sqrt(numero);
            return (numero);
        }

        [WebMethod(Description = "Raiz Cuadrada")]
        public double RaizCuadrada(double numero)
        {
            return RaizCuadradaB(numero);

        }

        /////////   Raiz Nsima
        private double RaizEnesimaB(double numero, double raiz)
        {
            numero = Math.Pow(numero, 1.0 / raiz);
            return (numero);
        }

        [WebMethod(Description = "Raiz Enesima")]
        public double RaizEnesima(double numero, double raiz)
        {
            return RaizEnesimaB(numero, raiz);

        }
        /////////   Inversa
        private double numinversob(double numero)
        {
            numero = 1 / numero;
            return (numero);
        }

        [WebMethod(Description = "Inversa")]
        public double numinverso(double numero)
        {
            return numinversob(numero);

        }
    }
}