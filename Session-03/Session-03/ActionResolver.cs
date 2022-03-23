using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03 {


    public enum ActionEnum { 
        Convert,
        Uppercase,
        Reverse
    } 

    internal class BaseRequest {

        public Guid RequestID { get; set; }

        public BaseRequest() {
          
        }

    }

    internal class BaseResponse : BaseRequest {

        public Guid ResponseID { get; set; }

        public BaseResponse() {

        }

    }

    internal class ActionRequest : BaseRequest {

        public ActionEnum Action { get; set; }
        public string Input { get; set; }

        public ActionRequest() {

        }
    }

    internal class ActionResponse : BaseResponse {

        public string Output { get; set; }

        public ActionResponse() {

        }
    }

    internal class Message {


       
        
    }

    internal class MessageLogger {

        public Message Message  { get; set; }
}

    internal abstract class BaseResolver {


        public abstract ActionResponse Execute(ActionRequest request);

        public abstract string Convert();

    }

    internal class LoggedResolver : BaseResolver {

        public MessageLogger Logger { get; set; }

        public LoggedResolver() {

        }

        public override ActionResponse Execute(ActionRequest request) {

            var response = new ActionResponse();

            try {
                BaseExecute exec = null;

                switch (request.Action) {
                    case ActionEnum.Convert:
                        exec = new Convert();
                        break;

                    case ActionEnum.Uppercase:
                        exec = new ToUpperCase();
                        break;

                    case ActionEnum.Reverse:
                        exec = new Reverse();
                        break;

                    default:
                        break;
                }

                response.Output = exec.Execute(request.Input);


                // DO ALL THE THINGS!

            }
            catch (Exception ex) {
                Logger.Messages[0] = ex.Message;
                
                throw;
            }
            
            return response;
        }

        public override string Convert() {
            //throw new NotImplementedException();

            return null;
        }

        //public virtual string Convert() {

        //    // do 1

        //    return null;
        //}

    }


    internal abstract class BaseExecute {


        public abstract string Execute(string s);
    }

    internal class ToUpperCase : BaseExecute {

        public MessageLogger Logger { get; set; }

        public override string Execute(string s) {


            return null;
        }
    }

    internal class Reverse : BaseExecute {

        public MessageLogger Logger { get; set; }

        public override string Execute(string s) {


            return null;
        }


    }

    internal class Convert : BaseExecute {

        public MessageLogger Logger { get; set; }

        public override string Execute(string s) {


            return null;
        }


    }

    // 
    internal class ActionResolver : LoggedResolver {


        public ActionResolver() {

        }

        public void DoAction() {

            try {

                Execute();
            }
            catch (Exception) {
                LogMessage();
            }
        
        }


        public void LogMessage() { 
        
        
        }


        public virtual void Execute() {


        }


    }
}
