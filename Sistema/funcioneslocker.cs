using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Sistema
{
    class funcioneslocker
    {
        public static bool login(string usuario, string contra)
        {
            bool bandera = false;
            MySqlCommand sentencia = new MySqlCommand(String.Format("select * from admin where administrador='" + usuario + "' and contraseña='" + contra + "'"), Conexion2.obtenerConexion2());
            MySqlDataReader lector = sentencia.ExecuteReader();

            if (lector.Read())
            {
                bandera = true;
            }
            else
            {
                bandera = false;
            }

            return bandera;
        }
    }
}
