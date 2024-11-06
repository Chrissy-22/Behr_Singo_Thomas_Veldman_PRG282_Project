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

namespace Behr_Singo_Thomas_Veldman_PRG282_Project
{
    public partial class frmStudent : Form
    {
        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        // This code is done to access methods stored on the Logic.cs and FIleHandler.cs, in Form1.cs file

        private Logic logic; // Private field to hold the object.

        public frmStudent()
        {
            InitializeComponent();
            logic = new Logic(this); // Passes the current object of fromStudent to the Logic class.
        }

        FileHandler fileHandler = new FileHandler();
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

        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnView_Click(object sender, EventArgs e)
        {

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
