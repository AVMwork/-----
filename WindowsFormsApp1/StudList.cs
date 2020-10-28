using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace WindowsFormsApp1
{
    public partial class StudList : Form
    {
        
        public StudList()
        {
            InitializeComponent();
        }

        private void StudList_Load(object sender, EventArgs e)
        {
            
            listBox2.Items.AddRange(databaseservis.dbContext.students.ToArray()); 
            
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            var temp = listBox2.SelectedItem;
            if (temp != null)
            {
                var forma = new StudentEdit();
                var t = (Student)temp;
                forma.Put(t);

                var rezult = forma.ShowDialog();
                if (rezult == DialogResult.OK)
                {
                    t = forma.Get();
                    listBox2.Items.Remove(temp);

                    if ((databaseservis.dbContext.students.SingleOrDefault<Student>(n => n.Id == t.Id)) != null) // возвращаем или null если ничего не нашли или указатель на объект 
                    {
                        (databaseservis.dbContext.students.SingleOrDefault<Student>(n => n.Id == t.Id)).Name = t.Name;
                        (databaseservis.dbContext.students.SingleOrDefault<Student>(n => n.Id == t.Id)).Age = t.Age;
                        (databaseservis.dbContext.students.SingleOrDefault<Student>(n => n.Id == t.Id)).Group = t.Group;
                        
                        listBox2.Items.Add(t);
                        listBox2.Refresh();
                    }                   

                    databaseservis.Save();

                }
            }
         }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) 
        {
            var temp = listBox2.SelectedItem;
            if (temp != null)
            {
                databaseservis.dbContext.students.Remove((Student)temp);
                databaseservis.Save();
                listBox2.Items.Remove(temp);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var forma = new StudentEdit();
            var rezult = forma.ShowDialog();
            if (rezult == DialogResult.OK)
            {
                var stud = new Student();
                stud = forma.Get();
                databaseservis.dbContext.students.Add(stud);
                databaseservis.Save();
                listBox2.Items.Add(stud);

                //File.WriteAllText(@"C:\Temp\spisok.json", System.Text.Json.JsonSerializer.Serialize(stud));
            }
        }
    }
}
