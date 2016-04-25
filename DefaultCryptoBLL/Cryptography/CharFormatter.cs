using System;
using System.Collections.Generic;

namespace DefaultCryptoBLL.Cryptography
{
    /// <summary>
    /// Provides methods to format characters.
    /// </summary>
    internal class CharFormatter
    {
        private readonly IDictionary<Operator, Func<int, int, char>> _dictionary;

        #region Constructors

        internal CharFormatter()
        {
            _dictionary = new Dictionary<Operator, Func<int, int, char>>
            {
                {Operator.Add, (a, b) => (char) (a + b)},
                {Operator.Subtract, (a, b) => (char) (a - b)},
                {Operator.Devide, (a, b) => (char) (a/b)},
                {Operator.Multiply, (a, b) => (char) (a*b)}
            };
        }

        #endregion

        #region Internal methods

        /// <summary>
        /// Based on the operation provided will add, substract, divide or multiply the provided characters.
        /// </summary>
        /// <param name="a">First character.</param>
        /// <param name="b">Second character.</param>
        /// <param name="charOperator">Operation to perform.</param>
        /// <returns>New created character.</returns>
        internal char FormatNewChar(int a, int b, Operator charOperator)
        {
            var pedik = _dictionary[charOperator];
            var res = pedik(a, b);
            return res;
        }

        /// <summary>
        /// Internal enum to describe the operations that can be performed on two objects.
        /// </summary>
        internal enum Operator
        {
            Add, Subtract, Devide, Multiply
        }

        #endregion
    }
}
