using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhanSu
{
    class ChucVu
    {
        private string tencv;
        private string macv{get; set;}
      

        

        public string Macv
        {
            get
            {
                return macv;
            }

            set
            {
                macv = value;
            }
        }
        public ChucVu(string tencv, string macv)
        {
            this.Tencv = tencv;
            this.Macv = macv;
        }
    }
}
