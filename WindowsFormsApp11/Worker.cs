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
    public partial class Worker : Form
    {
        public Workers workers;
        //static int ID = 0;
        public static List<Workers> workerList;
        public Worker()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Workers.ID++;
            workers.Name = textBox1.Text;
            workers.Surname = textBox2.Text;
            workers.DepartName = comboBox1.Text;
            workers.Start_Date = dateTimePicker1.Value;
            workerList.Add(workers);
            Close();
        }

        private void Worker_Load(object sender, EventArgs e)
        {
            workerList = new List<Workers>();
            workers = new Workers();
            foreach (var item in Department.list)
            {
                comboBox1.Items.Add(item.departmentName);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    public class Workers
    {
        public static int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string DepartName { get; set; }
        public DateTime Start_Date { get; set; }
    }
}
