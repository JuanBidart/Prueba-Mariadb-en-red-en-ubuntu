using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace controlador
{
    public class ConexionControl
    {

        private string server = "192.168.0.74";
        private string user = "ubujuan";
        private string pass = "123";
        private string database = "Prueba1";
        MySqlConnection conexion;
        MySqlCommand cmd;


        public ConexionControl() 
        {
          conexion = new MySqlConnection($"Server={server};Database={database};User ID={user};Password={pass}");          
            cmd = conexion.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
          
        }

        
        public string ProbarConexion()
        {
            try
            {
                MySqlConnection conexion = new MySqlConnection($"Server={server};Database={database};User ID={user};Password={pass}");
                MySqlConnectionStringBuilder mySqlConnectionStringBuilder = new MySqlConnectionStringBuilder();
                mySqlConnectionStringBuilder.CancellationTimeout = cmd.CommandTimeout = 5;

                conexion.Open();
                return "Prueba Exitosa!!!!!!!!";

                //if (conexion.State == System.Data.ConnectionState.Open)
                //{
                //    return "Prueba Exitosa!!!!!!!!";
                //}
                //else
                //{
                //    return "No se relizo la conexion";
                //}
            }
            catch (Exception ex)
            {

                return "Lo pario " + ex.Message ;
            }

        }



    }
}
