using Infrastructure;
using System;
using System.Windows.Forms;

namespace Contracts
{
    public interface IController
    {
    
        event EventHandler NextView;
        UserControl View { get; }
    }
}
