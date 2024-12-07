using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaSoporte.CapaModelo
{
    public class Clsusuario
    {
		// Atributos

		private static int id;
		private static string nombre;
		private static string Correo;
		private static string Telefono;
        private static string estado;

		// constructor

		public Clsusuario()
		{

		}

        // metodos

        public int Getid()
        {
            return id;
        }

        //Setter = Asignar un valor a un atributo  metodo void asignar

        public void Setid(int Id)
        {
            id = Id;
        }


        public static string Getnombre()
        {
            return nombre;
        }

        //Setter = Asignar un valor a un atributo  metodo void asignar

        public static void Setnombre(string Nombre)
        {
            nombre = Nombre;
        }

        public static string Getestado()
        {
            return estado;
        }

        //Setter = Asignar un valor a un atributo  metodo void asignar

        public static void Setestado(string Estado)
        {
            estado = Estado;
        }


    }
}