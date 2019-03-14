using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGame
{
    public static class InputDialog
    {
        public static string ShowDialog(string text, bool hidden = false)
        {
            Form dg = new Form()
            {
                Width = 450,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label thelabel = new Label { Left = 50, Top = 10, Width = 310, Text = text };
            thelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            TextBox thetext = new TextBox { Left=50, Top=38, Width = 330, MaxLength = 13 };
            if (hidden)
                thetext.PasswordChar = '*';
            thetext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Button confirm = new Button { Left = 175, Top = 68, Text = "Ok", DialogResult = DialogResult.OK };
            confirm.Click += (sender, e) => { dg.Close(); };
            dg.Controls.Add(thelabel);
            dg.Controls.Add(thetext);
            dg.Controls.Add(confirm);
            dg.AcceptButton = confirm;

            return dg.ShowDialog() == DialogResult.OK ? thetext.Text : "";
        }
        
    }
}
