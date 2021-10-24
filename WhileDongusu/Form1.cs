using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhileDongusu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int number = 0;
        int fact = 1;
        string factText = "";
        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            lbl_result.Text = "";
            lbl_factText.Text = "";
            fact = 1;
            factText = "";

            try
            {
                number = Convert.ToInt32(tbx_enteredNumber.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Tam Sayı Giriniz!");
                return;
            }

            if (number < 0)
            {
                MessageBox.Show("Negatif sayıların faktöriyeli yoktur!");
                return;
            }

            if (number == 0)
            {
                fact = 1;
                lbl_result.Text = fact.ToString();
                factText = "0! = 1";
                return;
            }

            factText = number + "! = " + number;
            while (true)
            {
                fact *= number;
                number--;
                if (number <= 0) break;
                factText += "x" + number.ToString();
            }

            lbl_factText.Text = factText;
            lbl_result.Text = fact.ToString();
        }
    }
}
