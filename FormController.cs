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
using XComponent.SliderBar;

namespace GUI_SortifyBot
{
    public partial class FormController : Form
    {

        //Forms
        private IconButton currentBtn;
        private System.Windows.Forms.Panel leftBorderBtn;
        private Form currentChildForm;

        //Constructor
        public FormController()
        {
            InitializeComponent();
            leftBorderBtn = new System.Windows.Forms.Panel();
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

        private void Slider(MACTrackBar slider, System.Windows.Forms.TextBox textBox)
        {
            textBox.Text = slider.Value.ToString();

            bool result = textBox.Text.Any(x => char.IsNumber(x));
            if (result == true && textBox.Text != string.Empty)
            {
                string onlyNumbers = Regex.Replace(textBox.Text, "[^. 0-9.-]", "");
                slider.Value = Int32.Parse(onlyNumbers);
                textBox.Text = onlyNumbers;
            }
            else if (textBox.Text == string.Empty)
            {
                slider.Value = 0;
            }

            Console.Write(textBox1.Text + " " + textBox2.Text + " " + textBox3.Text + " " + textBox4.Text + " " + textBox5.Text + " " + textBox6.Text);
        }
        
        private void slider1_ValueChanged(object sender, decimal value)
        {
            Slider(slider1, textBox1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Slider(slider1, textBox1);
        }

        private void slider2_ValueChanged(object sender, decimal value)
        {
            Slider(slider2, textBox2);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Slider(slider2, textBox2);
        }

        private void slider3_ValueChanged(object sender, decimal value)
        {
            Slider(slider3, textBox3);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Slider(slider3, textBox3);
        }

        private void slider4_ValueChanged(object sender, decimal value)
        {
            Slider(slider4, textBox4);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Slider(slider4, textBox4);
        }

        private void slider5_ValueChanged(object sender, decimal value)
        {
            Slider(slider5, textBox5);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            Slider(slider5, textBox5);
        }

        private void slider6_ValueChanged(object sender, decimal value)
        {
            Slider(slider6, textBox6);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            Slider(slider6, textBox6);
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

        private Rectangle buttonOriginalRectangle;
        private Rectangle originalFormSize;

        private void FormController_Load(object sender, EventArgs e)
        {
            originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
            buttonOriginalRectangle = new Rectangle(button1.Location.X, button1.Location.Y, button1.Width, button1.Height);
        }

        private void resizeControl(Rectangle r, FontAwesome.Sharp.IconButton c)
        {
            float xRatio = (float)(this.Width) / (float)(originalFormSize.Width);
            float yRatio = (float)(this.Height) / (float)(originalFormSize.Height);

            int newX = (int)(r.Location.X * xRatio);
            int newY = (int)(r.Location.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
        }

        private void FormController_Resize(object sender, EventArgs e)
        {
            resizeControl(buttonOriginalRectangle, iconButtonOpen);
        }
    }
}
