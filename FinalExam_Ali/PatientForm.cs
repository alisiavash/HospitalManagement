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
    public partial class PatientForm : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-U2UNUUNB;Initial Catalog=Hospital;Integrated Security=True");
        public PatientForm()
        {
            InitializeComponent();
        }
        void DisplayTable()
        {
            conn.Open();
            SqlCommand sqlCom = conn.CreateCommand();
            sqlCom.CommandType = CommandType.Text;
            sqlCom.CommandText = "select * from PatientTable";
            sqlCom.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(sqlCom);
            sda.Fill(dt);
            dataGridView_Patient.DataSource = dt;
            conn.Close();
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
        private void AddPatientButton_Click(object sender, EventArgs e)
        {
            try
            {
      
                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_INSERT_Patient_Table", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("patientID", SqlDbType.NVarChar).Value = PatientIDtextBox.Text;
                cmd.Parameters.AddWithValue("firstname", SqlDbType.NVarChar).Value = PatientFirstNameTextBox.Text;
                cmd.Parameters.AddWithValue("lastname", SqlDbType.NVarChar).Value = PatientLastNameTextBox.Text;
                cmd.Parameters.AddWithValue("departmentCode", SqlDbType.Int).Value = PatientDepCodeTextBox.Text;
                cmd.Parameters.AddWithValue("sectionNumber", SqlDbType.NVarChar).Value = PatientSectionTextBox.Text;
                cmd.Parameters.AddWithValue("disChargeStatus", SqlDbType.NVarChar).Value = PatientDischargeStatTextBox.Text;
                cmd.Parameters.AddWithValue("balance", SqlDbType.Float).Value = Convert.ToDouble(PatientBalanceTextBox.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("The Patient has been successfully added.");

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

        private void UpdatePatientButton_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_UPDATE_Patient_Table", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("patientID", SqlDbType.NVarChar).Value = PatientIDtextBox.Text;
                cmd.Parameters.AddWithValue("firstname", SqlDbType.NVarChar).Value = PatientFirstNameTextBox.Text;
                cmd.Parameters.AddWithValue("lastname", SqlDbType.NVarChar).Value = PatientLastNameTextBox.Text;
                cmd.Parameters.AddWithValue("departmentCode", SqlDbType.Int).Value = PatientDepCodeTextBox.Text;
                cmd.Parameters.AddWithValue("sectionNumber", SqlDbType.NVarChar).Value = PatientSectionTextBox.Text;
                cmd.Parameters.AddWithValue("disChargeStatus", SqlDbType.NVarChar).Value = PatientDischargeStatTextBox.Text;
                cmd.Parameters.AddWithValue("balance", SqlDbType.Float).Value = Convert.ToDouble(PatientBalanceTextBox.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                DisplayTable();
                MessageBox.Show("The Patient with the ID " + PatientIDtextBox.Text + " has been updated");
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

        private void DeletePatientButton_Click(object sender, EventArgs e)
        {
            
            conn.Open();
            SqlCommand cmd = new SqlCommand("SP_DELETE_PATIENT", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("patientID", SqlDbType.NVarChar).Value = PatientIDtextBox.Text;
            cmd.ExecuteNonQuery();
            conn.Close();
            DisplayTable();
            MessageBox.Show("The patient with the ID " + PatientIDtextBox.Text + " has been deleted");
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void refreshTheDataOfDoctorTAble()
        {

            SqlDataAdapter sda = new SqlDataAdapter("select * from PatientTable", conn);
            DataSet dataset = new DataSet();
            sda.Fill(dataset);
            dataGridView_Patient.DataSource = dataset.Tables[0];
        }
        private void PatFormTimer_Tick(object sender, EventArgs e)
        {
            refreshTheDataOfDoctorTAble();
            PatFormTimer.Start();
        }
        private void PatientForm_Load(object sender, EventArgs e)
        {
            PatFormTimer.Start();
        }

        
    }
}
