﻿using System;
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

        } // End of Student class
        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        // METHOD: GetDetails
        public Student GetDetails()
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

        } // End of GetDetails method 
        /////////////////////////////////////////////////////////////////////////////////////////////////////////
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

            fileHandler.AddNewStudent(student.StudentNumber, student.Name, student.Age, student.Course);
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnView_Click(object sender, EventArgs e)
        {
            dtgvStudent.Columns.Clear();

            List<Student> students = fileHandler.ViewAllStudents();

            dtgvStudent.DataSource = students;

            dtgvStudent.Refresh();
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnSummary_Click(object sender, EventArgs e)
        {
            logic.GenerateSummary();
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////

    } // End of Form1 class
}
