using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
            var forma = new StudentEdit();
            
            var rezult = forma.ShowDialog();

        }
    }
}
