using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultCryptoBLL.Services
{
    /// <summary>
    /// Provides mechanism to measure actions
    /// </summary>
    public static class Timer
    {
        #region Public methods

        /// <summary>
        /// Will mesure time it took for an action to start and end
        /// </summary>
        /// <param name="action">Action to measure.</param>
        /// <returns>Time span it took for the action to complete.</returns>
        public static TimeSpan MeasureTimeForAction(Action action)
        {
            Stopwatch s = new Stopwatch();
            s.Start();
            action();
            s.Stop();
            return s.Elapsed;
        }

        #endregion
    }
}
