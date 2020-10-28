using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var forma = new StudentEdit();

            string s = File.ReadAllText(@"C:\Temp\spisok.json");
            Student stud = System.Text.Json.JsonSerializer.Deserialize<Student>(s);

            forma.Put(stud);


            //var stud = new Student();
            //stud = forma.Get();
            var rezult = forma.ShowDialog();
            if (rezult == DialogResult.OK)
            {
                // var stud = new Student();
                stud = forma.Get();
                File.WriteAllText(@"C:\Temp\spisok.json", System.Text.Json.JsonSerializer.Serialize(stud));
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            var forma2 = new Tour();
            var rezult = forma2.ShowDialog();

            MessageBox.Show("Вы выбрали тур " + Tour.previw +" на 7 дней c " + Tour.bday.Day + "." + Tour.bday.Month + " по " + Tour.eday.Day + "."+ Tour.eday.Month);
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            var forma3 = new StudList();
            var rezult = forma3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var forma4 = new StudList2();
            forma4.Show();
        }
    }
}