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
    public partial class Department : Form
    {
        public Departments departments;
        public static List<Departments> list = new List<Departments>();
        public Department()
        {
            InitializeComponent();
        }

        private void Department_Load(object sender, EventArgs e)
        {
            departments = new Departments();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            departments.departmentName = textBox1.Text;
            list.Add(departments);
            Close();
        }
    }
    public class Departments
    {
        public string departmentName { get; set; }
    }
}
