using System;
using System.Collections.Generic;
using ClassAula;
using Interfaces5;
//Ejercicio 5. Pacrtica5
namespace Ordenicio
{
    public class OrdenInicio : OrdenAula1
    {
        private Aula aula;

        public OrdenInicio(Aula aula)
        {
            this.aula = aula;
        }

        public void ejecutar()
        {
            aula.Comenzar();
        }
    }
}