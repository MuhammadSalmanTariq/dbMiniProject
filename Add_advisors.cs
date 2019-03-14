using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Add_Advisors : Form
    {
        public Add_Advisors()
        {
            InitializeComponent();
        }
        public string constr = "Data Source=DESKTOP-4GO5058\\SQLEXPRESS;Initial Catalog=ProjectA;Integrated Security=True";


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                if(comboBox1.SelectedIndex == 0)
                { }
                //SqlCommand cmd = new SqlCommand(insert, con);
                //cmd.ExecuteNonQuery();
            }
        }

        private void Add_Advisors_Load(object sender, EventArgs e)
        {

        }
    }
}
