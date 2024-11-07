using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Behr_Singo_Thomas_Veldman_PRG282_Project.Data_Layer;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace Behr_Singo_Thomas_Veldman_PRG282_Project.Business_Layer
{
    internal class Logic
    {

        public void Update(Students student)
        {
            string query = $"UPDATE Students SET StudentNumber = '{student.StudentNumber}', " +
                $" Name = '{student.Name}', StudentAge= '{student.Age}' " +
                $"Where CourceName = '{student.Cource}'";
            string ErrorCheck = $"SELECT StudentID FROM Students WHERE StudentID = {student.StudentID}";

            SqlConnection con = new SqlConnection(Conn);
            try
            {
                con.Open();
                MessageBox.Show("Connected");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            SqlCommand cmd = new SqlCommand(query, con);
            SqlCommand check = new SqlCommand(ErrorCheck, con);

            object result = check.ExecuteScalar();

            if (Convert.ToInt32(result) == student.StudentID)
            {
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Updated");
            }
            else
            {
                MessageBox.Show("Student doesn't exist");
            }

            private void btnUpdate_Click(object sender, EventArgs e)
            {
                int StudentNumber = int.Parse(txtStudentNumber.Text);
                string Name = txtName.Text;
                string Age = txtAge.Text;
                string Course = txtCourseName.Text;
                Students student = new Students(StudentNumber, Name, Age, Course);
                handler.Update(student);
            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////

        } // End of Logic class
}
