namespace VP_Assignment2
{
    partial class SearchByName
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
            this.button1 = new System.Windows.Forms.Button();
            this.suniv = new System.Windows.Forms.TextBox();
            this.sdept = new System.Windows.Forms.TextBox();
            this.scgpa = new System.Windows.Forms.TextBox();
            this.ssemster = new System.Windows.Forms.TextBox();
            this.sname = new System.Windows.Forms.TextBox();
            this.ssid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.searcName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(366, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 39;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // suniv
            // 
            this.suniv.Location = new System.Drawing.Point(222, 373);
            this.suniv.Multiline = true;
            this.suniv.Name = "suniv";
            this.suniv.ReadOnly = true;
            this.suniv.Size = new System.Drawing.Size(127, 30);
            this.suniv.TabIndex = 38;
            this.suniv.TextChanged += new System.EventHandler(this.suniv_TextChanged);
            // 
            // sdept
            // 
            this.sdept.Location = new System.Drawing.Point(222, 311);
            this.sdept.Multiline = true;
            this.sdept.Name = "sdept";
            this.sdept.ReadOnly = true;
            this.sdept.Size = new System.Drawing.Size(127, 30);
            this.sdept.TabIndex = 37;
            this.sdept.TextChanged += new System.EventHandler(this.sdept_TextChanged);
            // 
            // scgpa
            // 
            this.scgpa.Location = new System.Drawing.Point(222, 262);
            this.scgpa.Multiline = true;
            this.scgpa.Name = "scgpa";
            this.scgpa.ReadOnly = true;
            this.scgpa.Size = new System.Drawing.Size(127, 30);
            this.scgpa.TabIndex = 36;
            this.scgpa.TextChanged += new System.EventHandler(this.scgpa_TextChanged);
            // 
            // ssemster
            // 
            this.ssemster.Location = new System.Drawing.Point(222, 202);
            this.ssemster.Multiline = true;
            this.ssemster.Name = "ssemster";
            this.ssemster.ReadOnly = true;
            this.ssemster.Size = new System.Drawing.Size(127, 30);
            this.ssemster.TabIndex = 35;
            this.ssemster.TextChanged += new System.EventHandler(this.ssemster_TextChanged);
            // 
            // sname
            // 
            this.sname.Location = new System.Drawing.Point(222, 142);
            this.sname.Multiline = true;
            this.sname.Name = "sname";
            this.sname.ReadOnly = true;
            this.sname.Size = new System.Drawing.Size(127, 30);
            this.sname.TabIndex = 34;
            this.sname.TextChanged += new System.EventHandler(this.sname_TextChanged);
            // 
            // ssid
            // 
            this.ssid.Location = new System.Drawing.Point(222, 87);
            this.ssid.Multiline = true;
            this.ssid.Name = "ssid";
            this.ssid.ReadOnly = true;
            this.ssid.Size = new System.Drawing.Size(127, 30);
            this.ssid.TabIndex = 33;
            this.ssid.TextChanged += new System.EventHandler(this.ssid_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(106, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 18);
            this.label6.TabIndex = 32;
            this.label6.Text = "University";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(106, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 18);
            this.label5.TabIndex = 31;
            this.label5.Text = "Department";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(106, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 18);
            this.label4.TabIndex = 30;
            this.label4.Text = "CGPA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(106, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 29;
            this.label3.Text = "semster";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(106, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 18);
            this.label2.TabIndex = 28;
            this.label2.Text = "ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(106, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 18);
            this.label7.TabIndex = 27;
            this.label7.Text = "Name";
            // 
            // searcName
            // 
            this.searcName.Location = new System.Drawing.Point(222, 42);
            this.searcName.Multiline = true;
            this.searcName.Name = "searcName";
            this.searcName.Size = new System.Drawing.Size(127, 30);
            this.searcName.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(86, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "Enter Student Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SearchByName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VP_Assignment2.Properties.Resources._1491356;
            this.ClientSize = new System.Drawing.Size(536, 416);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.suniv);
            this.Controls.Add(this.sdept);
            this.Controls.Add(this.scgpa);
            this.Controls.Add(this.ssemster);
            this.Controls.Add(this.sname);
            this.Controls.Add(this.ssid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.searcName);
            this.Controls.Add(this.label1);
            this.Name = "SearchByName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchByName";
            this.Load += new System.EventHandler(this.SearchByName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox suniv;
        private System.Windows.Forms.TextBox sdept;
        private System.Windows.Forms.TextBox scgpa;
        private System.Windows.Forms.TextBox ssemster;
        private System.Windows.Forms.TextBox sname;
        private System.Windows.Forms.TextBox ssid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox searcName;
        private System.Windows.Forms.Label label1;

    }
}