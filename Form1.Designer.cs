namespace Laba2
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pField = new System.Windows.Forms.TextBox();
            this.qField = new System.Windows.Forms.TextBox();
            this.dField = new System.Windows.Forms.TextBox();
            this.Decipher = new System.Windows.Forms.Button();
            this.Encipher = new System.Windows.Forms.Button();
            this.Generate = new System.Windows.Forms.Button();
            this.PlainTextField = new System.Windows.Forms.TextBox();
            this.CipherTextField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.eField = new System.Windows.Forms.TextBox();
            this.p = new System.Windows.Forms.Label();
            this.q = new System.Windows.Forms.Label();
            this.d = new System.Windows.Forms.Label();
            this.e = new System.Windows.Forms.Label();
            this.w_n = new System.Windows.Forms.Label();
            this.n = new System.Windows.Forms.Label();
            this.w_nField = new System.Windows.Forms.TextBox();
            this.nField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pField
            // 
            this.pField.Location = new System.Drawing.Point(41, 44);
            this.pField.Name = "pField";
            this.pField.Size = new System.Drawing.Size(167, 20);
            this.pField.TabIndex = 0;
            this.pField.WordWrap = false;
            // 
            // qField
            // 
            this.qField.Location = new System.Drawing.Point(245, 44);
            this.qField.Name = "qField";
            this.qField.Size = new System.Drawing.Size(167, 20);
            this.qField.TabIndex = 2;
            this.qField.WordWrap = false;
            // 
            // dField
            // 
            this.dField.Location = new System.Drawing.Point(245, 87);
            this.dField.Name = "dField";
            this.dField.ReadOnly = true;
            this.dField.Size = new System.Drawing.Size(167, 20);
            this.dField.TabIndex = 6;
            this.dField.WordWrap = false;
            // 
            // Decipher
            // 
            this.Decipher.Location = new System.Drawing.Point(73, 522);
            this.Decipher.Name = "Decipher";
            this.Decipher.Size = new System.Drawing.Size(75, 23);
            this.Decipher.TabIndex = 8;
            this.Decipher.Text = "Decipher";
            this.Decipher.UseVisualStyleBackColor = true;
            this.Decipher.Click += new System.EventHandler(this.Decipher_Click);
            // 
            // Encipher
            // 
            this.Encipher.Location = new System.Drawing.Point(598, 522);
            this.Encipher.Name = "Encipher";
            this.Encipher.Size = new System.Drawing.Size(75, 23);
            this.Encipher.TabIndex = 9;
            this.Encipher.Text = "Encipher";
            this.Encipher.UseVisualStyleBackColor = true;
            this.Encipher.Click += new System.EventHandler(this.Encipher_Click);
            // 
            // Generate
            // 
            this.Generate.Location = new System.Drawing.Point(669, 64);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(75, 23);
            this.Generate.TabIndex = 10;
            this.Generate.Text = "Generate";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // PlainTextField
            // 
            this.PlainTextField.Location = new System.Drawing.Point(41, 204);
            this.PlainTextField.Multiline = true;
            this.PlainTextField.Name = "PlainTextField";
            this.PlainTextField.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PlainTextField.Size = new System.Drawing.Size(684, 123);
            this.PlainTextField.TabIndex = 11;
            this.PlainTextField.TabStop = false;
            // 
            // CipherTextField
            // 
            this.CipherTextField.Location = new System.Drawing.Point(41, 382);
            this.CipherTextField.Multiline = true;
            this.CipherTextField.Name = "CipherTextField";
            this.CipherTextField.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CipherTextField.Size = new System.Drawing.Size(684, 123);
            this.CipherTextField.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Plain text:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Cipher text:";
            // 
            // eField
            // 
            this.eField.Location = new System.Drawing.Point(41, 87);
            this.eField.Name = "eField";
            this.eField.Size = new System.Drawing.Size(167, 20);
            this.eField.TabIndex = 15;
            this.eField.WordWrap = false;
            // 
            // p
            // 
            this.p.AutoSize = true;
            this.p.Location = new System.Drawing.Point(19, 47);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(16, 13);
            this.p.TabIndex = 16;
            this.p.Text = "p:";
            // 
            // q
            // 
            this.q.AutoSize = true;
            this.q.Location = new System.Drawing.Point(223, 47);
            this.q.Name = "q";
            this.q.Size = new System.Drawing.Size(16, 13);
            this.q.TabIndex = 17;
            this.q.Text = "q:";
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.Location = new System.Drawing.Point(223, 90);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(16, 13);
            this.d.TabIndex = 19;
            this.d.Text = "d:";
            // 
            // e
            // 
            this.e.AutoSize = true;
            this.e.Location = new System.Drawing.Point(19, 90);
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(16, 13);
            this.e.TabIndex = 18;
            this.e.Text = "e:";
            // 
            // w_n
            // 
            this.w_n.AutoSize = true;
            this.w_n.Location = new System.Drawing.Point(432, 90);
            this.w_n.Name = "w_n";
            this.w_n.Size = new System.Drawing.Size(30, 13);
            this.w_n.TabIndex = 23;
            this.w_n.Text = "w(n):";
            // 
            // n
            // 
            this.n.AutoSize = true;
            this.n.Location = new System.Drawing.Point(446, 47);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(16, 13);
            this.n.TabIndex = 22;
            this.n.Text = "n:";
            // 
            // w_nField
            // 
            this.w_nField.Location = new System.Drawing.Point(468, 87);
            this.w_nField.Name = "w_nField";
            this.w_nField.ReadOnly = true;
            this.w_nField.Size = new System.Drawing.Size(167, 20);
            this.w_nField.TabIndex = 21;
            this.w_nField.WordWrap = false;
            // 
            // nField
            // 
            this.nField.Location = new System.Drawing.Point(468, 44);
            this.nField.Name = "nField";
            this.nField.ReadOnly = true;
            this.nField.Size = new System.Drawing.Size(167, 20);
            this.nField.TabIndex = 20;
            this.nField.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 566);
            this.Controls.Add(this.w_n);
            this.Controls.Add(this.n);
            this.Controls.Add(this.w_nField);
            this.Controls.Add(this.nField);
            this.Controls.Add(this.d);
            this.Controls.Add(this.e);
            this.Controls.Add(this.q);
            this.Controls.Add(this.p);
            this.Controls.Add(this.eField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CipherTextField);
            this.Controls.Add(this.PlainTextField);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.Encipher);
            this.Controls.Add(this.Decipher);
            this.Controls.Add(this.dField);
            this.Controls.Add(this.qField);
            this.Controls.Add(this.pField);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pField;
        private System.Windows.Forms.TextBox qField;
        private System.Windows.Forms.TextBox dField;
        private System.Windows.Forms.Button Decipher;
        private System.Windows.Forms.Button Encipher;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.TextBox PlainTextField;
        private System.Windows.Forms.TextBox CipherTextField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox eField;
        private System.Windows.Forms.Label p;
        private System.Windows.Forms.Label q;
        private System.Windows.Forms.Label d;
        private System.Windows.Forms.Label e;
        private System.Windows.Forms.Label w_n;
        private System.Windows.Forms.Label n;
        private System.Windows.Forms.TextBox w_nField;
        private System.Windows.Forms.TextBox nField;
    }
}

