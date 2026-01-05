namespace Survey
{
    partial class Main
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
            this.btn_toTestMng = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pn_Login = new System.Windows.Forms.Panel();
            this.btn_logIn = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_userName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_MyTests = new System.Windows.Forms.Button();
            this.btn_logOut = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pn_Login.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_toTestMng
            // 
            this.btn_toTestMng.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_toTestMng.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_toTestMng.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_toTestMng.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_toTestMng.Image = global::Survey.Properties.Resources.Custom_Icon_Design_Mono_General_2_Edit_64;
            this.btn_toTestMng.Location = new System.Drawing.Point(3, 3);
            this.btn_toTestMng.Name = "btn_toTestMng";
            this.btn_toTestMng.Size = new System.Drawing.Size(330, 78);
            this.btn_toTestMng.TabIndex = 0;
            this.btn_toTestMng.Text = "Test Management ";
            this.btn_toTestMng.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_toTestMng.UseVisualStyleBackColor = true;
            this.btn_toTestMng.Visible = false;
            this.btn_toTestMng.Click += new System.EventHandler(this.btn_toTestMng_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Survey.Properties.Resources.man_3653346_1280;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(609, 404);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pn_Login
            // 
            this.pn_Login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_Login.Controls.Add(this.btn_logIn);
            this.pn_Login.Controls.Add(this.txt_password);
            this.pn_Login.Controls.Add(this.txt_userName);
            this.pn_Login.Controls.Add(this.label3);
            this.pn_Login.Controls.Add(this.label2);
            this.pn_Login.Controls.Add(this.label1);
            this.pn_Login.Location = new System.Drawing.Point(669, 158);
            this.pn_Login.Name = "pn_Login";
            this.pn_Login.Size = new System.Drawing.Size(272, 257);
            this.pn_Login.TabIndex = 2;
            // 
            // btn_logIn
            // 
            this.btn_logIn.Location = new System.Drawing.Point(109, 212);
            this.btn_logIn.Name = "btn_logIn";
            this.btn_logIn.Size = new System.Drawing.Size(75, 23);
            this.btn_logIn.TabIndex = 5;
            this.btn_logIn.Text = "Log in";
            this.btn_logIn.UseVisualStyleBackColor = true;
            this.btn_logIn.Click += new System.EventHandler(this.btn_logIn_Click);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(54, 155);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(169, 20);
            this.txt_password.TabIndex = 4;
            // 
            // txt_userName
            // 
            this.txt_userName.Location = new System.Drawing.Point(54, 106);
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Size = new System.Drawing.Size(169, 20);
            this.txt_userName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(104, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Log in";
            // 
            // btn_MyTests
            // 
            this.btn_MyTests.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_MyTests.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_MyTests.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MyTests.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_MyTests.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_MyTests.Location = new System.Drawing.Point(3, 87);
            this.btn_MyTests.Name = "btn_MyTests";
            this.btn_MyTests.Size = new System.Drawing.Size(330, 79);
            this.btn_MyTests.TabIndex = 3;
            this.btn_MyTests.Text = "My Tests";
            this.btn_MyTests.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_MyTests.UseVisualStyleBackColor = true;
            this.btn_MyTests.Visible = false;
            // 
            // btn_logOut
            // 
            this.btn_logOut.Location = new System.Drawing.Point(896, 524);
            this.btn_logOut.Name = "btn_logOut";
            this.btn_logOut.Size = new System.Drawing.Size(75, 23);
            this.btn_logOut.TabIndex = 4;
            this.btn_logOut.Text = "Log Out";
            this.btn_logOut.UseVisualStyleBackColor = true;
            this.btn_logOut.Visible = false;
            this.btn_logOut.Click += new System.EventHandler(this.btn_logOut_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_toTestMng);
            this.flowLayoutPanel1.Controls.Add(this.btn_MyTests);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(633, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(338, 173);
            this.flowLayoutPanel1.TabIndex = 5;
            this.flowLayoutPanel1.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 559);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btn_logOut);
            this.Controls.Add(this.pn_Login);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Main";
            this.Text = "Survey";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pn_Login.ResumeLayout(false);
            this.pn_Login.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_toTestMng;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pn_Login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_userName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_logIn;
        private System.Windows.Forms.Button btn_MyTests;
        private System.Windows.Forms.Button btn_logOut;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

