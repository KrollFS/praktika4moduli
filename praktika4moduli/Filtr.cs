using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static praktika4moduli.Filtr;
using static praktika4moduli.Okno;

namespace praktika4moduli
{
    public partial class Filtr : Form
    {
        private List<Project> projects = new List<Project>();
        public string ProjectName { get; private set; }
        public string ProjectStatus { get; private set; }
        public Filtr()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProjectName = textBox1.Text;
            ProjectStatus = textBox2.Text;

            
            this.Close();


        }


        private void button2_Click(object sender, EventArgs e)
        {
            Okno okno = new Okno();
            okno.Show();
            this.Hide();
        }
        public class Project
        {
            public string Name { get; }
            public string Status { get; }

            public Project(string name, string status)
            {
                Name = name;
                Status = status;
            }

            public override string ToString()
            {
                return $"{Name} - {Status}";
            }
        }
    }
}
