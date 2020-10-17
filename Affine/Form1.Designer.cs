namespace Affine
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
            this.encryptBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxEncrypt = new System.Windows.Forms.TextBox();
            this.textBoxDecrypt = new System.Windows.Forms.TextBox();
            this.decryptBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.filteredTextVal = new System.Windows.Forms.Label();
            this.keyA = new System.Windows.Forms.NumericUpDown();
            this.keyB = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.encryptOutput = new System.Windows.Forms.TextBox();
            this.decryptOutput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.keyA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyB)).BeginInit();
            this.SuspendLayout();
            // 
            // encryptBtn
            // 
            this.encryptBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(102)))), ((int)(((byte)(141)))));
            this.encryptBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.encryptBtn.FlatAppearance.BorderSize = 0;
            this.encryptBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(102)))), ((int)(((byte)(200)))));
            this.encryptBtn.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptBtn.ForeColor = System.Drawing.Color.White;
            this.encryptBtn.Location = new System.Drawing.Point(400, 160);
            this.encryptBtn.Name = "encryptBtn";
            this.encryptBtn.Size = new System.Drawing.Size(191, 66);
            this.encryptBtn.TabIndex = 0;
            this.encryptBtn.Text = "Encrypt";
            this.encryptBtn.UseVisualStyleBackColor = false;
            this.encryptBtn.Click += new System.EventHandler(this.encryptBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 11F);
            this.label1.Location = new System.Drawing.Point(171, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "a:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 11F);
            this.label2.Location = new System.Drawing.Point(171, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "b:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(158, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Text for encryption:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(158, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Text for decryption:";
            // 
            // textBoxEncrypt
            // 
            this.textBoxEncrypt.Location = new System.Drawing.Point(302, 51);
            this.textBoxEncrypt.Name = "textBoxEncrypt";
            this.textBoxEncrypt.Size = new System.Drawing.Size(614, 34);
            this.textBoxEncrypt.TabIndex = 5;
            this.textBoxEncrypt.TextChanged += new System.EventHandler(this.textBoxEncrypt_TextChanged);
            // 
            // textBoxDecrypt
            // 
            this.textBoxDecrypt.Location = new System.Drawing.Point(302, 90);
            this.textBoxDecrypt.Name = "textBoxDecrypt";
            this.textBoxDecrypt.Size = new System.Drawing.Size(614, 34);
            this.textBoxDecrypt.TabIndex = 6;
            // 
            // decryptBtn
            // 
            this.decryptBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(102)))), ((int)(((byte)(141)))));
            this.decryptBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.decryptBtn.FlatAppearance.BorderSize = 0;
            this.decryptBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(102)))), ((int)(((byte)(200)))));
            this.decryptBtn.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptBtn.ForeColor = System.Drawing.Color.White;
            this.decryptBtn.Location = new System.Drawing.Point(611, 160);
            this.decryptBtn.Name = "decryptBtn";
            this.decryptBtn.Size = new System.Drawing.Size(191, 66);
            this.decryptBtn.TabIndex = 9;
            this.decryptBtn.Text = "Decrypt";
            this.decryptBtn.UseVisualStyleBackColor = false;
            this.decryptBtn.Click += new System.EventHandler(this.decryptBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Filtered text:";
            // 
            // filteredTextVal
            // 
            this.filteredTextVal.AutoSize = true;
            this.filteredTextVal.Location = new System.Drawing.Point(285, 303);
            this.filteredTextVal.Name = "filteredTextVal";
            this.filteredTextVal.Size = new System.Drawing.Size(22, 22);
            this.filteredTextVal.TabIndex = 13;
            this.filteredTextVal.Text = "...";
            // 
            // keyA
            // 
            this.keyA.Location = new System.Drawing.Point(213, 160);
            this.keyA.Name = "keyA";
            this.keyA.Size = new System.Drawing.Size(46, 34);
            this.keyA.TabIndex = 14;
            this.keyA.ValueChanged += new System.EventHandler(this.keyA_ValueChanged);
            // 
            // keyB
            // 
            this.keyB.Location = new System.Drawing.Point(213, 192);
            this.keyB.Name = "keyB";
            this.keyB.Size = new System.Drawing.Size(46, 34);
            this.keyB.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(172, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 22);
            this.label6.TabIndex = 16;
            this.label6.Text = "Encrypted output:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(172, 420);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 22);
            this.label7.TabIndex = 17;
            this.label7.Text = "Decrypted output:";
            // 
            // encryptOutput
            // 
            this.encryptOutput.Location = new System.Drawing.Point(329, 355);
            this.encryptOutput.Name = "encryptOutput";
            this.encryptOutput.Size = new System.Drawing.Size(614, 34);
            this.encryptOutput.TabIndex = 18;
            this.encryptOutput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // decryptOutput
            // 
            this.decryptOutput.Location = new System.Drawing.Point(329, 413);
            this.decryptOutput.Name = "decryptOutput";
            this.decryptOutput.Size = new System.Drawing.Size(614, 34);
            this.decryptOutput.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1067, 588);
            this.Controls.Add(this.decryptOutput);
            this.Controls.Add(this.encryptOutput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.keyB);
            this.Controls.Add(this.keyA);
            this.Controls.Add(this.filteredTextVal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.decryptBtn);
            this.Controls.Add(this.textBoxDecrypt);
            this.Controls.Add(this.textBoxEncrypt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.encryptBtn);
            this.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Affiny cipher encryption/decryprion tool";
            ((System.ComponentModel.ISupportInitialize)(this.keyA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button encryptBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxEncrypt;
        private System.Windows.Forms.TextBox textBoxDecrypt;
        private System.Windows.Forms.Button decryptBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label filteredTextVal;
        private System.Windows.Forms.NumericUpDown keyA;
        private System.Windows.Forms.NumericUpDown keyB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox encryptOutput;
        private System.Windows.Forms.TextBox decryptOutput;
    }
}

