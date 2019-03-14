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
    public partial class Add_Student : Form
    {
        public Add_Student()
        {
            InitializeComponent();
        }
        public string constr = "Data Source=DESKTOP-4GO5058\\SQLEXPRESS;Initial Catalog=ProjectA;Integrated Security=True";


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Add_Student_Load(object sender, EventArgs e)
        {

        }

        private void txtDateOfBirth_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            string data;
            if (con.State == System.Data.ConnectionState.Open)
            {
                if(cmbGender.SelectedIndex == 0)
                {
                    data = "INSERT INTO Person(FirstName, LastName, Contact, Email, DateOfBirth, Gender) VALUES('" + Convert.ToString(txtFirstName.Text) + "', '" + Convert.ToString(txtLastName.Text) + "','" + Convert.ToString(txtContact.Text) + "', '" + Convert.ToString(txtEmail.Text) + "','" + Convert.ToDateTime(dateTimePickerDob.Value) + "', '" + 1 + "')";

                    //SqlCommand cmd = new SqlCommand(data, con);
                    //cmd.ExecuteNonQuery();
                }
                else
                {
                    data = "INSERT INTO Person(FirstName, LastName, Contact, Email, DateOfBirth, Gender) VALUES('" + Convert.ToString(txtFirstName.Text) + "', '" + Convert.ToString(txtLastName.Text) + "','" + Convert.ToString(txtContact.Text) + "', '" + Convert.ToString(txtEmail.Text) + "','" + Convert.ToDateTime(dateTimePickerDob.Value) + "', '" + 2 + "')";
                    //SqlCommand cmd = new SqlCommand(data, con);
                   
                }
                int id;
                SqlCommand cmd = new SqlCommand(data, con);
                cmd.ExecuteNonQuery();
                cmd.CommandText = "Select @@Identity";
                id = Convert.ToInt32(cmd.ExecuteScalar());
                string InsertStudent = "INSERT INTO Student(Id, RegistrationNo) VALUES('" + id + "','" + Convert.ToString(txtregno.Text) + "')";
                SqlCommand sqlCommand = new SqlCommand(InsertStudent, con);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Student Added");
            }
        }
    }
}
