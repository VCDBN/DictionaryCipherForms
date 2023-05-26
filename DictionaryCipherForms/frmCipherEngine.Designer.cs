namespace DictionaryCipherForms
{
    partial class frmCipherEngine
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.txbInput = new System.Windows.Forms.TextBox();
            this.txbOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(65, 191);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 0;
            this.btnEncrypt.Text = "Encrypt!";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(249, 191);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 1;
            this.btnDecrypt.Text = "Decrypt!";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // txbInput
            // 
            this.txbInput.Location = new System.Drawing.Point(15, 13);
            this.txbInput.Multiline = true;
            this.txbInput.Name = "txbInput";
            this.txbInput.Size = new System.Drawing.Size(381, 162);
            this.txbInput.TabIndex = 2;
            // 
            // txbOutput
            // 
            this.txbOutput.Location = new System.Drawing.Point(15, 232);
            this.txbOutput.Multiline = true;
            this.txbOutput.Name = "txbOutput";
            this.txbOutput.Size = new System.Drawing.Size(381, 163);
            this.txbOutput.TabIndex = 3;
            // 
            // frmCipherEngine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 407);
            this.Controls.Add(this.txbOutput);
            this.Controls.Add(this.txbInput);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Name = "frmCipherEngine";
            this.Text = "CipherEngine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnEncrypt;
        private Button btnDecrypt;
        private TextBox txbInput;
        private TextBox txbOutput;
    }
}