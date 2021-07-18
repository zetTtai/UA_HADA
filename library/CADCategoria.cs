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
    /// Clase CADCategoria, clase encargada de insertar y leer la categoria de una vivienda almacenada en una base de datos
    /// </summary>
    public class CADCategoria
    {
        private string constring;
        /// <summary>
        /// Método constructor de CADCategoria, es el encargado de conectarse con la base de datos
        /// </summary>
        public CADCategoria()
        {
            constring = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ToString();
        }
        /// <summary>
        /// Método para insertar una categoria en la base de datos
        /// </summary>
        /// <param ENCategoria="en"></param>
        /// <returns>devolvemos true si hemos podido crear bien la categoria </returns>
        public bool createCategoria(ENCategoria en)
        {
            
            bool ok = false;
            try
            {
                SqlConnection c = new SqlConnection(constring);
                c.Open();
                //Creamos una categoria según su tipo
                SqlCommand command = new SqlCommand("Insert Into Categoria (Tipo) VALUES ('" + en._tipo + "')", c);
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
        /// Método encargado de leer una categoria 
        /// </summary>
        /// <param ENCategoria="en"></param>
        /// <returns>Devuelve true si se ha podido leer la categoria</returns>
        public bool readCategoria(ENCategoria en)
        {
            bool ok = false;
            try
            {
                SqlConnection c = new SqlConnection(constring);
                c.Open();
                //Seleccionamos las viviendas del mismo tipo
                SqlCommand com = new SqlCommand("Select * from Categoria where Tipo like '%" + en._tipo + "%'", c);
                SqlDataReader dr = com.ExecuteReader();

                while (dr.Read())
                {
                    en._tipo = dr["Tipo"].ToString();
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
