using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryLeak1
{
    class LeakyEventHandler
    {
        public void Subscribe(LeakyData data)
        {
            data.SomeEvent += Data_SomeEvent;
        }

        private void Data_SomeEvent(object sender, EventArgs e)
        {
            
        }
    }
}
