using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace praktika4moduli
{
    public partial class Registr : Form
    {
        public Registr()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string firstName = textBox1.Text;
            string lastName = textBox2.Text;
            string patronymic = textBox3.Text;
            string birthDate = textBox4.Text;
            string email = textBox5.Text;
            string password = textBox6.Text;
            string confirmPassword = textBox7.Text;

            if (password == confirmPassword)
            {
                MessageBox.Show($"{firstName}, вы зарегистрировались.");
                Okno okno = new Okno();
                okno.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Неверный пароль");
            }
        }
    }
}
