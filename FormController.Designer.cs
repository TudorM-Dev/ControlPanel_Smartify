namespace GUI_SortifyBot
{
    partial class FormController
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.iconButtonOpen = new FontAwesome.Sharp.IconButton();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.stopButton = new FontAwesome.Sharp.IconButton();
            this.connectButton = new FontAwesome.Sharp.IconButton();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.slider5 = new XComponent.SliderBar.MACTrackBar();
            this.slider2 = new XComponent.SliderBar.MACTrackBar();
            this.slider3 = new XComponent.SliderBar.MACTrackBar();
            this.slider6 = new XComponent.SliderBar.MACTrackBar();
            this.slider4 = new XComponent.SliderBar.MACTrackBar();
            this.slider1 = new XComponent.SliderBar.MACTrackBar();
            this.button1 = new System.Windows.Forms.Button();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(17)))), ((int)(((byte)(59)))));
            this.panelDesktop.Controls.Add(this.iconButton1);
            this.panelDesktop.Controls.Add(this.button1);
            this.panelDesktop.Controls.Add(this.iconButtonOpen);
            this.panelDesktop.Controls.Add(this.textBox8);
            this.panelDesktop.Controls.Add(this.textBoxPort);
            this.panelDesktop.Controls.Add(this.stopButton);
            this.panelDesktop.Controls.Add(this.connectButton);
            this.panelDesktop.Controls.Add(this.textBox6);
            this.panelDesktop.Controls.Add(this.textBox5);
            this.panelDesktop.Controls.Add(this.textBox4);
            this.panelDesktop.Controls.Add(this.textBox3);
            this.panelDesktop.Controls.Add(this.textBox2);
            this.panelDesktop.Controls.Add(this.textBox1);
            this.panelDesktop.Controls.Add(this.label1);
            this.panelDesktop.Controls.Add(this.slider5);
            this.panelDesktop.Controls.Add(this.slider2);
            this.panelDesktop.Controls.Add(this.slider3);
            this.panelDesktop.Controls.Add(this.slider6);
            this.panelDesktop.Controls.Add(this.slider4);
            this.panelDesktop.Controls.Add(this.slider1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDesktop.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelDesktop.Location = new System.Drawing.Point(0, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1186, 640);
            this.panelDesktop.TabIndex = 3;
            // 
            // iconButtonOpen
            // 
            this.iconButtonOpen.BackColor = System.Drawing.Color.Purple;
            this.iconButtonOpen.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.iconButtonOpen.FlatAppearance.BorderSize = 0;
            this.iconButtonOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Violet;
            this.iconButtonOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonOpen.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonOpen.IconColor = System.Drawing.Color.Empty;
            this.iconButtonOpen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonOpen.Location = new System.Drawing.Point(808, 568);
            this.iconButtonOpen.Name = "iconButtonOpen";
            this.iconButtonOpen.Size = new System.Drawing.Size(172, 41);
            this.iconButtonOpen.TabIndex = 23;
            this.iconButtonOpen.Text = "OPEN SIMULATION";
            this.iconButtonOpen.UseVisualStyleBackColor = false;
            this.iconButtonOpen.Click += new System.EventHandler(this.iconButtonOpen_Click);
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(17)))), ((int)(((byte)(59)))));
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBox8.Location = new System.Drawing.Point(471, 469);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(36, 19);
            this.textBox8.TabIndex = 22;
            this.textBox8.Text = "Port:";
            // 
            // textBoxPort
            // 
            this.textBoxPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(17)))), ((int)(((byte)(59)))));
            this.textBoxPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPort.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxPort.Location = new System.Drawing.Point(512, 466);
            this.textBoxPort.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPort.MaxLength = 4;
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxPort.Size = new System.Drawing.Size(76, 26);
            this.textBoxPort.TabIndex = 21;
            this.textBoxPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxPort.TextChanged += new System.EventHandler(this.textBoxPort_TextChanged);
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.stopButton.FlatAppearance.BorderSize = 0;
            this.stopButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.stopButton.IconColor = System.Drawing.Color.Black;
            this.stopButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.stopButton.Location = new System.Drawing.Point(270, 463);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(119, 33);
            this.stopButton.TabIndex = 20;
            this.stopButton.Text = "STOP";
            this.stopButton.UseVisualStyleBackColor = false;
            // 
            // connectButton
            // 
            this.connectButton.BackColor = System.Drawing.Color.Green;
            this.connectButton.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.connectButton.FlatAppearance.BorderSize = 0;
            this.connectButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.connectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.connectButton.IconColor = System.Drawing.Color.Empty;
            this.connectButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.connectButton.Location = new System.Drawing.Point(45, 463);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(119, 33);
            this.connectButton.TabIndex = 19;
            this.connectButton.Text = "CONNECT";
            this.connectButton.UseVisualStyleBackColor = false;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(17)))), ((int)(((byte)(59)))));
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox6.Location = new System.Drawing.Point(566, 410);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2);
            this.textBox6.Name = "textBox6";
            this.textBox6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox6.Size = new System.Drawing.Size(76, 26);
            this.textBox6.TabIndex = 18;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(17)))), ((int)(((byte)(59)))));
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox5.Location = new System.Drawing.Point(566, 335);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox5.Size = new System.Drawing.Size(76, 26);
            this.textBox5.TabIndex = 17;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(17)))), ((int)(((byte)(59)))));
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox4.Location = new System.Drawing.Point(566, 260);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox4.Size = new System.Drawing.Size(76, 26);
            this.textBox4.TabIndex = 16;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(17)))), ((int)(((byte)(59)))));
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox3.Location = new System.Drawing.Point(566, 185);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox3.Size = new System.Drawing.Size(76, 26);
            this.textBox3.TabIndex = 15;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(17)))), ((int)(((byte)(59)))));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox2.Location = new System.Drawing.Point(566, 110);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox2.Size = new System.Drawing.Size(76, 26);
            this.textBox2.TabIndex = 14;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(17)))), ((int)(((byte)(59)))));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(566, 44);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(76, 26);
            this.textBox1.TabIndex = 13;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(564, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            // 
            // slider5
            // 
            this.slider5.BackColor = System.Drawing.Color.Transparent;
            this.slider5.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.slider5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slider5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.slider5.IndentHeight = 6;
            this.slider5.Location = new System.Drawing.Point(12, 335);
            this.slider5.Maximum = 150;
            this.slider5.Minimum = -150;
            this.slider5.Name = "slider5";
            this.slider5.Size = new System.Drawing.Size(546, 47);
            this.slider5.TabIndex = 11;
            this.slider5.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.slider5.TickFrequency = 20;
            this.slider5.TickHeight = 4;
            this.slider5.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(130)))), ((int)(((byte)(198)))));
            this.slider5.TrackerSize = new System.Drawing.Size(16, 16);
            this.slider5.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.slider5.TrackLineHeight = 3;
            this.slider5.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.slider5.Value = 0;
            this.slider5.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.slider5_ValueChanged);
            // 
            // slider2
            // 
            this.slider2.BackColor = System.Drawing.Color.Transparent;
            this.slider2.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.slider2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slider2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.slider2.IndentHeight = 6;
            this.slider2.Location = new System.Drawing.Point(12, 110);
            this.slider2.Maximum = 150;
            this.slider2.Minimum = -150;
            this.slider2.Name = "slider2";
            this.slider2.Size = new System.Drawing.Size(546, 47);
            this.slider2.TabIndex = 10;
            this.slider2.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.slider2.TickFrequency = 20;
            this.slider2.TickHeight = 4;
            this.slider2.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(130)))), ((int)(((byte)(198)))));
            this.slider2.TrackerSize = new System.Drawing.Size(16, 16);
            this.slider2.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.slider2.TrackLineHeight = 3;
            this.slider2.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.slider2.Value = 0;
            this.slider2.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.slider2_ValueChanged);
            // 
            // slider3
            // 
            this.slider3.BackColor = System.Drawing.Color.Transparent;
            this.slider3.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.slider3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slider3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.slider3.IndentHeight = 6;
            this.slider3.Location = new System.Drawing.Point(12, 185);
            this.slider3.Maximum = 150;
            this.slider3.Minimum = -150;
            this.slider3.Name = "slider3";
            this.slider3.Size = new System.Drawing.Size(546, 47);
            this.slider3.TabIndex = 9;
            this.slider3.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.slider3.TickFrequency = 20;
            this.slider3.TickHeight = 4;
            this.slider3.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(130)))), ((int)(((byte)(198)))));
            this.slider3.TrackerSize = new System.Drawing.Size(16, 16);
            this.slider3.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.slider3.TrackLineHeight = 3;
            this.slider3.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.slider3.Value = 0;
            this.slider3.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.slider3_ValueChanged);
            // 
            // slider6
            // 
            this.slider6.BackColor = System.Drawing.Color.Transparent;
            this.slider6.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.slider6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slider6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.slider6.IndentHeight = 6;
            this.slider6.Location = new System.Drawing.Point(12, 410);
            this.slider6.Maximum = 100;
            this.slider6.Minimum = 0;
            this.slider6.Name = "slider6";
            this.slider6.Size = new System.Drawing.Size(546, 47);
            this.slider6.TabIndex = 8;
            this.slider6.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.slider6.TickFrequency = 10;
            this.slider6.TickHeight = 4;
            this.slider6.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(130)))), ((int)(((byte)(198)))));
            this.slider6.TrackerSize = new System.Drawing.Size(16, 16);
            this.slider6.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.slider6.TrackLineHeight = 3;
            this.slider6.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.slider6.Value = 0;
            this.slider6.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.slider6_ValueChanged);
            // 
            // slider4
            // 
            this.slider4.BackColor = System.Drawing.Color.Transparent;
            this.slider4.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.slider4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slider4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.slider4.IndentHeight = 6;
            this.slider4.Location = new System.Drawing.Point(12, 260);
            this.slider4.Maximum = 180;
            this.slider4.Minimum = -180;
            this.slider4.Name = "slider4";
            this.slider4.Size = new System.Drawing.Size(546, 47);
            this.slider4.TabIndex = 7;
            this.slider4.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.slider4.TickFrequency = 30;
            this.slider4.TickHeight = 4;
            this.slider4.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(130)))), ((int)(((byte)(198)))));
            this.slider4.TrackerSize = new System.Drawing.Size(16, 16);
            this.slider4.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.slider4.TrackLineHeight = 3;
            this.slider4.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.slider4.Value = 0;
            this.slider4.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.slider4_ValueChanged);
            // 
            // slider1
            // 
            this.slider1.BackColor = System.Drawing.Color.Transparent;
            this.slider1.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.slider1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slider1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.slider1.IndentHeight = 6;
            this.slider1.Location = new System.Drawing.Point(12, 35);
            this.slider1.Maximum = 150;
            this.slider1.Minimum = -150;
            this.slider1.Name = "slider1";
            this.slider1.Size = new System.Drawing.Size(546, 47);
            this.slider1.TabIndex = 6;
            this.slider1.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.slider1.TickFrequency = 20;
            this.slider1.TickHeight = 4;
            this.slider1.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(130)))), ((int)(((byte)(198)))));
            this.slider1.TrackerSize = new System.Drawing.Size(16, 16);
            this.slider1.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.slider1.TrackLineHeight = 3;
            this.slider1.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.slider1.Value = 0;
            this.slider1.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.slider1_ValueChanged);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(773, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 101);
            this.button1.TabIndex = 24;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(781, 118);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(75, 23);
            this.iconButton1.TabIndex = 25;
            this.iconButton1.Text = "iconButton1";
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // FormController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 640);
            this.Controls.Add(this.panelDesktop);
            this.Name = "FormController";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormController_Load);
            this.Resize += new System.EventHandler(this.FormController_Resize);
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDesktop;
        private XComponent.SliderBar.MACTrackBar slider1;
        private XComponent.SliderBar.MACTrackBar slider5;
        private XComponent.SliderBar.MACTrackBar slider2;
        private XComponent.SliderBar.MACTrackBar slider3;
        private XComponent.SliderBar.MACTrackBar slider6;
        private XComponent.SliderBar.MACTrackBar slider4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private FontAwesome.Sharp.IconButton connectButton;
        private FontAwesome.Sharp.IconButton stopButton;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBoxPort;
        private FontAwesome.Sharp.IconButton iconButtonOpen;
        private System.Windows.Forms.Button button1;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}

