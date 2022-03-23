namespace Session_09.Impl {

    internal interface IGameController {
        bool MoveBackward();
        bool MoveForward();
        bool MoveLeft();
        bool MoveRight();
    }

    internal class PcGameController : IGameController {

        public bool MoveForward() {
            // press W

            return true;
        }

        public bool MoveBackward() {

            return true;

        }

        public bool MoveRight() {
            return true;

        }

        public bool MoveLeft() {
            return true;

        }
    }

    internal class PlaystationGameController : IGameController {

        public bool MoveForward() {
            // press Joy

            return true;
        }

        public bool MoveBackward() {

            return true;

        }

        public bool MoveRight() {

            return true;
        }

        public bool MoveLeft() {

            return true;
        }
    }

    internal class XboxGameController : IGameController {

        public XboxGameController() {

        }

        public bool MoveForward() {
            // press Arrow

            return true;
        }

        public bool MoveBackward() {

            return true;
        }

        public bool MoveRight() {

            return true;
        }

        public bool MoveLeft() {

            return true;
        }

    }

    internal class KoukouController : IGameController {

        public KoukouController() {

        }

        public bool MoveForward() {
            // press Arrow

            return true;
        }

        public bool MoveBackward() {

            return true;
        }

        public bool MoveRight() {

            return true;
        }

        public bool MoveLeft() {

            return true;
        }

    }

    internal class InputHandler {

        private IGameController _gameController;


        public InputHandler(IGameController gameController) {
            _gameController = gameController;
        }

        public bool MoveForward() {
            return _gameController.MoveForward();
        }

        public bool MoveBackward() {
            return _gameController.MoveBackward();
        }

        public bool MoveRight() {
            return _gameController.MoveRight();
        }

        public bool MoveLeft() {
            return _gameController.MoveLeft();
        }
    }

    public enum InputDeviceEnum { 
        Keyboard,
        PS,
        XBOX,
        koukou
    
    }


    internal class Game {

       private InputHandler _inputHandler;

       public int AvatarPosX = 0;

        public Game(InputDeviceEnum inputDeviceEnum) {
            SetController(inputDeviceEnum);
        }

        private void SetController(InputDeviceEnum inputDeviceEnum) {

            switch (inputDeviceEnum) {
                case InputDeviceEnum.Keyboard:
                    _inputHandler = new InputHandler(new PcGameController());
                    break;

                case InputDeviceEnum.PS:
                    _inputHandler = new InputHandler(new PlaystationGameController());
                    break;

                case InputDeviceEnum.XBOX:
                    _inputHandler = new InputHandler(new XboxGameController());
                    break;

                case InputDeviceEnum.koukou:
                    _inputHandler = new InputHandler(new KoukouController());
                    break;

                default:
                    // error ? -- 
                    break;
            }

          
        }

        public void Tick() {

            MoveForward();

        }


        public void MoveForward() {
            
            if (_inputHandler.MoveForward()) {

                AvatarPosX++;
            }
        }
    }
        
    
}
