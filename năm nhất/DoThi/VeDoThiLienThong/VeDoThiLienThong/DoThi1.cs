using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeDoThiLienThong
{
    public interface ThuatToanDuyen
    {
        List<object> Duyet(DoThi1 dt);
    }

    class Bfs : ThuatToanDuyen
    {

        public List<object> Duyet(DoThi1 dt)
        {
            throw new NotImplementedException();
        }
    }

    class Dfs : Bfs
    {

        public List<object> Duyet(DoThi1 dt)
        {
            throw new NotImplementedException();
        }
    }
     

    class DoThi1
    {
        public int[,] Arr;
        public object TapDinh, TapCanh;

        public void ThemDinh()
        {

        }
        public void ThemCanh()
        {

        }

        public List<object> Duyet(ThuatToanDuyen duyet)
        {
            return duyet.Duyet(this);
        }

    }
}
