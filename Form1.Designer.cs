namespace Netease_music_tltle_to_PNG
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
            this.browse_button = new System.Windows.Forms.Button();
            this.lable_save_location = new System.Windows.Forms.Label();
            this.textBox_save_location = new System.Windows.Forms.TextBox();
            this.folderBrowser_save_location = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.status_lable = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.run = new System.Windows.Forms.Button();
            this.background_loop = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // browse_button
            // 
            this.browse_button.Location = new System.Drawing.Point(12, 38);
            this.browse_button.Name = "browse_button";
            this.browse_button.Size = new System.Drawing.Size(75, 23);
            this.browse_button.TabIndex = 0;
            this.browse_button.Text = "浏览";
            this.browse_button.UseVisualStyleBackColor = true;
            this.browse_button.Click += new System.EventHandler(this.browse_button_Click);
            // 
            // lable_save_location
            // 
            this.lable_save_location.AutoSize = true;
            this.lable_save_location.Location = new System.Drawing.Point(12, 15);
            this.lable_save_location.Name = "lable_save_location";
            this.lable_save_location.Size = new System.Drawing.Size(79, 13);
            this.lable_save_location.TabIndex = 1;
            this.lable_save_location.Text = "图片保存路径";
            this.lable_save_location.Click += new System.EventHandler(this.lable_save_location_Click);
            // 
            // textBox_save_location
            // 
            this.textBox_save_location.Location = new System.Drawing.Point(97, 12);
            this.textBox_save_location.Name = "textBox_save_location";
            this.textBox_save_location.Size = new System.Drawing.Size(141, 20);
            this.textBox_save_location.TabIndex = 2;
            this.textBox_save_location.TextChanged += new System.EventHandler(this.textBox_save_location_TextChanged);
            // 
            // folderBrowser_save_location
            // 
            this.folderBrowser_save_location.HelpRequest += new System.EventHandler(this.folderBrowser_save_location_HelpRequest);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 2);
            this.label1.TabIndex = 3;
            // 
            // status_lable
            // 
            this.status_lable.AutoSize = true;
            this.status_lable.Location = new System.Drawing.Point(15, 74);
            this.status_lable.Name = "status_lable";
            this.status_lable.Size = new System.Drawing.Size(61, 13);
            this.status_lable.TabIndex = 4;
            this.status_lable.Text = "运行状态: ";
            this.status_lable.Click += new System.EventHandler(this.status_lable_Click);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(76, 74);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(43, 13);
            this.status.TabIndex = 4;
            this.status.Text = "未捕获";
            this.status.Click += new System.EventHandler(this.status_Click);
            // 
            // run
            // 
            this.run.Location = new System.Drawing.Point(163, 38);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(75, 23);
            this.run.TabIndex = 0;
            this.run.Text = "捕获";
            this.run.UseVisualStyleBackColor = true;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // background_loop
            // 
            this.background_loop.WorkerSupportsCancellation = true;
            this.background_loop.DoWork += new System.ComponentModel.DoWorkEventHandler(this.background_loop_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 99);
            this.Controls.Add(this.status);
            this.Controls.Add(this.status_lable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_save_location);
            this.Controls.Add(this.lable_save_location);
            this.Controls.Add(this.run);
            this.Controls.Add(this.browse_button);
            this.Name = "Form1";
            this.Text = "网易云音乐播放捕获";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browse_button;
        private System.Windows.Forms.Label lable_save_location;
        private System.Windows.Forms.TextBox textBox_save_location;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser_save_location;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label status_lable;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Button run;
        private System.ComponentModel.BackgroundWorker background_loop;
    }
}

