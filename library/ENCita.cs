using library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    /// <summary>
    /// Clase encargada de declarar los atributos de una cita y llamar a los metodos de CADCita
    /// </summary>
    public class ENCita
    {
        private string fecha;
        private int _hora;
        private int _dia;
        private int _año;
        private int _mes;
        private string lugar;
        private string _usuario;
        public int mes
        {
            get { return _mes; }
            set { _mes = value; }
        }
        public int hora
        {
            get { return _hora; }
            set { _hora = value; }
        }
        public int dia
        {
            get { return _dia; }
            set { _dia = value; }
        }
        public int año
        {
            get { return _año; }
            set { _año = value; }
        }
        public string lugarCita
        {
            get { return lugar; }
            set { lugar = value; }
        }
        public string usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public ENCita()
        {

        }
        /// <summary>
        /// constructor de copia
        /// </summary>
        /// <param name="año"></param>
        /// <param name="dia"></param>
        /// <param name="hora"></param>
        /// <param name="lugar"></param>
        /// <param name="usu"></param>
        public ENCita(int año, int dia, int hora, string lugar, string usu)
        {
            this.año = año;
            this.dia = dia;
            this.hora = hora;
            this.lugarCita = lugar;
            usuario = usu;
        }
        /// <summary>
        /// Método que llama a crear cita 
        /// </summary>
        /// <returns>Devuelve true si hemos podido crear la cita</returns>
        public bool createCita()
        {
            CADCita c = new CADCita();
            return c.createCita(this);
        }

    }
}
