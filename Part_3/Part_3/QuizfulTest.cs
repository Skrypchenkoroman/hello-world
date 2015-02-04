using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_3
{
    interface IControl
    {
        void Paint();
    }
    interface IForm
    {
        void Paint();
    }
    class Page : IControl, IForm
    {
        public void Paint() { }
        static void Main2(string[] args)
        {
            Page pp = new Page();
            pp.Paint();

            Console.ReadKey();
        }
    } 

}
