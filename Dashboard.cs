using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        public string constr = "Data Source=DESKTOP-4GO5058\\SQLEXPRESS;Initial Catalog=ProjectA;Integrated Security=True";


        private void button1_Click(object sender, EventArgs e)
        {
            Form2 addPro = new Form2();
            addPro.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add_Advisors add = new Add_Advisors();
            add.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Add_Student ads = new Add_Student();
            ads.Show();
            this.Hide();
        }

        private void btnManageEvaluation_Click(object sender, EventArgs e)
        {
            AddEvaluation adE = new AddEvaluation();
            this.Hide();
            adE.Show();
        }
    }
}
