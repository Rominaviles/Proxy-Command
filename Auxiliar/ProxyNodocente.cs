using System;
using System.Collections.Generic;
using FabricNoDocente;
using Interfaces;
using Nodocent;

namespace ProxyNoDocente
{
    public class NoDocenteProxy: INodocente
    {
        INodocente? NodocenteReal =null;
        string nombre;
        int OpCreacion;

        public NoDocenteProxy(string n, int op)
        {
            this.nombre = n; 
            this.OpCreacion= op;           
        }

        public string getNombre()
        {
            return nombre;
        }
        public int getDNI()
        {
            return NodocenteReal?.getDNI()??0;
        }       
        
        public void setNombre(string nombre)
        {
            this.nombre =nombre;
        }
        public void abrirAula()
        {
            if (NodocenteReal==null)
            {
                NodocenteReal = (INodocente)FabricaNoDocente.crearAleatorio(OpCreacion);
            }   
            NodocenteReal.abrirAula();      
        }
        public void prenderLuces()
        {
            Console.WriteLine("Estoy prendiendo las luces");
        }
        public void cerrarAula()
        {
            if(NodocenteReal==null)
            {
                NodocenteReal = (INodocente)FabricaNoDocente.crearAleatorio(OpCreacion);
            }   
            NodocenteReal.cerrarAula();  
        }

        public bool sosIgual(Comparable c)
        {
            return NodocenteReal?.sosIgual((Comparable)c)??false;
        }
        public bool sosMenor(Comparable c)
        {
            return NodocenteReal?.sosMenor((Comparable)c)??false;
        }
        public bool SosMayor(Comparable c)
        {
            return NodocenteReal?.SosMayor((Comparable)c)??false;
        }

    }
}