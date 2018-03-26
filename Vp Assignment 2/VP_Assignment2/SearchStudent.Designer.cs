namespace VP_Assignment2
{
    partial class SearchStudent
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
            this.searchid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sid = new System.Windows.Forms.TextBox();
            this.sname = new System.Windows.Forms.TextBox();
            this.ssemster = new System.Windows.Forms.TextBox();
            this.scgpa = new System.Windows.Forms.TextBox();
            this.sdept = new System.Windows.Forms.TextBox();
            this.suniv = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Student id";
            // 
            // searchid
            // 
            this.searchid.Location = new System.Drawing.Point(144, 24);
            this.searchid.Multiline = true;
            this.searchid.Name = "searchid";
            this.searchid.Size = new System.Drawing.Size(127, 30);
            this.searchid.TabIndex = 1;
            this.searchid.TextChanged += new System.EventHandler(this.searchid_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "University";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Department";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "CGPA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "semster";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Name";
            // 
            // sid
            // 
            this.sid.Location = new System.Drawing.Point(144, 69);
            this.sid.Multiline = true;
            this.sid.Name = "sid";
            this.sid.Size = new System.Drawing.Size(127, 30);
            this.sid.TabIndex = 18;
            this.sid.TextChanged += new System.EventHandler(this.sid_TextChanged);
            // 
            // sname
            // 
            this.sname.Location = new System.Drawing.Point(144, 124);
            this.sname.Multiline = true;
            this.sname.Name = "sname";
            this.sname.Size = new System.Drawing.Size(127, 30);
            this.sname.TabIndex = 19;
            // 
            // ssemster
            // 
            this.ssemster.Location = new System.Drawing.Point(144, 184);
            this.ssemster.Multiline = true;
            this.ssemster.Name = "ssemster";
            this.ssemster.Size = new System.Drawing.Size(127, 30);
            this.ssemster.TabIndex = 20;
            // 
            // scgpa
            // 
            this.scgpa.Location = new System.Drawing.Point(144, 244);
            this.scgpa.Multiline = true;
            this.scgpa.Name = "scgpa";
            this.scgpa.Size = new System.Drawing.Size(127, 30);
            this.scgpa.TabIndex = 21;
            // 
            // sdept
            // 
            this.sdept.Location = new System.Drawing.Point(144, 293);
            this.sdept.Multiline = true;
            this.sdept.Name = "sdept";
            this.sdept.Size = new System.Drawing.Size(127, 30);
            this.sdept.TabIndex = 22;
            // 
            // suniv
            // 
            this.suniv.Location = new System.Drawing.Point(144, 355);
            this.suniv.Multiline = true;
            this.suniv.Name = "suniv";
            this.suniv.Size = new System.Drawing.Size(127, 30);
            this.suniv.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(315, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 421);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.suniv);
            this.Controls.Add(this.sdept);
            this.Controls.Add(this.scgpa);
            this.Controls.Add(this.ssemster);
            this.Controls.Add(this.sname);
            this.Controls.Add(this.sid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.searchid);
            this.Controls.Add(this.label1);
            this.Name = "SearchStudent";
            this.Text = "SearchStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox sid;
        private System.Windows.Forms.TextBox sname;
        private System.Windows.Forms.TextBox ssemster;
        private System.Windows.Forms.TextBox scgpa;
        private System.Windows.Forms.TextBox sdept;
        private System.Windows.Forms.TextBox suniv;
        private System.Windows.Forms.Button button1;
    }
}