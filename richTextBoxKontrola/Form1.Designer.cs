namespace richTextBoxKontrola
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
            this.citajBtn = new System.Windows.Forms.Button();
            this.brisiBtn = new System.Windows.Forms.Button();
            this.Textb = new System.Windows.Forms.RichTextBox();
            this.spremiBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // citajBtn
            // 
            this.citajBtn.Location = new System.Drawing.Point(34, 33);
            this.citajBtn.Name = "citajBtn";
            this.citajBtn.Size = new System.Drawing.Size(75, 23);
            this.citajBtn.TabIndex = 0;
            this.citajBtn.Text = "Citaj";
            this.citajBtn.UseVisualStyleBackColor = true;
            this.citajBtn.Click += new System.EventHandler(this.citajBtn_Click);
            // 
            // brisiBtn
            // 
            this.brisiBtn.Location = new System.Drawing.Point(204, 33);
            this.brisiBtn.Name = "brisiBtn";
            this.brisiBtn.Size = new System.Drawing.Size(75, 23);
            this.brisiBtn.TabIndex = 1;
            this.brisiBtn.Text = "Brisi";
            this.brisiBtn.UseVisualStyleBackColor = true;
            this.brisiBtn.Click += new System.EventHandler(this.brisiBtn_Click);
            // 
            // Textb
            // 
            this.Textb.Location = new System.Drawing.Point(34, 80);
            this.Textb.Name = "Textb";
            this.Textb.Size = new System.Drawing.Size(245, 161);
            this.Textb.TabIndex = 2;
            this.Textb.Text = "";
            // 
            // spremiBtn
            // 
            this.spremiBtn.Location = new System.Drawing.Point(54, 261);
            this.spremiBtn.Name = "spremiBtn";
            this.spremiBtn.Size = new System.Drawing.Size(75, 23);
            this.spremiBtn.TabIndex = 3;
            this.spremiBtn.Text = "Spremi";
            this.spremiBtn.UseVisualStyleBackColor = true;
            this.spremiBtn.Click += new System.EventHandler(this.spremiBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 309);
            this.Controls.Add(this.spremiBtn);
            this.Controls.Add(this.Textb);
            this.Controls.Add(this.brisiBtn);
            this.Controls.Add(this.citajBtn);
            this.Name = "Form1";
            this.Text = "Upotreba RichTextBox kontrole";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button citajBtn;
        private System.Windows.Forms.Button brisiBtn;
        private System.Windows.Forms.RichTextBox Textb;
        private System.Windows.Forms.Button spremiBtn;
    }
}

