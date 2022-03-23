using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc {


    internal interface INutrition { 
        int Vitamins { get; set; }
    }

    internal interface IFood {
        
        int Calories { get; set; }

        void Consume<T>();
    }

    internal class PetFood : IFood, INutrition {

        public int Calories { get; set; }

        public int Vitamins { get; set; }

        public PetFood() {

        }

        public void Consume<T>() {
           
        }
    }


    internal class Food : IFood {

        public int Calories { get; set; }

        public Food() {

        }


        // generic method
        public void Consume<T>(string s, T t) {


            return; // new List<T>();

        }
    }
}
