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
            set;
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

        List<int> content
        {
            get;
            set;
        }

        string type
        {
            get;
            set;
        }
    
        void getContent();
    }
}
