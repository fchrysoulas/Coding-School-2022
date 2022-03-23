using Session_09.Impl;
using Session_09.Impl.DI;
using System.Text.Json;

namespace Session_09 {
    public partial class Form1 : Form {

        private ClassRoom _classRoom;

        private const int MAX_ITEMS_PER_LIST = 4;

        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            Run run = new Run();  
            //run.
        }

        private void Form1_Load(object sender, EventArgs e) {



            FillStudents();


            //for (int i = 1; i < 7; i++) {
            //    listBox1.Items.Add(i);
            //}

        }

        private void FillStudents() {
            if (File.Exists("storage.json")) {
                LoadData();
            }

            foreach (Student item in _classRoom.Students) {

                listBox1.Items.Add(item.Name);
            }
        }

        private void LoadData() {

            string s = File.ReadAllText("storage.json");


            _classRoom = JsonSerializer.Deserialize<ClassRoom>(s);

        }

        private void button1_Click_1(object sender, EventArgs e) {

            Random r = new Random();


            ListBoxDist listDist = new ListBoxDist();

            listDist.ListBoxes.Add(listBox2);
            listDist.ListBoxes.Add(listBox3);
            listDist.ListBoxes.Add(listBox4);
            listDist.ListBoxes.Add(listBox5);
            listDist.ListBoxes.Add(listBox6);
            listDist.ListBoxes.Add(listBox7);


          while(listBox1.Items.Count > 0) { 

                Distribute(r, listDist);

                Thread.Sleep(100);

                this.Refresh();
            }


            
        }

        private void Distribute(Random r, ListBoxDist listDist) {

            if (listBox1.Items.Count > 0) {

                int i = r.Next(listBox1.Items.Count);

                List<ListBox> availableListBoxes = listDist.ListBoxes.FindAll(x => x.Items.Count < MAX_ITEMS_PER_LIST);

                int j = r.Next(availableListBoxes.Count);

                textBox1.Text += i.ToString() + Environment.NewLine;

                availableListBoxes[j].Items.Add(listBox1.Items[i]);

                listBox1.Items.RemoveAt(i);

            }
        }

    }
}