using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_09.Impl {


    public class Duck {

        public Duck() { 
        
        }

        public virtual void Quack() {
            // DO QUACK
        }

        public virtual void Eat() {
            // DO EAT
        }

        public virtual void Fly() {
            // DO FLY
        }

        public virtual void Swim() {
            // DO SWIM
        }
    }

    public class SwampDuck : Duck {

        public SwampDuck() {

        }

        public void Dive() { }
    }


    public class RubberDuck : Duck {

        public RubberDuck() {

        }


        public override void Eat() {
        }

        public override void Fly() {
        }
    }


    public class MechanicalDuck : SwampDuck {



        public override void Quack() {
            
        }

        public override void Eat() {
        }

    }
}
