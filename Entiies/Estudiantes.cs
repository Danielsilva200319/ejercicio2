using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicio2.Entiies
{
    public class Estudiantes
    {
        private string id;
        private string nombre;
        private string email;
        private int edad;
        private string direccion;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        
    }
}