using System;
using System.Windows.Forms;

namespace ELifeCalculator
{
    public partial class Form1 : Form
    {
        double Life;
        double Armor;
        double MR;
        double DamagereductionArmor;
        double DamagereductionMR;
        double ELifeArmor;
        double ELifeMR;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            readData();
            calculateDMGReduction();
            calculateELife();
            displayResult();
        }

        private void displayResult()
        {
            textBox4.Text = ELifeArmor.ToString("0");
            textBox5.Text = ELifeMR.ToString("0");
        }

        private void calculateELife()
        {
            ELifeArmor = (DamagereductionArmor * Life) + Life;
            ELifeMR = (DamagereductionMR * Life) + Life;

        }

        private void calculateDMGReduction()
        {
                DamagereductionArmor = 1 - (100 / (100 + Armor));
                DamagereductionMR = 1 - (100 / (100 + MR));
        }

        private void readData()
        {
            Life = Convert.ToDouble(textBox1.Text);
            Armor = Convert.ToDouble(textBox2.Text);
            MR = Convert.ToDouble(textBox3.Text);
        }
    }
}
