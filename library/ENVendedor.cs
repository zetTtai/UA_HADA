using library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    class ENVendedor:ENUsuario
    {
        //Relaciones
        private List<ENVivienda> _viviendas;
        public List<ENVivienda> viviendas
        {
            set; get;
        }
        public ENVendedor()
        {

        }
        public ENVendedor(string nif, string nombre, string apellido,
            int edad, int telefono, string email)
        {
            
        }
        public ENVendedor(ENVendedor vendedor)
        {

        }
        public bool createVendedor()
        {
            return false;
        }
        public bool readVendedor()
        {
            return false;
        }
        public bool updateVendedor()
        {
            return false;
        }
        public bool deleteVendedor()
        {
            return false;
        }
    }
}
