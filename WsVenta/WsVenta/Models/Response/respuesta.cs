using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WsVenta.Models.Response
{
    public class respuesta
    {
        private int exito;
        private string mensaje;
        private object data;

        public int Exito { get => exito; set => exito = value; }
        public string Mensaje { get => mensaje; set => mensaje = value; }
        public object Data { get => data; set => data = value; }
        public respuesta()
        {
            this.exito = 0;
        } 
    }
}