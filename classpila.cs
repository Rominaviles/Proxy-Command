using System;
using System.Collections.Generic;
using Interfaces;
using Interfaces2;
using Interfaces5;
using ClassOrdenAulaLlena;

namespace Classpila
{//Modificado por la act 5, ejercicio 9
    public class Pila : Coleccionable, Ordenable
    {
        private List<Comparable> elementos;
        private OrdenAula1? OrdenInicio= null, OrdenFin= null;
        private OrdenAula2? OrdenAlumno= null;
        public Pila()
        {
            this.elementos= new List<Comparable>();
        }

        public void apilar(Comparable c)
        {
            this.elementos.Add(c);

            //Agregacion de comportamientos adicionales
            if (elementos.Count==1)
            {
                if (OrdenInicio != null)
                {
                    OrdenInicio.ejecutar();
                }  
            }

            if (OrdenAlumno != null)
            {
                OrdenAlumno.ejecutar(c);
            } 

            if (elementos.Count==40)
            {
                if (OrdenFin != null)
                {
                    OrdenFin.ejecutar();
                }  
            }
        }

        public Comparable desapilar()
        {
            Comparable e= this.elementos[this.elementos.Count -1];
            this.elementos.RemoveAt(this.elementos.Count -1); 
            return e;
        }

        //Metodos de la interface coleccionable clase 1
        public int cuantos()
        {
            return this.elementos.Count;
        }

         public Comparable minimo()
         {
             Comparable masChico = this.elementos[0];
             foreach (Comparable e in elementos)
             {
                 if (e.sosMenor(masChico))
                 {
                     masChico = e;
                 }
             }
             return masChico;
         }

        public Comparable maximo()
        {
            Comparable masGrande = this.elementos[0];
            foreach (Comparable e in elementos)
            {
                if (e.SosMayor(masGrande))
                {
                    masGrande = e;
                }
            }return masGrande;

        }
        public void agregar(Comparable c)
        {
            this.apilar(c);
        }
        public bool contiene (Comparable c)
        {
            foreach(Comparable e in this.elementos){
                if(e.sosIgual(c)){
                    return true;
                }
            }
            return false;           
        }

        //Metodo Interface Ordenable, ejercicio 9
        public void setOrdenInicio(OrdenAula1 o)
        {
            OrdenInicio=o;
        }
        public void setOrdenLlegaAlumno(OrdenAula2 o)
        {
            OrdenAlumno= o;
        }
        public void setOrdenAulaLlena(OrdenAula1 o)
        {
            OrdenFin= o;
        }



    }

}