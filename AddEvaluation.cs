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
    public partial class AddEvaluation : Form
    {
        public AddEvaluation()
        {
            InitializeComponent();
        }
        public string constr = "Data Source=DESKTOP-4GO5058\\SQLEXPRESS;Initial Catalog=ProjectA;Integrated Security=True";


        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string insert = "insert into ";
                SqlCommand cmd = new SqlCommand(insert, con);
                cmd.ExecuteNonQuery();
            }
        }

        private void AddEvaluation_Load(object sender, EventArgs e)
        {

        }
    }
}
