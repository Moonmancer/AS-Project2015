using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public interface iProducts
    {
        int id
        {
            get;
        }

        string name
        {
            get;
            set;
        }

        decimal price
        {
            get;
            set;
        }

        string type
        {
            get;
            set;
        }
    }
}
