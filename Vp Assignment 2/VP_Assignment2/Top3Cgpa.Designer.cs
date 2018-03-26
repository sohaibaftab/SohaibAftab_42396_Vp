namespace VP_Assignment2
{
    partial class Top3Cgpa
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
            this.top1 = new System.Windows.Forms.TextBox();
            this.top2 = new System.Windows.Forms.TextBox();
            this.top3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 71);
            this.button1.TabIndex = 0;
            this.button1.Text = "Click Here To Know Top 3 Cgpa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // top1
            // 
            this.top1.Location = new System.Drawing.Point(143, 152);
            this.top1.Multiline = true;
            this.top1.Name = "top1";
            this.top1.Size = new System.Drawing.Size(115, 32);
            this.top1.TabIndex = 1;
            // 
            // top2
            // 
            this.top2.Location = new System.Drawing.Point(143, 200);
            this.top2.Multiline = true;
            this.top2.Name = "top2";
            this.top2.Size = new System.Drawing.Size(115, 32);
            this.top2.TabIndex = 2;
            // 
            // top3
            // 
            this.top3.Location = new System.Drawing.Point(143, 254);
            this.top3.Multiline = true;
            this.top3.Name = "top3";
            this.top3.Size = new System.Drawing.Size(115, 32);
            this.top3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Top2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Top1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Top3";
            // 
            // Top3Cgpa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 349);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.top3);
            this.Controls.Add(this.top2);
            this.Controls.Add(this.top1);
            this.Controls.Add(this.button1);
            this.Name = "Top3Cgpa";
            this.Text = "Top3Cgpa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox top1;
        private System.Windows.Forms.TextBox top2;
        private System.Windows.Forms.TextBox top3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}