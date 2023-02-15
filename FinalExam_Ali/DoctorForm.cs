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
    public partial class DoctorForm : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-U2UNUUNB;Initial Catalog=Hospital;Integrated Security=True");
        public DoctorForm()
        {
            InitializeComponent();
        }
        void clearForm()
        {
            Action<Control.ControlCollection> clear = null;
            clear = (controls) =>
            {
                foreach (Control control in controls)
                {
                    if (control is TextBox)
                    {
                        (control as TextBox).Clear();
                    }
                    else
                    {
                        clear(control.Controls);
                    }
                }
            };
            clear(Controls);
        }

        private void AddDocButton_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_INSERT_Doctor_Table", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("doctorID", SqlDbType.NVarChar).Value = DoctorIDtextBox.Text;
                cmd.Parameters.AddWithValue("Firstname", SqlDbType.NVarChar).Value = DocFirstNameTextBox.Text;
                cmd.Parameters.AddWithValue("Lastname", SqlDbType.NVarChar).Value = DocLastNameTextBox.Text;
                cmd.Parameters.AddWithValue("departmentCode", SqlDbType.Int).Value = DocDepCodeTextBox.Text;
                cmd.Parameters.AddWithValue("yearsOfPractice", SqlDbType.Int).Value = DocYearPracticTextBox.Text;
                cmd.Parameters.AddWithValue("shiftHours", SqlDbType.Float).Value = Convert.ToDouble(DocShiftHoursTextBox.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("The Doctor has been successfully added.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex.ToString());
            }
            finally
            {
                conn.Close();
                DisplayTable();
                clearForm();
            }
        }
        void DisplayTable()
        {
            conn.Open();
            SqlCommand sqlCom = conn.CreateCommand();
            sqlCom.CommandType = CommandType.Text;
            sqlCom.CommandText = "select * from DoctorTable";
            sqlCom.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(sqlCom);
            sda.Fill(dt);
            dataGridView_Doctor.DataSource = dt;    
            conn.Close();
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateDocButton_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_UPDATE_Doctor_Table", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("doctorID", SqlDbType.NVarChar).Value = DoctorIDtextBox.Text;
                cmd.Parameters.AddWithValue("Firstname", SqlDbType.NVarChar).Value = DocFirstNameTextBox.Text;
                cmd.Parameters.AddWithValue("Lastname", SqlDbType.NVarChar).Value = DocLastNameTextBox.Text;
                cmd.Parameters.AddWithValue("departmentCode", SqlDbType.Int).Value = DocDepCodeTextBox.Text;
                cmd.Parameters.AddWithValue("yearsOfPractice", SqlDbType.Int).Value = DocYearPracticTextBox.Text;
                cmd.Parameters.AddWithValue("shiftHours", SqlDbType.Float).Value = Convert.ToDouble(DocShiftHoursTextBox.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                DisplayTable();
                MessageBox.Show("The Doctor with the ID " + DoctorIDtextBox.Text + " has been updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex.ToString());
            }
            finally
            {
                conn.Close();
                DisplayTable();
                clearForm();
            }
            
        }

        private void DeleteDocButton_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SP_DELETE_DOCTOR", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("doctorID", SqlDbType.NVarChar).Value = DoctorIDtextBox.Text;
            cmd.ExecuteNonQuery();
            conn.Close();
            DisplayTable();
            MessageBox.Show("The Doctor with the ID " + DoctorIDtextBox.Text + " has been deleted");
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void goToPatientButton_Click(object sender, EventArgs e)
        {
            PatientForm patform = new PatientForm();
            patform.ShowDialog();
        }
        private void refreshTheDataOfDoctorTAble()
        {
          
            SqlDataAdapter sda = new SqlDataAdapter("select * from DoctorTable", conn);
            DataSet dataset = new DataSet();
            sda.Fill(dataset);
            dataGridView_Doctor.DataSource = dataset.Tables[0];
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            refreshTheDataOfDoctorTAble();
            DocFormTimer.Start();
        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {
            DocFormTimer.Start();
        }
    }
}
