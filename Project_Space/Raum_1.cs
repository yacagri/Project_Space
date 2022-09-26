using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Space
{

   
    internal class Raum_1
    {
        private Button btn1;
        private Button btn2;

        string name = "yyy";

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public Raum_1()
        {
        }

        public Raum_1(string name)
        {
            this.name = name;
        }

        public Raum_1(Button btn1, Button btn2)
        {
            this.btn1 = btn1;
            this.btn2 = btn2;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
