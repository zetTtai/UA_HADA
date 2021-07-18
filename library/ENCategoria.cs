using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    /// <summary>
    /// clase ENCategoria, clase encargada de llamar a los metodos de CADCategoria y declarar sus variables
    /// </summary>
    public class ENCategoria
    {
        private string tipo;
        private List<ENVivienda> viviendas;
        public string _tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public List<ENVivienda> _viviendas
        {
            get { return viviendas; }
            set { viviendas = value; }
        }
        /// <summary>
        /// Constructor por defecto de ENCategoria
        /// </summary>
        public ENCategoria()
        {
            tipo = "NaN";
            viviendas = null;
        }
        /// <summary>
        /// Constructor de copia de ENCategoria
        /// </summary>
        /// <param name="tipo"></param>
        /// <param name="viviendas"></param>
        public ENCategoria(string tipo, List<ENVivienda> viviendas)
        {
            this.tipo = tipo;
            this.viviendas = viviendas;
        }
        /// <summary>
        /// Método que crea una categoria
        /// </summary>
        /// <returns>Devuelve true si hemos podido crear la categoria</returns>
        public bool createCategoria()
        {
            CADCategoria categoria = new CADCategoria();
            return categoria.createCategoria(this);
        }
        /// <summary>
        /// Método que llama a readCAtegoria de CADCategoria 
        /// </summary>
        /// <returns> si la categoria se ha podido leer devolvemos true</returns>
        public bool readCategoria()
        {
            CADCategoria categoria = new CADCategoria();
            return categoria.readCategoria(this);
        }

    }
}
