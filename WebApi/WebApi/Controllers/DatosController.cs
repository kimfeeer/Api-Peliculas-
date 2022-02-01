using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;  
using WebApi.Models.Response;
using WebApi.Models;
using WebApi.Models.Request; 

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DatosController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            Respuesta oRespuesta = new Respuesta();
            try
            {
                using (WebApiContext db = new WebApiContext())
                {
                    var lst = db.Peliculas.ToList();
                    oRespuesta.Titulo = (char)100;

                }
            }
            
            catch (Exception ex)
            {
                oRespuesta.Mensaje = ex.Message;    
            }

            return Ok(oRespuesta); 
        }

        [HttpPost]
        public IActionResult Add(DatosRequest model)
        {
            Respuesta oRespuesta = new Respuesta(); 
            try
            {
                using (WebApiContext db =new WebApiContext())
                {
                    Datos oDatos 
                    

                }
            }
        }
    }
}
