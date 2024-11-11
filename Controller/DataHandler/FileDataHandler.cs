using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.DataHandler
{
    /// <summary>
    /// Implementación de <see cref="IDataHandler"/> cuando se usan archivos.
    /// </summary>
    /// <seealso cref="Controller.DataHandler.IDataHandler"/>
    public class FileDataHandler : IDataHandler
    {
        /// <summary>
        /// Lee los datos desde un archivo.
        /// </summary>
        public void ReadData()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Escribe los datos.
        /// </summary>
        /// <exception cref="System.NotImplementedException"></exception>
        public void WriteData()
        {
            throw new NotImplementedException();
        }
    }
}
