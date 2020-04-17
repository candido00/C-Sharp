using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNum1.Text.Trim() == null || textBoxNum1.Text.Trim() == "")
                {
                    MessageBox.Show("VALORES NAO PODEM SER NULOS OU VAZIO!!", "ERRO!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (textBoxNum2.Text.Trim() == null || textBoxNum2.Text.Trim() == "")
                {
                    MessageBox.Show("VALORES NAO PODEM SER NULOS OU VAZIO!!", "ERRO!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    double num1, num2, soma;
                    num1 = Convert.ToDouble(textBoxNum1.Text);
                    num2 = Convert.ToDouble(textBoxNum2.Text);
                    soma = (num1 + num2);
                    textBoxResultado.Text = soma.ToString();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("INSIRA APENAS NÚMEROS!!","ERRO!!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            textBoxNum1.Clear();
            textBoxNum2.Clear();
            textBoxResultado.Clear();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNum1.Text.Trim() == null || textBoxNum1.Text.Trim() == "")
                {
                    MessageBox.Show("VALORES NAO PODEM SER NULOS OU VAZIO!!", "ERRO!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (textBoxNum2.Text.Trim() == null || textBoxNum2.Text.Trim() == "")
                {
                    MessageBox.Show("VALORES NAO PODEM SER NULOS OU VAZIO!!", "ERRO!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    double num1, num2, subtr;
                    num1 = Convert.ToDouble(textBoxNum1.Text);
                    num2 = Convert.ToDouble(textBoxNum2.Text);
                    subtr = (num1 - num2);
                    textBoxResultado.Text = subtr.ToString();
                }
                
            }
            catch (FormatException)
            {
                MessageBox.Show("INSIRA APENAS NÚMEROS!!", "ERRO!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNum1.Text.Trim() == null || textBoxNum1.Text.Trim() == "")
                {
                    MessageBox.Show("VALORES NAO PODEM SER NULOS OU VAZIO!!", "ERRO!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (textBoxNum2.Text.Trim() == null || textBoxNum2.Text.Trim() == "")
                {
                    MessageBox.Show("VALORES NAO PODEM SER NULOS OU VAZIO!!", "ERRO!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    double num1, num2, multip;
                    num1 = Convert.ToDouble(textBoxNum1.Text);
                    num2 = Convert.ToDouble(textBoxNum2.Text);
                    multip = (num1 * num2);
                    textBoxResultado.Text = multip.ToString();
                }               
            }
            catch (FormatException)
            {
                MessageBox.Show("INSIRA APENAS NÚMEROS!!", "ERRO!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNum1.Text.Trim() == null || textBoxNum1.Text.Trim() == "")
                {
                    MessageBox.Show("VALORES NAO PODEM SER NULOS OU VAZIO!!", "ERRO!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (textBoxNum2.Text.Trim() == null || textBoxNum2.Text.Trim() == "")
                {
                    MessageBox.Show("VALORES NAO PODEM SER NULOS OU VAZIO!!", "ERRO!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    double num1, num2, divis;
                    num1 = Convert.ToDouble(textBoxNum1.Text);
                    num2 = Convert.ToDouble(textBoxNum2.Text);

                    if (num2 == 0)
                    {
                        MessageBox.Show("NÃO É POSSIVEL DIVIDOR POR ZERO ( 0 ).", "ERRO!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        divis = (num1 / num2);
                        textBoxResultado.Text = divis.ToString();
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("INSIRA APENAS NÚMEROS!!", "ERRO!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
