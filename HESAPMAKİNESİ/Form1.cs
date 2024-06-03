using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HESAPMAKİNESİ
{
    public partial class Form1 : Form
    {
        char _işlem;
        private bool _ekranTemizlenecekmi;
        int _ilksayi;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rakam1Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekmi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "1";
        }

        private void rakam2Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekmi = false;
            }

            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "2";
        }

        private void rakam3Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekmi = false;
            }

            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "3";
        }

        private void rakam4Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekmi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "4";
        }

        private void rakam5Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekmi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "5";
        }

        private void rakam6Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekmi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "6";
        }

        private void rakam7Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekmi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "7";
        }

        private void rakam8Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekmi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "8";
        }

        private void rakam9Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekmi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "9";
        }

        private void rakam0Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekmi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "0";
        }

        private void artiButton_Click(object sender, EventArgs e)
        {
            _işlem = '+';
            _ekranTemizlenecekmi = true;
            _ilksayi = Convert.ToInt32(ekranLabel.Text);
        }

        private void eşittirButton_Click(object sender, EventArgs e)
        {
            int  ikinciSayi = Convert.ToInt32(ekranLabel.Text);
            int  sonuç;
            


            switch(_işlem)
            {
                case '+':
                    sonuç = _ilksayi + ikinciSayi;
                    break;
                case '-':
                    sonuç = _ilksayi - ikinciSayi;
                    break;
                case '*':
                    sonuç = _ilksayi * ikinciSayi;
                    break;
                case '/':
                    sonuç = _ilksayi / ikinciSayi;
                    break;
                default:
                    sonuç =0;
                    break;

                    
            }

            ekranLabel.Text = Convert.ToString(sonuç);
            


        }

        private void eksiButton_Click(object sender, EventArgs e)
        {
            _işlem = '-';
            _ekranTemizlenecekmi = true;
            _ilksayi = Convert.ToInt32(ekranLabel.Text);
        }

        private void çarpıButton_Click(object sender, EventArgs e)
        {
            _işlem = '*';
            _ekranTemizlenecekmi = true;
            _ilksayi = Convert.ToInt32(ekranLabel.Text);
        }

        private void bölüButton_Click(object sender, EventArgs e)
        {
            _işlem = '/';
            _ekranTemizlenecekmi = true;
            _ilksayi = Convert.ToInt32(ekranLabel.Text);
        }

        private void temizleButton_Click(object sender, EventArgs e)
        {
            ekranLabel.Text = "0";
        }
    }
}
