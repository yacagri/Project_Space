using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Space
{
    public partial class Form1 : Form
    {

        Bridge childForm = new Bridge();
        public Form1()
        {

            InitializeComponent();
          //  WindowState = FormWindowState.Maximized;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rtb_Story.BackColor = Color.Black;
            rtb_Story.ForeColor = Color.LightBlue;
            rtb_Story.BorderStyle = BorderStyle.None;

            rtb_Story.ReadOnly = true;


            string text1 = " test test test";
            // this.Controls.Add(rtb_Story);
            ThreadPool.QueueUserWorkItem(sebastian, text1);            
        }


        void sebastian(object state)
        { 
            string text1 = state.ToString();

            int i = 0;
            for (i = 0; i < text1.Length; i++)
            {
                // Console.Write(text1[i]);

                //  rtb_Story.AppendText(text1[i].ToString());
                AppendNewTextToRichTextBox(text1[i]);

                Thread.Sleep(200);

            }
        }

        private delegate void app_char(char c);
        private void AppendNewTextToRichTextBox(char c)
        {
            if (InvokeRequired)
            {
                Invoke(new app_char(AppendNewTextToRichTextBox), c);
            }
            else
            {
                rtb_Story.AppendText(c.ToString(CultureInfo.InvariantCulture));
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            RichTextBox richTextBox = (RichTextBox)sender;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Button button = (Button)button1.Tag;

            if (childForm == null)
            {
                childForm = new Bridge();   //Create form if not created
                childForm.FormClosed += childForm_FormClosed;  //Add eventhandler to cleanup after form closes
            }

            childForm.Show(this);  //Show Form assigning this form as the forms owner
            Hide();
        }

        void childForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            childForm = null;  //If form is closed make sure reference is set to null
            Show();
        }
       
    }
}
