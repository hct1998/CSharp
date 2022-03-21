﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPersonas { 
    public partial class Program
{
    static void IngresarPersona()
    {
        string nombre;
        uint telefono;
        double peso;
        double estatura;

        Console.WriteLine("Bievenido al programa ultramente BKN");

        bool esValido;

        do
        {
            Console.WriteLine("Ingrese telefono");
            string tel = Console.ReadLine().Trim();
            esValido = UInt32.TryParse(tel, out telefono);
        } while (!esValido);

        do
        {
            Console.WriteLine("Ingrese peso");
            string pes = Console.ReadLine().Trim();
            esValido = Double.TryParse(pes, out peso);
        } while (!esValido);

        do
        {
            Console.WriteLine("Ingrese estatura");
            string est = Console.ReadLine().Trim();
            esValido = Double.TryParse(est, out estatura);
        } while (!esValido);

        do
        {
            Console.WriteLine("Ingrese nombre");
            nombre = Console.ReadLine().Trim();
        } while (nombre == string.Empty);

        Persona p = new Persona();
        p.Nombre = nombre;

        Console.WriteLine("Nombre: {0}", nombre);
        Console.WriteLine("Telefono : {0}", telefono);
        Console.WriteLine("Peso : {0}", peso);
        Console.WriteLine("Estatura : {0}", estatura);
        Console.WriteLine("IMC es : {0}", peso / (estatura * estatura));
        Console.ReadKey();
    }

        static void MostrarPersona()
        {

        }

        static void BuscarPersona()
        {

        }


}
}

