using System;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Linq;
using System.Drawing;
using System.Threading.Tasks;

namespace SecurePasswordGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(upper.Checked | lower.Checked | number.Checked | symbol.Checked)
            {
                int _len = Convert.ToInt32(lenVal.Value);
                string _chars = "";
                    if (upper.Checked) _chars += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                    if (lower.Checked) _chars += "abcdefghijklmnopqrstuvwxyz";
                    if (number.Checked) _chars += "0123456789";
                    if (symbol.Checked) _chars += "~!@%$<>^&_-#";
                var _rnd = new Random();
                var _pass = new string(
                    Enumerable.Repeat(_chars, _len)
                    .Select(s => s[_rnd.Next(s.Length)])
                    .ToArray());
                lblPassword.Text = _pass;
            }
            else
            {
                MessageBox.Show("Error: Please select one or more password options");
            }
        }

        private void cpyBtn_Click(object sender, EventArgs e)
        {
            if (lblPassword.Text != "") Clipboard.SetText(lblPassword.Text);
        }
    }
}