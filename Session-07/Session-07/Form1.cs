using Calc;
using System.Text.Json;

namespace Session_07 {

    public partial class Form1 : Form {


        private const string FILE_NAME = "storage.json";

        private Calc.PetShop _petShop;
        

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

            _petShop = new Calc.PetShop();
            _petShop.Pets = new List<Pet>();

            var hector = new Pet() {
                Age = 7,
                Name = "Hector"
            };

            var zeus = new Pet() {
                Age = 3,
                Name = "Zeus"
            };


            _petShop.Pets[0] = hector;
            _petShop.Pets[1] = zeus;

        }

        private void btnSave_Click(object sender, EventArgs e) {


            // JavascriptSerializer ~4.7
            // Newtonsoft -- External lib
            // JsonSerializer 6.0

            string json = JsonSerializer.Serialize(_petShop);

            File.WriteAllText(FILE_NAME, json);

            this.textBox1.Text = "File Saved!";
            

        }

        private void btnLoad_Click(object sender, EventArgs e) {

            string s = File.ReadAllText(FILE_NAME);

            textBox1.Text = s;

            _petShop = (Calc.PetShop)JsonSerializer.Deserialize(s, typeof(Calc.PetShop));

     
    
        }

        private void button1_Click(object sender, EventArgs e) {


            //Pet pet = _petShop.Pets[0];

            //PetForm petForm = new PetForm();
            //petForm.Name = pet.Name;
            //petForm.Age = pet.Age;

            //petForm.Show();
           
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }
    }
}