namespace Vp_semester_Project
{
    partial class Admin
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
            this.Question = new System.Windows.Forms.RichTextBox();
            this.A = new System.Windows.Forms.TextBox();
            this.B = new System.Windows.Forms.TextBox();
            this.C = new System.Windows.Forms.TextBox();
            this.D = new System.Windows.Forms.TextBox();
            this.Answer = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Question
            // 
            this.Question.Location = new System.Drawing.Point(163, 37);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(318, 191);
            this.Question.TabIndex = 0;
            this.Question.Text = "";
            // 
            // A
            // 
            this.A.Location = new System.Drawing.Point(163, 263);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(100, 20);
            this.A.TabIndex = 1;
            // 
            // B
            // 
            this.B.Location = new System.Drawing.Point(163, 307);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(100, 20);
            this.B.TabIndex = 2;
            // 
            // C
            // 
            this.C.Location = new System.Drawing.Point(163, 362);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(100, 20);
            this.C.TabIndex = 3;
            // 
            // D
            // 
            this.D.Location = new System.Drawing.Point(163, 399);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(100, 20);
            this.D.TabIndex = 4;
            // 
            // Answer
            // 
            this.Answer.Location = new System.Drawing.Point(163, 479);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(100, 20);
            this.Answer.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(426, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 538);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.D);
            this.Controls.Add(this.C);
            this.Controls.Add(this.B);
            this.Controls.Add(this.A);
            this.Controls.Add(this.Question);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Question;
        private System.Windows.Forms.TextBox A;
        private System.Windows.Forms.TextBox B;
        private System.Windows.Forms.TextBox C;
        private System.Windows.Forms.TextBox D;
        private System.Windows.Forms.TextBox Answer;
        private System.Windows.Forms.Button button1;
    }
}