using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebAppWebApiAngularJs.Models;

namespace WebAppWebApiAngularJs.Controllers
{
    [EnableCors("*","*","*")]
    public class ProductoNgController : ApiController
    {
        //es necesario el id=null para que por la url lo pueda ubicar http://localhost:50931/api/ProductoNg
        //sino lo tomar como diferente con parametro obligatirio http://localhost:50931/api/ProductoNg/1
        public HttpResponseMessage GetProductListado(int? id=null)
        {
            if (id == null)
                return Request.CreateResponse(HttpStatusCode.OK, ProductoNgRepo.ProductoNgListar(), Configuration.Formatters.JsonFormatter);
            else
                return Request.CreateResponse(HttpStatusCode.OK, "indv",Configuration.Formatters.JsonFormatter);

        }
    }
}
