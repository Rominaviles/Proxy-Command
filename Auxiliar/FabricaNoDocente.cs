using System;
using System.Collections.Generic;
using ClassFabricaComparable;
using ClassGeneradorDatosRandom;
using ClassLectorDatos;
using Interfaces;
using noDocent;

namespace FabricNoDocente
{
    public class FabricaNoDocente : FabricaComparables
    {
        private GeneradorDeDatosAleatorios generador;
        private LectorDeDatos lector;

        public FabricaNoDocente()
        {
            generador = new GeneradorDeDatosAleatorios();
            lector = new LectorDeDatos();
        }

        public override Comparable crearAleatorio()
        {
            string nombre = generador.stringAleatorio(5);
            int dni = generador.numeroAleatorio(99999999);
            int FechaIngreso = generador.numeroAleatorio(10000);
  
            return new noDocente(nombre, dni, FechaIngreso);
        }
        public override Comparable crearPorTeclado()
        {
            Console.WriteLine("Para nombre:");
            string nombre = lector.StringPorTeclado();
            Console.WriteLine("Para dni:");
            int dni = lector.NumeroPorTeclado();
            Console.WriteLine("Para FechaIngreso:");
            int FechaIngreso = lector.NumeroPorTeclado();
            
            return new noDocente(nombre, dni, FechaIngreso);
        }
    }
}