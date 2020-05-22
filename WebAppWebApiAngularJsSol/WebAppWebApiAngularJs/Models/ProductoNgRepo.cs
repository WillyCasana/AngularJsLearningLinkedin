using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Dapper;

namespace WebAppWebApiAngularJs.Models
{
    public static  class ProductoNgRepo
    {
       static string  cadConex= @"Server=DESKTOP-4KPFF10\SVR2016;Initial Catalog=Prueba;UID=adminSisPla;PWD=123456";

        internal static List<ProductoNgEnt> ProductoNgListar()
        {
            List<ProductoNgEnt> productoNgObj = null;

            using (SqlConnection conObj = new SqlConnection(cadConex))
            {
                productoNgObj= conObj.Query<ProductoNgEnt>("usp_ProductoNgListar", commandType: System.Data.CommandType.StoredProcedure).ToList();
            }

            return productoNgObj;
        }

    }
}