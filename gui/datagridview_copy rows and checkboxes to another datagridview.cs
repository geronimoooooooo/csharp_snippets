using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        List<Person> liste = null;
        public Form1()
        {
            liste = new List<Person> { new Person() { name = "o", name2 = "o2" }, new Person() { name = "z", name2 = "d2" } };

           

            InitializeComponent();
            dataGridView1.DataSource = liste;
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> liste_rows = new List<DataGridViewRow>();


            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if(dataGridView1.Rows[i].Cells[0].Value!=null)
                if ((bool)dataGridView1.Rows[i].Cells[0].Value)
                {

                    liste_rows.Add(dataGridView1.Rows[i]);
                    System.Diagnostics.Debug.WriteLine(dataGridView1.Rows[i].Cells[1].Value);
                }
            }
            
            foreach (var item in liste_rows)
            {
                DataGridViewRow b  = item.Clone() as DataGridViewRow;
                b.ReadOnly = true;
                int colindex = 0;
                foreach (DataGridViewCell cell in item.Cells)
                {
                    b.Cells[colindex].Value = cell.Value;
                    colindex++;
                }

                dataGridView2.Rows.Add(b);
                System.Diagnostics.Debug.WriteLine(dataGridView2.Rows[dataGridView2.Rows.Count-1].Cells[1].Value);
            }



        }

     
    }
}
