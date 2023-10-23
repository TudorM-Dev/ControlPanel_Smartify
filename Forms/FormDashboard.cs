using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortifyBot_UI.Forms
{
    public partial class FormDashboard : Form
    {
        public static FormDashboard instance;
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            chart1.Series["Stats"].Points.AddXY(2019, 142000);
            chart1.Series["Stats"].Points.AddXY(2020, 130000);
            chart1.Series["Stats"].Points.AddXY(2021, 152000);
            chart1.Series["Stats"].Points.AddXY(2022, 172000);
            chart1.Series["Stats"].Points.AddXY(2023, 192000);
        }

    }
}
