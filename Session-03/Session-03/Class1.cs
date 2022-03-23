using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03 {

    public enum MeatTypeEnum {
        Beef,
        Chicken

    }


    public class Food {

        public MeatTypeEnum MeatType { get; set; }
        public int Calories { get; set; }
        public int Qty { get; set; }

        public Food() {

        }



    }


    internal class Class1 {

        public string ExMessage { get; set; }
        public string UserMessage { get; set; }

        public string Result { get; set; }

        private int _paces;

        public Class1() {
            _paces = 0;
        }

        public void Hunt(bool preyFound, PetTypeEnum petType) {

            _paces++;
            if (_paces >= 5) {
                preyFound = true;
            }

            if (preyFound) {
                Result = "Found";
                return; // "found";

            }
            else {
                Hunt(false, petType);
            }

        }


        public void Eat(int cal) {

            //Eat(!(cal == 1000));


            if (cal == 1000) {
                Eat(false);
                return;
            }

            Eat(true);

            //else {

            //}
        }

        public void Eat(bool hungry) {

            Eat(hungry, null);
        }

        public void Eat(Food food) {

            Eat(true, food);
        }

        public void Eat(bool hungry, Food food) {
            try {
                if (hungry) {

                    //if (food != null) {
                        food.Qty -= 10;
                    //}

                    hungry = false;
                }
            }
            catch (Exception ex) {
                ExMessage = ex.ToString();


                //throw;



            }
        }
    }
}
