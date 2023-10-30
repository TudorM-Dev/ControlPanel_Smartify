using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using XComponent.SliderBar;
using System.Speech;
using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace SortifyBot_UI.Forms
{
    public partial class FormController : Form
    {

        String jointSerialOutput;

        public static FormController instance;

        SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();
        SpeechSynthesizer speech = new SpeechSynthesizer();


        public FormController()
        {
            InitializeComponent();
            instance = this;
            Choices choices = new Choices();
            string[] text = File.ReadAllLines(Environment.CurrentDirectory + "//Grammar.txt");
            choices.Add(text);
            Grammar grammar = new Grammar(new GrammarBuilder(choices));
            recEngine.LoadGrammar(grammar);
            recEngine.SetInputToDefaultAudioDevice();
            recEngine.RecognizeAsync(RecognizeMode.Multiple);
            recEngine.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(recEngine_SpeechRecognized);

            speech.SelectVoiceByHints(VoiceGender.Male);
        }

        private void recEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string result = e.Result.Text;

            if(btnAuto.Text == "AUTO")
            {
                if(result == "Hello")
                {
                    result = "Hi, how can I help you";
                }

                if (result == "Turn around")
                {
                    result = "Turning around right now";
                }

                speech.SpeakAsync(result);
                labelSpeech.Text = result;
            }

        }

        private void TextBoxValue(MACTrackBar slider, System.Windows.Forms.TextBox textBox)
        {
            textBox.Text = slider.Value.ToString();
        }

        private void Slider(MACTrackBar slider, System.Windows.Forms.TextBox textBox)
        {

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

            Console.WriteLine(getGlobalValue());

        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        public void btnOpenS_Click_1(object sender, EventArgs e)
        {
            if (!FormSettings.simSelected()) return;

            string s = FormSettings.getExePath();
            System.Diagnostics.Process.Start(s);
                //SetParent(proc.MainWindowHandle, this.Handle);
        }

        private void updateGlobalValue()
        {
            jointSerialOutput = slider1.Value + " " + slider2.Value + " " + slider3.Value + " " + slider4.Value + " " + slider5.Value + " " + slider6.Value;
        }

        private string getGlobalValue()
        {
            updateGlobalValue();
            return jointSerialOutput;
        }


        private void textBoxPort_TextChanged(object sender, EventArgs e)
        {
            string onlyNumbers = Regex.Replace(textBoxPort.Text, "[^. 0-9.-]", "");
            textBoxPort.Text = onlyNumbers;
        }

        private void btnAuto_MouseEnter(object sender, EventArgs e)
        {
            if (btnAuto.Text == "MANUAL")
                btnAuto.BackColor = Color.Cyan;
            else
                btnAuto.BackColor = Color.DarkCyan;
        }

        private void btnAuto_MouseLeave(object sender, EventArgs e)//test
        {
            if (btnAuto.Text == "MANUAL")
                btnAuto.BackColor = Color.DarkCyan;
            else
                btnAuto.BackColor = Color.Cyan;
        }


        private void btnSendData_Click(object sender, EventArgs e)
        {
            TextWriter text1 = new StreamWriter("RobotData.txt");
            text1.WriteLine(textBox1.Text + " " + textBox2.Text + " " + textBox3.Text + " " + textBox4.Text + " " + textBox5.Text + " " + textBox6.Text + " ");
            text1.Close();
        }


        #region SliderRegion

        private void slider1_ValueChanged(object sender, decimal value)
        {
            TextBoxValue(slider1, textBox1);

        }
        private void slider2_ValueChanged(object sender, decimal value)
        {
            TextBoxValue(slider2, textBox2);

        }
        private void slider3_ValueChanged(object sender, decimal value)
        {
            TextBoxValue(slider3, textBox3);

        }
        private void slider4_ValueChanged(object sender, decimal value)
        {
            TextBoxValue(slider4, textBox4);

        }
        private void slider5_ValueChanged(object sender, decimal value)
        {
            TextBoxValue(slider5, textBox5);

        }
        private void slider6_ValueChanged(object sender, decimal value)
        {
            TextBoxValue(slider6, textBox6);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Slider(slider1, textBox1);
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Slider(slider2, textBox2);
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Slider(slider3, textBox3);
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Slider(slider4, textBox4);
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            Slider(slider5, textBox5);
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            Slider(slider6, textBox6);
        }

        private void FormController_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
        }


        #endregion

        private void changeToStop()
        {
            btnConnect.Text = "STOP";
            btnConnect.BackColor = Color.Red;
        }

        private void changeToConnect()
        {
            btnConnect.Text = "CONNECt";
            btnConnect.BackColor = Color.Green;
        }
        
        private void btnConnect_Click(object sender, EventArgs e)
        {
            
        }

        private void changeToManual()
        {
            btnAuto.BackColor = Color.DarkCyan;
            btnAuto.Text = "MANUAL";
        }

        private void changeToAuto()
        {
            btnAuto.BackColor = Color.Cyan;
            btnAuto.Text = "AUTO";
        }
        private void btnAuto_Click(object sender, EventArgs e)
        {

        }

        private void changeToReset()
        {
            btnReset.Text = "RESET";
            btnReset.BackColor = Color.Red;
        }

        private void changeToResume()
        {
            btnReset.Text = "RESUME";
            btnReset.BackColor = Color.Yellow;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {

        }
    }
}
