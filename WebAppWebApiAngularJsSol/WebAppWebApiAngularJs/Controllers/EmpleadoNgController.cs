using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiAngularJs.Modelo;
using System.Web.Http.Cors;


namespace WebAppWebApiAngularJs.Controllers
{
    [EnableCors("*","*","*")]
    public class EmpleadoNgController : ApiController
    {
        //en este caso tiene que se id por convencion si es diferente no toma el valor
        public HttpResponseMessage GetEmpListado(int? id = null)
        {
            //JsonRequestBehavior.AllowGet = Configuration.Formatters.JsonFormatter

            //int idemp = id;

            if (id == null)
                return Request.CreateResponse(HttpStatusCode.OK, EmpleadoNgRepo.EmpleadoNgObtenerListado()
                , Configuration.Formatters.JsonFormatter);
            else
                return Request.CreateResponse(HttpStatusCode.OK, EmpleadoNgRepo.EmpleadoNgObtenerListadoXId(id)
                    ,Configuration.Formatters.JsonFormatter);
        }

        public HttpResponseMessage PostEmp(EmpleadoNg emp)
        {
            EmpleadoNgRepo.EmpInsertOrEdit(emp);

            return Request.CreateResponse(HttpStatusCode.OK, "Grabado con éxito");

        }

    }
}
