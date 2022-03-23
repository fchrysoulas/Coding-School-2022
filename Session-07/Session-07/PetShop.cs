using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calc;

namespace Session_07 {
    
    public partial class PetShop : Form {

        private const string FILE_NAME = "storage.json";

        private Calc.PetShop _petShop;

        public PetShop() {
            InitializeComponent();
        }

        #region UI Controls
        private void openToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void Form2_Load(object sender, EventArgs e) {
            LoadData();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e) {
            LoadData();

            MessageBox.Show("Loaded OK!");
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            SaveData();
        }
        #endregion


        private void LoadData() {

            string s = File.ReadAllText(FILE_NAME);

            //textBox1.Text = s;

            _petShop = (Calc.PetShop)JsonSerializer.Deserialize(s, typeof(Calc.PetShop));

            
        }

        private void SaveData() {

            string json = JsonSerializer.Serialize(_petShop);

            File.WriteAllText(FILE_NAME, json);

            MessageBox.Show("File Saved!");
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e) {


            if (_petShop != null && _petShop.Pets.Count() > 0) {

                // open form
                PetForm petForm = new PetForm();

                // set pets array
                petForm.Pets = _petShop.Pets;
                
                // show pet form
                petForm.ShowDialog();


            }
            else {
                MessageBox.Show("Petshop is not loaded!", "Warning",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
            }
        }

        private void PetShop_FormClosing(object sender, FormClosingEventArgs e) {

            SaveData();
        }
    }
}
