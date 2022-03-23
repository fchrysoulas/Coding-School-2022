namespace Calc {


    [Serializable]
    public class Pet {

        public string Name { get; set; }
        public int Age { get; set; }

        public Pet() {
            Name = string.Empty;
            Age = 0;
        }


        public Pet ShallowCopy() {
            return (Pet)MemberwiseClone();
        }
    }


    public class Manager { 
    
    }

    public class PetManager : Manager {

        public List<Pet> Pets { get; set; }

        public PetManager() {
            Pets = new List<Pet>(); 
        }


        public Pet AddPet() {

            return AddPet("{enter name}", 0);
        }

        public Pet AddPet(string name) {

            return AddPet(name, 0);
        }

        public Pet AddPet(string name, int age) {

            Pet pet = new Pet() {
                Name = name,
                Age = age,
            };

            Pets.Add(pet);

            return pet;
        }

    }

    [Serializable]
    public class PetShop {

        public List<Pet>? Pets { get; set; }

        public PetShop() {

        }

        
       
    }
}