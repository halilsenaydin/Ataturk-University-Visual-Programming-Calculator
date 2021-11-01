
namespace CalculatorUI.Forms
{
    partial class Scientific
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxKeys = new System.Windows.Forms.GroupBox();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnFactorial = new System.Windows.Forms.Button();
            this.btnLn = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnPow = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnAddition = new System.Windows.Forms.Button();
            this.btnSin = new System.Windows.Forms.Button();
            this.btnSubtraction = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnCot = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnClearInput = new System.Windows.Forms.Button();
            this.btnTan = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnInputAndResultClear = new System.Windows.Forms.Button();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.groupBoxKeys.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxKeys
            // 
            this.groupBoxKeys.Controls.Add(this.btnMod);
            this.groupBoxKeys.Controls.Add(this.btnFactorial);
            this.groupBoxKeys.Controls.Add(this.btnLn);
            this.groupBoxKeys.Controls.Add(this.btnLog);
            this.groupBoxKeys.Controls.Add(this.btnPow);
            this.groupBoxKeys.Controls.Add(this.btnSqrt);
            this.groupBoxKeys.Controls.Add(this.btnMultiplication);
            this.groupBoxKeys.Controls.Add(this.btnEquals);
            this.groupBoxKeys.Controls.Add(this.btnAddition);
            this.groupBoxKeys.Controls.Add(this.btnSin);
            this.groupBoxKeys.Controls.Add(this.btnSubtraction);
            this.groupBoxKeys.Controls.Add(this.btnDivision);
            this.groupBoxKeys.Controls.Add(this.btnCot);
            this.groupBoxKeys.Controls.Add(this.btnDel);
            this.groupBoxKeys.Controls.Add(this.btnClearInput);
            this.groupBoxKeys.Controls.Add(this.btnTan);
            this.groupBoxKeys.Controls.Add(this.btnCos);
            this.groupBoxKeys.Controls.Add(this.btnInputAndResultClear);
            this.groupBoxKeys.Location = new System.Drawing.Point(12, 89);
            this.groupBoxKeys.Name = "groupBoxKeys";
            this.groupBoxKeys.Size = new System.Drawing.Size(279, 338);
            this.groupBoxKeys.TabIndex = 0;
            this.groupBoxKeys.TabStop = false;
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(169, 282);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(49, 46);
            this.btnMod.TabIndex = 15;
            this.btnMod.Text = "mod";
            this.btnMod.UseVisualStyleBackColor = true;
            // 
            // btnFactorial
            // 
            this.btnFactorial.Location = new System.Drawing.Point(168, 230);
            this.btnFactorial.Name = "btnFactorial";
            this.btnFactorial.Size = new System.Drawing.Size(49, 46);
            this.btnFactorial.TabIndex = 14;
            this.btnFactorial.Text = "n!";
            this.btnFactorial.UseVisualStyleBackColor = true;
            // 
            // btnLn
            // 
            this.btnLn.Location = new System.Drawing.Point(169, 178);
            this.btnLn.Name = "btnLn";
            this.btnLn.Size = new System.Drawing.Size(49, 46);
            this.btnLn.TabIndex = 13;
            this.btnLn.Text = "ln";
            this.btnLn.UseVisualStyleBackColor = true;
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(169, 126);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(49, 46);
            this.btnLog.TabIndex = 12;
            this.btnLog.Text = "log";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnPow
            // 
            this.btnPow.Location = new System.Drawing.Point(168, 74);
            this.btnPow.Name = "btnPow";
            this.btnPow.Size = new System.Drawing.Size(49, 46);
            this.btnPow.TabIndex = 11;
            this.btnPow.Text = "x^y";
            this.btnPow.UseVisualStyleBackColor = true;
            this.btnPow.Click += new System.EventHandler(this.btnPow_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.Location = new System.Drawing.Point(169, 22);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(49, 46);
            this.btnSqrt.TabIndex = 10;
            this.btnSqrt.Text = "x^(1/2)";
            this.btnSqrt.UseVisualStyleBackColor = true;
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.Location = new System.Drawing.Point(223, 126);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(49, 46);
            this.btnMultiplication.TabIndex = 8;
            this.btnMultiplication.Text = "*";
            this.btnMultiplication.UseVisualStyleBackColor = true;
            this.btnMultiplication.Click += new System.EventHandler(this.btnMultiplication_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.Location = new System.Drawing.Point(223, 282);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(49, 46);
            this.btnEquals.TabIndex = 2;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnAddition
            // 
            this.btnAddition.Location = new System.Drawing.Point(224, 230);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(49, 46);
            this.btnAddition.TabIndex = 4;
            this.btnAddition.Text = "+";
            this.btnAddition.UseVisualStyleBackColor = true;
            this.btnAddition.Click += new System.EventHandler(this.btnAddition_Click);
            // 
            // btnSin
            // 
            this.btnSin.Location = new System.Drawing.Point(6, 22);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(49, 46);
            this.btnSin.TabIndex = 9;
            this.btnSin.Text = "sin";
            this.btnSin.UseVisualStyleBackColor = true;
            this.btnSin.Click += new System.EventHandler(this.btnSin_Click);
            // 
            // btnSubtraction
            // 
            this.btnSubtraction.Location = new System.Drawing.Point(223, 178);
            this.btnSubtraction.Name = "btnSubtraction";
            this.btnSubtraction.Size = new System.Drawing.Size(49, 46);
            this.btnSubtraction.TabIndex = 3;
            this.btnSubtraction.Text = "-";
            this.btnSubtraction.UseVisualStyleBackColor = true;
            this.btnSubtraction.Click += new System.EventHandler(this.btnSubtraction_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Location = new System.Drawing.Point(223, 74);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(49, 46);
            this.btnDivision.TabIndex = 4;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnCot
            // 
            this.btnCot.Location = new System.Drawing.Point(116, 74);
            this.btnCot.Name = "btnCot";
            this.btnCot.Size = new System.Drawing.Size(49, 46);
            this.btnCot.TabIndex = 5;
            this.btnCot.Text = "cot";
            this.btnCot.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(223, 22);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(49, 46);
            this.btnDel.TabIndex = 7;
            this.btnDel.Text = "Geri Al";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnClearInput
            // 
            this.btnClearInput.Location = new System.Drawing.Point(61, 22);
            this.btnClearInput.Name = "btnClearInput";
            this.btnClearInput.Size = new System.Drawing.Size(49, 46);
            this.btnClearInput.TabIndex = 6;
            this.btnClearInput.Text = "CE";
            this.btnClearInput.UseVisualStyleBackColor = true;
            // 
            // btnTan
            // 
            this.btnTan.Location = new System.Drawing.Point(61, 74);
            this.btnTan.Name = "btnTan";
            this.btnTan.Size = new System.Drawing.Size(49, 46);
            this.btnTan.TabIndex = 1;
            this.btnTan.Text = "tan";
            this.btnTan.UseVisualStyleBackColor = true;
            // 
            // btnCos
            // 
            this.btnCos.Location = new System.Drawing.Point(6, 74);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(49, 46);
            this.btnCos.TabIndex = 2;
            this.btnCos.Text = "cos";
            this.btnCos.UseVisualStyleBackColor = true;
            this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
            // 
            // btnInputAndResultClear
            // 
            this.btnInputAndResultClear.Location = new System.Drawing.Point(116, 22);
            this.btnInputAndResultClear.Name = "btnInputAndResultClear";
            this.btnInputAndResultClear.Size = new System.Drawing.Size(49, 46);
            this.btnInputAndResultClear.TabIndex = 3;
            this.btnInputAndResultClear.Text = "C";
            this.btnInputAndResultClear.UseVisualStyleBackColor = true;
            this.btnInputAndResultClear.Click += new System.EventHandler(this.btnInputAndResultClear_Click);
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(12, 71);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(0, 15);
            this.lblInput.TabIndex = 10;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(195, 71);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(13, 15);
            this.lblResult.TabIndex = 11;
            this.lblResult.Text = "0";
            // 
            // Scientific
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 439);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.groupBoxKeys);
            this.Name = "Scientific";
            this.Text = "Scientific";
            this.Load += new System.EventHandler(this.Scientific_Load);
            this.groupBoxKeys.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxKeys;
        private System.Windows.Forms.Button btnSin;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnClearInput;
        private System.Windows.Forms.Button btnInputAndResultClear;
        private System.Windows.Forms.Button btnTan;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnCot;
        private System.Windows.Forms.Button btnMultiplication;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnSubtraction;
        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnFactorial;
        private System.Windows.Forms.Button btnLn;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnPow;
        private System.Windows.Forms.Button btnSqrt;
    }
}