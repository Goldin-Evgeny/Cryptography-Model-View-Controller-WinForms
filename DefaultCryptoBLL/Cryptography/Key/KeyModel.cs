using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultCryptoBLL.Cryptography.Key
{
    /// <summary>
    /// Key model implementation.
    /// </summary>
    class KeyModel : Infrastructure.Key
    {
        #region Constructors

        public KeyModel(int key)
        {
            KeyModel = key;
        }

        public KeyModel()
        {

        }

        #endregion

        #region Public methods

        /// <summary>
        /// String representation of key.
        /// </summary>
        /// <returns>String representation of key</returns>
        public override string ToString()
        {
            return KeyModel.ToString();
        }

        #endregion
    }
}
