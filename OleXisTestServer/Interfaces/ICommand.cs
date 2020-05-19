using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NetClasses;

namespace OleXisTestServer
{
    public interface ICommand
    {
        byte[] Execute(out CommandError error);
    }
}
