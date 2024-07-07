using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;
using strategy;
using Interfaces;
using Classpersona;
using Classcola;
using Classpila;
using Classalumno;
using Classnumero;
using Interfaces2;
using Microsoft.VisualBasic;
using ClassFabricaComparable;
using Interfaces3;
using ClassFabricaAlumnos;
using ClassFabricaNumeros;
using ClassProfesor;
using MetodologíasDeProgramaciónI;
using ClassAlumnoAdaptable;
using ClassAlumnoEstudioso;
using Interfaces4;
using DecaradorDeLegajo;
using DecoradoDeNotas;
using EstadoDelAlumno;
using ClassRecuadroAsteriscos;
using ClassAula;
using Interfaces5;
using Ordenicio;
using ClassOrdenAulaLlena;
using ClassOrdenLlegaAlum;
using ProxyAlumno;
using Nodocent;
using ProxyNoDocente;


namespace ClasesMet
{
    class Program
    
    {
        //EJERCICIO 5
        public static void llenar (Coleccionable c, int opcion)
        {
            int cont = 0;
            while (cont<20)
            {
                Comparable comparable = FabricaComparables.crearAleatorio(opcion);
                c.agregar(comparable);
                cont++;
                Console.WriteLine("Elemento agregado, n°" + cont);
            }
            
        }
        public static void DictadoDeClases(Profesor p)
        {
            int cont=0;
            while(cont<=5)
            {
                p.hablarALaClase();
                p.escribirEnElPizarron();
                cont++;
                
            }
        }

        
        static void Main(string[] args)
        {
            INodocente proxy = new NoDocenteProxy("Pedro", 4);
            
            proxy.abrirAula();
            proxy.prenderLuces();
            proxy.cerrarAula();




            //Teacher teacher = new Teacher();
//Proxy
            /*for (int i = 0; i < 5; i++)
            {
                IAlumno proxy= new AlumnoProxy("Juan",2); 
                IAlumno decorador = new DecoradorLegajo(proxy);
                IAlumno decorador1 = new DecoradoNotasEnLetras(decorador);
                IAlumno decorador2 = new EstadoAlumno(decorador1);
                IAlumno decorador3 = new RecuadroAstericos(decorador2);
                Student student = new AlumnoAdaptable(decorador3);

                teacher.goToClass(student);
            }

            for (int i = 0; i < 5; i++)
            {
                IAlumno proxy= new AlumnoProxy("Pablo",3); 
                IAlumno decorador = new DecoradorLegajo(proxy);
                IAlumno decorador1 = new DecoradoNotasEnLetras(decorador);
                IAlumno decorador2 = new EstadoAlumno(decorador1);
                IAlumno decorador3 = new RecuadroAstericos(decorador2);
                Student student = new AlumnoAdaptable(decorador3);

                teacher.goToClass(student);
            }

            teacher.teachingAClass();*/

//Comand

            /*Aula aula = new Aula(teacher);
            OrdenAula1 Inicio = new OrdenInicio(aula);
            OrdenAula1 AulaLlena = new OrdenAulaLlena(aula);
            OrdenAula2 LlegaAlumno = new OrdenLlegaAlumno(aula);

            /*Pila pila= new Pila();
            pila.setOrdenInicio(Inicio);
            pila.setOrdenAulaLlena(AulaLlena);
            pila.setOrdenLlegaAlumno(LlegaAlumno);

            llenar(pila,3);
            llenar(pila,2);
            
            Cola cola = new Cola();
            cola.setOrdenInicio(Inicio);
            cola.setOrdenAulaLlena(AulaLlena);
            cola.setOrdenLlegaAlumno(LlegaAlumno);

            llenar(cola,3);
            llenar(cola,2);*/



//Proxy : facil: fecha de ingreso, prender las luces tambien. El otro no 
        }
    }


}