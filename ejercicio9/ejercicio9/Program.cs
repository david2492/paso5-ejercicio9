using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


/*9.En el restaurante CARBÓN Y SABOR requiere un programa que permita
hallar el plato más costoso y más barato así:
● Por teclado se debe solicitar la cantidad de platos a valorar. (ejemplo si
digita 5 deberá repetir los pasos siguientes 5 veces)
● Se requiere captura por teclado del nombre y valor del plato (siendo el
valor un número entero).
● Se debe calcular e imprimir en consola el nombre y valor del plato más
costoso y el nombre y valor del plato más barato.*/


namespace tienda
{
    class Program
    {

        static void Main(string[] args)
        {
            int valMax = 0; int valMin = 0;
            string nomPrecioMax = "", nomPrecioMin = "";

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("*************************************");
            Console.WriteLine("CARBÓN Y SABOR");
            Console.WriteLine("*************************************");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("-----------------------------------------");
            System.Console.WriteLine("INGRESA EL NUMERO DE PLATOS A INGRESAR:");
            System.Console.WriteLine("-----------------------------------------");
            int cantProductos = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= cantProductos; i++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                System.Console.WriteLine("-----------------------------------------");
                System.Console.WriteLine("INGRESA EL NOMBRE DEL PLATO No {0}", i);
                System.Console.WriteLine("-----------------------------------------");
                string nomproductos1 = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.Cyan;
                System.Console.WriteLine("-----------------------------------------");
                System.Console.WriteLine("INGRESA EL VALOR DEL PLATO No {0}", i);
                System.Console.WriteLine("-----------------------------------------");
                int totalValor = Convert.ToInt32(Console.ReadLine());


                NomProductos result1 = new NomProductos();
                string Resultproductos = result1.igu(nomproductos1);


                valProducto result2 = new valProducto();
                int ResultValor = result2.igu(totalValor);

                if (i == 1)
                {

                    valMax = ResultValor;
                    valMin = ResultValor;
                }
                if (ResultValor > valMax)
                {
                    nomPrecioMax = Resultproductos;
                    valMax = ResultValor;
                }
                if (ResultValor < valMin)
                {
                    nomPrecioMin = Resultproductos;
                    valMin = ResultValor;
                }

                




            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("**************************************************************");
            Console.WriteLine("EL PLATO MAS COSTOSO ES " + nomPrecioMax + " CON UN VALOR DE: " + valMax);
            Console.WriteLine("************************************************");
            Console.WriteLine("EL PLATO MAS BARATO ES " + nomPrecioMin + " CON UN VALOR DE: " + valMin);
            Console.WriteLine("***************************************************************");
            Console.WriteLine("precione una tecla para salir....");



        }

        class NomProductos
        {
            private string producto;


            public string igu(string aproducto)
            {
                producto = aproducto;


                return producto;

            }
        }

        class valProducto
        {
            private int valor;


            public int igu(int aValor)
            {
                valor = aValor;




                return valor;

            }
        }

    }
}
