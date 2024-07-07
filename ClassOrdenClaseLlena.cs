using System;
using System.Collections.Generic;
using ClassAula;
using Interfaces5;
//Ejercicio 5. Pacrtica5
namespace ClassOrdenAulaLlena
{
    public class OrdenAulaLlena : OrdenAula1
    {
        private Aula aula;

        public OrdenAulaLlena(Aula aula)
        {
            this.aula = aula;
        }

        public void ejecutar()
        {
            aula.ClaseLista();
            Console.WriteLine("Aula Llena..");
        }
    }

}