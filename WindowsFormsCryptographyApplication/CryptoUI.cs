using Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCryptographyApplication
{
    public partial class CryptoUI : Form, IUserInteractor
    {
        public CryptoUI()
        {
            InitializeComponent();
        }

        public void ShowWindow()
        {
            Show();
        }
    }
}
