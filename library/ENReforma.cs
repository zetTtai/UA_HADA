using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    /// <summary>
    /// Clase ENReforma en ella se declaran los atributos que tienen una reforma y se llama a los metodos de CADReforma
    /// </summary>
    public class ENReforma
    {
        private string descripcion;
        private string _nombre;
        public string descripcionReforma
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public ENReforma()
        {

        }
        /// <summary>
        /// Constructor de copia
        /// </summary>
        /// <param name="desc"></param>
        /// <param name="nombre"></param>
        public ENReforma(string desc, string nombre)
        {
            this.descripcionReforma = desc;
            this.nombre = nombre;
        }
        /// <summary>
        /// Método encargado de llamar a create reforma de la clase CADReforma
        /// </summary>
        /// <returns>Devuelve true si hemos conseguido crear la reforma</returns>
        public bool createReforma()
        {
            CADReforma c = new CADReforma();
            return c.createReforma(this);
        }
        /// <summary>
        /// Método encargado de llamar a readReforma de la clase CADReforma
        /// </summary>
        /// <returns>Devuelve true si hemos conseguido leer la reforma</returns>
        public bool readReforma()
        {
            CADReforma c = new CADReforma();
            return c.readReforma(this);
        }
    }
}
