namespace WindowsFormApp
{
    partial class form_MyApp
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
            this.btn_hello = new System.Windows.Forms.Button();
            this.lbl_hellomessage = new System.Windows.Forms.Label();
            this.btn_changecolor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_hello
            // 
            this.btn_hello.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hello.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_hello.Location = new System.Drawing.Point(281, 104);
            this.btn_hello.Name = "btn_hello";
            this.btn_hello.Size = new System.Drawing.Size(255, 62);
            this.btn_hello.TabIndex = 1;
            this.btn_hello.Text = "Hello, Click me!";
            this.btn_hello.UseVisualStyleBackColor = true;
            this.btn_hello.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_hellomessage
            // 
            this.lbl_hellomessage.AutoSize = true;
            this.lbl_hellomessage.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hellomessage.Location = new System.Drawing.Point(281, 219);
            this.lbl_hellomessage.Name = "lbl_hellomessage";
            this.lbl_hellomessage.Size = new System.Drawing.Size(0, 25);
            this.lbl_hellomessage.TabIndex = 3;
            this.lbl_hellomessage.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_changecolor
            // 
            this.btn_changecolor.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_changecolor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_changecolor.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_changecolor.Location = new System.Drawing.Point(596, 104);
            this.btn_changecolor.Name = "btn_changecolor";
            this.btn_changecolor.Size = new System.Drawing.Size(255, 62);
            this.btn_changecolor.TabIndex = 4;
            this.btn_changecolor.Text = "Change Color";
            this.btn_changecolor.UseVisualStyleBackColor = false;
            this.btn_changecolor.Click += new System.EventHandler(this.btn_changecolor_Click);
            // 
            // form_MyApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 569);
            this.Controls.Add(this.btn_changecolor);
            this.Controls.Add(this.lbl_hellomessage);
            this.Controls.Add(this.btn_hello);
            this.Name = "form_MyApp";
            this.Text = "MyApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_hello;
        private System.Windows.Forms.Label lbl_hellomessage;
        private System.Windows.Forms.Button btn_changecolor;
    }
}

