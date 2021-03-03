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
        public LargeObject[] LargeObjects = new LargeObject[10];

        public LeakyApp()
        {
            for(int x=0;x<LeakyDatas.Length;++x)
            {
                var data = new LeakyData();
                new LeakyEventHandler().Subscribe(data);
                LeakyDatas[x] = data;
            }

            for(int y=0;y< LargeObjects.Length;++y)
            {
                LargeObjects[y] = new LargeObject();
            }
        }
    }
}
