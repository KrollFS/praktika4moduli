using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static praktika4moduli.Okno;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace praktika4moduli
{

    public partial class Okno : Form
    {
       
        private List<Project> projects;
        
        public Okno()
        {
            InitializeComponent();
            
            
        }

        public Okno(string username )
            {
                InitializeComponent();

                Text = "Добро пожаловать, " + username + "!";
            projects = new List<Project>();
            foreach (var project in projects)
            {
                listBoxProjects.Items.Add(project.ToString()); 
            }

        }
       

        private void Button1_Click(object sender, EventArgs e)
            {

            Filtr filtr = new Filtr();

           
            filtr.FormClosed += (s, args) =>
            {

                if (filtr.ProjectName != null && filtr.ProjectStatus != null)
                {
                    listBoxProjects.Items.Add($"{filtr.ProjectName} - {filtr.ProjectStatus}");
                }
            };

            
            filtr.ShowDialog();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (listBoxProjects.SelectedItem != null)
            {
                
                listBoxProjects.Items.Remove(listBoxProjects.SelectedItem);
            }
            else
            {
                
                MessageBox.Show("Выберите элемент для удаления.");

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            
        }
        public class Project
        {
            public string Name { get; set; }
            public string Status { get; set; }

            public Project(string name, string status)
            {
                Name = name;
                Status = status;
            }







        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
