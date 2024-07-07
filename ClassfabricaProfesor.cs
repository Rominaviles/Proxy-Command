using System;
using System.Collections.Generic;
using ClassFabricaComparable;
using ClassGeneradorDatosRandom;
using ClassLectorDatos;
using ClassProfesor;
using Interfaces;

namespace ClassfabricaProfesor
{
    public class FabricaProfesor : FabricaComparables
    {
        private GeneradorDeDatosAleatorios generador;
        private LectorDeDatos lector;

        public FabricaProfesor()
        {
            generador = new GeneradorDeDatosAleatorios();
            lector = new LectorDeDatos();
        }


        public override Comparable crearAleatorio()
        {
            Console.WriteLine("Ingrese la cantidad maxima que desea el texto: ");
            int cant= int.Parse(Console.ReadLine()??"");
            string nombre = generador.stringAleatorio(cant);
            int dni = generador.numeroAleatorio(99999999);
            int antiguedad = generador.numeroAleatorio(50);

            return new Profesor(nombre, dni, antiguedad,true);
        }

        public override Comparable crearPorTeclado()
        {
            string nombre = lector.StringPorTeclado();
            int dni = lector.NumeroPorTeclado();
            int antiguedad = lector.NumeroPorTeclado();

            return new Profesor (nombre, dni, antiguedad,true);
        }
    }
}