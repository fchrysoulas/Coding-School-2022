using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03 {

    internal class Iterations {


        public Iterations() {

        }

        public string ForTest() {

            string s = string.Empty;

            for (int i = 0; i < 10; i++) {

                 s += $"pos: {i} ";

            }

            return s;
        
        }

        public string WhileTest() {

            string s = string.Empty;

            int i = 0;
            while (i < 10) {

                s += $"pos: {i} ";

                i++;
            }



            return s;
        }

        public string DoTest() {

            string s = string.Empty;

            int i = 0;

            do {
                
                s += $"pos: {i} ";

                i++;

            } while (i < 10);

            return s;
        }

    }
}
