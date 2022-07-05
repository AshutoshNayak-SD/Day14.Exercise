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
using System.Configuration;

namespace Day14.Exercise
{
    public partial class FrmStudentMaster : Form
    {
        public FrmStudentMaster()
        {
            InitializeComponent();
        }
        
        private SqlDataReader reader = null;
        private void FrmStudentMaster_Load(object sender, EventArgs e)
        {
            //Create sql Coonection
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=ECXLC5470\SQLEXPRESS;Initial Catalog=Training;Integrated Security=true";

            //Create Sql Command
            SqlCommand cmd = new SqlCommand();
            //Passing connection object
            cmd.Connection = con;
            //passing Command
            cmd.CommandText = "Select Stud_Code,Stud_Name,Dept_Code,Stud_Dob,Address from Student_master";

            //open the Connection
            con.Open();
            //execute the Command and fetch data
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            //store in the Text Box
            TxtStudCode.Text = reader["Stud_Code"].ToString();
            TxtStudName.Text = reader["Stud_Name"].ToString();
            TxtDeptCode.Text = reader["Dept_Code"].ToString();
            TxtStudDob.Text = reader["Stud_Dob"].ToString();
            TxtAddress.Text = reader["Address"].ToString();

            reader.Close();
            cmd.Dispose();
            con.Close();


            

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.ClearData();
         }

        public void ClearData()
        {
            TxtStudCode.Clear();
            TxtStudName.Clear();
            TxtDeptCode.Clear();
            TxtStudDob.Clear();
            TxtAddress.Clear();
            TxtStudCode.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using(SqlConnection con=new SqlConnection(@"Data Source=ECXLC5470\SQLEXPRESS;Initial Catalog=Training;Integrated Security=true"))
            {
                using(SqlCommand cmd=new SqlCommand("Select Stud_Name,Dept_Code,Stud_Dob,Address from Student_master where Stud_Code=@Stud_Code",con))
                {
                    cmd.Parameters.AddWithValue("@Stud_Code", TxtStudCode.Text);
                    if(con.State==ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    using (reader = cmd.ExecuteReader())
                    {
                        if(reader.HasRows)
                        {
                            reader.Read();
                            TxtStudName.Text = reader["Stud_Name"].ToString();
                            TxtDeptCode.Text = reader["Dept_Code"].ToString();
                            TxtStudDob.Text = reader["Stud_Dob"].ToString();
                            TxtAddress.Text = reader["Address"].ToString();

                        }
                        else 
                        {
                            MessageBox.Show("No Record");
                            this.ClearData();
                        }
                    }
                }
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            using(SqlConnection con= new SqlConnection(ConfigurationManager.ConnectionStrings["TrainingEx"].ConnectionString))
            {
                using(SqlCommand cmd=new SqlCommand("usp_AddNewStudent",con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Stud_Code", TxtStudCode.Text);
                    cmd.Parameters.AddWithValue("@Stud_Name", TxtStudName.Text);
                    cmd.Parameters.AddWithValue("@Dept_Code", TxtDeptCode.Text);
                    cmd.Parameters.AddWithValue("@Stud_Dob", TxtStudDob.Text);
                    cmd.Parameters.AddWithValue("@Address", TxtAddress.Text);
                    
                    if(con.State==ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    cmd.ExecuteNonQuery();

                }
            }
            MessageBox.Show("New Student Added in Student_master");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["TrainingEx"].ConnectionString))
            {
                using(SqlCommand cmd=new SqlCommand("usp_UpdateStudNameAndDeptCode",con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Stud_Name", TxtStudName.Text);
                    cmd.Parameters.AddWithValue("@Dept_Code", TxtDeptCode.Text);
                    cmd.Parameters.AddWithValue("@Stud_Code", TxtStudCode.Text);
                    if(con.State==ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Record Updated Succesfully");

        }
    }
}
