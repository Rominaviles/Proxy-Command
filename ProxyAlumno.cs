using System;
using System.Collections.Generic;
using ClassFabricaAlumnos;
using Interfaces;
using Interfaces4;
//Ejercicio1.act5
namespace ProxyAlumno           
{   
    public class AlumnoProxy : IAlumno
    {
        IAlumno? alumnoReal= null;
        string nombre;
        int OpcionDeCreacion;

        public AlumnoProxy(string n, int opc)
        {   
            this.nombre = n; 
            this.OpcionDeCreacion = opc;
        }

        public string getNombre()
        {
            return nombre;
        }



        public void setNombre(string nombre)
        {
            this.nombre =nombre;
        }

        public int getLegajo()
        {
            return alumnoReal?.getLegajo()??0;
        }
        public int getDNI()
        {
            return alumnoReal?.getDNI()??0;
        }
        public int getPromedio()
        {
            return alumnoReal?.getPromedio()??0;
        }
        public int getCalificacion()
        {
            return alumnoReal?.getCalificacion()??0;
        }
        public void setCalificacion(int calificacion)
        {
            alumnoReal?.setCalificacion(calificacion);
        }
        public string MostrarCalificacion()
        {
            return alumnoReal?.MostrarCalificacion()??"";
        }
        public bool sosIgual(Comparable c)
        {
            return alumnoReal?.sosIgual((Comparable)c)??false;
        }
        public bool sosMenor(Comparable c)
        {
            return alumnoReal?.sosMenor((Comparable)c)??false;
        }
        public bool SosMayor(Comparable c)
        {
            return alumnoReal?.SosMayor((Comparable)c)??false;
        }

        //Creacion del objeto Real
        public int responderPregunta(int pregunta)
        {
            if (alumnoReal==null)
            {
                alumnoReal = (IAlumno)FabricaDeAlumnos.crearAleatorio(OpcionDeCreacion);
                this.setNombre(alumnoReal.getNombre());
            }
            return alumnoReal.responderPregunta(pregunta);
        }
    }
}