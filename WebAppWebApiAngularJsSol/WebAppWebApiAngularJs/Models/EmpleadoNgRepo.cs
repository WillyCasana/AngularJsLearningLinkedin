using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;

namespace WebApiAngularJs.Modelo
{
    public static class EmpleadoNgRepo
    {
        static string cadConex = @"Server=DESKTOP-4KPFF10\SVR2016;Initial Catalog=Prueba;UID=adminSisPla;Pwd=123456";

        internal static List<EmpleadoNg> EmpleadoNgObtenerListado()
        {
            List<EmpleadoNg> empListadoObj = null;


            using (SqlConnection conObj = new SqlConnection(cadConex))
            {
                empListadoObj=conObj.Query<EmpleadoNg>("usp_EmpleadoNgObtenerListado", commandType: System.Data.CommandType.StoredProcedure).ToList();
            }

            return empListadoObj;
        }

        internal static EmpleadoNg EmpleadoNgObtenerListadoXId(int? empId)
        {
            EmpleadoNg empObj = null;

            using(SqlConnection conObj = new SqlConnection(cadConex))
            {
                empObj = conObj.Query<EmpleadoNg>("usp_EmpleadoNgObtenerListado", new { empId }, commandType: System.Data.CommandType.StoredProcedure).FirstOrDefault();
            }

            return empObj;
        }

        internal static void EmpInsertOrEdit(EmpleadoNg emp)
        {
            using (SqlConnection conObj = new SqlConnection(cadConex))
            {
                conObj.Execute("usp_EmpInsertOrEdit", new { emp.id, emp.nombre, emp.descripcion }, commandType: System.Data.CommandType.StoredProcedure);

            }
        }
    }
}
