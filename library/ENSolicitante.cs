using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    class ENSolicitante:ENUsuario
    {
        //Relaciones
        private List<ENCita> _citas;
        public List<ENCita> citas
        {
            set; get;
        }
        private List<ENVivienda> _viviendas;
        public List<ENCita> viviendas
        {
            set; get;
        }
        public ENSolicitante()
        {

        }
        public ENSolicitante(string nif, string nombre, string apellido,
            int edad, int telefono, string email)
        {

        }
        public ENSolicitante(ENSolicitante solicitante)
        {

        }
        public bool createSolicitante()
        {
            return false;
        }
        public bool readSolicitante()
        {
            return false;
        }
        public bool updateSolicitante()
        {
            return false;
        }
        public bool deleteSolicitante()
        {
            return false;
        }
    }
}
