using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MatrixCalculator.DataStructures;
using MatrixCalculator.MathOps;
using System.IO;

namespace MatrixCalculator
{
    public partial class LinearSystemOpsWindow : Form
    {
        private LogHandler logHandl;
        
        public LinearSystemOpsWindow()
        {
            InitializeComponent();

            logHandl = new LogHandler(logTextBox); // log operations handler, used by methods which report their actions into the logTextBox
            algorithmComboBox.SelectedIndex = 0;

            // Winforms designer seems to change the default cell style with no reason, so this ensures that the text color is correct
            systemMatrixDataGridView.DefaultCellStyle.ForeColor = SystemColors.ControlText;
            constVectorDataGridView.DefaultCellStyle.ForeColor = SystemColors.ControlText;
            solutionDataGridView.DefaultCellStyle.ForeColor = SystemColors.ControlText;
        }

        /// <summary>
        /// Displays the doubles vector into the solution's DataGridView
        /// </summary>
        /// <param name="solution"></param>
        private void DisplaySolution(double[] solution)
        {
            if (solution == null)
            {
                Util.ErrorBox("The solution could not be found using this algorithm");
                logHandl.LogMessage("The solution could not be found using this algorithm");
                return;
            }

            if (solution.Length == solutionDataGridView.RowCount) // dimension check
            {
                for (int i = 0; i < solution.Length; i++)
                {
                    solutionDataGridView.Rows[i].Cells[0].Value = solution[i];
                }
            }
        }

        /// <summary>
        /// Clears the matrix & constVect DataGridViews
        /// </summary>
        private void ClearSystem()
        {
            for (int i = 0; i < systemMatrixDataGridView.RowCount; i++)
            {
                for (int j = 0; j < systemMatrixDataGridView.ColumnCount; j++)
                {
                    systemMatrixDataGridView.Rows[i].Cells[j].Value = string.Empty;
                }
                // safe because matrix and vector can't ever have different RowCount
                constVectorDataGridView.Rows[i].Cells[0].Value = string.Empty;
            }
        }

        /// <summary>
        /// Sets the default values for system cells (so that they are never null)
        /// </summary>
        private void InitializeSystem()
        {
            for (int i = 0; i < systemMatrixDataGridView.RowCount; i++)
            {
                for (int j = 0; j < systemMatrixDataGridView.ColumnCount; j++)
                {
                    systemMatrixDataGridView.Rows[i].Cells[j].Value = "0";
                }
                // safe because the constVect always has the same number of rows
                constVectorDataGridView.Rows[i].Cells[0].Value = "0";
            }
        }

        /// <summary>
        /// Sets all the blank values to 0
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FillBlanks()
        {
            for (int i = 0; i < systemMatrixDataGridView.RowCount; i++)
            {
                for (int j = 0; j < systemMatrixDataGridView.ColumnCount; j++)
                {
                    var matrixVal = systemMatrixDataGridView.Rows[i].Cells[j].Value;
                    if (matrixVal != null && matrixVal.ToString().Length == 0)
                    {
                        systemMatrixDataGridView.Rows[i].Cells[j].Value = "0";
                    }
                }

                // safe because the constVect always has the same number of rows
                var vectorVal = constVectorDataGridView.Rows[i].Cells[0].Value;
                if (vectorVal != null && vectorVal.ToString().Length == 0)
                {
                    constVectorDataGridView.Rows[i].Cells[0].Value = "0";
                }
            }
        }

        /// <summary>
        /// Parses the system string and inserts it into the DataGridViews
        /// </summary>
        /// <param name="systemString"></param>
        private void InitializeSystemFromString(string systemString)
        {
            string[] systemRows = systemString.Split('\n');

            // if dimensions don't match
            if (systemRows.Length != systemMatrixDataGridView.RowCount)
            {
                Util.ErrorBox("System dimension doesn't match");
                return;
            }

            // parse and insert into the DataGridViews
            for (int i = 0; i < systemRows.Length; i++)
            {
                string[] row = systemRows[i].Split(' ');
                for (int j = 0; j < row.Length - 1; j++)
                {
                    systemMatrixDataGridView.Rows[i].Cells[j].Value = row[j];
                }
                constVectorDataGridView.Rows[i].Cells[0].Value = row[row.Length - 1];
            }
        }

        /// <summary>
        /// Saves the system into the specified location
        /// </summary>
        /// <param name="path"></param>
        private void SaveSystem(string path)
        {
            try
            {
                File.WriteAllText(path, (new LinearSystem(systemMatrixDataGridView, constVectorDataGridView)).ToString());
            }
            catch (Exception ex)
            {
                Util.ErrorBox(string.Format("Failed to save the system\n\n{0}", ex.Message));
            }
        }

