namespace AutoAction
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tbX = new System.Windows.Forms.TextBox();
            this.btClick = new System.Windows.Forms.Button();
            this.tbY = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Position:";
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(12, 37);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(75, 20);
            this.tbX.TabIndex = 1;
            // 
            // btClick
            // 
            this.btClick.Location = new System.Drawing.Point(12, 63);
            this.btClick.Name = "btClick";
            this.btClick.Size = new System.Drawing.Size(156, 23);
            this.btClick.TabIndex = 2;
            this.btClick.Text = "Auto Click";
            this.btClick.UseVisualStyleBackColor = true;
            this.btClick.Click += new System.EventHandler(this.btClick_Click);
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(93, 37);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(75, 20);
            this.tbY.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 104);
            this.Controls.Add(this.tbY);
            this.Controls.Add(this.btClick);
            this.Controls.Add(this.tbX);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.Button btClick;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.Timer timer1;
    }
}

