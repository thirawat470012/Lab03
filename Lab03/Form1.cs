using System.Net.Http.Headers;

namespace Lab03
{
    public partial class Form1 : Form
    {
        List<string> fields = new List<string>();
        List<double> values = new List<double>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student(textBoxName.Text, textBoxId.Text, textBoxBirth.Text, int.Parse(textBoxAge.Text),
                double.Parse(textBoxHeight.Text), double.Parse(textBoxGrade.Text), textBoxBranch.Text);
            fields.Add(student.myname);
            values.Add(student.grade);
            dataGridView1.Rows.Add(student.myname, student.myid, student.birth, student.age, student.height, student.grade, student.branch);

            values.Sort();
            textBoxMin.Text = "เกรดต่ำสุด " + values.First().ToString();
            textBoxMax.Text = "เกรดสูงสุด " + values.Last().ToString();
            textBoxAll.Text = "จำนวนนักเรียนทั้งหมด " + fields.Count.ToString() + " คน";

        }

        private void textBoxGrade_TextChanged(object sender, EventArgs e)
        {

        }
    }
}