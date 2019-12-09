using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trig
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double sin(double x)
        {
            return (Math.Sin(x * Math.PI / 180.0));
        }
        double asin(double x)
        {
            return (Math.Asin(x) * 180.0 / Math.PI);

        double Cos(double x)
        {
            return (Math.Cos(x * Math.PI / 180.0));
        }
        double Acos(double x)
        {
            return (Math.Acos(x) * 180.0 / Math.PI);
        }
                private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
