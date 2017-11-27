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
        }

        /// <summary>
        /// Displays the doubles vector into the solution's DataGridView
        /// </summary>
        /// <param name="solution"></param>
        private void DisplaySolution(double[] solution)
        {
            if (solution.Length == solutionDataGridView.RowCount) // dimension check
            {
                if (solution == null)
                {
                    Util.ErrorBox("The solution could not be found using this algorithm");
                    logHandl.LogMessage("The solution could not be found using this algorithm");
                }
                else
                {
                    for (int i = 0; i < solution.Length; i++)
                    {
                        solutionDataGridView.Rows[i].Cells[0].Value = solution[i];
                    }
                }
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

            // sets up the DataGridViews for the system
            systemMatrixDataGridView.RowCount = dim;
            systemMatrixDataGridView.ColumnCount = dim;

            constVectorDataGridView.ColumnCount = 1;
            constVectorDataGridView.RowCount = dim;

            solutionDataGridView.Rows.Clear(); // clear the solution vector
            solutionDataGridView.ColumnCount = 1;
            solutionDataGridView.RowCount = dim;
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
                    default:
                        break;
                }
                DisplaySolution(solution);
            }
        }

        #region DataGridView buttons

        private void copySystemButton_Click(object sender, EventArgs e)
        {

        }

        private void pasteSystemButton_Click(object sender, EventArgs e)
        {

        }

        private void clearSystemButton_Click(object sender, EventArgs e)
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

        private void copyVectorButton_Click(object sender, EventArgs e)
        {
            
        }


        #endregion

        #region Window buttons

        private void importButton_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            if (solutionDataGridView.RowCount > 0) // if the system has been initialized
            {
                DialogResult confirmation = Util.ConfirmationBox("Closing the form may result in a loss of data.\nWould you like to save the system?");

                if (confirmation == DialogResult.Yes)
                {

                }
                else if (confirmation == DialogResult.No)
                {
                    Close();
                }
            }
        }

        #endregion

        private void LinearSystemOpsWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (solutionDataGridView.RowCount > 0) // if the system has been initialized
            {
                DialogResult confirmation = Util.ConfirmationBox("Closing the form may result in a loss of data.\nWould you like to save the system?");

                if (confirmation == DialogResult.Yes)
                {
                    #warning TODO
                }
                else if (confirmation == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
