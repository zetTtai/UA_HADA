using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using library;


namespace library
{
    /// <summary>
    /// Clase ENVivienda, clase encargadad de definir los atributos de una vivienda y llamar a los métodos de CADVivienda
    /// </summary>
    public class ENVivienda
    {

        private int _metroscuadrados;
        private int _numeroDormitorios;
        private int _numeroBaños;
        private string _direccion;
        private int _precio;
        private string _localidad;
        private string _descripcion;
        private string _imagenUrl;
        private string _maps;
        private string _dueño;
        private int _id;
        private string _categoria;
        private string _reforma;

        public int id
        {
            get;
            set;
        }
        public string dueño
        {
            get { return _dueño; }
            set { _dueño = value; }
        }
        public string imagenUrl
        {
            get { return _imagenUrl; }
            set { _imagenUrl = value; }
        }
        public string maps
        {
            get { return _maps; }
            set { _maps = value; }
        }

        public string categoria
        {
            get { return _categoria; }
            set { _categoria = value; }
        }

        public string reforma
        {
            get { return _reforma; }
            set { _reforma = value; }
        }

        public int metrosCuadradosVivienda
        {
            get { return _metroscuadrados; }
            set { _metroscuadrados = value; }
        }
        public int numeroDormitoriosVivienda
        {
            get { return _numeroDormitorios; }
            set { _numeroDormitorios = value; }
        }
        public int numeroBañosVivienda
        {
            get { return _numeroBaños; }
            set { _numeroBaños = value; }
        }
        public string direccionVivienda
        {
            get { return _direccion; }
            set { _direccion = value; }
        }
        public int precioVivienda
        {
            get { return _precio; }
            set { _precio = value; }
        }
        public string localidadVivienda
        {
            get { return _localidad; }
            set { _localidad = value; }
        }
        public string descripcionVivienda
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
        /// <summary>
        /// Constructor de copia de ENVivienda
        /// </summary>
        public ENVivienda()
        {

        }
        /// <summary>
        /// Constructor a partir de los atributos de ENVivienda
        /// </summary>
        /// <param name="metroscuadrados"></param>
        /// <param name="numDormitorios"></param>
        /// <param name="numBaños"></param>
        /// <param name="dirreccion"></param>
        /// <param name="precio"></param>
        /// <param name="localidad"></param>
        /// <param name="descripcion"></param>
        public ENVivienda(int metroscuadrados, int numDormitorios, int numBaños, string dirreccion, int precio, string localidad, string descripcion)
        {
            this.metrosCuadradosVivienda = metroscuadrados;
            this.numeroDormitoriosVivienda = numDormitorios;
            this.numeroBañosVivienda = numBaños;
            this.direccionVivienda = direccionVivienda;
            this.precioVivienda = precio;
            this.localidadVivienda = localidad;
            this.descripcionVivienda = descripcion;
        }
        /// <summary>
        /// Método encargado de llamar a createVivienda de la clase CADVivienda
        /// </summary>
        /// <returns>Devuelve true si se ha podido crear </returns>
        public bool createVivienda()
        {
            CADVivienda c = new CADVivienda();
            return c.createVivienda(this);
        }
        /// <summary>
        /// Método encargado de llamar a readVivienda de la clase CADVivienda
        /// </summary>
        /// <returns> Devuelve true si conseguimos leer la vivienda</returns>
        public bool readVivienda()
        {
            CADVivienda c = new CADVivienda();
            return c.readVivienda(this);
        }
        /// <summary>
        /// Método encargado de llamar a readFavViviendas de la clase CADVivienda
        /// </summary>
        /// <returns> Devuelve true si hemos podido leer la vivienda Favorita</returns>
        public bool readFavVivienda()
        {
            CADVivienda c = new CADVivienda();
            return c.readFavVivienda(this);
        }
        /// <summary>
        /// Método encargado de llamar readFollowingVivienda de la clase CADVivienda
        /// </summary>
        /// <returns>Devuevlve true si hemos podido leer la siguiente vivienda</returns>
        public bool readFollowingVivienda()
        {
            CADVivienda c = new CADVivienda();
            return c.readFollowingVivienda(this);
        }
        /// <summary>
        /// Método encargado de leer la vivienda a la que pertenece un usuario, este metodo llama a readUsuVivienda de la clase CADVivienda
        /// </summary>
        /// <returns>Devuelve true si hemos conseguido leer la vivienda</returns>
        public bool readUsuVivienda()
        {
            CADVivienda c = new CADVivienda();
            return c.readUsuVivienda(this);
        }
  

    }
}
