using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03 {

    internal class Cat : Pet {


        public ushort NumberOfFeet { get; set; }

        public Cat() {
            FoodType = "CatFood";
            SkinType = "Fur";
        }


    }

    internal class Fish : Pet {

        public ushort FinSize { get; set; }
        
        public Fish() {
            FoodType = "FishFood";
            SkinType = "Scales";
        }
    }
}
