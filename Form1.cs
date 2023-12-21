namespace OOP
{
    public partial class Form1 : Form
    {

        private Details dt = new Details();

        private string[] firstNameArr = { };
        private string[] middleNameArr = { };
        private string[] lastNameArr = { };
        private string[] AgeArr = { };


        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {

            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "First Name";
            dataGridView1.Columns[1].Name = "Middle Name";
            dataGridView1.Columns[2].Name = "Last Name";
            dataGridView1.Columns[3].Name = "Age";
            UpdateDataGridView();
        }

        private void UpdateDataGridView()
        {
            dataGridView1.Rows.Clear();

            for (int i = 0; i < dt.GetFirstName().Length; i++)
            {
                dataGridView1.Rows.Add(dt.GetFirstName()[i], dt.GetMiddleName()[i], dt.GetLastName()[i], dt.GetAge()[i]);
            }

            //foreach(var item in dt.GetDataArray())
            //{
            //    dataGridView1.Rows.Add(item);
            //}

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string middleName = txtMiddleName.Text;
            string age = txtAge.Text;

            if (txtFirstName.Text == "" || txtLastName.Text == "" || txtMiddleName.Text == "" || txtAge.Text == "")
            {
                MessageBox.Show("Fill in all field");
                return;
            }

            //Array.Resize(ref firstNameArr, firstNameArr.Length + 1);
            //firstNameArr[firstNameArr.Length - 1] = firstName;

            //Array.Resize(ref middleNameArr, middleNameArr.Length + 1);
            //middleNameArr[middleNameArr.Length - 1] = middleName;

            //Array.Resize(ref lastNameArr, lastNameArr.Length + 1);
            //lastNameArr[lastNameArr.Length - 1] = lastName;

            //Array.Resize(ref AgeArr, AgeArr.Length + 1);
            //AgeArr[AgeArr.Length - 1] = age;

            dt.AddDataFirstName(firstName);
            dt.AddDataMiddleName(middleName);
            dt.AddDataLastName(lastName);
            dt.AddAge(age);

            UpdateDataGridView();
            txtFirstName.Clear();


        }
    }
}