using System;
using System.Collections.Generic;
using Classpersona;
using Nodocent;

namespace noDocent
{
    public class noDocente: Persona, INodocente
    {
        private int FechaIngreso;

        public noDocente (string n, int d, int fi) : base(n,d)
        {
            this.FechaIngreso = fi;
        }

        public void setNombre(string nombre)
        {
            nombre = nombre ??"";
        }

        public int getFechaIngreso(int FechaIngreso)
        {
            return this.FechaIngreso;
        }


        public void abrirAula()
        {
            Console.WriteLine("Estoy abriendo el aula");
        }

        public void prenderLuces()
        {
            Console.WriteLine("Estoy prendiendo las luces");
        }

        public void cerrarAula()
        {
            Console.WriteLine("Estoy cerrando las aulas");
        }

    }
}