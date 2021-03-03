using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryLeak1
{
    class LargeObject
    {
        private string LargeString;

        public LargeObject()
        {
            StringBuilder sb = new StringBuilder();
            for(int x=0;x<100000;++x)
            {
                sb.AppendLine("abcdefghijabcdefghijabcdefghijabcdefghijabcdefghijabcdefghijabcdefghijabcdefghijabcdefghijabcdefghijabcdefghijabcdefghijabcdefghij");
            }

            LargeString = sb.ToString();
        }
    }
}
