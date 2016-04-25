using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DefaultCryptoBLL.Cryptography.Exceptions
{
    /// <summary>
    /// Exception to represent an illegal key creation.
    /// </summary>
    [Serializable]
    internal class InvalidEncryptionKeyException : Exception
    {
        #region Constructors

        public InvalidEncryptionKeyException()
        {
        }

        public InvalidEncryptionKeyException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidEncryptionKeyException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        #endregion
    }
}
