using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_01_2023_WpfApp_Text_format
{
    public class for_Toolbar
    {
        public int size1 { get; set; }
        public IList<int> list { get; set; }

        public for_Toolbar()
        {
            for (int i = 0; i < 20; i++)
            {
                if (i % 2 == 0)
                {
                    list.Add(i);
                }
            }
            
        }
    }
}
