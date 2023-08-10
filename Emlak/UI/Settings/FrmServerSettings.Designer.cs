namespace Emlak.UI.Settings
{
    partial class FrmServerSettings
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
            this.components = new System.ComponentModel.Container();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConnectionCheck = new System.Windows.Forms.Button();
            this.btnSaveAndExit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnAttach = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.comboBoxDbs = new System.Windows.Forms.ComboBox();
            this.btnDetachDb = new System.Windows.Forms.Button();
            this.txtConnectionString = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(89, 10);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(126, 20);
            this.txtServer.TabIndex = 4;
            this.txtServer.Text = ".\\sqlexpress";
            this.toolTip1.SetToolTip(this.txtServer, "Sunucuya bağlanmak için \"ipadres\\sqlexpress\" yazın.");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Veritabanı";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(89, 68);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(126, 20);
            this.txtUser.TabIndex = 6;
            this.txtUser.Text = "sa";
            this.toolTip1.SetToolTip(this.txtUser, "Veritabanı sistemi kullanıcı adı. Varsayılan sa");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kullanıcı Adı";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(89, 97);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(126, 20);
            this.txtPass.TabIndex = 7;
            this.txtPass.Text = "123";
            this.toolTip1.SetToolTip(this.txtPass, "Veritabanı sistemi şifre. Varsayılan 123");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Şifre";
            // 
            // btnConnectionCheck
            // 
            this.btnConnectionCheck.Location = new System.Drawing.Point(247, 9);
            this.btnConnectionCheck.Name = "btnConnectionCheck";
            this.btnConnectionCheck.Size = new System.Drawing.Size(165, 23);
            this.btnConnectionCheck.TabIndex = 8;
            this.btnConnectionCheck.Text = "Bağlantı Kontrolü Yap";
            this.btnConnectionCheck.UseVisualStyleBackColor = true;
            this.btnConnectionCheck.Click += new System.EventHandler(this.btnConnectionCheck_Click);
            // 
            // btnSaveAndExit
            // 
            this.btnSaveAndExit.Location = new System.Drawing.Point(247, 96);
            this.btnSaveAndExit.Name = "btnSaveAndExit";
            this.btnSaveAndExit.Size = new System.Drawing.Size(165, 23);
            this.btnSaveAndExit.TabIndex = 9;
            this.btnSaveAndExit.Text = "Kaydet ve Çık";
            this.btnSaveAndExit.UseVisualStyleBackColor = true;
            this.btnSaveAndExit.Click += new System.EventHandler(this.btnSaveAndExit_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ShowAlways = true;
            // 
            // btnAttach
            // 
            this.btnAttach.Location = new System.Drawing.Point(247, 38);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(165, 23);
            this.btnAttach.TabIndex = 10;
            this.btnAttach.Text = "Veritabanı Bağla";
            this.toolTip1.SetToolTip(this.btnAttach, "Dikkat uygulamayı yönetici olarak çalıştırın!\r\nData klasörü güvenlik ayarlarında " +
        "yazma izinlerini kontrol edin.");
            this.btnAttach.UseVisualStyleBackColor = true;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "mdf";
            this.openFileDialog1.ShowHelp = true;
            this.openFileDialog1.ShowReadOnly = true;
            this.openFileDialog1.Title = "Veritabanını Seç ve Bağla";
            // 
            // comboBoxDbs
            // 
            this.comboBoxDbs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDbs.FormattingEnabled = true;
            this.comboBoxDbs.Location = new System.Drawing.Point(89, 39);
            this.comboBoxDbs.Name = "comboBoxDbs";
            this.comboBoxDbs.Size = new System.Drawing.Size(126, 21);
            this.comboBoxDbs.TabIndex = 5;
            // 
            // btnDetachDb
            // 
            this.btnDetachDb.Location = new System.Drawing.Point(247, 67);
            this.btnDetachDb.Name = "btnDetachDb";
            this.btnDetachDb.Size = new System.Drawing.Size(165, 23);
            this.btnDetachDb.TabIndex = 10;
            this.btnDetachDb.Text = "Veritabanı Bağlantısını Kes";
            this.btnDetachDb.UseVisualStyleBackColor = true;
            this.btnDetachDb.Click += new System.EventHandler(this.btnDetachDb_Click);
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Location = new System.Drawing.Point(12, 125);
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.ReadOnly = true;
            this.txtConnectionString.Size = new System.Drawing.Size(400, 75);
            this.txtConnectionString.TabIndex = 11;
            this.txtConnectionString.Text = "";
            // 
            // FrmServerSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 212);
            this.Controls.Add(this.txtConnectionString);
            this.Controls.Add(this.comboBoxDbs);
            this.Controls.Add(this.btnDetachDb);
            this.Controls.Add(this.btnAttach);
            this.Controls.Add(this.btnSaveAndExit);
            this.Controls.Add(this.btnConnectionCheck);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtServer);
            this.Name = "FrmServerSettings";
            this.Text = "Sunucu Ayarları";
            this.Load += new System.EventHandler(this.FrmServerSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConnectionCheck;
        private System.Windows.Forms.Button btnSaveAndExit;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox comboBoxDbs;
        private System.Windows.Forms.Button btnDetachDb;
        private System.Windows.Forms.RichTextBox txtConnectionString;
    }
}