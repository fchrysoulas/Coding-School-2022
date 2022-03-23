using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_09.Impl {

    // INTERFACES
    // GENERICS
    // COMPOSITION
    // DEPENDENCY INJECTION

    internal interface IA {
        void Do();
    }

    internal class A : IA {

        public void Do() { 
            // DO
        }
    
    }

    internal class D : IA {

        public void Do() {
            // DO
        }

    }


    internal class B {

        private IA _a;

        public B(IA a) {
            _a = a;
        }

        public void Do() {

            _a.Do();
        }

        public void DoSomethingElse () {
            // DO SOMETHING
        }
    }

    internal class C {

        

        public C() {

            A a = new A();
          //  B b = new B(d);

        //    b.Do();
        //    b.DoSomethingElse();
        }
    
    }
}
