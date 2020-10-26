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
    public partial class StudentEdit : Form
    {
        public object DateTimePicker1 { get; private set; }

        public StudentEdit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox3.Text, out int qw)==false || int.TryParse(textBox4.Text, out int qy) == false)
            {
                MessageBox.Show("Введены некоректные данные");
            }
            else
            { 
              DialogResult = DialogResult.OK;
              Close(); 
            }
        }
        public void Put(Student stud) 
        {
            textBox1.Text = stud.Name;
            textBox3.Text = stud.Age.ToString();
            textBox4.Text = stud.Group.ToString();
        }
        public Student Get()
        {
            var stud = new Student();
            stud.Name= textBox1.Text;
            stud.Age= int.Parse(textBox3.Text);
            stud.Group= int.Parse(textBox4.Text);
            Trace.WriteLine(stud.Age);

            dateTimePicker1.CustomFormat = "MMMM dd, yyyy - dddd";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;

            var dghf = dateTimePicker1.Value;

            Console.WriteLine(dghf);

            return stud;
        }
    }
}
