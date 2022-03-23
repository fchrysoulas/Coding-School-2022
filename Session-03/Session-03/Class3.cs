using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03 {
    
    internal class Vehicle {

        public decimal Distance { get; set; }
        public decimal Time { get; set; }

        public Vehicle() {

        }


        public virtual decimal Speed() {

            return Distance / Time;
        }

    }

    internal class SpaceShip : Vehicle {

        public SpaceShip() {

        }

        public override decimal Speed() {
            return base.Speed();


        }


    }



}
