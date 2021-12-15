namespace Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.n1 = new System.Windows.Forms.Button();
            this.n2 = new System.Windows.Forms.Button();
            this.n3 = new System.Windows.Forms.Button();
            this.n4 = new System.Windows.Forms.Button();
            this.n5 = new System.Windows.Forms.Button();
            this.n6 = new System.Windows.Forms.Button();
            this.n7 = new System.Windows.Forms.Button();
            this.n8 = new System.Windows.Forms.Button();
            this.n9 = new System.Windows.Forms.Button();
            this.n0 = new System.Windows.Forms.Button();
            this.bc = new System.Windows.Forms.Button();
            this.bad = new System.Windows.Forms.Button();
            this.bsub = new System.Windows.Forms.Button();
            this.bmul = new System.Windows.Forms.Button();
            this.bdiv = new System.Windows.Forms.Button();
            this.ndot = new System.Windows.Forms.Button();
            this.nequal = new System.Windows.Forms.Button();
            this.currentOperation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(36, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(315, 49);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // n1
            // 
            this.n1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.n1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("n1.BackgroundImage")));
            this.n1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.n1.ForeColor = System.Drawing.Color.Cornsilk;
            this.n1.Location = new System.Drawing.Point(36, 120);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(58, 61);
            this.n1.TabIndex = 1;
            this.n1.Text = "1";
            this.n1.UseVisualStyleBackColor = false;
            this.n1.Click += new System.EventHandler(this.n1_Click);
            // 
            // n2
            // 
            this.n2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.n2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("n2.BackgroundImage")));
            this.n2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.n2.ForeColor = System.Drawing.Color.Cornsilk;
            this.n2.Location = new System.Drawing.Point(100, 119);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(58, 61);
            this.n2.TabIndex = 1;
            this.n2.Text = "2";
            this.n2.UseVisualStyleBackColor = false;
            this.n2.Click += new System.EventHandler(this.n2_Click);
            // 
            // n3
            // 
            this.n3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.n3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("n3.BackgroundImage")));
            this.n3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.n3.ForeColor = System.Drawing.Color.Cornsilk;
            this.n3.Location = new System.Drawing.Point(164, 119);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(58, 61);
            this.n3.TabIndex = 1;
            this.n3.Text = "3";
            this.n3.UseVisualStyleBackColor = false;
            this.n3.Click += new System.EventHandler(this.n3_Click);
            // 
            // n4
            // 
            this.n4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.n4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("n4.BackgroundImage")));
            this.n4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.n4.ForeColor = System.Drawing.Color.Cornsilk;
            this.n4.Location = new System.Drawing.Point(36, 187);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(58, 61);
            this.n4.TabIndex = 1;
            this.n4.Text = "4";
            this.n4.UseVisualStyleBackColor = false;
            this.n4.Click += new System.EventHandler(this.n4_Click);
            // 
            // n5
            // 
            this.n5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.n5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("n5.BackgroundImage")));
            this.n5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.n5.ForeColor = System.Drawing.Color.Cornsilk;
            this.n5.Location = new System.Drawing.Point(100, 186);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(58, 61);
            this.n5.TabIndex = 1;
            this.n5.Text = "5";
            this.n5.UseVisualStyleBackColor = false;
            this.n5.Click += new System.EventHandler(this.n5_Click);
            // 
            // n6
            // 
            this.n6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.n6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("n6.BackgroundImage")));
            this.n6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.n6.ForeColor = System.Drawing.Color.Cornsilk;
            this.n6.Location = new System.Drawing.Point(164, 186);
            this.n6.Name = "n6";
            this.n6.Size = new System.Drawing.Size(58, 61);
            this.n6.TabIndex = 1;
            this.n6.Text = "6";
            this.n6.UseVisualStyleBackColor = false;
            this.n6.Click += new System.EventHandler(this.n6_Click);
            // 
            // n7
            // 
            this.n7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.n7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("n7.BackgroundImage")));
            this.n7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.n7.ForeColor = System.Drawing.Color.Cornsilk;
            this.n7.Location = new System.Drawing.Point(36, 254);
            this.n7.Name = "n7";
            this.n7.Size = new System.Drawing.Size(58, 61);
            this.n7.TabIndex = 1;
            this.n7.Text = "7";
            this.n7.UseVisualStyleBackColor = false;
            this.n7.Click += new System.EventHandler(this.n7_Click);
            // 
            // n8
            // 
            this.n8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.n8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("n8.BackgroundImage")));
            this.n8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.n8.ForeColor = System.Drawing.Color.Cornsilk;
            this.n8.Location = new System.Drawing.Point(99, 253);
            this.n8.Name = "n8";
            this.n8.Size = new System.Drawing.Size(58, 61);
            this.n8.TabIndex = 1;
            this.n8.Text = "8";
            this.n8.UseVisualStyleBackColor = false;
            this.n8.Click += new System.EventHandler(this.n8_Click);
            // 
            // n9
            // 
            this.n9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.n9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("n9.BackgroundImage")));
            this.n9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.n9.ForeColor = System.Drawing.Color.Cornsilk;
            this.n9.Location = new System.Drawing.Point(163, 254);
            this.n9.Name = "n9";
            this.n9.Size = new System.Drawing.Size(59, 61);
            this.n9.TabIndex = 1;
            this.n9.Text = "9";
            this.n9.UseVisualStyleBackColor = false;
            this.n9.Click += new System.EventHandler(this.n9_Click);
            // 
            // n0
            // 
            this.n0.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.n0.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("n0.BackgroundImage")));
            this.n0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.n0.ForeColor = System.Drawing.Color.Cornsilk;
            this.n0.Location = new System.Drawing.Point(35, 321);
            this.n0.Name = "n0";
            this.n0.Size = new System.Drawing.Size(122, 61);
            this.n0.TabIndex = 1;
            this.n0.Text = "0";
            this.n0.UseVisualStyleBackColor = false;
            this.n0.Click += new System.EventHandler(this.n0_Click);
            // 
            // bc
            // 
            this.bc.BackgroundImage = global::Calculator.Properties.Resources.stylish_glowing_digital_red_lines_banner_1017_23964;
            this.bc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bc.ForeColor = System.Drawing.Color.Cornsilk;
            this.bc.Location = new System.Drawing.Point(293, 120);
            this.bc.Name = "bc";
            this.bc.Size = new System.Drawing.Size(58, 61);
            this.bc.TabIndex = 2;
            this.bc.Text = "C";
            this.bc.UseVisualStyleBackColor = true;
            this.bc.Click += new System.EventHandler(this.bc_Click);
            // 
            // bad
            // 
            this.bad.BackgroundImage = global::Calculator.Properties.Resources.stylish_glowing_digital_red_lines_banner_1017_23964;
            this.bad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bad.ForeColor = System.Drawing.Color.Cornsilk;
            this.bad.Location = new System.Drawing.Point(228, 119);
            this.bad.Name = "bad";
            this.bad.Size = new System.Drawing.Size(59, 61);
            this.bad.TabIndex = 2;
            this.bad.Text = "+";
            this.bad.UseVisualStyleBackColor = true;
            this.bad.Click += new System.EventHandler(this.bad_Click);
            // 
            // bsub
            // 
            this.bsub.BackgroundImage = global::Calculator.Properties.Resources.stylish_glowing_digital_red_lines_banner_1017_23964;
            this.bsub.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bsub.ForeColor = System.Drawing.Color.Cornsilk;
            this.bsub.Location = new System.Drawing.Point(228, 186);
            this.bsub.Name = "bsub";
            this.bsub.Size = new System.Drawing.Size(59, 61);
            this.bsub.TabIndex = 2;
            this.bsub.Text = "-";
            this.bsub.UseVisualStyleBackColor = true;
            this.bsub.Click += new System.EventHandler(this.bsub_Click);
            // 
            // bmul
            // 
            this.bmul.BackgroundImage = global::Calculator.Properties.Resources.stylish_glowing_digital_red_lines_banner_1017_23964;
            this.bmul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bmul.ForeColor = System.Drawing.Color.Cornsilk;
            this.bmul.Location = new System.Drawing.Point(227, 253);
            this.bmul.Name = "bmul";
            this.bmul.Size = new System.Drawing.Size(59, 61);
            this.bmul.TabIndex = 2;
            this.bmul.Text = "*";
            this.bmul.UseVisualStyleBackColor = true;
            this.bmul.Click += new System.EventHandler(this.bmul_Click);
            // 
            // bdiv
            // 
            this.bdiv.BackgroundImage = global::Calculator.Properties.Resources.stylish_glowing_digital_red_lines_banner_1017_23964;
            this.bdiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bdiv.ForeColor = System.Drawing.Color.Cornsilk;
            this.bdiv.Location = new System.Drawing.Point(227, 320);
            this.bdiv.Name = "bdiv";
            this.bdiv.Size = new System.Drawing.Size(59, 61);
            this.bdiv.TabIndex = 2;
            this.bdiv.Text = "/";
            this.bdiv.UseVisualStyleBackColor = true;
            this.bdiv.Click += new System.EventHandler(this.bdiv_Click);
            // 
            // ndot
            // 
            this.ndot.BackgroundImage = global::Calculator.Properties.Resources.stylish_glowing_digital_red_lines_banner_1017_23964;
            this.ndot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ndot.ForeColor = System.Drawing.Color.Cornsilk;
            this.ndot.Location = new System.Drawing.Point(164, 320);
            this.ndot.Name = "ndot";
            this.ndot.Size = new System.Drawing.Size(58, 61);
            this.ndot.TabIndex = 3;
            this.ndot.Text = ".";
            this.ndot.UseVisualStyleBackColor = true;
            this.ndot.Click += new System.EventHandler(this.ndot_Click);
            // 
            // nequal
            // 
            this.nequal.BackgroundImage = global::Calculator.Properties.Resources.download;
            this.nequal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nequal.ForeColor = System.Drawing.Color.Cornsilk;
            this.nequal.Location = new System.Drawing.Point(292, 187);
            this.nequal.Name = "nequal";
            this.nequal.Size = new System.Drawing.Size(59, 195);
            this.nequal.TabIndex = 4;
            this.nequal.Text = "=";
            this.nequal.UseVisualStyleBackColor = true;
            this.nequal.Click += new System.EventHandler(this.nequal_Click);
            // 
            // currentOperation
            // 
            this.currentOperation.AutoSize = true;
            this.currentOperation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.currentOperation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.currentOperation.ForeColor = System.Drawing.Color.Cornsilk;
            this.currentOperation.Location = new System.Drawing.Point(36, 33);
            this.currentOperation.Name = "currentOperation";
            this.currentOperation.Size = new System.Drawing.Size(2, 33);
            this.currentOperation.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(380, 412);
            this.Controls.Add(this.currentOperation);
            this.Controls.Add(this.nequal);
            this.Controls.Add(this.ndot);
            this.Controls.Add(this.bdiv);
            this.Controls.Add(this.bmul);
            this.Controls.Add(this.bsub);
            this.Controls.Add(this.bad);
            this.Controls.Add(this.bc);
            this.Controls.Add(this.n0);
            this.Controls.Add(this.n9);
            this.Controls.Add(this.n8);
            this.Controls.Add(this.n7);
            this.Controls.Add(this.n6);
            this.Controls.Add(this.n5);
            this.Controls.Add(this.n4);
            this.Controls.Add(this.n3);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Button n1;
        private Button n2;
        private Button n3;
        private Button n4;
        private Button n5;
        private Button n6;
        private Button n7;
        private Button n8;
        private Button n9;
        private Button n0;
        private Button ndot1;
        private Button bc;
        private Button bad;
        private Button bsub;
        private Button bmul;
        private Button bdiv;
        private Button ndot;
        private Button nequal;
        private Label currentOperation;
    }
}