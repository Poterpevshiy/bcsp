namespace bcsp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PathArc1TextBox = new System.Windows.Forms.TextBox();
            this.PathArc2TextBox = new System.Windows.Forms.TextBox();
            this.Path1button = new System.Windows.Forms.Button();
            this.Path2button = new System.Windows.Forms.Button();
            this.res_textBox = new System.Windows.Forms.TextBox();
            this.Startbutton = new System.Windows.Forms.Button();
            this.openPath1button = new System.Windows.Forms.Button();
            this.openPath2button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PathArc1TextBox
            // 
            this.PathArc1TextBox.Location = new System.Drawing.Point(173, 30);
            this.PathArc1TextBox.Multiline = true;
            this.PathArc1TextBox.Name = "PathArc1TextBox";
            this.PathArc1TextBox.Size = new System.Drawing.Size(878, 28);
            this.PathArc1TextBox.TabIndex = 4;
            this.PathArc1TextBox.TextChanged += new System.EventHandler(this.PathArc1TextBox_TextChanged);
            // 
            // PathArc2TextBox
            // 
            this.PathArc2TextBox.Location = new System.Drawing.Point(173, 107);
            this.PathArc2TextBox.Multiline = true;
            this.PathArc2TextBox.Name = "PathArc2TextBox";
            this.PathArc2TextBox.Size = new System.Drawing.Size(878, 28);
            this.PathArc2TextBox.TabIndex = 5;
            this.PathArc2TextBox.TextChanged += new System.EventHandler(this.PathArc2TextBox_TextChanged);
            // 
            // Path1button
            // 
            this.Path1button.Location = new System.Drawing.Point(29, 11);
            this.Path1button.Name = "Path1button";
            this.Path1button.Size = new System.Drawing.Size(103, 58);
            this.Path1button.TabIndex = 1;
            this.Path1button.Text = "Select the folder";
            this.Path1button.UseVisualStyleBackColor = true;
            this.Path1button.Click += new System.EventHandler(this.Path1button_Click);
            // 
            // Path2button
            // 
            this.Path2button.Location = new System.Drawing.Point(29, 88);
            this.Path2button.Name = "Path2button";
            this.Path2button.Size = new System.Drawing.Size(103, 58);
            this.Path2button.TabIndex = 2;
            this.Path2button.Text = "Select the folder";
            this.Path2button.UseVisualStyleBackColor = true;
            this.Path2button.Click += new System.EventHandler(this.Path2button_Click);
            // 
            // res_textBox
            // 
            this.res_textBox.Location = new System.Drawing.Point(29, 237);
            this.res_textBox.Multiline = true;
            this.res_textBox.Name = "res_textBox";
            this.res_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.res_textBox.Size = new System.Drawing.Size(1022, 201);
            this.res_textBox.TabIndex = 6;
            // 
            // Startbutton
            // 
            this.Startbutton.Location = new System.Drawing.Point(29, 166);
            this.Startbutton.Name = "Startbutton";
            this.Startbutton.Size = new System.Drawing.Size(103, 58);
            this.Startbutton.TabIndex = 3;
            this.Startbutton.Text = "Start";
            this.Startbutton.UseVisualStyleBackColor = true;
            this.Startbutton.Click += new System.EventHandler(this.Startbutton_Click);
            // 
            // openPath1button
            // 
            this.openPath1button.Font = new System.Drawing.Font("Segoe UI", 3.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.openPath1button.Location = new System.Drawing.Point(131, 11);
            this.openPath1button.Name = "openPath1button";
            this.openPath1button.Size = new System.Drawing.Size(12, 58);
            this.openPath1button.TabIndex = 7;
            this.openPath1button.Text = "O\r\np\r\ne\r\nn";
            this.openPath1button.UseVisualStyleBackColor = true;
            this.openPath1button.Click += new System.EventHandler(this.openPath1button_Click);
            // 
            // openPath2button
            // 
            this.openPath2button.Font = new System.Drawing.Font("Segoe UI", 3.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.openPath2button.Location = new System.Drawing.Point(131, 88);
            this.openPath2button.Name = "openPath2button";
            this.openPath2button.Size = new System.Drawing.Size(12, 58);
            this.openPath2button.TabIndex = 8;
            this.openPath2button.Text = "Open";
            this.openPath2button.UseVisualStyleBackColor = true;
            this.openPath2button.Click += new System.EventHandler(this.openPath2button_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 3.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(131, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(12, 58);
            this.button1.TabIndex = 9;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.openTXTbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.openPath2button);
            this.Controls.Add(this.openPath1button);
            this.Controls.Add(this.Startbutton);
            this.Controls.Add(this.res_textBox);
            this.Controls.Add(this.Path2button);
            this.Controls.Add(this.Path1button);
            this.Controls.Add(this.PathArc2TextBox);
            this.Controls.Add(this.PathArc1TextBox);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Ololo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox PathArc1TextBox;
        private System.Windows.Forms.TextBox PathArc2TextBox;
        private System.Windows.Forms.Button Path1button;
        private System.Windows.Forms.Button Path2button;
        private System.Windows.Forms.Button Startbutton;
        public System.Windows.Forms.TextBox res_textBox;
        private System.Windows.Forms.Button openPath1button;
        private System.Windows.Forms.Button openPath2button;
        private System.Windows.Forms.Button button1;
    }
}

