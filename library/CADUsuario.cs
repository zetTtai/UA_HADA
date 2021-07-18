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
    /// Clase CADUsuario encargada de interactuar con la tabla usuario de la base de datos
    /// </summary>
    public class CADUsuario
    {
        private string constring;
        /// <summary>
        /// Método encargado de conectar con la base de datos
        /// </summary>
        public CADUsuario()
        {
            constring = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ToString();
        }
        /// <summary>
        /// Método auxiliar para comprobar que esta todo bien 
        /// </summary>
        /// <param string="nif"></param>
        /// <returns>Devolvemos true si esta todo bien</returns>
        private bool todoOk(string nif)
        {
            bool finded = false;
            SqlConnection c = new SqlConnection(constring);
            c.Open();
            SqlCommand com = new SqlCommand("Select * from Usuarios", c);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read() && finded == false)
            {
                if (nif == dr["nif"].ToString())
                {
                    finded = true;
                }

            }
            dr.Close();
            c.Close();
            return finded;
        }
        /// <summary>
        /// Método para crear un usuario en la base de datos
        /// </summary>
        /// <param ENUsuario="en"></param>
        /// <returns>Devuelve true si hemos conseguido insertar el usuario en la base de datos</returns>
        public bool createUsuario(ENUsuario en)
        {
            bool ok = false;
            if (!todoOk(en.nif))
            {
                try
                {
                    SqlConnection c = new SqlConnection(constring);
                    c.Open();
                    //Insertamos el usuario con un dni, un nombre, un teléfono, un email y una contraseña
                    SqlCommand command = new SqlCommand("Insert Into Usuarios (Nif, Nombre, Telefono, email, contraseña) VALUES ('" + en.nif + "','" + en.nombre + "','" + en.telefono + "','" + en.email + "','" + en.contraseña + "')", c);
                    ok = true;
                    command.ExecuteNonQuery();
                    c.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine("User operation has failed. Error: {0}", e.Message);
                    return false;
                }
            }
            return ok;
        }
        /// <summary>
        /// Método encargado de leer un usuario de la bsae de datos
        /// </summary>
        /// <param name="en"></param>
        /// <returns></returns>
        public bool readUsuario(ENUsuario en)
        {
            bool ok = false;
            try
            {
                SqlConnection c = new SqlConnection(constring);
                c.Open();
                //Seleccionamos los usuarios que tienen el mismo email y contraseña
                SqlCommand com = new SqlCommand("Select * from Usuarios where Email like '%" + en.email + "%' and Contraseña like '%" + en.contraseña + "%'", c);
                SqlDataReader dr = com.ExecuteReader();

                while (dr.Read())
                {
                    //Insertamos los valores en la clase ENUsuario
                    en.nombre = dr["Nombre"].ToString();
                    en.email = dr["Email"].ToString();
                    en.telefono = dr["Telefono"].ToString();
                    en.nif = dr["Nif"].ToString();
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
        /// <summary>
        /// Método encargado de añadir una vivienda a un usuario 
        /// </summary>
        /// <param ENUsuario="en"></param>
        /// <param ENVIvienda="vi"></param>
        /// <returns>Devolvemos true si podemos añadir la vivienda</returns>
        public bool addVivienda(ENUsuario en, ENVivienda vi)
        {
            bool ok = false;
            try
            {
                SqlConnection c = new SqlConnection(constring);
                c.Open();
                SqlCommand com = new SqlCommand("Select * from Usuarios where nif like '%" + en.nif + "%'", c);
                SqlDataReader dr = com.ExecuteReader();

                while (dr.Read())
                {
                    //Si añadimos la vivienda copiamos los datos de la vivienda a usuario 
                    en.nombre = dr["Nombre"].ToString();
                    en.email = dr["Email"].ToString();
                    en.telefono = dr["Telefono"].ToString();
                    en.nif = dr["Nif"].ToString();
                    en.favs.Add(vi.direccionVivienda);
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
