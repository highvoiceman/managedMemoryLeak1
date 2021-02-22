using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryLeak1
{
    class LeakyData
    {
        public int SomeData = 10;

        public event EventHandler SomeEvent;
    }
}
