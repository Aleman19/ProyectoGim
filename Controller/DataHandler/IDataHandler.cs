using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.DataHandler
{
    /// <summary>
    /// Contrato para elementos que manejan datos.
    /// </summary>
    public interface IDataHandler
    {
        /// <summary>
        /// Lee los datos.
        /// </summary>
        public void ReadData();

        /// <summary>
        /// Escribe los datos.
        /// </summary>
        public void WriteData();
    }
}
