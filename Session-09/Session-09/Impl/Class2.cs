using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_09.Impl {

    public enum TeamEnum { 
        Red,
        Green,
        Blue
    
    }



    internal class ClassRoom { 
    
    
        public List<Student> Students { get; set; }

        public ClassRoom() {
            Students = new List<Student>();
        }
    
    }


    internal class Student {

        //public TeamEnum Team { get; set; }
        public string Name { get; set; }

        public Student() {

        }

    }
}
