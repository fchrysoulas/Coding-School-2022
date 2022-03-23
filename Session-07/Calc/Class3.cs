using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc {


    internal class MyList<T> {




        public void Add() {


        }

    }


    internal class Class3<T> {

        private T _t;

        public Class3() {


            Food food = new Food();

            food.Consume<Food>("RC", food);


            List<Food> foodList = new List<Food>();
        }
    }

    internal class EditForm<T> {

        public EditForm() {

        }

        public T Create<T>() where T :new() {

           
            return new T();

        }

        public void Read() {
            // load
        }

        public void Delete() {

        }

        public void Update() {

        }
    }


    internal class FormManageer {



        public FormManageer() {

            var editStudents = new EditForm<Student>();

            var editProfessors = new EditForm<Professor>();


        }
    }


    internal interface IPerson { 
    
    }

    internal class Professor : IPerson { 
    
    }

    internal class Student : IPerson { 
    
    
    }
}
