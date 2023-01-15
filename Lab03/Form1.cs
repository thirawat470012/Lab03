using System.Net.Http.Headers;

namespace Lab03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student(textBoxName.Text, textBoxId.Text, textBoxBirth.Text, int.Parse(textBoxAge.Text),
                double.Parse(textBoxHeight.Text), double.Parse(textBoxGrade.Text), textBoxBranch.Text);
            student.AddData(dataGridView1);        
        }

        private void textBoxGrade_TextChanged(object sender, EventArgs e)
        {

        }
    }
}