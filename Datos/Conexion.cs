﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace Datos
{
    public class Conexion
    {
        //declarar la cadena de conexion
        static string cadena = "Server=localhost;Database=TallerMecanico;Integrated Security=true";
        SqlConnection conexion = new SqlConnection(cadena);

    }
}
