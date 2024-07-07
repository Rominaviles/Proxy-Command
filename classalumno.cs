using System;
using System.Collections.Generic;
using Interfaces;
using Classpersona;
using strategy;
using Interfaces3;
using ClassProfesor;
using Interfaces4;

namespace Classalumno
{//Actividad 1, ejercicio 15    //Agregacion de la interface IAlumno de la act 4, ejercicio 6.
    public class Alumno : Persona, Observador, IAlumno
    {
        private int legajo;
        private int promedio;
        private int calificacion; //Ejercicio 1. Act4
//Agregacion Strategy
        private EstrategiaComparacion estrategia;

        public Alumno(string n, int d, int l, int p, int calif) : base (n, d)
        {
//Estrategia por defecto
            estrategia= new EstrategiaPorDni();
            this.legajo=l;
            this.promedio=p;
            this.calificacion=calif;
        }
//Estrategia setter
        public void setEstrategia(EstrategiaComparacion c)
        {
            estrategia = c;
        }

        public int getLegajo()
        {
            return this.legajo;
        }

        public int getPromedio()
        {
            return this.promedio;
        }

        //getter, setter y metodos ejercicio1. act4

        public int getCalificacion()
        {
            return this.calificacion;
        }

        public void setNombre(string nombre)
        {
            nombre = nombre ??"";
        }

        public void setCalificacion(int calificacion)
        {
            this.calificacion= calificacion;
        }

        public virtual int responderPregunta(int pregunta)
        {
            Random rdm = new Random();
            return rdm.Next(1,3);

        }

        public string MostrarCalificacion()
        {
            return "Nombre: " + getNombre() + "Calificion: " + getCalificacion();
        }

        public override string ToString()
        {
            return "Nombre: "+ getNombre() + ", Dni: " + getDNI() + ", Legajo: " + getLegajo() + ", Promedio: " + getPromedio();
        }

        //EJERCICIO 18 (Implementacion de la interface comparable)
        public override bool sosIgual(Comparable c)
        {
            return estrategia.sosIgual(this, (IAlumno)c);
        }

        public override bool sosMenor(Comparable c)
        {
            return estrategia.sosMenor(this, (IAlumno)c);
        }

        public override bool SosMayor(Comparable c)
        {
            return estrategia.SosMayor(this, (IAlumno)c);
        }

        //Ejercicio 11, Actividad 3

        public void PrestarAtencion()
        {
            Console.WriteLine("Prestando Atencion.");
        }

        public void Distraerse()
        {
            Random rdm = new Random();
            int opc = rdm.Next(3);
            switch (opc)
            {
                case 1 : Console.WriteLine("Mirando el celular.."); break;
                case 2 : Console.WriteLine("Dibujando en el margen de la carpeta.."); break;
                case 3 : Console.WriteLine("Tirando aviones de papel.."); break;
            }
        }

        //Metodos Observador
        public void Actualizar(Observado o)
        {
            
            if(o.isEstaHablando() == true)
            {
                this.PrestarAtencion();
            }
            else
            {
                this.Distraerse();
            
            }
        }
        

    }


}