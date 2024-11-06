using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Behr_Singo_Thomas_Veldman_PRG282_Project.Business_Layer;

namespace Behr_Singo_Thomas_Veldman_PRG282_Project.Data_Layer
{
    internal class FileHandler
    {
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
