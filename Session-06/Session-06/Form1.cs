using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_06 {

    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
        }

        #region UI Controls
        private void btnOK_Click(object sender, EventArgs e) {
            //this.Close();

            this.textBox1.BackColor = Color.Red;
        }

        private void Form1_Load(object sender, EventArgs e) {
            this.textBox1.Text = "Fotis";
        }

        private void button3_Click(object sender, EventArgs e) {
            Add();
        }

        private void button3_Click_1(object sender, EventArgs e) {
            //this.textBox2.Text += "+";


            Calculator.Calc calc = new Calculator.Calc();
            this.textBox2.Text += calc.Add();
        }

        private void btnTest_Click(object sender, EventArgs e) {
            NewProject();
        }

        private void newProjectToolStripMenuItem_Click(object sender, EventArgs e) {
            NewProject();
        }
        #endregion



        private void Add() {
            this.textBox2.Text += "1";


        }


        private void NewProject() {
            Class1 c = new Class1();
            c.Test = 1;
        }

      
    }
}
