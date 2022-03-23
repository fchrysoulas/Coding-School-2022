using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_09 {

    public class Cook {


        public Cook() {

        }


        public string ToastBread() {

            Thread.Sleep(3000); 

            return "Bread Ready!";
        
        }

        public string FryBacon() {

            Thread.Sleep(3000);

            return "Bacon Ready!";

        }

    }

    public class CookAsync {


        public CookAsync() {

        }


        public async Task<string> ToastBread() {

            await Task.Delay(3000);

            return "Bread Ready!";

        }

        public async Task<string> FryBacon() {

            await Task.Delay(5000);

            return "Bacon Ready!";

        }


        public async Task<string> SliceTomatoes() {

            await Task.Delay(20000);

            return "Tomatoes Ready!";

        }

    }


}
