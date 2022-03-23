using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_09.Impl.DI {

    public interface IDuckBehaviour : ISwimBehaviour, IFlyBehaviour { 
    
    
    }

    public interface IBehaviour {
        void Do();
    }

    public interface IQuackBehaviour {
        void Quack();
    }

    public interface IEatBehaviour {
        void Eat();
    }

    public interface IFlyBehaviour {
        void Fly();
    }

    public interface ISwimBehaviour {

        //int Stamina { get; set; }

        void Swim();

        //List
    }

    public interface IDiveBehaviour {
        void Dive();
    }

    public interface IBoomBehaviour {
        void Boom();
    }

    public class QuackBehaviour : IQuackBehaviour {

        public void Quack() {
            // DO QUACK
        }
    }

    public class EatBehaviour : IBehaviour {

        public void Do() {
            // DO EAT
        }
    }

    public class EatNothingBehaviour : IEatBehaviour {

        public void Eat() {
            // DO EAT -- empty
        }
    }

    public class FlyBehaviour : IBehaviour {

        public void Do() {
            // DO FLY
        }

    }

    public class Fly2Behaviour : IBehaviour {

        public void Do() {
            // DO FLY
        }

    }

    public class SwimBehaviour : ISwimBehaviour {

        public int Stamina { get; set; }

        public  void Swim() {
            // DO SWIM -- both feet
        }
    }

    public class SwimLeftBehaviour : ISwimBehaviour {

        public int Stamina { get; set; }

        public void Swim() {
            // DO SWIM -- left feet
        }
    }

    public class SwimRightBehaviour : ISwimBehaviour {

        public int Stamina { get; set; }

        public void Swim() {
            // DO SWIM -- right feet
        }
    }

    public class DiveBehaviour : IDiveBehaviour {

        public  void Dive() {
            // DO SWIM
        }
    }

    public class BoomBehaviour : IBehaviour {

        public void Do() {
            // DO boom
        }
    }


    public class BoomNonLethalBehaviour : IBehaviour {

        public void Do() {
            // DO carnavali boom


        }
    }


    public class Duck {

        private IBehaviour _quackBehaviour;
        private IBehaviour _eatBehaviour;
        private IBehaviour _flyBehaviour;
        private IBehaviour _swimBehaviour;
        private IBehaviour _diveBehaviour;
        private IBehaviour _boomBehaviour;


        public int Stamina { get; set; }


        //public Duck(IQuackBehaviour quackBehaviour, IEatBehaviour eatBehaviour, IFlyBehaviour flyBehaviour, ISwimBehaviour swimBehaviour ){

        //    _quackBehaviour = quackBehaviour;
        //    _eatBehaviour = eatBehaviour;
        //    _flyBehaviour = flyBehaviour;
        //    _swimBehaviour = swimBehaviour;
        //}

        public Duck(IBehaviour quackBehaviour, IBehaviour eatBehaviour, IBehaviour flyBehaviour, IBehaviour swimBehaviour,
            IBehaviour diveBehaviour) {

            _quackBehaviour = quackBehaviour;
            _eatBehaviour = eatBehaviour;
            _flyBehaviour = flyBehaviour;
            _swimBehaviour = swimBehaviour;
            _diveBehaviour = diveBehaviour;

        }

        public Duck(IBehaviour flyBehaviour, IBehaviour boomBehaviour) {

            _flyBehaviour = flyBehaviour;
            _boomBehaviour = boomBehaviour;
        }

        public void Quack() {
            _quackBehaviour.Do();
        }
        
        public void Eat() {
            _eatBehaviour.Do();
        }
        
        public void Fly() {
            _flyBehaviour.Do();
        }
        
        public void Swim() {

            _swimBehaviour.Do();

          //  Stamina = _swimBehaviour.Stamina;
        }

        public void Dive() {
            _swimBehaviour.Do();
        }

        public void Boom() {
            _boomBehaviour.Do();
        }

    }

    public class Run {


        public Run() {


            //QuackBehaviour quack = new QuackBehaviour();
            //SwimBehaviour swim = new SwimBehaviour();


            //FlyBehaviour fly = new FlyBehaviour();
            //EatBehaviour eat = new EatBehaviour();

            //Duck duck = new Duck(quack, eat, fly, swim);

            //Duck swampDuck = new Duck(quack, eat, fly, swim, new DiveBehaviour());

            //Duck rubberDuck = new Duck(quack, null, null, swim, null);



            //Duck swampDuckLeftSwimmer = new Duck(new QuackBehaviour(), new EatBehaviour(), new FlyBehaviour(), new SwimLeftBehaviour());

            //swampDuckLeftSwimmer.Swim();

            //Duck swampDuckLeftSwimmerNoEat = new Duck(new QuackBehaviour(), new EatNothingBehaviour(), new FlyBehaviour(), new SwimLeftBehaviour());


            Duck killerDuck = new Duck(new FlyBehaviour(), new BoomBehaviour());


            Duck patrasDuck = new Duck(new FlyBehaviour(), new BoomNonLethalBehaviour());

            killerDuck.Fly();
            killerDuck.Boom();

            
        }
    }

}
