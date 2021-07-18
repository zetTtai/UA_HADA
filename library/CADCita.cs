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
    /// Clase CADCita, clase encargada de insertar y leer las citas de un usuario en una base de datos
    /// </summary>
    public class CADCita
    {
        private string constring;
        /// <summary>
        /// Método constructor de CADCita, se encarga de conectar cita con la base de datos
        /// </summary>
        public CADCita()
        {
            constring = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ToString();
        }
        /// <summary>
        /// Método para crear una cita 
        /// </summary>
        /// <param ENCita="en"></param>
        /// <returns>Devolvemos true si hemos conseguido crear la cita </returns>
        public bool createCita(ENCita en)
        {

            bool ok = false;
            var rand = new Random();
            //Creamos valores randoms para crear la cita 
            en.hora = rand.Next(9, 20 + 1);
            en.dia = rand.Next(1, 30 + 1);
            en.mes = rand.Next(1, 12 + 1);
            en.año = 2020;
            try
            {
                SqlConnection c = new SqlConnection(constring);
                c.Open();
                //Insertamos la cita segun su hora, su dia y su mes
                SqlCommand command = new SqlCommand("Insert Into Cita (Hora, Dia, Mes, Año, Lugar, Cliente) VALUES ('" + en.hora + "','" + en.dia + "','" + en.mes + "','" + en.año  + "','" + en.lugarCita + "','" + en.usuario + "')", c);
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

            //bool ok = false;
            
        }

    }
}
