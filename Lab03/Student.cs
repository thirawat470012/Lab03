using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{

    public class Student
    {
        public string myname;
        public string myid;
        public string birth;
        public int age;
        public double height;
        public double grade;
        public string branch;

        public Student(String myname, String myid, String birth, int age, double height, double grade, string branch)
        {
            this.myname = myname;
            this.myid = myid;
            this.birth = birth;
            this.age = age;
            this.height = height;
            this.grade = grade;
            this.branch = branch;
        }



        public void AddData(DataGridView myData)
        {
            myData.Rows.Add(this.myname, this.myid, this.birth, this.age, this.height, this.grade, this.branch);
        }
    }
}
