using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tabuleiro
{
    class TabuleiroException:Exception
    {
        public TabuleiroException(string msg) : base(msg) 
        {
        
        }
    }
}
