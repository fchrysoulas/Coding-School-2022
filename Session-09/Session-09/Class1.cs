using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_09 {

    internal class FotisButton : Button {

        public override string Text { get => "Mr." + base.Text; set => base.Text = value; }

    }
}
