using Entities.Abstracts;
using Entities.Concretes;
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

        ~Intro() // Destructor
        {
            this.Close();
        }

        private List<string> inputs = new List<string>(); // String List.. string to double converting, easier than smashing (10.25)
        private List<double> numbers = new List<double>(); // İşlem gören tüm sayıları içerir. örneğin 3 + 5 işlemindeki 3 ve 5..

        // Tüm işlemleri içerir. Soyutlama yaptığımı düşünüyorum çünkü kod tekrarını önledim (bir işlem bir kaç form'da çağrılabilir..) ve işlem kurallarını kontrol edeceğim bir sistem kurdum..
        IOperationService operationService = new OperationManager();

        private void Intro_Load(object sender, EventArgs e)
        {
            CreateKeys();
            
            // Set Color Of Menu
            standardToolStripMenuItem.BackColor = Color.Black;
            standardToolStripMenuItem.ForeColor = Color.White;

            bilimselToolStripMenuItem.BackColor = Color.Black;
            bilimselToolStripMenuItem.ForeColor = Color.White;

            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show("Hesap makinemin arayüzünü çok iyi yapamadım :( \n" +
                "Ama kodlarımın kaliteli olduğuna eminim. \n" +
                "OOP'nin gerektirdiği gibi kodladım ve soyutlamaları doğru yerde kullandığımı düşünüyorum..",
                "lilah Calculator - Uygulamam Hakkında", buttons, MessageBoxIcon.Information);
        }

        // Create keys using loop and add in groupbox for use later on.
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
                    key.BackColor = Color.Black;
                    key.ForeColor = Color.White;

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

        double GetNumber() // Girilen sayıları uygun formatda al ve işlenebilecek hale çevir.
        {
            string numberText = "";
            foreach (var item in inputs)
            {
                numberText += item;
            }

            if (numberText != "")
            {
                var number = Convert.ToDouble(numberText);
                numbers.Add(number);
            }
             
            return numbers[numbers.Count - 1];
        }

        // +, -, *, /
        private void btnAddition_Click(object sender, EventArgs e)
        {
            var number = GetNumber(); // Get Number
            var result = operationService.Adding(number);

            if (result.Success)
            {
                lblInput.Text = String.Format("{0} + ", result.Data);
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

            if (result.Success)
            {
                lblInput.Text = String.Format("{0} - ", result.Data);
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

            if (result.Success)
            {
                lblInput.Text = String.Format("{0} * ", result.Data);
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

            if (result.Success)
            {
                lblInput.Text = String.Format("{0} / ", result.Data);
                inputs.Clear();
                lblResult.Text = result.Data.ToString();
            }

            else
            {
                MessageBox.Show(result.Message);
            }
        }

        // Operations
        private void btnInversion_Click(object sender, EventArgs e)
        {
            var number = GetNumber();
            var result = operationService.Inversion(number);
            if (!result.Success)
            {
                MessageBox.Show(result.Message);
            }

            else
            {
                inputs.Clear();
                numbers.Add(result.Data);
                lblResult.Text = result.Data.ToString();
            }
        }

        private void btnExponentOfTwo_Click(object sender, EventArgs e)
        {
            var number = GetNumber();
            var result = operationService.Pow(number);
            if (!result.Success)
            {
                MessageBox.Show(result.Message);
            }

            else
            {
                inputs.Clear();
                numbers.Add(result.Data);
                lblResult.Text = result.Data.ToString();
            }
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            var number = GetNumber();
            var result = operationService.Root(number);
            if (!result.Success)
            {
                MessageBox.Show(result.Message);
            }

            else
            {
                inputs.Clear();
                numbers.Add(result.Data);
                lblResult.Text = result.Data.ToString();
            }
        }
        private void btnPercent_Click(object sender, EventArgs e)
        {
            var number = GetNumber();
            var result = operationService.Percent(number);
            if (!result.Success)
            {
                MessageBox.Show(result.Message);
            }

            else
            {
                inputs.Clear();
                numbers.Add(result.Data);
                lblResult.Text = result.Data.ToString();
            }
        }

        // Get Result
        private void btnEquals_Click(object sender, EventArgs e)
        {
            var number = GetNumber();
            inputs.Clear();
            var result = operationService.Equals(number);
            if (!result.Success)
            {
                MessageBox.Show(result.Message);
            }

            else
            {
                lblResult.Text = result.Data.ToString();
                lblInput.Text = result.Data.ToString();
            }
        }

        // Take it back
        private void btnDel_Click(object sender, EventArgs e)
        {
            inputs.Remove(inputs[inputs.Count-1]);

            var text = lblInput.Text.Remove(lblInput.Text.Length-1);
            lblInput.Text = text;
        }

        // Reset All
        private void btnInputAndResultClear_Click(object sender, EventArgs e)
        {
            operationService.ClearResult();
            inputs.Clear();
            lblInput.Text = "";
            lblResult.Text = operationService.GetResult().ToString();
        }

        // Menu Clicks
        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Intro form = new Intro();
            this.Hide();
            GC.Collect(); // Garbage Collector.. C# prog. dilinin bellek yönetim sınıfıdır..
            form.Show();
        }

        private void bilimselToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Scientific form = new Scientific();
            this.Hide();
            GC.Collect(); // Garbage Collector.. C# prog. dilinin bellek yönetim sınıfıdır..
            form.Show();
        }
    }
}
