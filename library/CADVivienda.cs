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
    /// Clase CADVivienda esta clase esta encargada de llevar a cabo las acciones con la tabla vivienda de la base de datos 
    /// </summary>
    public class CADVivienda
    {
        private string constring;

        /// <summary>
        /// Método constructor encargado de conectarse con la base de datos
        /// </summary>
        public CADVivienda()
        {
            constring = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ToString();
        }
        /// <summary>
        /// Método encargado de crear una vivienda a partir de sus atributos
        /// </summary>
        /// <param ENVivienda="en"></param>
        /// <returns>Devolvemos true si hemos podido insertar la vivienda en la base de datos</returns>
        public bool createVivienda(ENVivienda en)
        {
            bool ok = false;
            try
            {
                SqlConnection c = new SqlConnection(constring);
                c.Open();
                //Creamos una vivienda con sus atributos y la insertamos en la base de datos
                SqlCommand command = new SqlCommand("Insert Into Viviendas (MetrosCuadrados, Direccion, Localidad, Precio, Descripcion, NumeroBaños, NumeroHabitaciones, Categoria, Reforma, ImagenesUrl, Maps, Dueño ) VALUES ('" + en.metrosCuadradosVivienda + "','" + en.direccionVivienda + "','" + en.localidadVivienda + "','" + en.precioVivienda + "','" + en.descripcionVivienda + "','" + en.numeroBañosVivienda + "','" + en.numeroDormitoriosVivienda + "','" + en.categoria + "','" + en.reforma + "','" + en.imagenUrl + "','" + en.maps + "','" + en.dueño + "')", c);
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
        /// Método encargado de leer la siguiente Vivienda 
        /// </summary>
        /// <param ENVivienda="en"></param>
        /// <returns>Devolvemos true si hemos podido leer la siguiente vivienda</returns>
        public bool readFollowingVivienda(ENVivienda en)
        {
            bool correcto = false;
            //int pos = correctoTodo(en.nifUsuario);
            int contador = 0;
            //int posCorrecto = -1;
           // if (pos != -1)
            //{
                try
                {
                    SqlConnection ccc = new SqlConnection(constring);
                    ccc.Open();
                    SqlCommand comando = new SqlCommand("Select * from Viviendas", ccc);
                    SqlDataReader dr = comando.ExecuteReader();
                    while (dr.Read())
                    {
                        if (contador == 1)
                        {
                            en.precioVivienda = int.Parse(dr["Precio"].ToString());
                            en.metrosCuadradosVivienda = int.Parse(dr["MetrosCuadrados"].ToString());
                            en.numeroBañosVivienda = int.Parse(dr["NumeroBaños"].ToString());
                            en.numeroDormitoriosVivienda = int.Parse(dr["NumeroHabitaciones"].ToString());
                            en.descripcionVivienda = dr["Descripcion"].ToString();
                            en.imagenUrl = dr["ImagenesUrl"].ToString();
                            en.categoria = dr["Categoria"].ToString();
                            en.direccionVivienda = dr["Direccion"].ToString();
                            en.localidadVivienda = dr["Localidad"].ToString();
                            en.reforma = dr["Reforma"].ToString();
                            en.maps = dr["Maps"].ToString();
                            en.direccionVivienda = dr["Direccion"].ToString();
                            correcto = true;
                            break;
                        }
                        if (en.direccionVivienda == dr["Direccion"].ToString() && en.dueño == dr["Dueño"].ToString())
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
        /// <summary>
        /// Método que se encarga de leer las viviendas favoritas
        /// </summary>
        /// <param ENVIvienda="en"></param>
        /// <returns>Devuelve true si hemos podido leer la vivienda favorita</returns>
        public bool readFavVivienda(ENVivienda en)
        {
            bool ok = false;
            try
            {
                SqlConnection c = new SqlConnection(constring);
                c.Open();
                SqlCommand com = new SqlCommand("Select * from Viviendas ", c);
                SqlDataReader dr = com.ExecuteReader();

                while (dr.Read())
                {
                    if(en.localidadVivienda == dr["Localidad"].ToString() && en.direccionVivienda == dr["Direccion"].ToString() && en.dueño == dr["Dueño"].ToString())
                    {
                        en.precioVivienda = int.Parse(dr["Precio"].ToString());
                        en.metrosCuadradosVivienda = int.Parse(dr["MetrosCuadrados"].ToString());
                        en.numeroBañosVivienda = int.Parse(dr["NumeroBaños"].ToString());
                        en.numeroDormitoriosVivienda = int.Parse(dr["NumeroHabitaciones"].ToString());
                        en.descripcionVivienda = dr["Descripcion"].ToString();
                        en.imagenUrl = dr["ImagenesUrl"].ToString();
                        en.maps = dr["Maps"].ToString();
                        en.categoria = dr["Categoria"].ToString();
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
        /// Método para leer una vivienda
        /// </summary>
        /// <param ENVivienda="en"></param>
        /// <returns>Devolvemos true si conseguimos leer la vivienda </returns>
        public bool readVivienda(ENVivienda en)
        {
            bool ok = false;
            try
            {
                SqlConnection c = new SqlConnection(constring);
                c.Open();
                SqlCommand com = new SqlCommand("Select * from Viviendas where Localidad like '%" + en.localidadVivienda + "%' and Direccion like '%" + en.direccionVivienda + "%'", c);
                SqlDataReader dr = com.ExecuteReader();

                while (dr.Read())
                {

                    if (en.precioVivienda >= int.Parse(dr["Precio"].ToString()))
                    {
                        en.precioVivienda = int.Parse(dr["Precio"].ToString());
                        en.metrosCuadradosVivienda = int.Parse(dr["MetrosCuadrados"].ToString());
                        en.numeroBañosVivienda = int.Parse(dr["NumeroBaños"].ToString());
                        en.numeroDormitoriosVivienda = int.Parse(dr["NumeroHabitaciones"].ToString());
                        en.descripcionVivienda = dr["Descripcion"].ToString();
                        en.imagenUrl = dr["ImagenesUrl"].ToString();
                        en.maps = dr["Maps"].ToString();
                        en.categoria = dr["Categoria"].ToString();
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
        /// Método encargado de leer el usuario que ha puesto a la venta esa vivienda 
        /// </summary>
        /// <param ENVivienda="en"></param>
        /// <returns>Devuelve true si conseguimos encontrar el dueño de esa vivienda</returns>
        public bool readUsuVivienda(ENVivienda en)
        {
            bool ok = false;
            try
            {
                SqlConnection c = new SqlConnection(constring);
                c.Open();
                SqlCommand com = new SqlCommand("Select * from Viviendas where Dueño like '%" + en.dueño + "%'", c);
                SqlDataReader dr = com.ExecuteReader();

                while (dr.Read())
                {

                    if (en.dueño == dr["Dueño"].ToString())
                    {
                        en.precioVivienda = int.Parse(dr["Precio"].ToString());
                        en.metrosCuadradosVivienda = int.Parse(dr["MetrosCuadrados"].ToString());
                        en.numeroBañosVivienda = int.Parse(dr["NumeroBaños"].ToString());
                        en.numeroDormitoriosVivienda = int.Parse(dr["NumeroHabitaciones"].ToString());
                        en.descripcionVivienda = dr["Descripcion"].ToString();
                        en.imagenUrl = dr["ImagenesUrl"].ToString();
                        en.direccionVivienda = dr["Direccion"].ToString();
                        en.localidadVivienda = dr["Localidad"].ToString();
                        en.maps = dr["Maps"].ToString();

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
    }
}
