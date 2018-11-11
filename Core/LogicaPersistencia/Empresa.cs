using System;

namespace LogicaPersistencia
{
    public class Empresa : Cliente
    {
        // Atributes
        private int rut;

        // Properties
        public int Rut { get { return rut; } }
        public string Contacto { get; set; }
        public string RazonSocial { get; set; }

        // Constructores
        public Empresa(int ruc, string contact, string razon, string dir, string tel, int id, string mail, string pass, Boolean activo) : base(dir, tel, id, mail, pass, activo)
        {
            rut = ruc;
            Contacto = contact;
            RazonSocial = razon;
        }
    }



}

