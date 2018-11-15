﻿using System;

namespace Modelo.ValueObjects
{
    public class ClienteVO : UsuarioVO
    {
        // Atributos
        private String direccion;
        private String telefono;
        
        // Properties
        public string Direccion { get { return direccion; } }
        public string Telefono { get { return telefono; } }

        // Constructores
        public ClienteVO(String dir, string tel, int id, string mail, string pass, Boolean activo, String tipo) : base(id, mail, pass, activo, tipo)
        {
            direccion = dir;
            telefono = tel;
        }
    }
}
