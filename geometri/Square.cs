using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometri
{
    public class Square
    {
        private int a;
        public int A
        {
            get
            {
                return this.a;
            }
            set
            {
                this.a = value;
            }
        }
        public int perimeter()
        {
            return this.a * 4;
        }
        public int area()
        {
            return this.a * a;
        }
        public Square()
        {

        }
    }
}
