using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortifyBot_UI.Forms
{
    public partial class FormSettings : Form
    {
        public static FormSettings instance;
        public static string exePath = null;
        public FormSettings()
        {
            InitializeComponent();
            instance = this;
            
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        public void btnChooseS_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            if (od.ShowDialog() == DialogResult.OK)
            {
                exePath = od.FileName;
            }
        }

        public static bool simSelected()
        {
            return (exePath != null);
        }

        public static string getExePath()
        {  return exePath; }

    }
}
