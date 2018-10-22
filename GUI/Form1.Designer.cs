namespace GUI
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
            this.message = new System.Windows.Forms.TextBox();
            this.cipher = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._128 = new System.Windows.Forms.RadioButton();
            this._192 = new System.Windows.Forms.RadioButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this._256 = new System.Windows.Forms.RadioButton();
            this.PasswordFile = new System.Windows.Forms.Button();
            this.MessageFile = new System.Windows.Forms.Button();
            this.Invcipher = new System.Windows.Forms.TextBox();
            this.Decipher = new System.Windows.Forms.Label();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picLable = new System.Windows.Forms.Label();
            this.hide = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // message
            // 
            this.message.Location = new System.Drawing.Point(99, 12);
            this.message.MaxLength = 100000;
            this.message.Multiline = true;
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(258, 78);
            this.message.TabIndex = 0;
            this.message.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cipher
            // 
            this.cipher.Location = new System.Drawing.Point(74, 412);
            this.cipher.MaxLength = 100000;
            this.cipher.Multiline = true;
            this.cipher.Name = "cipher";
            this.cipher.Size = new System.Drawing.Size(165, 79);
            this.cipher.TabIndex = 1;
            this.cipher.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(319, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Decrypt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(74, 383);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Encrypt";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(99, 133);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(270, 20);
            this.password.TabIndex = 4;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Message";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cipher";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // _128
            // 
            this._128.AutoSize = true;
            this._128.Location = new System.Drawing.Point(18, 13);
            this._128.Name = "_128";
            this._128.Size = new System.Drawing.Size(43, 17);
            this._128.TabIndex = 8;
            this._128.TabStop = true;
            this._128.Text = "128";
            this._128.UseVisualStyleBackColor = true;
            this._128.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // _192
            // 
            this._192.AutoSize = true;
            this._192.Location = new System.Drawing.Point(81, 13);
            this._192.Name = "_192";
            this._192.Size = new System.Drawing.Size(43, 17);
            this._192.TabIndex = 9;
            this._192.TabStop = true;
            this._192.Text = "192";
            this._192.UseVisualStyleBackColor = true;
            this._192.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // _256
            // 
            this._256.AutoSize = true;
            this._256.Location = new System.Drawing.Point(130, 13);
            this._256.Name = "_256";
            this._256.Size = new System.Drawing.Size(43, 17);
            this._256.TabIndex = 10;
            this._256.TabStop = true;
            this._256.Text = "256";
            this._256.UseVisualStyleBackColor = true;
            // 
            // PasswordFile
            // 
            this.PasswordFile.Location = new System.Drawing.Point(386, 133);
            this.PasswordFile.Name = "PasswordFile";
            this.PasswordFile.Size = new System.Drawing.Size(75, 23);
            this.PasswordFile.TabIndex = 11;
            this.PasswordFile.Text = "Browse";
            this.PasswordFile.UseVisualStyleBackColor = true;
            this.PasswordFile.Click += new System.EventHandler(this.PasswordFile_Click);
            // 
            // MessageFile
            // 
            this.MessageFile.Location = new System.Drawing.Point(386, 10);
            this.MessageFile.Name = "MessageFile";
            this.MessageFile.Size = new System.Drawing.Size(75, 23);
            this.MessageFile.TabIndex = 12;
            this.MessageFile.Text = "Browse";
            this.MessageFile.UseVisualStyleBackColor = true;
            this.MessageFile.Click += new System.EventHandler(this.MessageFile_Click);
            // 
            // Invcipher
            // 
            this.Invcipher.Location = new System.Drawing.Point(319, 412);
            this.Invcipher.Multiline = true;
            this.Invcipher.Name = "Invcipher";
            this.Invcipher.Size = new System.Drawing.Size(156, 79);
            this.Invcipher.TabIndex = 13;
            this.Invcipher.TextChanged += new System.EventHandler(this.Invcipher_TextChanged);
            // 
            // Decipher
            // 
            this.Decipher.AutoSize = true;
            this.Decipher.Location = new System.Drawing.Point(264, 415);
            this.Decipher.Name = "Decipher";
            this.Decipher.Size = new System.Drawing.Size(49, 13);
            this.Decipher.TabIndex = 14;
            this.Decipher.Text = "Decipher";
            this.Decipher.Click += new System.EventHandler(this.Decipher_Click);
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imagePictureBox.Location = new System.Drawing.Point(99, 159);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(270, 205);
            this.imagePictureBox.TabIndex = 15;
            this.imagePictureBox.TabStop = false;
            this.imagePictureBox.Click += new System.EventHandler(this.imagePictureBox_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._128);
            this.groupBox1.Controls.Add(this._192);
            this.groupBox1.Controls.Add(this._256);
            this.groupBox1.Location = new System.Drawing.Point(122, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 36);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Key Size";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // picLable
            // 
            this.picLable.AutoSize = true;
            this.picLable.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picLable.Location = new System.Drawing.Point(109, 246);
            this.picLable.Name = "picLable";
            this.picLable.Size = new System.Drawing.Size(248, 26);
            this.picLable.TabIndex = 17;
            this.picLable.Text = "Choose picture to be password ";
            this.picLable.Click += new System.EventHandler(this.label4_Click);
            // 
            // hide
            // 
            this.hide.Location = new System.Drawing.Point(562, 292);
            this.hide.Name = "hide";
            this.hide.Size = new System.Drawing.Size(75, 23);
            this.hide.TabIndex = 18;
            this.hide.Text = "Hide";
            this.hide.UseVisualStyleBackColor = true;
            this.hide.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(655, 292);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 19;
            this.button4.Text = "Unhide";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(524, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 221);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(634, 333);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 47);
            this.textBox2.TabIndex = 22;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(551, 29);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 24;
            this.button3.Text = "Open";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(679, 386);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 25;
            this.button5.Text = "Decrypt";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(524, 415);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 76);
            this.textBox1.TabIndex = 26;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(645, 29);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 27;
            this.button6.Text = "Save";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 517);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.hide);
            this.Controls.Add(this.picLable);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.imagePictureBox);
            this.Controls.Add(this.Decipher);
            this.Controls.Add(this.Invcipher);
            this.Controls.Add(this.MessageFile);
            this.Controls.Add(this.PasswordFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cipher);
            this.Controls.Add(this.message);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "AES Cryptograghy";
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.TextBox cipher;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton _128;
        private System.Windows.Forms.RadioButton _192;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RadioButton _256;
        private System.Windows.Forms.Button PasswordFile;
        private System.Windows.Forms.Button MessageFile;
        private System.Windows.Forms.TextBox Invcipher;
        private System.Windows.Forms.Label Decipher;
        private System.Windows.Forms.PictureBox imagePictureBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label picLable;
        private System.Windows.Forms.Button hide;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button6;
       
    }
}

