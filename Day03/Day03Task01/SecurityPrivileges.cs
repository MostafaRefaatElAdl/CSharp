using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03Task01
{
    [Flags]
    enum SecurityPrivileges:byte
    {
        Guest=1, Developer=2, Secretary=4, DBA=8
    }
}
