using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    public class Man : Ihuman
    {
        public event Action a;

        public void run()
        {
            a();
        }
    }

    public class Enumer : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            return new ss();
        }
    }

    public class ss : IEnumerator
    {
        int postion = -1;
        string a = "123456";
        public object Current => a[postion];

        public bool MoveNext()
        {
            postion++;
            return true;
        }

        public void Reset()
        {
            postion = -1;
        }
    }
}
