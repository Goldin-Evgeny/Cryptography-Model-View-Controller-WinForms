using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface ICryptographyAlgorithmModel
    {
        CryptographyType CryptographyType { get; set; }
        int Repeats { get; set; }
    }
}
