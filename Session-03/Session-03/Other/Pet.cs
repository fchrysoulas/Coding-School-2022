using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03 {

    // class
    internal class Pet {

        // property - PascalCasing
        public string Name { get; set; }
        public bool Hungry { get; set; }
        public int Energy { get; set; }
        public int Mood { get; set; }


        public string SkinType { get; set; }
        public string FoodType { get; set; }


        private const int RECOVERY_RATE_DAY_ENERGY = 1;
        private const int RECOVERY_RATE_NIGHT_ENERGY = 2;

        private const int RECOVERY_RATE_DAY_MOOD = 2;
        private const int RECOVERY_RATE_NIGHT_MOOD = 3;

        public DateTime DoB { get; set; }

        // TODO: CALCULATE AGE DEPENDING ON DATE OF BIRTH
        public ushort Age { get; }

        // constructor
        public Pet() {
            Age = 0;
        }

        // method - function
        public void Play() {


        }

        // Verb 
        public bool Sleep(int hour, bool isDay) {

            if (isDay) {
                RecoverEnergy(hour, RECOVERY_RATE_DAY_ENERGY);
                RecoverMood(hour, RECOVERY_RATE_DAY_MOOD);

               // Recover(hour, RECOVERY_RATE_DAY_ENERGY, RECOVERY_RATE_DAY_MOOD );
            }
            else {

               //Recover(hour, RECOVERY_RATE_NIGHT_ENERGY, RECOVERY_RATE_NIGHT_MOOD);
                RecoverEnergy(hour, RECOVERY_RATE_NIGHT_ENERGY);
                RecoverMood(hour, RECOVERY_RATE_NIGHT_MOOD);
            }


            Energy++; // postfix increment
            ++Energy; // prefix increment

            Energy += 1;
            Energy = Energy + 1;

            Energy--;

            return true;
        }



        public void DoSomething() {

            if (false) {


            }
        }


        private void RecoverEnergy(int hour, int recoveryRate) {

            Energy += hour * recoveryRate;
        }

        private void RecoverMood(int hour, int recoveryRate) {

            Mood += hour * recoveryRate;
        }


        private void DoSomething2(PetTypeEnum petType) {

            int petNum = (int)petType;

            if (petType == PetTypeEnum.Aquatic) {
                // TODO: DO 1
            }
            else if (petType == PetTypeEnum.Reptile) {
                // TODO: DO 2
            }
            else if (petType == PetTypeEnum.Mamal) {
                // TODO: DO 3
            }
            else {
                // TODO: DO 4
            }


            switch (petType) {
                case PetTypeEnum.Mamal:
                    // TODO: DO 3
                    break;
                case PetTypeEnum.Reptile:
                    // TODO: DO 2
                    break;
                case PetTypeEnum.Aquatic:
                    // TODO: DO 1
                    break;
                default:
                    // TODO: DO 4
                    break;
            }


        }

        //private void Recover(int hour, int recoveryRateEnergy,int recoveryRateMood) {

        //    Energy += hour * recoveryRateEnergy;
        //    Mood += hour * recoveryRateMood;

        //}



        //private string _name;

        //public string GetName() {
        //    return _name;

        //}

        //public void SetName(string name) {
        //    _name = name;

        //}
    }
}
