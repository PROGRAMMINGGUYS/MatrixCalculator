using System;
using System.Windows.Forms;

namespace MatrixCalculator
{
    /// <summary>
    /// Initial calculation modes menu
    /// </summary>
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();

            versionLabel.Text = Util.GetVersionString();
        }

        #region Menu button actions
        private void unaryOpsButton_Click(object sender, EventArgs e)
        {
            var unaryOpsWindow = new UnaryOpsWindow();
            unaryOpsWindow.Show();
        }

        private void binaryOpsButton_Click(object sender, EventArgs e)
        {
            var binaryOpsWindow = new BinaryOpsWindow();
            binaryOpsWindow.Show();
        }

        private void linearSystemOpsButton_Click(object sender, EventArgs e)
        {
            var linearSystemOpsWindow = new LinearSystemOpsWindow();
            linearSystemOpsWindow.Show();
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            var aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        #endregion
    }
}
