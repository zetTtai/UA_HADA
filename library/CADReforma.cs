using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    /// <summary>
    /// Clase CADReforma, esta se encarga de crear y leer reformas en la base de datos
    /// </summary>
    public class CADReforma
    {
        private string constring;
        /// <summary>
        /// Método Constructor encaragado de conectarse a la base de datos
        /// </summary>
        public CADReforma()
        {
            constring = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ToString();
        }
        /// <summary>
        /// Método encargado de crear una reforma 
        /// </summary>
        /// <param ENReforma="en"></param>
        /// <returns>Devuelve true si hemos podido crear la reforma</returns>
        public bool createReforma(ENReforma en)
        {
            bool ok = false;
            try
            {
                SqlConnection c = new SqlConnection(constring);
                c.Open();
                //Insertamos la reforma con su nombre y dirección
                SqlCommand command = new SqlCommand("Insert Into Reforma (Nombre, Descripcion) VALUES ('" + en.nombre + "','" + en.descripcionReforma + "')", c);
                ok = true;
                command.ExecuteNonQuery();
                c.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("User operation has failed. Error: {0}", e.Message);
                return false;
            }
            return ok;
        }
        /// <summary>
        /// Método encargado de leer reformas de la base de datos
        /// </summary>
        /// <param ENREforma="en"></param>
        /// <returns>Devolvemos true si hemos conseguido leer la reforma de la base de datos</returns>
        public bool readReforma(ENReforma en)
        {
            bool ok = false;
            try
            {
                SqlConnection c = new SqlConnection(constring);
                c.Open();
                //Seleccionamos las reformas con el mismo nombre
                SqlCommand com = new SqlCommand("Select * from Reforma where Nombre like '%" + en.nombre + "%'", c);
                SqlDataReader dr = com.ExecuteReader();

                while (dr.Read())
                {
                    en.nombre = dr["Nombre"].ToString();
                    en.descripcionReforma = dr["Descripcion"].ToString();
                    ok = true;
                }
                dr.Close();
                c.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("User operation has failed. Error: {0}", e.Message);
                return false;
            }
            return ok;
        }

    }
}
