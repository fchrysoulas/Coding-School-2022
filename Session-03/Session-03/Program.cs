using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03 {


    // PUBLIC (EVERYWHERE) > INTERNAL (PROJECT LEVEL) > PRIVATE (CLASS LEVEL)

    public class Program {

        static void Main(string[] args) {



            //var pet = new Pet();



            //Console.WriteLine(pet.Name);

            //decimal y = 1.0m;

            //object x = 1;

            //int z = (int)x; // HARD CAST (VALUE TYPES)

            //string a = (x as string); // SOFT CAST 

            //if (a != null) { 
            //    // DEN MPORW NA KANW CAST!
            //}


            //string c = null;
            //int k = Convert.ToInt32(c);


            //int? d = null;
            //string d1 = Convert.ToString(d);

            //string s1 = string.Empty;
            //string s2 = "";

            ////int p = Int32.Parse(c);


            //int i3 = 100;
            //int i4 = 50;

            //string format = string.Format("the sum of {1} and {0} is {2}", i3, i4, i3 + i4);

            //string format2 = $"the sum of {i3} and {i4} is {i4 + i3}";

            //Console.WriteLine(format2);

            ////**************************************************************************
            //object jimi = new Cat();

            ////(jimi as Cat).            

            //var dimi = new Cat();
            //dimi.Name = "dimi";

            //var nemo = new Fish();


            //var petShop = new PetShop();

            //petShop.CatCages = new Cat[5];
            //petShop.CatCages[0] = dimi;

            //petShop.FishCages = new Fish[10];
            //petShop.FishCages[1] = nemo;


            //bool u = dimi.Sleep(8, false);

            ////**************************************************************************

            //Iterations iter = new Iterations();

            //string iterFor = iter.ForTest();
            //Console.WriteLine(iterFor);

            //string iterWhile = iter.WhileTest();
            //Console.WriteLine(iterWhile);


            //string iterDo = iter.DoTest();
            //Console.WriteLine(iterDo);


            //// *************************************************************
            //string name = "fotis chrysoulas";
            //var c1 = new Class1();

            //string reversedName = c1.ReverseStingFor(name);
            //Console.WriteLine(reversedName);


            //// *************************************************************
            //string number = Console.ReadLine();

            //var c2 = new Class2();
            //// ....


            Food meatBeef = new Food();
            meatBeef.Calories = 1000;
            meatBeef.MeatType = MeatTypeEnum.Beef;
            meatBeef.Qty = 100;

            //Food meatChicken = new Food() {
            //    Calories = 500,
            //    MeatType = MeatTypeEnum.Chicken,
            //    Qty = 50
            //};

            Class1 c = new Class1();

            ////c.Hunt(false, PetTypeEnum.Mamal);

            bool hungry = true;


            c.Eat(hungry);

            Console.WriteLine(c.ExMessage);

            //c.Eat(hungry, meatBeef);

            //c.Eat(meatBeef);

            //Console.WriteLine(meatBeef.Qty);


            //Shape s = new Shape(); 

            var circle = new Circle() {
                Radius = 10
            };
            circle.Area();

            var rectangle = new Rectangle() {
                 X = 2,
                 Y = 3
            };
            rectangle.Area();


            Class2 c2 = new Class2();

            c2.CalcArea(circle);

            c2.CalcArea(rectangle);


            Console.ReadLine();
        }
    }
}
