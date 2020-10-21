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

        
    }
}
