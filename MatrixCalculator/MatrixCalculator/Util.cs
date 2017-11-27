using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixCalculator
{
    class Util
    {
        /// <summary>
        /// Returns the program's assembly version
        /// </summary>
        /// <returns></returns>
        public static string GetVersionString()
        {
            return "v" + typeof(Util).Assembly.GetName().Version.ToString();
        }

        /// <summary>
        /// Displays an error box with a specified message
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static DialogResult ErrorBox(string msg)
        {
            return MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Displays a confirmation box with a specified message
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static DialogResult ConfirmationBox(string msg)
        {
            return MessageBox.Show(msg, "Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }
    }
}
