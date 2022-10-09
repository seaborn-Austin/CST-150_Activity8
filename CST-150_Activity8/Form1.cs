using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_150_Activity8
{
    public partial class calorieCalculatorFrm : Form
    {
        public calorieCalculatorFrm()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int total = 0;
            total = FatCalories(int.Parse(fatGramTxt.Text)) + CarbCalories(int.Parse(carbGramsTxt.Text));
            totalCalTxt.Text = total.ToString();
            totalFatCalTxt.Text = FatCalories(int.Parse(fatGramTxt.Text)).ToString();
            totalCarbCalTxt.Text = CarbCalories(int.Parse(carbGramsTxt.Text)).ToString();
        }

        private int FatCalories(int fat)
        {
            return fat * 9;
        }

        private int CarbCalories(int carb)
        {
            return carb * 4;
        }

        private void carbGramsLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
