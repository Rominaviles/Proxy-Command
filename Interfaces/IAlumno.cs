using System;
using System.Collections.Generic;
using Interfaces;
//Ejercicio 6. act4
namespace Interfaces4
{
    public interface IAlumno :Comparable
    {
        string getNombre();
        int getLegajo();
        int getPromedio();
        int getDNI();
        void setNombre(string nombre);
        int getCalificacion();
        void setCalificacion(int calificacion);
        int responderPregunta(int pregunta);
        string MostrarCalificacion();

    }
}