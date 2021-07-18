using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    /// <summary>
    /// Clase ENFavorito, en esta clase declaramos los atributos de las viviendas favoritas y llamamos a los metodos que trabajan con ellas 
    /// </summary>
    public class ENFavoritos
    {
        private string _usuario;
        private string _viviendaDire;
        private string _viviendaLoca;

        public string usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }

        public string viviendaDire
        {
            get { return _viviendaDire; }
            set { _viviendaDire = value; }
        }

        public string viviendaLoca
        {
            get { return _viviendaLoca; }
            set { _viviendaLoca = value; }
        }
        /// <summary>
        /// Constructor por defecto de ENFavorito
        /// </summary>
        public ENFavoritos()
        {

        }
        /// <summary>
        ///Método que llama a crear lista fav de CADFavoritos 
        /// </summary>
        /// <returns>Devuelve true si se ha podido crear</returns>
        public bool createListaFav()
        {
            CADFavoritos c = new CADFavoritos();
            return c.createListaFav(this);
        }
        /// <summary>
        /// Método que se encarga de leer los favoritos
        /// </summary>
        /// <returns>Devuelve true si se ha podido leer</returns>
        public bool readfav()
        {
            CADFavoritos c = new CADFavoritos();
            return c.readfav(this);
        }
        /// <summary>
        /// Método que llama a existe de CADFavoritos
        /// </summary>
        /// <returns>Devuelve true si existe el favorito</returns>
        public bool existe()
        {
            CADFavoritos c = new CADFavoritos();
            return c.exite(this);
        }

        /// <summary>
        /// Método que lee el favorito siguiente si hay 
        /// </summary>
        /// <returns>Devuelve true si existe y consigue leer el siguiente</returns>
        public bool nextFav()
        {
            CADFavoritos c = new CADFavoritos();
            return c.nextFav(this);
        }

    }
}
