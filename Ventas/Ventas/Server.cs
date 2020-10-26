using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas
{
    class Server
    {

        //Cadena de Conexion
        string cadena = "data source =DESKTOP-NI6IJ7A; initial catalog = BaseDatos; user id = Usuario; password = Contraseña";

        public SqlConnection Conectarbd = new SqlConnection();

        //Constructor
        public conexionbd()
        {
            Conectarbd.Con nectionString = cadena;
        }

        //Metodo para abrir la conexion
        public void abrir()
        {
            try
            {
                Conectarbd.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("error al abrir BD " ex.Message);
            }
        }
}
