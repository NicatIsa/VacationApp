using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.Visible = false;
        }
        Department department = null;
        Worker worker = null;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.BurlyWood;
            
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = SystemColors.Control;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Department_FormClosed(object sender, FormClosedEventArgs e)
        {
            department = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            if (worker == null)
            {
                worker = new Worker();
                worker.FormClosed += Worker_FormClosed;
                worker.Show();

                
            }
            else
            {
                worker.Activate();
            }
        }

        private void Worker_FormClosed(object sender, FormClosedEventArgs e)
        {
            ListViewItem listView;
            foreach (var item in Worker.workerList)
            {
                listView = new ListViewItem(Workers.ID.ToString());
                listView.SubItems.Add(item.Name);
                listView.SubItems.Add(item.Surname);
                listView.SubItems.Add(item.DepartName);
                listView.SubItems.Add(item.Start_Date.ToString());
                listView1.Items.Add(listView);
            }
            worker = null;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (department == null)
            {
                department = new Department();
                department.FormClosed += Department_FormClosed;
                department.Show();
            }
            else
            {
                department.Activate();
            }
        }
    }
}
