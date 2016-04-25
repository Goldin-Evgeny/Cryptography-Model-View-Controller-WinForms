using System;
using System.Windows.Forms;

namespace CryptoWindowsFormsApplication.ProcessProgres
{
    public interface IProcessProgressView
    {
        ProgressBar ProgressBar { get; }
        Label ProcessingLabel { get; }
        Button NextButton { get; }

        object Invoke(Delegate method);
        object Invoke(Delegate method, params object[] args);

    }
}
