using System;

namespace POOagenda
{
    class Contacto
    {
        //Atributos
        string nombre;
        string apellido1;
        string apellido2;
        string direccion;
        string telMovil;
        string telFijo;
        string mail;

        //Constructor
        public Contacto(string n, string ap1, string ap2, string tMvl)
        {
            nombre = n;
            apellido1 = ap1;
            apellido2 = ap2;
            telMovil = tMvl;
        }

        //Constructor
        public Contacto(string n, string ap1, string tMvl)
        {
            nombre = n;
            apellido1 = ap1;
            telMovil = tMvl;
        }

        //Constructor
        public Contacto(string n, string ap1, string ap2, string tMvl, string dir, string tFijo, string mail)
        {
            nombre = n;
            apellido1 = ap1;
            apellido2 = ap2;
            direccion = dir;
            telMovil = tMvl;
            telFijo = tFijo;
            this.mail = mail; 
        }

        //Métodos propios
        public void SetNombre(string n)
        {
            nombre = n;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public void SetApellido1(string ap1)
        {
            apellido1 = ap1;
        }

        public string GetApellido1()
        {
            return apellido1;
        }

        public void SetApellido2(string ap2)
        {
            apellido2 = ap2;
        }

        public string GetApellido2()
        {
            return apellido2;
        }

        public void SetTelMovil(string tMvl)
        {
            telMovil = tMvl;
        }

        public string GetTelMovil()
        {
            return telMovil;
        }
    }
}






























