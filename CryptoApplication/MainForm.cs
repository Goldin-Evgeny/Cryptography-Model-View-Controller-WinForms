using System.Windows.Forms;
using Contracts;
using CryptoWindowsFormsApplication.Cryptography;
using DefalutCryptoDAL;
using DefaultCryptoBLL;
using DefaultCryptoBLL.Cryptography.Model;
using DefaultCryptoBLL.Services;

namespace CryptoApplication
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            ICryptographyView view = new CryptographyView();
            ICryptography model = new Cryptography();
            IDataAccess dal = new FileIO();
            IFileCryptographer bl = new FileCryptographer(dal);


            CryptographyController controller = new CryptographyController(view, model, bl);

            Controls.Add((UserControl) view);
        }
    }
}
