using Calc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_07 {

    public partial class PetForm : Form {

        public List<Pet> Pets { get; set; }

        private Pet _selectedPet;
        private Pet _originalPet;

        public PetForm() {
            InitializeComponent();
        }

        #region UI Controls
        private void Form3_Load(object sender, EventArgs e) {

            ShowList();
        
            
       
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e) {
            SelectPet();

            DisplayPet();
        }
        #endregion

        private void SelectPet() {

            if (_selectedPet != null)
                _selectedPet = Pets[listView.SelectedIndex];
        }

        private void ShowList() {

            listView.Items.Clear();

            foreach (Pet item in Pets) {

                if (item != null)
                    listView.Items.Add(string.Format("{0}", item.Name));
            }
        }

        private void DisplayPet() {

            if (_selectedPet != null) {
                txtName.Text = _selectedPet.Name;
                txtAge.Text = _selectedPet.Age.ToString();
            }
            else {
                txtName.Text = string.Empty;
                txtAge.Text = "0";
            }
        }

        private void UpdatePet() {

            _originalPet = _selectedPet.ShallowCopy();

            _selectedPet.Name = txtName.Text;
            _selectedPet.Age = Convert.ToInt32(txtAge.Text);
        }

        private void button1_Click(object sender, EventArgs e) {
            UpdatePet();

            ShowList();            
        }

        private void button2_Click(object sender, EventArgs e) {

            //this.Close();

            this.DialogResult = DialogResult.OK;

            
        }

        private void button5_Click(object sender, EventArgs e) {
            // revert

            _selectedPet = _originalPet;
         

            DisplayPet();

        }

        private void button4_Click(object sender, EventArgs e) {
            DeletePet();
        }


        private void DeletePet() {

            if (_selectedPet != null) {

                Pets.Remove(_selectedPet);

                _selectedPet = null;

                ShowList();
            }
            DisplayPet();
        }

        private void button3_Click(object sender, EventArgs e) {
            Pet pet = CreatePet();

            ShowList();

            listView.SelectedIndex = Pets.IndexOf(pet);
        }

        private Pet CreatePet() {


            PetManager manager = new PetManager();
            manager.Pets = Pets;

            Pet pet = manager.AddPet();

            
            return pet;
        }
    }
}
