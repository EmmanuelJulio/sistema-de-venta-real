using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WsVenta.Models.Request
{
    public class ClienteRequest
    {
        private int id;
        private string nombre;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
