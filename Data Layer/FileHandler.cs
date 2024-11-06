using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Behr_Singo_Thomas_Veldman_PRG282_Project.Business_Layer;
using static Behr_Singo_Thomas_Veldman_PRG282_Project.frmStudent;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Behr_Singo_Thomas_Veldman_PRG282_Project.Data_Layer
{
    internal class FileHandler
    {
        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        // This code is done to access methods stored on the Form1.cs and Logic.cs, in  FileHandler.cs

        private frmStudent form;

        public FileHandler(frmStudent formObject)
        {
            form = formObject;
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        //METHOD: AddNewStudent
        public void AddNewStudent(string number, string name, int age, string course)
        {
            try
            {
                // Define the file path in the user's Documents folder
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "students.txt");

                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine($"{number}, {name}, {age}, {course}");
                }

                MessageBox.Show("Student details saved successfully to text file. The file can be found in your Documents folder.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } // End of try block

            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving student details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } // End of catch block

        } // End of AddNewStudent method
        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        public void WriteSummaryFile(int totalAge, float averageAge)
        {
            try
            {

                // The summary.txt will be created and saved on the user's MyDocuments folder
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "summary.txt");

                // Write the total number of students and the average age to the summary textfile
                using (TextWriter writer = new StreamWriter(filePath)) // TextWriter to write the results into the "summary.txt" textfile 
                {
                    writer.WriteLine($"Total Age: {totalAge}, Average Age: {averageAge}");
                    MessageBox.Show("Results successfully written to the text file. Summary can be found in your Documents folder.");

                } // End of TextWriter

            } // End of try block
            catch (Exception ex)
            {
                MessageBox.Show("The summary results could not be written to the file:" + ex.Message);

            } // End of catch block
        } // End of WriteSummaryFile method
          /////////////////////////////////////////////////////////////////////////////////////////////////////////

    } // End of FileHandler class
}
