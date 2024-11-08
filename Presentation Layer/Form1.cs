using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

using Behr_Singo_Thomas_Veldman_PRG282_Project.Business_Layer;
using Behr_Singo_Thomas_Veldman_PRG282_Project.Data_Layer;
using static Behr_Singo_Thomas_Veldman_PRG282_Project.frmStudent;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Behr_Singo_Thomas_Veldman_PRG282_Project
{

    public partial class frmStudent : Form
    {
        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        // This code is done to access methods stored on the Logic.cs and FIleHandler.cs, in Form1.cs file

        private Logic logic;
        private FileHandler fileHandler;

        public frmStudent()
        {
            InitializeComponent();
            fileHandler = new FileHandler(this);
            logic = new Logic(this, fileHandler);
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        //CLASS: Student

        // This class is created to capture the student details from the groupbox so that it can be used in various other methods
        public class Student
        {
            public string Name { get; set; }
            public string StudentNumber { get; set; }
            public int Age { get; set; }
            public string Course { get; set; }

            public string GetStudentString()
            {
                return StudentNumber + "," + Name + "," + Age+","+Course;
        }

        } // End of Student class
        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        // METHOD: ValidateInputs

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(edtName.Text))
            {
                MessageBox.Show("Please enter a valid name.");
                edtName.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(edtNumber.Text))
            {
                MessageBox.Show("Please enter a valid student number.");
                edtNumber.Focus();
                return false;
            }
            if (cmbxCourse.SelectedItem == null)
            {
                MessageBox.Show("Please select a course.");
                cmbxCourse.Focus();
                return false;
            }
            if (numAge.Value <= 0)
            {
                MessageBox.Show("Please enter a valid age greater than zero.");
                numAge.Focus();
                return false;
            }
            return true;
        } // End of ValidateInputs method
        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        // METHOD: GetDetails
        public Student GetDetails()
        {
            if (!ValidateInputs())
            {
                return null;
            } // End of else statement
            else
            {
                string studentName = edtName.Text;
                string studentNumber = edtNumber.Text;
                int studentAge = Convert.ToInt32(numAge.Value);
                string studentCourse = cmbxCourse.SelectedItem.ToString();

                // A new Student object is created to allow developers to call the GetDetails method in other files
                return new Student
                {
                    StudentNumber = studentNumber,
                    Name = studentName,
                    Age = studentAge,
                    Course = studentCourse,
                };
            } // End of if statement

        } // End of GetDetails method 
        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        public bool StudentExists(Student student, List<Student> list)
        {
            return list.Any(studentList => studentList.StudentNumber == student.StudentNumber);
        }

        public void DisplayView()
        {
            dtgvStudent.Columns.Clear();

            List<Student> students = fileHandler.ViewAllStudents();

            dtgvStudent.DataSource = students;

            dtgvStudent.Refresh();
        }
        // METHOD: GetRowCount
        public int GetRowCount()
        {
            return dtgvStudent.Rows.Count;

        } // End of GetRowCount method
        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        // METHOD: GetTotalAge
        public int GetTotalAge()
        {
            int totalAge = 0;
            int ageColumnIndex = 2;

            foreach (DataGridViewRow row in dtgvStudent.Rows)
            {
                // If statement checks to see if there is a value in the row / coverts it to an integer
                if (row.Cells[ageColumnIndex].Value != null && int.TryParse(row.Cells[ageColumnIndex].Value.ToString(), out int age))
                {
                    totalAge += age;
                } // End of if statement

            } // End of foreach loop

            return totalAge;

        } // End of GetTotalAge method
        /////////////////////////////////////////////////////////////////////////////////////////////////////////
          // METHOD: DisplayTotalAndAverageAge
        public void DisplayTotalAndAverageAge(string text)
        {
            lblResults.Text = text;

        } // End of DisplayTotalAndAverageAge method
        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnAdd_Click(object sender, EventArgs e)
        {

            Student student = GetDetails();

            if (student == null) //Checks to see if the GetDetails method is null. If it does, a student cannot be added
                return;

            if (StudentExists(student, fileHandler.ViewAllStudents())){
                MessageBox.Show("Student already exists. Please re-enter student details!");
            }
            else
            {
                fileHandler.AddNewStudent(student.StudentNumber, student.Name, student.Age, student.Course);
                DisplayView();
            }
           
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnView_Click(object sender, EventArgs e)
        {
            DisplayView();
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Student student = GetDetails();

            if (student == null) //Checks to see if the GetDetails method is null. If it does, a student cannot be deleted
                return;

            if (StudentExists(student, fileHandler.ViewAllStudents()))
            {
                fileHandler.DeleteStudent(student.StudentNumber, student.Name, student.Age, student.Course);

                DisplayView();
            }
            else
            {
                MessageBox.Show("Unable to delete a student that does not exist!");
            }
            
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Student student = GetDetails();

            if (student == null) //Checks to see if the GetDetails method is null. If it does, a student cannot be updated
                return;

            List<Student> studentsUpdate = new List<Student>();   
            if (dtgvStudent.SelectedRows.Count > 0)
            {
                fileHandler.UpdateStudent(student.StudentNumber, student.Name, student.Age, student.Course);
                dtgvStudent.Refresh();
                
                DisplayView();

            }
            else
            {
                MessageBox.Show("Please select a record to update!");
            }

        }

        private void dtgvStudent_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvStudent.SelectedRows.Count > 0)
            {
                var selectedStudent = (Student)dtgvStudent.SelectedRows[0].DataBoundItem;
                edtName.Text = selectedStudent.Name.ToString();
                edtNumber.Text = selectedStudent.StudentNumber;
                numAge.Value = selectedStudent.Age;
                cmbxCourse.SelectedItem= selectedStudent.Course;

            }
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnSummary_Click(object sender, EventArgs e)
        {
            logic.GenerateSummary();
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////

    } // End of Form1 class
}
