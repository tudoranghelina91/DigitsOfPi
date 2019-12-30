namespace DigitsOfPi
{
    partial class Form1
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
            this.numberOfDigitsLabel = new System.Windows.Forms.Label();
            this.numbericUpDnDigitsOfPi = new System.Windows.Forms.NumericUpDown();
            this.calculatePiBtn = new System.Windows.Forms.Button();
            this.piTextBox = new System.Windows.Forms.TextBox();
            this.piProgressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.numbericUpDnDigitsOfPi)).BeginInit();
            this.SuspendLayout();
            // 
            // numberOfDigitsLabel
            // 
            this.numberOfDigitsLabel.AutoSize = true;
            this.numberOfDigitsLabel.Location = new System.Drawing.Point(13, 13);
            this.numberOfDigitsLabel.Name = "numberOfDigitsLabel";
            this.numberOfDigitsLabel.Size = new System.Drawing.Size(57, 13);
            this.numberOfDigitsLabel.TabIndex = 0;
            this.numberOfDigitsLabel.Text = "Digits of Pi";
            // 
            // numbericUpDnDigitsOfPi
            // 
            this.numbericUpDnDigitsOfPi.Location = new System.Drawing.Point(76, 11);
            this.numbericUpDnDigitsOfPi.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numbericUpDnDigitsOfPi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numbericUpDnDigitsOfPi.Name = "numbericUpDnDigitsOfPi";
            this.numbericUpDnDigitsOfPi.Size = new System.Drawing.Size(56, 20);
            this.numbericUpDnDigitsOfPi.TabIndex = 1;
            this.numbericUpDnDigitsOfPi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // calculatePiBtn
            // 
            this.calculatePiBtn.Location = new System.Drawing.Point(138, 8);
            this.calculatePiBtn.Name = "calculatePiBtn";
            this.calculatePiBtn.Size = new System.Drawing.Size(75, 23);
            this.calculatePiBtn.TabIndex = 2;
            this.calculatePiBtn.Text = "Calc";
            this.calculatePiBtn.UseVisualStyleBackColor = true;
            this.calculatePiBtn.Click += new System.EventHandler(this.calculatePiBtn_Click);
            // 
            // piTextBox
            // 
            this.piTextBox.Location = new System.Drawing.Point(12, 37);
            this.piTextBox.Multiline = true;
            this.piTextBox.Name = "piTextBox";
            this.piTextBox.ReadOnly = true;
            this.piTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.piTextBox.Size = new System.Drawing.Size(206, 165);
            this.piTextBox.TabIndex = 3;
            // 
            // piProgressBar
            // 
            this.piProgressBar.Location = new System.Drawing.Point(12, 210);
            this.piProgressBar.Name = "piProgressBar";
            this.piProgressBar.Size = new System.Drawing.Size(201, 23);
            this.piProgressBar.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 245);
            this.Controls.Add(this.piProgressBar);
            this.Controls.Add(this.piTextBox);
            this.Controls.Add(this.calculatePiBtn);
            this.Controls.Add(this.numbericUpDnDigitsOfPi);
            this.Controls.Add(this.numberOfDigitsLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numbericUpDnDigitsOfPi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numberOfDigitsLabel;
        private System.Windows.Forms.NumericUpDown numbericUpDnDigitsOfPi;
        private System.Windows.Forms.Button calculatePiBtn;
        private System.Windows.Forms.TextBox piTextBox;
        private System.Windows.Forms.ProgressBar piProgressBar;
    }
}

