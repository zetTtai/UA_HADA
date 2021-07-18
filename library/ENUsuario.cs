using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    /// <summary>
    /// Clase ENUsuario en ella se declaran los atributos que posee un usuario asi como se hacen las llamadas a los metodos de CADUsuario
    /// </summary>
    public class ENUsuario
    {
        //Atributos
        private string _nif;
        public string nif
        {
            set; get;
        }
        private string _nombre;
        public string nombre
        {
            set; get;
        }
        private string _contraseña;
        public string contraseña
        {
            set; get;
        }

        private string _telefono;
        public string telefono
        {
            set; get;
        }
        private string _email;
        public string email
        {
            set; get;
        }
        public List<string> favs;
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public ENUsuario()
        {

        }
        /// <summary>
        /// Constructor de copia de usuario 
        /// </summary>
        /// <param name="nif"></param>
        /// <param name="nombre"></param>
        /// <param name="contraseña"></param>
        /// <param name="edad"></param>
        /// <param name="telefono"></param>
        /// <param name="email"></param>
        public ENUsuario(string nif, string nombre, string contraseña,
            int edad, int telefono, string email)
        {

        }
        /// <summary>
        /// Constructor de copia de un usuario dado otro usuario
        /// </summary>
        /// <param name="usuario"></param>
        public ENUsuario(ENUsuario usuario)
        {

        }
        /// <summary>
        /// Método encargado de llamar a createUsuario de la clase CADUsuario 
        /// </summary>
        /// <returns> Devuelve true si hemos podido crear el usuario </returns>
        public bool createUsuario()
        {
            CADUsuario c = new CADUsuario();
            return c.createUsuario(this);
        }
        /// <summary>
        /// Método encargado de llamar a a readUsuario de la clase CADUsuario 
        /// </summary>
        /// <returns>Devuelve true si conseguimos leer el usuario</returns>
        public bool readUsuario()
        {
            CADUsuario c = new CADUsuario();
            return c.readUsuario(this);
        }
        /// <summary>
        /// Método encargado de añadir una vivienda a un usuario 
        /// </summary>
        /// <param name="en"></param>
        /// <returns>Devuelve true si se ha podido añadir</returns>
        public bool addVivienda(ENVivienda en)
        {
            CADUsuario c = new CADUsuario();
            return c.addVivienda(this, en);
        }
    }
}
