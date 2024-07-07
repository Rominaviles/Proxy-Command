using System;
using System.Collections.Generic;
using Interfaces;
using Interfaces2;
using Interfaces5;

namespace Classcola
{//Modificado por la act 5, ejercicio 9
    public class Cola: Coleccionable, Ordenable
    {
        private List<Comparable> elementos;
        private OrdenAula1? OrdenInicio= null, OrdenFin= null;
        private OrdenAula2? OrdenAlumno= null;

        public Cola()
        {
            this.elementos= new List<Comparable>();

        }

        public void encolar(Comparable c)
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
        
        public void desencolar()
        {
            Comparable e= this.elementos[0];
            this.elementos.Remove(e);
        }
        //Metodos de la interface
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
            }return masChico;
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
            this.encolar(c);
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