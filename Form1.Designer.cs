namespace Translator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._lstLanguages = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this._txtResID = new System.Windows.Forms.TextBox();
            this._txtEnglish = new System.Windows.Forms.TextBox();
            this._txtResPath = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this._txtResult = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this._txtClientSecret = new System.Windows.Forms.TextBox();
            this._txtClientID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Res ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "English Value:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Languages:";
            // 
            // _lstLanguages
            // 
            this._lstLanguages.CheckOnClick = true;
            this._lstLanguages.FormattingEnabled = true;
            this._lstLanguages.Items.AddRange(new object[] {
            "de-DE",
            "en-AU",
            "en-GB",
            "en-IE",
            "en-NZ",
            "es-ES",
            "es-MX",
            "fr-BE",
            "fr-CA",
            "fr-FR",
            "nl-BE",
            "nl-NL",
            "pt-BR"});
            this._lstLanguages.Location = new System.Drawing.Point(108, 75);
            this._lstLanguages.Name = "_lstLanguages";
            this._lstLanguages.Size = new System.Drawing.Size(120, 214);
            this._lstLanguages.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Resx Folder Path:";
            // 
            // _txtResID
            // 
            this._txtResID.Location = new System.Drawing.Point(108, 14);
            this._txtResID.Name = "_txtResID";
            this._txtResID.Size = new System.Drawing.Size(788, 20);
            this._txtResID.TabIndex = 6;
            // 
            // _txtEnglish
            // 
            this._txtEnglish.Location = new System.Drawing.Point(107, 44);
            this._txtEnglish.Name = "_txtEnglish";
            this._txtEnglish.Size = new System.Drawing.Size(789, 20);
            this._txtEnglish.TabIndex = 7;
            // 
            // _txtResPath
            // 
            this._txtResPath.Location = new System.Drawing.Point(112, 300);
            this._txtResPath.Name = "_txtResPath";
            this._txtResPath.Size = new System.Drawing.Size(784, 20);
            this._txtResPath.TabIndex = 8;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(18, 395);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 9;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // _txtResult
            // 
            this._txtResult.Location = new System.Drawing.Point(16, 424);
            this._txtResult.Multiline = true;
            this._txtResult.Name = "_txtResult";
            this._txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this._txtResult.Size = new System.Drawing.Size(880, 296);
            this._txtResult.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(530, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(374, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "* If left blank, no files will be modified - only the result window will be popul" +
    "ated";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "MS Client ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(385, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "MS Client Secret:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(771, 357);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(54, 13);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Get Info...";
            this.linkLabel1.Click += new System.EventHandler(this.linkLabel1_Click);
            // 
            // _txtClientSecret
            // 
            this._txtClientSecret.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Translator.Properties.Settings.Default, "MSClientSecret", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this._txtClientSecret.Location = new System.Drawing.Point(480, 352);
            this._txtClientSecret.Name = "_txtClientSecret";
            this._txtClientSecret.Size = new System.Drawing.Size(256, 20);
            this._txtClientSecret.TabIndex = 15;
            this._txtClientSecret.Text = global::Translator.Properties.Settings.Default.MSClientSecret;
            // 
            // _txtClientID
            // 
            this._txtClientID.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Translator.Properties.Settings.Default, "MSClientID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this._txtClientID.Location = new System.Drawing.Point(90, 352);
            this._txtClientID.Name = "_txtClientID";
            this._txtClientID.Size = new System.Drawing.Size(256, 20);
            this._txtClientID.TabIndex = 14;
            this._txtClientID.Text = global::Translator.Properties.Settings.Default.MSClientID;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 732);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this._txtClientSecret);
            this.Controls.Add(this._txtClientID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._txtResult);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this._txtResPath);
            this.Controls.Add(this._txtEnglish);
            this.Controls.Add(this._txtResID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._lstLanguages);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox _lstLanguages;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _txtResID;
        private System.Windows.Forms.TextBox _txtEnglish;
        private System.Windows.Forms.TextBox _txtResPath;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox _txtResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox _txtClientID;
        private System.Windows.Forms.TextBox _txtClientSecret;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

