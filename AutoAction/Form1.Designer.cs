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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.chkShutdown = new System.Windows.Forms.CheckBox();
            this.btClose = new System.Windows.Forms.Button();
            this.btBuild = new System.Windows.Forms.Button();
            this.chkHide = new System.Windows.Forms.CheckBox();
            this.btNew = new System.Windows.Forms.Button();
            this.btRun = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btLoad = new System.Windows.Forms.Button();
            this.tbScript = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkHideApp = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(13, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Position:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.splitContainer1.Panel1.BackgroundImage = global::AutoAction.Properties.Resources.Free_Blurred_Backgrounds;
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel1.Controls.Add(this.chkHideApp);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.chkShutdown);
            this.splitContainer1.Panel1.Controls.Add(this.btClose);
            this.splitContainer1.Panel1.Controls.Add(this.btBuild);
            this.splitContainer1.Panel1.Controls.Add(this.chkHide);
            this.splitContainer1.Panel1.Controls.Add(this.btNew);
            this.splitContainer1.Panel1.Controls.Add(this.btRun);
            this.splitContainer1.Panel1.Controls.Add(this.btSave);
            this.splitContainer1.Panel1.Controls.Add(this.btLoad);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_Panel1_MouseDown);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tbScript);
            this.splitContainer1.Size = new System.Drawing.Size(849, 457);
            this.splitContainer1.SplitterDistance = 89;
            this.splitContainer1.TabIndex = 5;
            // 
            // chkShutdown
            // 
            this.chkShutdown.AutoSize = true;
            this.chkShutdown.BackColor = System.Drawing.Color.Transparent;
            this.chkShutdown.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkShutdown.Location = new System.Drawing.Point(170, 69);
            this.chkShutdown.Name = "chkShutdown";
            this.chkShutdown.Size = new System.Drawing.Size(139, 17);
            this.chkShutdown.TabIndex = 11;
            this.chkShutdown.Text = "Exit app when complete";
            this.chkShutdown.UseVisualStyleBackColor = false;
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.Firebrick;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btClose.Location = new System.Drawing.Point(800, 0);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(46, 23);
            this.btClose.TabIndex = 10;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btBuild
            // 
            this.btBuild.BackColor = System.Drawing.Color.DarkBlue;
            this.btBuild.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btBuild.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btBuild.Location = new System.Drawing.Point(703, 0);
            this.btBuild.Name = "btBuild";
            this.btBuild.Size = new System.Drawing.Size(93, 23);
            this.btBuild.TabIndex = 9;
            this.btBuild.Text = "Build to App";
            this.btBuild.UseVisualStyleBackColor = false;
            this.btBuild.Click += new System.EventHandler(this.btBuild_Click);
            // 
            // chkHide
            // 
            this.chkHide.AutoSize = true;
            this.chkHide.BackColor = System.Drawing.Color.Transparent;
            this.chkHide.Checked = true;
            this.chkHide.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHide.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkHide.Location = new System.Drawing.Point(13, 70);
            this.chkHide.Name = "chkHide";
            this.chkHide.Size = new System.Drawing.Size(75, 17);
            this.chkHide.TabIndex = 8;
            this.chkHide.Text = "Hide CMD";
            this.chkHide.UseVisualStyleBackColor = false;
            // 
            // btNew
            // 
            this.btNew.BackColor = System.Drawing.Color.Crimson;
            this.btNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btNew.Location = new System.Drawing.Point(335, 0);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(93, 23);
            this.btNew.TabIndex = 7;
            this.btNew.Text = "New Script";
            this.btNew.UseVisualStyleBackColor = false;
            this.btNew.Click += new System.EventHandler(this.button1_Click);
            // 
            // btRun
            // 
            this.btRun.BackColor = System.Drawing.Color.LimeGreen;
            this.btRun.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btRun.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btRun.Location = new System.Drawing.Point(611, 0);
            this.btRun.Name = "btRun";
            this.btRun.Size = new System.Drawing.Size(93, 23);
            this.btRun.TabIndex = 6;
            this.btRun.Text = "Run Script";
            this.btRun.UseVisualStyleBackColor = false;
            this.btRun.Click += new System.EventHandler(this.btRun_Click);
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.Gold;
            this.btSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSave.Location = new System.Drawing.Point(519, 0);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(93, 23);
            this.btSave.TabIndex = 5;
            this.btSave.Text = "Save Script";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btLoad
            // 
            this.btLoad.BackColor = System.Drawing.Color.OrangeRed;
            this.btLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btLoad.Location = new System.Drawing.Point(427, 0);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(93, 23);
            this.btLoad.TabIndex = 4;
            this.btLoad.Text = "Load Script";
            this.btLoad.UseVisualStyleBackColor = false;
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // tbScript
            // 
            this.tbScript.AcceptsTab = true;
            this.tbScript.BackColor = System.Drawing.SystemColors.MenuText;
            this.tbScript.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbScript.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbScript.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbScript.ForeColor = System.Drawing.Color.Yellow;
            this.tbScript.Location = new System.Drawing.Point(0, 0);
            this.tbScript.Name = "tbScript";
            this.tbScript.Size = new System.Drawing.Size(849, 364);
            this.tbScript.TabIndex = 0;
            this.tbScript.Text = resources.GetString("tbScript.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(13, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "AutoAction Script Editor 1.1b";
            // 
            // chkHideApp
            // 
            this.chkHideApp.AutoSize = true;
            this.chkHideApp.BackColor = System.Drawing.Color.Transparent;
            this.chkHideApp.Checked = true;
            this.chkHideApp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHideApp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkHideApp.Location = new System.Drawing.Point(94, 70);
            this.chkHideApp.Name = "chkHideApp";
            this.chkHideApp.Size = new System.Drawing.Size(70, 17);
            this.chkHideApp.TabIndex = 13;
            this.chkHideApp.Text = "Hide App";
            this.chkHideApp.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 457);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Auto Action Script";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btRun;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.RichTextBox tbScript;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.CheckBox chkHide;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btBuild;
        private System.Windows.Forms.CheckBox chkShutdown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkHideApp;
    }
}

