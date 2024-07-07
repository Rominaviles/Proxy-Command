using System;
using System.Collections.Generic;
using Interfaces;

namespace Nodocent
{
    public interface INodocente : Comparable
    {
        string getNombre();
        int getDNI();
        void setNombre(string nombre);
        void abrirAula();
        void prenderLuces();
        void cerrarAula();
    }
}