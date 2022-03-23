using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc {

    /// <summary>
    ///  ctrl K + F
    /// </summary>
    public class Class1 {


        public Class1() {
                
        }




        public void Do(string s, int i = 0) { 
        
        
        }



    }


    public class Class2 {


        public Class2() {
            Class1 c = new Class1();
            c.Do("a");

            c.Do("b", 2);
        }




    }

}
