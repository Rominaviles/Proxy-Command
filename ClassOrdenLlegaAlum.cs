using System;
using System.Collections.Generic;
using ClassAula;
using Interfaces;
using Interfaces4;
using Interfaces5;
//Ejercicio 7.Pract5
namespace ClassOrdenLlegaAlum
{
    public class OrdenLlegaAlumno : OrdenAula2
    {
        private Aula aula;

        public OrdenLlegaAlumno(Aula aula)
        {
            this.aula = aula;
        }

        public void ejecutar(Comparable c)
        {
            aula.nuevoAlumno((IAlumno)c);
            Console.WriteLine("Llega alumno..");
        }
    }
}