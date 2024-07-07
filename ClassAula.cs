using System;
using System.Collections.Generic;
using Classalumno;
using ClassAlumnoAdaptable;
using Interfaces4;
using MetodologíasDeProgramaciónI;
//Ejercicio 3.Practica5
namespace ClassAula
{
    public class Aula
    {
        private Teacher teacher;

        public Aula( Teacher teacher)
        {
            this.teacher = teacher;
        }

        public void Comenzar()
        {
            Console.WriteLine("Comenzando...");
            teacher= new Teacher();
        }

        public void nuevoAlumno(IAlumno alumno)
        {
            teacher.goToClass((new AlumnoAdaptable (alumno)));
        }

        public void ClaseLista()
        {
            teacher.teachingAClass();
        }

    }
}