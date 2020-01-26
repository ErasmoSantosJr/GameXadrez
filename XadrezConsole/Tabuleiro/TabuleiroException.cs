using System;
using System.Collections.Generic;
using System.Text;

namespace Tabuleiro
{
    class TabuleiroException : Exception
    {

        public TabuleiroException(string mensage) : base(mensage)
        {
        }
    }
}
