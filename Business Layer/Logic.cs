using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Behr_Singo_Thomas_Veldman_PRG282_Project.Data_Layer;

namespace Behr_Singo_Thomas_Veldman_PRG282_Project.Business_Layer
{
    internal class Logic
    {

        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Step 1: Retrieve the selected student from the DataGridView
            if (dtgvStudent.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dtgvStudent.SelectedRows[0];

                // Step 2: Populate the form fields with the selected student's data
                string studentNumber = selectedRow.Cells[0].Value.ToString();
                string studentName = selectedRow.Cells[1].Value.ToString();
                int studentAge = Convert.ToInt32(selectedRow.Cells[2].Value);
                string studentCourse = selectedRow.Cells[3].Value.ToString();

                // Pre-fill the form controls with the selected student's data
                edtName.Text = studentName;
                edtNumber.Text = studentNumber;
                numAge.Value = studentAge;
                cmbxCourse.SelectedItem = studentCourse;

                // After filling the form fields, now allow the user to make changes and click "Update" again
                // to save the updated details.

                // Step 3: Validate the updated data
                Student updatedStudent = GetDetails();  // Get updated details from the form

                // Basic validation: Ensure that all fields are filled correctly
                if (string.IsNullOrWhiteSpace(updatedStudent.Name) ||
                    string.IsNullOrWhiteSpace(updatedStudent.StudentNumber) ||
                    updatedStudent.Age <= 0 ||
                    string.IsNullOrWhiteSpace(updatedStudent.Course))
                {
                    MessageBox.Show("Please ensure all fields are filled out correctly.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Step 4: Update the student in the data source (students.txt)
                bool success = fileHandler.UpdateStudent(updatedStudent.StudentNumber, updatedStudent.Name, updatedStudent.Age, updatedStudent.Course);

                if (success)
                {
                    // Step 5: Refresh the DataGridView to reflect the updated data
                    List<Student> students = fileHandler.ViewAllStudents(); // Reload all students
                    dtgvStudent.DataSource = students;  // Update the DataGridView's data source
                    dtgvStudent.Refresh();  // Refresh the DataGridView to show updated information

                    // Optionally, you can clear the form fields after the update
                    edtName.Clear();
                    edtNumber.Clear();
                    numAge.Value = numAge.Minimum;
                    cmbxCourse.SelectedIndex = -1;

                    MessageBox.Show("Student record updated successfully.", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("An error occurred while updating the student record. Please try again.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a student from the list to update.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////

    } // End of Logic class
}
