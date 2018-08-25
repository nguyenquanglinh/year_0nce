using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoThiTrenForm
{
    public class Hinh
    {
        public Hinh()
        {
            TapDinh = new List<IDiem>();
            TapCanh = new List<Canh>();
        }

        public IDiem this[string name]
        {
            get
            {
                return TapDinh.FirstOrDefault(x => x.PointName.Equals(name));
            }
        }

        //TODO: can xem lai
        public List<IDiem> TapDinh;
        public List<Canh> TapCanh;
    }
}
