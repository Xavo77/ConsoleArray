using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] MesesNumero = { 1, 2 ,3,4,5,6,7,8,9,10,11,12};
            string[] MesesNombre = {
                "Enero" ,
                "Febrero",
                "Marzo",
                "Abril",
                "Mayo",
                "Junio",
                "Julio",
                "Agosto",
                "Septiembre",
                "Octubre",
                "Noviembre",
                "Diciembre" };
            Console.WriteLine("El número de Meses contenidos en el arreglo es: "+ MesesNumero.Count());

            Console.WriteLine("Los meses contenidos en el arreglo son: ");

            for (int i = 0; i < MesesNombre.Count(); i++)
            {
                Console.WriteLine("Mes :" + MesesNombre[i]);
            }
            
            Console.ReadLine();
        }
    }
}
