using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WsVenta.Models;
using WsVenta.Models.Request;
using WsVenta.Models.Response;
using Microsoft.AspNetCore.Authentication.OAuth;

namespace WsVenta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]


    public class ClienteController : ControllerBase 
    {
        [HttpGet]
        public IActionResult Get()
        {
            respuesta Orespuesta = new respuesta();
            try
            {
                using (VentaRealContext db = new VentaRealContext())
                {
                    var lst = db.Cliente.ToList();
                    Orespuesta.Exito = 1;
                    Orespuesta.Data = lst;

                }
            }
            catch (Exception ex)
            {
                Orespuesta.Mensaje = ex.Message;
            }
            return Ok(Orespuesta);

        }
        [HttpPost]
        public IActionResult add(ClienteRequest oModel)

        {
            respuesta respuesta = new respuesta();
            try
            {
                using (VentaRealContext db = new VentaRealContext())
                {
                    Cliente oCliente = new Cliente();
                    oCliente.Nombre = oModel.Nombre;
                    db.Cliente.Add(oCliente);
                    db.SaveChanges();
                    respuesta.Exito = 1;
                }
                    
            }
            catch (Exception ex)
            {

                respuesta.Mensaje = ex.Message;
            }
            return Ok(respuesta);
        }


        [HttpPut]
        public IActionResult Edit(ClienteRequest oModel)

        {
            respuesta respuesta = new respuesta();
            try
            {
                using (VentaRealContext db = new VentaRealContext())
                {
                    Cliente oCliente = db.Cliente.Find(oModel.Id);
                    db.Remove(oCliente);
                    db.SaveChanges();
                    respuesta.Exito = 1;
                }

            }
            catch (Exception ex)
            {

                respuesta.Mensaje = ex.Message;
            }
            return Ok(respuesta);
        }
        [HttpDelete("{Id}")]
        public IActionResult delete(ClienteRequest oModel)

        {
            respuesta respuesta = new respuesta();
            try
            {
                using (VentaRealContext db = new VentaRealContext())
                {
                    Cliente oCliente = db.Cliente.Find(oModel.Id);
                    oCliente.Nombre = oModel.Nombre;
                    db.Entry(oCliente).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                    respuesta.Exito = 1;
                }

            }
            catch (Exception ex)
            {

                respuesta.Mensaje = ex.Message;
            }
            return Ok(respuesta);
        }

    }
}

