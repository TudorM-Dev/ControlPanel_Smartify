using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using FontAwesome.Sharp;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Threading;
using System.IO;
using System.Windows.Controls;

namespace GUI_SortifyBot
{
    public partial class FormController : Form
    {
        //Forms
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        //Constructor
        public FormController()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //buttton
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(53, 58, 216);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //icon current child form

            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.MidnightBlue;
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                //open only form
                currentChildForm.Close();

            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        //Menu Button_Clicks

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
        }

        private void btnController_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
        }

        private void btnSettings_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
        }

        //drag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void slider1_ValueChanged(object sender, decimal value)
        {
            textBox1.Text = slider1.Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            bool result = textBox1.Text.Any(x => char.IsNumber(x));
            if (result == true && textBox1.Text != string.Empty)
            {
                string onlyNumbers1 = Regex.Replace(textBox1.Text, "[^. 0-9.-]", "");
                slider1.Value = Int32.Parse(onlyNumbers1);
                textBox1.Text = onlyNumbers1;
            }
            else if (textBox1.Text == string.Empty) { slider1.Value = 0; }

            string filePath = Path.Combine(Environment.CurrentDirectory, "F:\\Proiecte VS C#\\Data.txt");

                Console.WriteLine("Value from TextBox1: " + textBox1.Text);
                Console.WriteLine("Value from TextBox2: " + textBox2.Text);
                Console.WriteLine("Value from TextBox3: " + textBox3.Text);
                Console.WriteLine("Value from TextBox4: " + textBox4.Text);
                Console.WriteLine("Value from TextBox5: " + textBox5.Text);
                Console.WriteLine("Value from TextBox6: " + textBox6.Text);
            
        }

        private void slider2_ValueChanged(object sender, decimal value)
        {
            textBox2.Text = slider2.Value.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            bool result = textBox2.Text.Any(x => char.IsNumber(x));
            if (result == true && textBox2.Text != string.Empty)
            {
                string onlyNumbers2 = Regex.Replace(textBox2.Text, "[^. 0-9.-]", "");
                slider2.Value = Int32.Parse(onlyNumbers2);
                textBox2.Text = onlyNumbers2;
            }
            else if (textBox2.Text == string.Empty) { slider2.Value = 0; }

            string filePath = Path.Combine(Environment.CurrentDirectory, "F:\\Proiecte VS C#\\Data.txt");

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Value from TextBox1: " + textBox1.Text);
                writer.WriteLine("Value from TextBox2: " + textBox2.Text);
                writer.WriteLine("Value from TextBox3: " + textBox3.Text);
                writer.WriteLine("Value from TextBox4: " + textBox4.Text);
                writer.WriteLine("Value from TextBox5: " + textBox5.Text);
                writer.WriteLine("Value from TextBox6: " + textBox6.Text);
            }
        }

        private void slider3_ValueChanged(object sender, decimal value)
        {
            textBox3.Text = slider3.Value.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            bool result = textBox3.Text.Any(x => char.IsNumber(x));
            if (result == true && textBox3.Text != string.Empty)
            {
                string onlyNumbers3 = Regex.Replace(textBox3.Text, "[^. 0-9.-]", "");
                slider3.Value = Int32.Parse(onlyNumbers3);
                textBox3.Text = onlyNumbers3;  
            }
            else if (textBox3.Text == string.Empty) { slider3.Value = 0; }

            string filePath = Path.Combine(Environment.CurrentDirectory, "F:\\Proiecte VS C#\\Data.txt");

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Value from TextBox1: " + textBox1.Text);
                writer.WriteLine("Value from TextBox2: " + textBox2.Text);
                writer.WriteLine("Value from TextBox3: " + textBox3.Text);
                writer.WriteLine("Value from TextBox4: " + textBox4.Text);
                writer.WriteLine("Value from TextBox5: " + textBox5.Text);
                writer.WriteLine("Value from TextBox6: " + textBox6.Text);
            }
        }

        private void slider4_ValueChanged(object sender, decimal value)
        {
            textBox4.Text = slider4.Value.ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            bool result = textBox4.Text.Any(x => char.IsNumber(x));
            if (result == true && textBox4.Text != string.Empty)
            {
                string onlyNumbers4 = Regex.Replace(textBox4.Text, "[^. 0-9.-]", "");
                slider4.Value = Int32.Parse(onlyNumbers4);
                textBox4.Text = onlyNumbers4;
            }
            else if (textBox4.Text == string.Empty) { slider4.Value = 0; }

            string filePath = Path.Combine(Environment.CurrentDirectory, "F:\\Proiecte VS C#\\Data.txt");

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Value from TextBox1: " + textBox1.Text);
                writer.WriteLine("Value from TextBox2: " + textBox2.Text);
                writer.WriteLine("Value from TextBox3: " + textBox3.Text);
                writer.WriteLine("Value from TextBox4: " + textBox4.Text);
                writer.WriteLine("Value from TextBox5: " + textBox5.Text);
                writer.WriteLine("Value from TextBox6: " + textBox6.Text);
            }
        }

        private void slider5_ValueChanged(object sender, decimal value)
        {
            textBox5.Text = slider5.Value.ToString();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            bool result = textBox5.Text.Any(x => char.IsNumber(x));
            if (result == true && textBox5.Text != string.Empty)
            {
                string onlyNumbers5 = Regex.Replace(textBox5.Text, "[^. 0-9.-]", "");
                slider5.Value = Int32.Parse(onlyNumbers5);
                textBox5.Text = onlyNumbers5;
            }
            else if (textBox5.Text == string.Empty) { slider5.Value = 0; }

            string filePath = Path.Combine(Environment.CurrentDirectory, "F:\\Proiecte VS C#\\Data.txt");

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Value from TextBox1: " + textBox1.Text);
                writer.WriteLine("Value from TextBox2: " + textBox2.Text);
                writer.WriteLine("Value from TextBox3: " + textBox3.Text);
                writer.WriteLine("Value from TextBox4: " + textBox4.Text);
                writer.WriteLine("Value from TextBox5: " + textBox5.Text);
                writer.WriteLine("Value from TextBox6: " + textBox6.Text);
            }
        }

        private void slider6_ValueChanged(object sender, decimal value)
        {
            textBox6.Text = slider6.Value.ToString();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            bool result = textBox6.Text.Any(x => char.IsNumber(x));
            if (result == true && textBox6.Text != string.Empty)
            {
                string onlyNumbers6 = Regex.Replace(textBox6.Text, "[^. 0-9.-]", "");
                slider6.Value = Int32.Parse(onlyNumbers6);
                textBox6.Text = onlyNumbers6;
            }
            else if (textBox6.Text == string.Empty) { slider6.Value = 0; }

            string filePath = Path.Combine(Environment.CurrentDirectory, "F:\\Proiecte VS C#\\Data.txt");

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Value from TextBox1: " + textBox1.Text);
                writer.WriteLine("Value from TextBox2: " + textBox2.Text);
                writer.WriteLine("Value from TextBox3: " + textBox3.Text);
                writer.WriteLine("Value from TextBox4: " + textBox4.Text);
                writer.WriteLine("Value from TextBox5: " + textBox5.Text);
                writer.WriteLine("Value from TextBox6: " + textBox6.Text);
            }
        }

        private void textBoxPort_TextChanged(object sender, EventArgs e)
        {
            string onlyNumbers7 = Regex.Replace(textBoxPort.Text, "[^. 0-9.-]", "");
            textBoxPort.Text = onlyNumbers7;
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern IntPtr SetParent (IntPtr hWndChild, IntPtr hWndNewParent);

        private void iconButtonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            if(od.ShowDialog() == DialogResult.OK)
            {
                Process proc = Process.Start(od.FileName);
                proc.WaitForInputIdle();

                while(proc.MainWindowHandle == IntPtr.Zero) 
                {
                    Thread.Sleep(100);
                    proc.Refresh();
                }

                SetParent(proc.MainWindowHandle, this.Handle);
            }    
        }
        void sliderKkt(Slider slider, System.Windows.Controls.TextBox textBox)
        {

        }
    }

}
