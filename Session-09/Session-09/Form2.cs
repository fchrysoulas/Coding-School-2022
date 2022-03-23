using Session_09.Impl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_09 {
    public partial class Form2 : Form {

        private Transaction trans;
        private TransactionPolicy hal9k = new TransactionPolicy();

        public Form2() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {

            SecurityPolicy sp = new SecurityPolicy();

            Credentials cred = new Credentials(textBox1.Text, textBox2.Text); 

            if (sp.Auth(cred)) {

                // CONTINUE
            }
            else { 
                // VRE PIOS EISAI ESY ?

                // EXIT
            }
        }

        
        private void Form2_Load(object sender, EventArgs e) {


            trans = new Transaction() {

                ID = new Guid(),
                CustomerID = new Guid(),
                EmployeeID = new Guid(),

            };


            

            TransactionLine transLine1 = new TransactionLine() {
                ID = new Guid(),
                ProductID = new Guid(),
                Qty = 1, 
                TotalPrice = 2,
                TransactionID = trans.ID
            };


            TransactionLine transLine2 = new TransactionLine() {
                ID = new Guid(),
                ProductID = new Guid(),
                Qty = 3,
                TotalPrice = 3,
                TransactionID = trans.ID
            };

            hal9k.AddTransLine(trans, transLine1);
            hal9k.AddTransLine(trans, transLine2);


        }

        private void button2_Click(object sender, EventArgs e) {

            //hal9k.CalcTotal(trans);

            //textBox3.Text = trans.TotalPrice.ToString();

            Stopwatch watch = new Stopwatch();

            progressBar1.Minimum = 1;
            progressBar1.Maximum = 6;

            Cook cook = new Cook();

            watch.Start();

            AppendLog(cook.ToastBread());
            progressBar1.Value = 3;
            this.Refresh();

            AppendLog(cook.FryBacon());
            progressBar1.Value = 6;
            this.Refresh();

            watch.Stop();

            AppendLog(watch.ElapsedMilliseconds.ToString());


        }


        private void AppendLog(string s) {


            txtLog.Text += s + Environment.NewLine;


        }

        private void txtLog_TextChanged(object sender, EventArgs e) {

            
        }

        private void button3_Click(object sender, EventArgs e) {

           // Button button = sender as Button;

            TransactionLine transLine2 = new TransactionLine() {
                ID = new Guid(),
                ProductID = new Guid(),
                Qty = 3,
                TotalPrice = 3,
                TransactionID = trans.ID
            };

            hal9k.AddTransLine(trans, transLine2);
        }

        private async void button4_Click(object sender, EventArgs e) {


            Stopwatch watch = new Stopwatch();

            var cook = new CookAsync();

            progressBar1.Style = ProgressBarStyle.Marquee;
            

            Task<string> task1 =  cook.ToastBread();

            Task<string> task2 = cook.FryBacon();

            Task<string> task3 = cook.SliceTomatoes();

            watch.Start();


            await task2;
            AppendLog(task2.Result);

            await task1;
            AppendLog(task1.Result);
       

            await task3;
            AppendLog(task3.Result);

            watch.Stop();


            AppendLog(watch.ElapsedMilliseconds.ToString());
            

            //AppendLog(task2.Result);

            //this.Refresh();

        }
    }
}
