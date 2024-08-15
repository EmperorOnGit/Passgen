namespace PasswordGenerator
{
    partial class PasswordGeneratorForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.NumericUpDown PasswordLengthNumericUpDown;
        private System.Windows.Forms.Button GeneratePasswordButton;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox UppercaseCheckBox;
        private System.Windows.Forms.CheckBox LowercaseCheckBox;
        private System.Windows.Forms.CheckBox NumbersCheckBox;
        private System.Windows.Forms.CheckBox SpecialCharactersCheckBox;
        private System.Windows.Forms.Button CopyPasswordButton; 

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.PasswordLengthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.GeneratePasswordButton = new System.Windows.Forms.Button();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UppercaseCheckBox = new System.Windows.Forms.CheckBox();
            this.LowercaseCheckBox = new System.Windows.Forms.CheckBox();
            this.NumbersCheckBox = new System.Windows.Forms.CheckBox();
            this.SpecialCharactersCheckBox = new System.Windows.Forms.CheckBox();
            this.CopyPasswordButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordLengthNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // PasswordLengthNumericUpDown
            // 
            this.PasswordLengthNumericUpDown.Location = new System.Drawing.Point(12, 25);
            this.PasswordLengthNumericUpDown.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.PasswordLengthNumericUpDown.Name = "PasswordLengthNumericUpDown";
            this.PasswordLengthNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.PasswordLengthNumericUpDown.TabIndex = 0;
            this.PasswordLengthNumericUpDown.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // GeneratePasswordButton
            // 
            this.GeneratePasswordButton.Location = new System.Drawing.Point(138, 25);
            this.GeneratePasswordButton.Name = "GeneratePasswordButton";
            this.GeneratePasswordButton.Size = new System.Drawing.Size(120, 23);
            this.GeneratePasswordButton.TabIndex = 1;
            this.GeneratePasswordButton.Text = "Generate Password";
            this.GeneratePasswordButton.UseVisualStyleBackColor = true;
            this.GeneratePasswordButton.Click += new System.EventHandler(this.GeneratePasswordButton_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(12, 154);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.ReadOnly = true;
            this.PasswordTextBox.Size = new System.Drawing.Size(246, 20);
            this.PasswordTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password Length:";
            // 
            // UppercaseCheckBox
            // 
            this.UppercaseCheckBox.AutoSize = true;
            this.UppercaseCheckBox.Location = new System.Drawing.Point(12, 51);
            this.UppercaseCheckBox.Name = "UppercaseCheckBox";
            this.UppercaseCheckBox.Size = new System.Drawing.Size(78, 17);
            this.UppercaseCheckBox.TabIndex = 4;
            this.UppercaseCheckBox.Text = "Uppercase";
            this.UppercaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // LowercaseCheckBox
            // 
            this.LowercaseCheckBox.AutoSize = true;
            this.LowercaseCheckBox.Location = new System.Drawing.Point(12, 74);
            this.LowercaseCheckBox.Name = "LowercaseCheckBox";
            this.LowercaseCheckBox.Size = new System.Drawing.Size(78, 17);
            this.LowercaseCheckBox.TabIndex = 5;
            this.LowercaseCheckBox.Text = "Lowercase";
            this.LowercaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // NumbersCheckBox
            // 
            this.NumbersCheckBox.AutoSize = true;
            this.NumbersCheckBox.Location = new System.Drawing.Point(12, 97);
            this.NumbersCheckBox.Name = "NumbersCheckBox";
            this.NumbersCheckBox.Size = new System.Drawing.Size(68, 17);
            this.NumbersCheckBox.TabIndex = 6;
            this.NumbersCheckBox.Text = "Numbers";
            this.NumbersCheckBox.UseVisualStyleBackColor = true;
            // 
            // SpecialCharactersCheckBox
            // 
            this.SpecialCharactersCheckBox.AutoSize = true;
            this.SpecialCharactersCheckBox.Location = new System.Drawing.Point(12, 120);
            this.SpecialCharactersCheckBox.Name = "SpecialCharactersCheckBox";
            this.SpecialCharactersCheckBox.Size = new System.Drawing.Size(115, 17);
            this.SpecialCharactersCheckBox.TabIndex = 7;
            this.SpecialCharactersCheckBox.Text = "Special Characters";
            this.SpecialCharactersCheckBox.UseVisualStyleBackColor = true;
            // 
            // CopyPasswordButton
            // 
            this.CopyPasswordButton.Location = new System.Drawing.Point(138, 54);
            this.CopyPasswordButton.Name = "CopyPasswordButton";
            this.CopyPasswordButton.Size = new System.Drawing.Size(120, 23);
            this.CopyPasswordButton.TabIndex = 8;
            this.CopyPasswordButton.Text = "Copy Password";
            this.CopyPasswordButton.UseVisualStyleBackColor = true;
            this.CopyPasswordButton.Click += new System.EventHandler(this.CopyPasswordButton_Click);
            // 
            // PasswordGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 190);
            this.Controls.Add(this.CopyPasswordButton);
            this.Controls.Add(this.SpecialCharactersCheckBox);
            this.Controls.Add(this.NumbersCheckBox);
            this.Controls.Add(this.LowercaseCheckBox);
            this.Controls.Add(this.UppercaseCheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.GeneratePasswordButton);
            this.Controls.Add(this.PasswordLengthNumericUpDown);
            this.Name = "PasswordGeneratorForm";
            this.Text = "Passgen By Emperor";
            ((System.ComponentModel.ISupportInitialize)(this.PasswordLengthNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}