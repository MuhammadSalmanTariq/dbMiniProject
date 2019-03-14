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
    public partial class ShowProject : Form
    {
        public ShowProject()
        {
            InitializeComponent();
        }
        public string constr = "Data Source=DESKTOP-4GO5058\\SQLEXPRESS;Initial Catalog=ProjectA;Integrated Security=True";


        private void btnAddProjects_Click(object sender, EventArgs e)
        {
            
        }
    }
}
