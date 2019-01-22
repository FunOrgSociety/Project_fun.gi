namespace WindowsFormsApp2
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.LogoutLabel = new System.Windows.Forms.LinkLabel();
            this.savjetButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pretragaButton = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(201, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(116, 55);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 32;
            this.pictureBox3.TabStop = false;
            // 
            // LogoutLabel
            // 
            this.LogoutLabel.AutoSize = true;
            this.LogoutLabel.LinkColor = System.Drawing.Color.DarkRed;
            this.LogoutLabel.Location = new System.Drawing.Point(427, 451);
            this.LogoutLabel.Name = "LogoutLabel";
            this.LogoutLabel.Size = new System.Drawing.Size(63, 17);
            this.LogoutLabel.TabIndex = 31;
            this.LogoutLabel.TabStop = true;
            this.LogoutLabel.Text = "Log Out ";
            this.LogoutLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLabel_LinkClicked);
            // 
            // savjetButton
            // 
            this.savjetButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.savjetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savjetButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savjetButton.Location = new System.Drawing.Point(188, 282);
            this.savjetButton.Name = "savjetButton";
            this.savjetButton.Size = new System.Drawing.Size(155, 59);
            this.savjetButton.TabIndex = 29;
            this.savjetButton.Text = "Savjeti";
            this.savjetButton.UseVisualStyleBackColor = true;
            this.savjetButton.Click += new System.EventHandler(this.savjetButton_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(188, 217);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(155, 59);
            this.button5.TabIndex = 28;
            this.button5.Text = "Kada i gdje brati";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.kadaButton_Click);
            // 
            // pretragaButton
            // 
            this.pretragaButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.pretragaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pretragaButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pretragaButton.Location = new System.Drawing.Point(188, 152);
            this.pretragaButton.Name = "pretragaButton";
            this.pretragaButton.Size = new System.Drawing.Size(155, 59);
            this.pretragaButton.TabIndex = 27;
            this.pretragaButton.Text = "Pretraga po karakteristikama";
            this.pretragaButton.UseVisualStyleBackColor = true;
            this.pretragaButton.Click += new System.EventHandler(this.pretragaButton_Click_1);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(20, 392);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(98, 76);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 26;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(79, 70);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 102);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 25;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(337, 327);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(122, 82);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 30;
            this.pictureBox6.TabStop = false;
            // 
            // HomeForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(494, 479);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.LogoutLabel);
            this.Controls.Add(this.savjetButton);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pretragaButton);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomeForm";
            this.Text = "fun.gi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.LinkLabel LogoutLabel;
        private System.Windows.Forms.Button savjetButton;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button pretragaButton;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}