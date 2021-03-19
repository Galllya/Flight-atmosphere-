using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flight
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

   

      

        Formuls furm = new Formuls();
        private void btStart_Click(object sender, EventArgs e)
        {
            furm.makeValue((double)edAngle.Value, (double)edSpeed.Value, (double)edHeight.Value, (double)edWeight.Value,
               (double)edSquare.Value);

            furm.Position();

           
            
            chart1.Series[0].Points.Clear();
            chart1.Series[0].Points.AddXY(furm.x, furm.y);

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            furm.main();

            chart1.Series[0].Points.AddXY(furm.x, furm.y);
            if (furm.y <= 0) timer1.Stop();
        }

        private void edAngle_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
