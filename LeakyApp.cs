using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryLeak1
{
    class LeakyApp
    {
        public LeakyData[] LeakyDatas = new LeakyData[100];

        public LeakyApp()
        {
            for(int x=0;x<LeakyDatas.Length;++x)
            {
                var data = new LeakyData();
                new LeakyEventHandler().Subscribe(data);
                LeakyDatas[x] = data;
            }
        }
    }
}
