using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MatrixCalculator.DataStructures;

namespace MatrixCalculator
{
    /// <summary>
    /// Class for handling the log operations
    /// </summary>
    class LogHandler
    {
        public TextBox LogTBox { get; }

        public LogHandler(TextBox logTBox)
        {
            LogTBox = logTBox;
        }

        /// <summary>
        /// Prints the message into the log textbox
        /// </summary>
        /// <param name="msg"></param>
        public void LogMessage(string msg)
        {
            LogTBox.AppendText(string.Format(" >>> {0}\r\n", msg));
        }

        /// <summary>
        /// Prints the matrix into the log textbox
        /// </summary>
        /// <param name="matrix"></param>
        public void LogMatrix(Matrix matrix)
        {
            string[] matrixRows = matrix.ToString().Split('\n'); // split by whitespaces
            int[] maxLengths = MaxElemLengthByCol(matrixRows);

            LogTBox.AppendText("\r\n");
            foreach (string row in matrixRows)
            {
                string[] elems = row.Split(' '); // split by spaces
                for (int i = 0; i < elems.Length; i++)
                {
                    LogTBox.AppendText(elems[i].PadRight(maxLengths[i] + 1)); // added padding
                }
                LogTBox.AppendText("\r\n");
            }
            LogTBox.AppendText("\r\n");
        }

        /// <summary>
        /// Prints the system into the log textbox
        /// </summary>
        /// <param name="matrix"></param>
        public void LogSystem(LinearSystem system)
        {
            string[] systemRows = system.ToString().Split('\n'); // split by whitespaces
            int[] maxLengths = MaxElemLengthByCol(systemRows);

            LogTBox.AppendText("\r\n");
            foreach (string row in systemRows)
            {
                if (row.Length == 0) { continue; } // string.Split() may return some empty substrings

                string[] elems = row.Split(' '); // split by spaces
                for (int i = 0; i < elems.Length - 1; i++) // exclude the constant term
                {
                    LogTBox.AppendText(elems[i].PadRight(maxLengths[i] + 1)); // added padding
                }
                LogTBox.AppendText(string.Format("| {0}\r\n", elems[elems.Length - 1].PadRight(maxLengths[maxLengths.Length - 1] + 1)));
            }
            LogTBox.AppendText("\r\n");
        }

        /// <summary>
        /// Prints the vector into the log textbox
        /// </summary>
        /// <param name="matrix"></param>
        public void LogVector(double[] vector)
        {
            LogTBox.AppendText("\r\n[ ");
            foreach (double val in vector)
            {
                LogTBox.AppendText(string.Format("{0} ", val.ToString()));
            }
            LogTBox.AppendText("]\r\n");
        }

        /// <summary>
        /// Returns the maximum element length in the matrix(or system) for padding
        /// </summary>
        /// <param name="rows"></param>
        /// <returns></returns>
        private int[] MaxElemLengthByCol(string[] rows)
        {
            int[] maxLengths;
            string[][] elems = new string[rows.Length][]; // split the rows into elements

            for (int i = 0; i < rows.Length; i++)
            {
                elems[i] = rows[i].Split(' ');
            }

            maxLengths = new int[elems[0].Length];
            // this will also include the constant terms if a system is passed
            for (int i = 0; i < elems[0].Length; i++)
            {
                maxLengths[i] = 0;
                for (int j = 0; j < elems.Length; j++)
                {
                    if (elems[j][i].Length > maxLengths[i]) // string.Split() may return some empty substrings
                    {
                        maxLengths[i] = elems[j][i].Length;
                    }
                }
            }

            return maxLengths;
        }
    }
}
