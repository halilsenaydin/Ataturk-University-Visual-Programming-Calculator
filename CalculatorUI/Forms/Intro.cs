using Operations.Abstracts;
using Operations.Concretes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CalculatorUI.Forms
{
    public partial class Intro : Form
    {
        public Intro()
        {
            InitializeComponent();
        }

        private List<string> inputs = new List<string>();
        IOperationService operationService = new OperationManager();

        private void Intro_Load(object sender, EventArgs e)
        {
            CreateKeys();
        }

        private void CreateKeys()
        {
            List<Button> keys = new List<Button>();
            List<char> keyValues = new List<char>() { '7', '4', '1', ' ', '8', '5', '2', '0', '9', '6', '3', '.' };

            var buttonSize = new Size(49, 46);

            int i = 0;
            for (int x = 6; x <= 116; x+=55)
            {
                for (int y = 126; y <= 282; y+=52 )
                {
                    Button key = new Button();
                    key.Location = new Point(x, y);
                    key.Size = buttonSize;
                    key.Visible = true;
                    key.Text = keyValues[i].ToString();
                    key.Click += new System.EventHandler(this.KeyClick);

                    groupBoxKeys.Controls.Add(key);

                    i += 1;
                }
            }
        }

        void KeyClick(object sender, EventArgs e)
        {
            Button button = sender as Button; // Get Button Reference

            var number = button.Text;
            lblInput.Text += number;
            inputs.Add(number);
        }

        double GetNumber()
        {
            string numberText = "";
            foreach (var item in inputs)
            {
                numberText += item;
            }

            var number = Convert.ToDouble(numberText);
            return number;
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            var number = GetNumber(); // Get Number
            var result = operationService.Adding(number);

            lblInput.Text += "+";
            if (result.Success)
            {
                inputs.Clear();
                lblResult.Text = result.Data.ToString();
            }

            else
            {
                MessageBox.Show(result.Message);
            }
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            var number = GetNumber(); // Get Number
            var result = operationService.Subtraction(number);

            lblInput.Text += "-";
            if (result.Success)
            {
                inputs.Clear();
                lblResult.Text = result.Data.ToString();
            }

            else
            {
                MessageBox.Show(result.Message);
            }
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            var number = GetNumber(); // Get Number
            var result = operationService.Multiplication(number);

            lblInput.Text += "*";
            if (result.Success)
            {
                inputs.Clear();
                lblResult.Text = result.Data.ToString();
            }

            else
            {
                MessageBox.Show(result.Message);
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            var number = GetNumber(); // Get Number
            var result = operationService.Division(number);

            lblInput.Text += "/";
            if (result.Success)
            {
                inputs.Clear();
                lblResult.Text = result.Data.ToString();
            }

            else
            {
                MessageBox.Show(result.Message);
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            inputs.Clear();
            lblResult.Text = operationService.GetResult().ToString();
            lblInput.Text = operationService.GetResult().ToString();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            inputs.Remove(inputs[inputs.Count-1]);

            var text = lblInput.Text.Remove(lblInput.Text.Length-1);
            lblInput.Text = text;
        }

        private void btnInputAndResult_Click(object sender, EventArgs e)
        {
            operationService.ClearResult();
            inputs.Clear();
            lblInput.Text = "";
            lblResult.Text = operationService.GetResult().ToString();
        }
    }
}
