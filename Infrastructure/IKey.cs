using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    /// <summary>
    /// Key model interface.
    /// </summary>
    public abstract class Key
    {
        public int KeyModel { get; set; }
        
        public abstract override string ToString();

    }
}
