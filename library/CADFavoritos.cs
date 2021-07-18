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
    /// Clase CADFavoritos,clase encargada de crear y leer listas de favoritos en la base de datos
    /// </summary>
    public class CADFavoritos
    {
        private string constring;
        /// <summary>
        /// Método Constructor que se encarga de conectarse con la base de datos
        /// </summary>
        public CADFavoritos()
        {
            constring = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ToString();
        }
        /// <summary>
        /// Método para insertar una lista de viviendas favortias en la base de datos
        /// </summary>
        /// <param ENFavoritos="en"></param>
        /// <returns>Devuelve true si se ha podido crear la lista de favoritos</returns>
        public bool createListaFav(ENFavoritos en)
        {
            bool ok = false;
            try
            {
                SqlConnection c = new SqlConnection(constring);
                c.Open();
                //Insertamos la lista segun un usuario
                SqlCommand command = new SqlCommand("Insert Into Lista_Favoritos (Usuario, ViviendaDireccion, ViviendaLocalidad) VALUES ('" + en.usuario + "','" + en.viviendaDire + "','" + en.viviendaLoca + "')", c);
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
        /// Método para leer una lista de favoritos de la base de datos
        /// </summary>
        /// <param ENFavoritos="en"></param>
        /// <returns>Devuelve true si hemos conseguido leer la lista</returns>
        public bool readfav(ENFavoritos en)
        {
            bool ok = false;
            try
            {
                SqlConnection c = new SqlConnection(constring);
                c.Open();
                //Leemos la lista según un usuario
                SqlCommand com = new SqlCommand("Select * from Lista_Favoritos where Usuario like '%" + en.usuario + "%'", c);
                SqlDataReader dr = com.ExecuteReader();

                while (dr.Read())
                {
                    en.viviendaDire = dr["ViviendaDireccion"].ToString();
                    en.viviendaLoca = dr["ViviendaLocalidad"].ToString();
                    ok = true;
                    break;
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
        /// <summary>
        /// Método encargado de encontrar las viviendas favoritas del usuario
        /// </summary>
        /// <param ENFavoritos="en"></param>
        /// <returns></returns>
        public bool exite(ENFavoritos en)
        {
            bool ok = false;
            int founded = 0;
            try
            {
                SqlConnection c = new SqlConnection(constring);
                c.Open();
                SqlCommand com = new SqlCommand("Select * from Lista_Favoritos where Usuario like '%" + en.usuario + "%'", c);
                SqlDataReader dr = com.ExecuteReader();

                while (dr.Read())
                {
                    if (en.viviendaDire == dr["ViviendaDireccion"].ToString() && en.viviendaLoca == dr["ViviendaLocalidad"].ToString())
                    {
                        founded++;
                        ok = true;
                        break;

                    }


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
        /// <summary>
        /// Método para leer los siguientes favoritos
        /// </summary>
        /// <param ENFavorito="en"></param>
        /// <returns>Devolvemos true si hemos conseguido acceder al favorito siguiente</returns>
        public bool nextFav(ENFavoritos en)
        {

            bool correcto = false;
            int contador = 0;
            try
            {
                SqlConnection ccc = new SqlConnection(constring);
                ccc.Open();
                SqlCommand comando = new SqlCommand("Select * from Lista_Favoritos", ccc);
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    if (contador == 1)
                    {
                        en.viviendaDire = dr["ViviendaDireccion"].ToString();
                        en.viviendaLoca = dr["ViviendaLocalidad"].ToString();
                        correcto = true;
                        break;                       
                    }
                    if (dr["ViviendaDireccion"].ToString() == en.viviendaDire)
                    {
                        contador++;
                    }
                }
                dr.Close();
                ccc.Close();
            }
            catch (Exception excepcion)
            {
                Console.WriteLine("User operation has failed. Error: {0}", excepcion.Message);
            }
            return correcto;
        }
    }
}
