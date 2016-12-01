using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MO_4_Interpolation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] x_values = new double[11] { -5, -4, -3, -2, -1,0,1,2,3,4,5};
            double[] y_values = new double[11] { 2.1, 3.6, 3, 1.4, 2 , 2.2 ,1.3,-0.2,0.6,1.7,2.3};

           for( int i = 0;  i < 11; i++)
           {
                chart1.Series[1].Points.AddXY(x_values[i], y_values[i]);
                //chart1.Series[0].Points.AddXY(i, LP.fi(i,x_values,y_values));
           }
            for (double i = -5; i < 5.1; i+=0.1)
            {
                //chart1.Series[1].Points.AddXY(x_values[i], y_values[i]);
                chart1.Series[0].Points.AddXY(i, LP.fi(i,x_values,y_values));
            }


        }
    }
}
