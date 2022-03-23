using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_09.Impl {

    internal class Shop { 
   
        public List<Transaction> Transactions;
        public List<Customer> Customers;

        public Shop() {
            Transactions = new List<Transaction>();
            Customers = new List<Customer>(); 
        }
    
    }

    internal class Transaction {


        // master - header

        public Guid ID { get; set; }
        public Guid CustomerID { get; set; }
        public Guid EmployeeID { get; set; }

        public decimal TotalPrice { get; set; }

        public List<TransactionLine> TransactionLines { get; set; }

        public Transaction() {

            TransactionLines = new List<TransactionLine>();
        }

    }

    internal class TransactionLine {

        // detail - lines


        public Guid ID { get; set; }
        public Guid TransactionID { get; set; }
        public Guid ProductID { get; set; }

        public int Qty { get; set; }
        public decimal TotalPrice { get; set; }

        public TransactionLine() {

        }

    }

    internal class Customer { 
    
    
    }

    internal class TransactionPolicy {


        public const int DAY_WORKING_HOURS = 8;

        public TransactionPolicy() {

        }

        public bool ValidateHoursPerDay(decimal totalHours, int numberOfEngineers) {


            if (totalHours > numberOfEngineers * DAY_WORKING_HOURS) {
                return false;

            }
            else return true;

        }

        public void AddTransLine(Transaction trans, TransactionLine transLine) {


            trans.TransactionLines.Add(transLine);
        
        
        }

        public void CalcTotal(Transaction trans) {


            trans.TotalPrice = trans.TransactionLines.Sum(x => x.TotalPrice);
        } 
    }


    internal class Credentials {


        public string Username { get; set; }
        public string Password { get; set; }

        public Credentials() {
                
        }

        public Credentials(string username, string password) {

            Username = username;
            Password = password;
        }
    }

    internal class SecurityPolicy {


        public SecurityPolicy() {

        }

        public bool Auth(Credentials credentials) {


            if (credentials.Username == "admin" && credentials.Password == "1234") {
                return true;
            }

            return false;

        }
    }
}
