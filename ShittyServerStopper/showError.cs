using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shitty_Server_Stopper
{
    public static class showError
    {
        public static System.Windows.Forms.DialogResult ShowError(string title, string message, string help)
        {
            System.Windows.Forms.DialogResult dgr = System.Windows.Forms.DialogResult.None;

            using (Error err = new Error())
            {
                err.Text = "Error: " + message;
                err.Title = title;
                err.Message = message;
                err.Help = help;
                err.ShowDialog();
            }

            return dgr;
        }
    }
}
