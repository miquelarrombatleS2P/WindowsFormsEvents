using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCommonEvents
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            
        }

        private void mainForm_MouseClick(object sender, MouseEventArgs e)
        {
            string text = null;
            if (e.Button == MouseButtons.Left)
            {
                text += $"Left button of the mouse has been clicked over main form. ";
            }
            else
            {
                text += $"Right button of the mouse has been clicked over main form ";
            }

            messagesTextBox.AppendText(text + Environment.NewLine);
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            messagesTextBox.AppendText("Main Form Loaded." + Environment.NewLine);
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            messagesTextBox.AppendText("The System has detected a Double Click on the label"+Environment.NewLine);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            messagesTextBox.AppendText("Numeric Up Down value changed " + numericUpDown1.Value + Environment.NewLine);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            messagesTextBox.AppendText("List Box Selected Index has changed to "+listBox1.SelectedIndex+Environment.NewLine);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            messagesTextBox.AppendText("textBox1 has got the focus now" + Environment.NewLine);
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            messagesTextBox.AppendText("textBox1 has lost the focus" + Environment.NewLine);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            messagesTextBox.AppendText($"The key '{textBox1.Text}' has been pressed and released." + Environment.NewLine);
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            messagesTextBox.AppendText("The mouse pointer is inside the image" + Environment.NewLine);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            messagesTextBox.AppendText("The mouse pointer is outside the image" + Environment.NewLine);
        }
    }
}
