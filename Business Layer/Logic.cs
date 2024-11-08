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
        // This code is done to access methods stored on the Form1.cs and FileHandler.cs, in Logic.cs

        private frmStudent form;
        FileHandler fileHandler;

        public Logic(frmStudent formObject, FileHandler fileHandler)
        {
            form = formObject;
            this.fileHandler = fileHandler;
        }

          /////////////////////////////////////////////////////////////////////////////////////////////////////////
        // Generate a Summary Report
        public void GenerateSummary()
        {

            int totalAge = form.GetTotalAge(); // Calls GetTotalAge method from Form1.cs
            int rowCount = form.GetRowCount(); // Calls GetRowCount method from Form1.cs

            float averageAge = 0;

            // VALIDATION: If statement to check if the rowCount is not zero
            if (rowCount > 0)
            {
                averageAge = (float)totalAge / rowCount;
            } // End of if statement
            else
            {
                MessageBox.Show("There are no records loaded");
                return;
            } // End of else statement

            form.DisplayTotalAndAverageAge($"Total Age: {totalAge}, Average Age: {averageAge}");

            fileHandler.WriteSummaryFile(totalAge, averageAge);

        } // End of GenerateSummary
        /////////////////////////////////////////////////////////////////////////////////////////////////////////
    } // End of Logic class
}
