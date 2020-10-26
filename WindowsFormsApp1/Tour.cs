using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Tour : Form
    {
       public Tour()
        {
            InitializeComponent();
        }

        public static string previw;
        public static DateTime bday;
        public static DateTime eday;

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                previw = radioButton1.Text;
            }

            if (radioButton2.Checked == true)
            {
                previw = radioButton2.Text;
            }

            if (radioButton3.Checked == true)
            {
                previw = radioButton3.Text;
            }

            bday = monthCalendar1.SelectionStart;
            eday = monthCalendar1.SelectionEnd;

            var delta = eday - bday; // TimeSpan

            if (delta.Days == 6)
            {
                Close(); 

            }
            else MessageBox.Show("Некорректное число дней");

        }

        public void Put(Student stud)
        {
            //textBox1.Text = stud.Name;
            //textBox3.Text = stud.Age.ToString();
            //textBox4.Text = stud.Group.ToString();
        }
        public Student Get()
        {
            var stud = new Student();
            //stud.Name = textBox1.Text;
            //stud.Age = int.Parse(textBox3.Text);
            //stud.Group = int.Parse(textBox4.Text);
            //Trace.WriteLine(stud.Age);

            //dateTimePicker1.CustomFormat = "MMMM dd, yyyy - dddd";
            //dateTimePicker1.Format = DateTimePickerFormat.Custom;

            //var dghf = dateTimePicker1.Value;

            //Console.WriteLine(dghf);

            return stud;
        }
    }
}
