using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03 {

    internal abstract class Shape {


        public Shape() {

        }

        public abstract double Area();
        public abstract double Draw();

    }

    internal class Rectangle : Shape {

        public int X { get; set; }
        public int Y { get; set; }

        public Rectangle() {

        }

        public override double Area() {

            return X * Y;
        }


        public double Area(int x) {

            return 0;
        }

        public override double Draw() {
            throw new NotImplementedException();
        }

        public virtual void SetSquare() {
            Y = X;
        }

    }

    internal class Square : Rectangle {


        public Square() {
            SetSquare();
        }

        public override void SetSquare() {
            base.SetSquare();
        }
    }

    internal class Circle : Shape {

        public int Radius { get; set; }

        public Circle() {

        }

        public override double Area() {

            return Radius * Radius * Math.PI;
        }

        public override double Draw() {
            throw new NotImplementedException();
        }

    }

    internal class Triangle : Shape {

        public Triangle() {

        }

        public override double Area() {

            return 0;
        }

        public override double Draw() {
            throw new NotImplementedException();
        }

    }
}
