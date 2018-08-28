namespace Pastebin
{
    partial class MainForm
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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.LabelLogin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxContent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxExpiration = new System.Windows.Forms.ComboBox();
            this.comboBoxExposure = new System.Windows.Forms.ComboBox();
            this.comboBoxSyntax = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(12, 24);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(224, 35);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Log In";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // LabelLogin
            // 
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.Location = new System.Drawing.Point(12, 8);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(120, 13);
            this.LabelLogin.TabIndex = 1;
            this.LabelLogin.Text = "Please log in to use app";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Paste Title";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(12, 89);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(221, 20);
            this.textBoxTitle.TabIndex = 3;
            // 
            // textBoxContent
            // 
            this.textBoxContent.Location = new System.Drawing.Point(12, 131);
            this.textBoxContent.Name = "textBoxContent";
            this.textBoxContent.Size = new System.Drawing.Size(221, 20);
            this.textBoxContent.TabIndex = 5;
            this.textBoxContent.Click += new System.EventHandler(this.textBoxContent_Clicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Paste Contents";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Paste Exposure";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Paste Expiration";
            // 
            // comboBoxExpiration
            // 
            this.comboBoxExpiration.FormattingEnabled = true;
            this.comboBoxExpiration.Location = new System.Drawing.Point(12, 179);
            this.comboBoxExpiration.Name = "comboBoxExpiration";
            this.comboBoxExpiration.Size = new System.Drawing.Size(221, 21);
            this.comboBoxExpiration.TabIndex = 10;
            this.comboBoxExpiration.Text = "Please Select A Value.";
            // 
            // comboBoxExposure
            // 
            this.comboBoxExposure.FormattingEnabled = true;
            this.comboBoxExposure.Location = new System.Drawing.Point(12, 227);
            this.comboBoxExposure.Name = "comboBoxExposure";
            this.comboBoxExposure.Size = new System.Drawing.Size(221, 21);
            this.comboBoxExposure.TabIndex = 11;
            this.comboBoxExposure.Text = "Please Select A Value.";
            // 
            // comboBoxSyntax
            // 
            this.comboBoxSyntax.FormattingEnabled = true;
            this.comboBoxSyntax.Location = new System.Drawing.Point(12, 279);
            this.comboBoxSyntax.Name = "comboBoxSyntax";
            this.comboBoxSyntax.Size = new System.Drawing.Size(221, 21);
            this.comboBoxSyntax.TabIndex = 13;
            this.comboBoxSyntax.Text = "Please Select A Value.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Paste Syntax Highlighting";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(12, 317);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(224, 36);
            this.buttonSubmit.TabIndex = 14;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 363);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.comboBoxSyntax);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxExposure);
            this.Controls.Add(this.comboBoxExpiration);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxContent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelLogin);
            this.Controls.Add(this.buttonLogin);
            this.Name = "MainForm";
            this.Text = "Pastebin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label LabelLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxContent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxExpiration;
        private System.Windows.Forms.ComboBox comboBoxExposure;
        private System.Windows.Forms.ComboBox comboBoxSyntax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSubmit;
    }
}