        /// <summary>
        /// Sets the grid for matrices and vectors of the system
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void setButton_Click(object sender, EventArgs e)
        {
            int dim = (int)dimensionNumericUpDown.Value;
            ClearSystem();

            // sets up the DataGridViews for the system
            systemMatrixDataGridView.RowCount = dim;
            systemMatrixDataGridView.ColumnCount = dim;

            constVectorDataGridView.ColumnCount = 1;
            constVectorDataGridView.RowCount = dim;

            solutionDataGridView.Rows.Clear(); // clear the solution vector
            solutionDataGridView.ColumnCount = 1;
            solutionDataGridView.RowCount = dim;

            InitializeSystem();
        }

        /// <summary>
        /// Determines & initiates the algorithm by which the solution is calculated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (solutionDataGridView.RowCount > 0) // if the system has been initialized
            {
                int dim = (int)dimensionNumericUpDown.Value;
                double[] solution = null;
                // get the data from the DataGridViews into the LinearSystem instance
                LinearSystem sys = new LinearSystem(systemMatrixDataGridView, constVectorDataGridView);

                switch (algorithmComboBox.SelectedIndex)
                {
                    case 0: // Gaussian elimination
                        solution = GaussianEliminationAlg.SolveSystem(logHandl, sys);
                        break;
                    case 1: // LU decomposition
                        solution = LUDecompAlg.SolveSystem(logHandl, sys);
                        break;
                    default:
                        break;
                }
                DisplaySolution(solution);
            }
        }

        
        #region DataGridView buttons

        private void copySystemButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(new LinearSystem(systemMatrixDataGridView, constVectorDataGridView).ToString());
        }

        private void pasteSystemButton_Click(object sender, EventArgs e)
        {
            string pastedSystem = Clipboard.GetText();

            // pastes the system if it's of a valid size, spliting it into elements
            try
            {
                InitializeSystemFromString(pastedSystem);
            }
            catch (Exception)
            {
                ClearSystem();
                Util.ErrorBox("Failed to paste the system");
            }
        }

        private void clearSystemButton_Click(object sender, EventArgs e)
        {
            ClearSystem();
        }

        private void copyVectorButton_Click(object sender, EventArgs e)
        {
            if (solutionDataGridView.RowCount == 0) { return; }
                
            string vect = string.Empty;
            for (int i = 0; i < solutionDataGridView.RowCount; i++)
            {
                vect += solutionDataGridView.Rows[i].Cells[0].Value;
                if (i != solutionDataGridView.RowCount - 1) { vect += " "; }
            }

            Clipboard.SetText(vect);
        }


        #endregion

        #region Window buttons

        private void importButton_Click(object sender, EventArgs e)
        {
            try
            {
                systemOpenFileDialog.FileName = string.Empty;
                DialogResult openFileDialogResult = systemOpenFileDialog.ShowDialog();              

                if (openFileDialogResult == DialogResult.OK)
                {
                    InitializeSystemFromString(File.ReadAllText(systemOpenFileDialog.FileName));
                }
            }
            catch (Exception)
            {
                ClearSystem();
                Util.ErrorBox("Failed to import the system");
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            DialogResult saveFileDialogResult = systemSaveFileDialog.ShowDialog();

            if (saveFileDialogResult == DialogResult.OK)
            {
                SaveSystem(systemSaveFileDialog.FileName);
            }
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            ClearSystem();

            systemMatrixDataGridView.RowCount = 0;
            systemMatrixDataGridView.ColumnCount = 0;

            constVectorDataGridView.RowCount = 0;
            constVectorDataGridView.ColumnCount = 0;

            solutionDataGridView.RowCount = 0;
            solutionDataGridView.ColumnCount = 0;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            if (solutionDataGridView.RowCount > 0) // if the system has been initialized
            {
                DialogResult confirmation = Util.ConfirmationBox("Closing the form may result in a loss of data.\nWould you like to save the system?");

                if (confirmation == DialogResult.Yes) // save system option
                {
                    DialogResult saveFileDialogResult = systemSaveFileDialog.ShowDialog();

                    if (saveFileDialogResult == DialogResult.OK)
                    {
                        SaveSystem(systemSaveFileDialog.FileName);
                    }
                }
                else if (confirmation == DialogResult.No)
                {
                    Close();
                }
            }
            else { Close(); }
        }

        #endregion


        private void LinearSystemOpsWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (solutionDataGridView.RowCount > 0) // if the system has been initialized
            {
                DialogResult confirmation = Util.ConfirmationBox("Closing the form may result in a loss of data.\nWould you like to save the system?");
                if (confirmation == DialogResult.Yes) // save system option
                {
                    DialogResult saveFileDialogResult = systemSaveFileDialog.ShowDialog();

                    if (saveFileDialogResult == DialogResult.OK)
                    {
                        SaveSystem(systemSaveFileDialog.FileName);
                    }
                }
                else if (confirmation == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        /// <summary>
        /// Used to set all the blank values to 0
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void systemDataGridViews_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            FillBlanks();
        }
    }
}
