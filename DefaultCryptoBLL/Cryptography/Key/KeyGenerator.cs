using DefaultCryptoBLL.Cryptography.Exceptions;
using Infrastructure;
using System;

namespace DefaultCryptoBLL.Cryptography.Key
{
    /// <summary>
    /// Provides method to create Key models instances.
    /// </summary>
    internal class KeyGenerator
    {
        #region Class variable

        private static readonly Random Random = new Random();

        #endregion

        #region Internal methods

        /// <summary>
        /// Generates a random key and return a key model instance.
        /// </summary>
        /// <returns>KeyModel Instance.</returns>
        internal static Infrastructure.Key CreateInstance(int maxKeyValue)
        {
            int key = Random.Next(1, maxKeyValue);
            Infrastructure.Key keyModel = new KeyModel { KeyModel = key };
            return keyModel;
        }

        /// <summary>
        /// Parses string representation of key into KeyModel object.
        /// </summary>
        /// <param name="key">String representation.</param>
        /// <returns>KeyModel Instance.</returns>
        internal static Infrastructure.Key Parse(string key)
        {
            int keyInt;
            if (int.TryParse(key, out keyInt))
            {
                return new KeyModel { KeyModel = keyInt };
            }

            throw new InvalidEncryptionKeyException();
        }

        /// <summary>
        /// Parses a string array representation of keys into KeyModel array.
        /// </summary>
        /// <param name="stringKeys">String array representation.</param>
        /// <returns>KeyModel instances.</returns>
        internal static Infrastructure.Key[] Parse(string[] stringKeys)
        {
            //Read about extention methods
            Infrastructure.Key[] keys = new KeyModel[stringKeys.Length];
            for (int i = 0; i < stringKeys.Length; i++)
            {
                keys[i] = Parse(stringKeys[i]);
            }
            return keys;
        }

        #endregion

    }
}
