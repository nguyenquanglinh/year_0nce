using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimDuongTrenForm
{
    public class Hinh
    {
        public Hinh()
        {
            tapDinh = new List<IDiem>();
            tapCanh = new List<Canh>();
        }
        public List<IDiem> tapDinh;
        public List<Canh> tapCanh;
    }
}
