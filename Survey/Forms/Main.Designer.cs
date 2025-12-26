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
            this.SuspendLayout();
            // 
            // btn_toTestMng
            // 
            this.btn_toTestMng.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_toTestMng.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_toTestMng.Location = new System.Drawing.Point(12, 511);
            this.btn_toTestMng.Name = "btn_toTestMng";
            this.btn_toTestMng.Size = new System.Drawing.Size(186, 36);
            this.btn_toTestMng.TabIndex = 0;
            this.btn_toTestMng.Text = "Test Management  📝";
            this.btn_toTestMng.UseVisualStyleBackColor = true;
            this.btn_toTestMng.Click += new System.EventHandler(this.btn_toTestMng_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 559);
            this.Controls.Add(this.btn_toTestMng);
            this.Name = "Main";
            this.Text = "Survey";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_toTestMng;
    }
}

