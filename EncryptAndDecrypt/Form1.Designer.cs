namespace EncryptAndDecrypt
{
    partial class Form1
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
            btnEncrypt = new Button();
            label1 = new Label();
            textDecrypt = new TextBox();
            textEncrypt = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnDecrypt = new Button();
            textValue = new TextBox();
            SuspendLayout();
            // 
            // btnEncrypt
            // 
            btnEncrypt.BackColor = Color.Blue;
            btnEncrypt.ForeColor = SystemColors.ControlLightLight;
            btnEncrypt.Location = new Point(302, 209);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(71, 33);
            btnEncrypt.TabIndex = 0;
            btnEncrypt.Text = "Encrypt";
            btnEncrypt.UseVisualStyleBackColor = false;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.ForeColor = Color.FromArgb(0, 192, 192);
            label1.Location = new Point(142, 81);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "Value:";
            // 
            // textDecrypt
            // 
            textDecrypt.Location = new Point(186, 180);
            textDecrypt.Multiline = true;
            textDecrypt.Name = "textDecrypt";
            textDecrypt.Size = new Size(268, 23);
            textDecrypt.TabIndex = 3;
            // 
            // textEncrypt
            // 
            textEncrypt.Location = new Point(186, 127);
            textEncrypt.Multiline = true;
            textEncrypt.Name = "textEncrypt";
            textEncrypt.Size = new Size(268, 23);
            textEncrypt.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.ForeColor = Color.FromArgb(0, 192, 192);
            label2.Location = new Point(130, 127);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 5;
            label2.Text = "Encrypt:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.ForeColor = Color.FromArgb(0, 192, 192);
            label3.Location = new Point(129, 180);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 6;
            label3.Text = "Decrypt:";
            // 
            // btnDecrypt
            // 
            btnDecrypt.BackColor = Color.Blue;
            btnDecrypt.ForeColor = SystemColors.ControlLightLight;
            btnDecrypt.Location = new Point(379, 209);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(75, 33);
            btnDecrypt.TabIndex = 7;
            btnDecrypt.Text = "Decrypt";
            btnDecrypt.UseVisualStyleBackColor = false;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // textValue
            // 
            textValue.Location = new Point(186, 81);
            textValue.Multiline = true;
            textValue.Name = "textValue";
            textValue.Size = new Size(268, 23);
            textValue.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(textValue);
            Controls.Add(btnDecrypt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textEncrypt);
            Controls.Add(textDecrypt);
            Controls.Add(label1);
            Controls.Add(btnEncrypt);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEncrypt;
        private Label label1;
        private TextBox textDecrypt;
        private TextBox textEncrypt;
        private Label label2;
        private Label label3;
        private Button btnDecrypt;
        private TextBox textValue;
    }
}
