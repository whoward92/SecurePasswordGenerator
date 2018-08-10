namespace SecurePasswordGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblPassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cpyBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lenVal = new System.Windows.Forms.NumericUpDown();
            this.upper = new System.Windows.Forms.CheckBox();
            this.number = new System.Windows.Forms.CheckBox();
            this.lower = new System.Windows.Forms.CheckBox();
            this.symbol = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.lenVal)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPassword.Location = new System.Drawing.Point(12, 134);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(501, 26);
            this.lblPassword.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(14, 168);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Generate Password";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cpyBtn
            // 
            this.cpyBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpyBtn.Location = new System.Drawing.Point(407, 168);
            this.cpyBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cpyBtn.Name = "cpyBtn";
            this.cpyBtn.Size = new System.Drawing.Size(111, 36);
            this.cpyBtn.TabIndex = 2;
            this.cpyBtn.Text = "Copy";
            this.cpyBtn.UseVisualStyleBackColor = true;
            this.cpyBtn.Click += new System.EventHandler(this.cpyBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(74, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Length (Min 8 | Max 99):";
            // 
            // lenVal
            // 
            this.lenVal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lenVal.Location = new System.Drawing.Point(265, 62);
            this.lenVal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lenVal.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.lenVal.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.lenVal.Name = "lenVal";
            this.lenVal.Size = new System.Drawing.Size(118, 27);
            this.lenVal.TabIndex = 5;
            this.lenVal.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // upper
            // 
            this.upper.AutoSize = true;
            this.upper.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.upper.ForeColor = System.Drawing.Color.White;
            this.upper.Location = new System.Drawing.Point(11, 22);
            this.upper.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.upper.Name = "upper";
            this.upper.Size = new System.Drawing.Size(108, 22);
            this.upper.TabIndex = 6;
            this.upper.Text = "Uppercase";
            this.upper.UseVisualStyleBackColor = true;
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.number.ForeColor = System.Drawing.Color.White;
            this.number.Location = new System.Drawing.Point(271, 22);
            this.number.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(92, 22);
            this.number.TabIndex = 7;
            this.number.Text = "Numbers";
            this.number.UseVisualStyleBackColor = true;
            // 
            // lower
            // 
            this.lower.AutoSize = true;
            this.lower.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.lower.ForeColor = System.Drawing.Color.White;
            this.lower.Location = new System.Drawing.Point(142, 22);
            this.lower.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lower.Name = "lower";
            this.lower.Size = new System.Drawing.Size(107, 22);
            this.lower.TabIndex = 8;
            this.lower.Text = "Lowercase";
            this.lower.UseVisualStyleBackColor = true;
            // 
            // symbol
            // 
            this.symbol.AutoSize = true;
            this.symbol.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.symbol.ForeColor = System.Drawing.Color.White;
            this.symbol.Location = new System.Drawing.Point(391, 22);
            this.symbol.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.symbol.Name = "symbol";
            this.symbol.Size = new System.Drawing.Size(88, 22);
            this.symbol.TabIndex = 9;
            this.symbol.Text = "Symbols";
            this.symbol.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lower);
            this.groupBox1.Controls.Add(this.lenVal);
            this.groupBox1.Controls.Add(this.symbol);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.upper);
            this.groupBox1.Controls.Add(this.number);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(502, 124);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(530, 216);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cpyBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblPassword);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secure Password Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lenVal)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lblPassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cpyBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown lenVal;
        private System.Windows.Forms.CheckBox upper;
        private System.Windows.Forms.CheckBox number;
        private System.Windows.Forms.CheckBox lower;
        private System.Windows.Forms.CheckBox symbol;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

