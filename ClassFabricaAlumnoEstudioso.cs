using System;
using System.Collections.Generic;
using ClassAlumnoEstudioso;
using ClassFabricaComparable;
using ClassGeneradorDatosRandom;
using ClassLectorDatos;
using Interfaces;
//Creacion de Fabrica para la actividad 5.
namespace FabAlumnoEstudioso
{
    public class FabricaDeAlumnoEstudioso : FabricaComparables
    {
        private GeneradorDeDatosAleatorios generador;
        private LectorDeDatos lector;

        public FabricaDeAlumnoEstudioso()
        {
            generador = new GeneradorDeDatosAleatorios();
            lector = new LectorDeDatos();
        }
        public override Comparable crearAleatorio()
        {
            string nombre = generador.stringAleatorio(5);
            int dni = generador.numeroAleatorio(99999999);
            int legajo = generador.numeroAleatorio(10000);
            int calificacion = generador.numeroAleatorio(10);
            int promedio = generador.numeroAleatorio(10);  

            return new AlumnoMuyEstudioso(nombre, dni, legajo,calificacion,promedio);
    
        }

        public override Comparable crearPorTeclado()
        {
            Console.WriteLine("Para nombre:");
            string nombre = lector.StringPorTeclado();
            Console.WriteLine("Para dni:");
            int dni = lector.NumeroPorTeclado();
            Console.WriteLine("Para legajo:");
            int legajo = lector.NumeroPorTeclado();
            Console.WriteLine("Para calificacion:");
            int calificacion = lector.NumeroPorTeclado();
            Console.WriteLine("Para promedio:");
            int promedio = lector.NumeroPorTeclado();
            
            return new AlumnoMuyEstudioso(nombre, dni, legajo, calificacion,promedio);
        }
    }
}