using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laboratorna_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bttnRes_Click(object sender, EventArgs e)
        {
            if(IsJavaIdentifier(txtBox.Text))
            {
                lblRes.Text = "Ця послідовність правильно\r\nзображає ідентифікатор мови Java";
            }
            else
            {
                lblRes.Text = "Ця послідовність не правильно\r\nзображає ідентифікатор мови Java";
            }
        }

        bool IsJavaIdentifier(string input)
        {
            if (string.IsNullOrEmpty(input))
                return false;

            if (!char.IsLetter(input[0]) && input[0] != '_')
                return false;

            for (int i = 1; i < input.Length; i++)
            {
                if (!char.IsLetterOrDigit(input[i]) && input[i] != '_')
                    return false;
            }

            if (IsReservedWord(input))
                return false;

            return true;
        }

        bool IsReservedWord(string input)
        {
            string[] reservedWords = { "abstract", "assert", "boolean", "break", "byte", "case", "catch",
                                   "char", "class", "const", "continue", "default", "do", "double",
                                   "else", "enum", "extends", "final", "finally", "float", "for",
                                   "goto", "if", "implements", "import", "instanceof", "int", "interface",
                                   "long", "native", "new", "package", "private", "protected", "public",
                                   "return", "short", "static", "strictfp", "super", "switch", "synchronized",
                                   "this", "throw", "throws", "transient", "try", "void", "volatile", "while" };

            return Array.IndexOf(reservedWords, input) != -1;
        }
    }
}
