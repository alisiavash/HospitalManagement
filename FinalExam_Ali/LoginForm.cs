using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalExam_Ali
{
    public partial class LoginForm : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-U2UNUUNB;Initial Catalog=Hospital;Integrated Security=True");
        public LoginForm()
        {
            InitializeComponent();
        }
        void clearForm()
        {
            Action<Control.ControlCollection> clearAll = null;
            clearAll = (controls) =>
            {
                foreach (Control control in controls)
                {
                    if (control is TextBox)
                    {
                        (control as TextBox).Clear();
                    }
                    else
                    {
                        clearAll(control.Controls);
                    }
                }
            };
            clearAll(Controls);
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {

            try
            {
                string query = "select * from login where Username = '" + usernameText.Text + "' " +
                    "and Password = '" + passwordText.Text + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    DoctorForm doc = new DoctorForm();
                    doc.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Error! The username or password are wrong.");
                    clearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
