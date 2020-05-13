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
            this.logBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.catch_speed = new System.Windows.Forms.TrackBar();
            this.label_catch_speed = new System.Windows.Forms.Label();
            this.label_catch_speed_value = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.check_output_as_png = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.catch_speed)).BeginInit();
            this.SuspendLayout();
            // 
            // browse_button
            // 
            this.browse_button.Location = new System.Drawing.Point(147, 46);
            this.browse_button.Name = "browse_button";
            this.browse_button.Size = new System.Drawing.Size(75, 23);
            this.browse_button.TabIndex = 0;
            this.browse_button.Text = "浏览...";
            this.browse_button.UseVisualStyleBackColor = true;
            this.browse_button.Click += new System.EventHandler(this.browse_button_Click);
            // 
            // lable_save_location
            // 
            this.lable_save_location.AutoSize = true;
            this.lable_save_location.Location = new System.Drawing.Point(12, 23);
            this.lable_save_location.Name = "lable_save_location";
            this.lable_save_location.Size = new System.Drawing.Size(61, 13);
            this.lable_save_location.TabIndex = 1;
            this.lable_save_location.Text = "保存路径：";
            this.lable_save_location.Click += new System.EventHandler(this.lable_save_location_Click);
            // 
            // textBox_save_location
            // 
            this.textBox_save_location.Location = new System.Drawing.Point(76, 20);
            this.textBox_save_location.Name = "textBox_save_location";
            this.textBox_save_location.Size = new System.Drawing.Size(146, 20);
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
            this.label1.Location = new System.Drawing.Point(12, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 2);
            this.label1.TabIndex = 3;
            // 
            // status_lable
            // 
            this.status_lable.AutoSize = true;
            this.status_lable.Location = new System.Drawing.Point(15, 345);
            this.status_lable.Name = "status_lable";
            this.status_lable.Size = new System.Drawing.Size(61, 13);
            this.status_lable.TabIndex = 4;
            this.status_lable.Text = "运行状态: ";
            this.status_lable.Click += new System.EventHandler(this.status_lable_Click);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(76, 345);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(43, 13);
            this.status.TabIndex = 4;
            this.status.Text = "未捕获";
            this.status.Click += new System.EventHandler(this.status_Click);
            // 
            // run
            // 
            this.run.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.run.Location = new System.Drawing.Point(253, 14);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(223, 43);
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
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(253, 74);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.logBox.Size = new System.Drawing.Size(223, 289);
            this.logBox.TabIndex = 5;
            this.logBox.TextChanged += new System.EventHandler(this.logBox_TextChanged);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(236, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(2, 348);
            this.label2.TabIndex = 3;
            // 
            // catch_speed
            // 
            this.catch_speed.LargeChange = 500;
            this.catch_speed.Location = new System.Drawing.Point(12, 99);
            this.catch_speed.Maximum = 60000;
            this.catch_speed.Minimum = 500;
            this.catch_speed.Name = "catch_speed";
            this.catch_speed.Size = new System.Drawing.Size(207, 45);
            this.catch_speed.SmallChange = 100;
            this.catch_speed.TabIndex = 6;
            this.catch_speed.TickFrequency = 1000;
            this.catch_speed.Value = 2000;
            this.catch_speed.Scroll += new System.EventHandler(this.catch_speed_Scroll);
            // 
            // label_catch_speed
            // 
            this.label_catch_speed.AutoSize = true;
            this.label_catch_speed.Location = new System.Drawing.Point(12, 77);
            this.label_catch_speed.Name = "label_catch_speed";
            this.label_catch_speed.Size = new System.Drawing.Size(85, 13);
            this.label_catch_speed.TabIndex = 1;
            this.label_catch_speed.Text = "捕获标题间隔：";
            this.label_catch_speed.Click += new System.EventHandler(this.label_catch_speed_Click);
            // 
            // label_catch_speed_value
            // 
            this.label_catch_speed_value.AutoSize = true;
            this.label_catch_speed_value.Location = new System.Drawing.Point(103, 77);
            this.label_catch_speed_value.Name = "label_catch_speed_value";
            this.label_catch_speed_value.Size = new System.Drawing.Size(27, 13);
            this.label_catch_speed_value.TabIndex = 1;
            this.label_catch_speed_value.Text = "N/A";
            this.label_catch_speed_value.Click += new System.EventHandler(this.label_catch_speed_value_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(18, 150);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(204, 132);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "捕获标题间隔提示：\n调整每多少毫秒检查一次曲名是否变化的设置项。\n间隔越短反应延迟越短，相反的将会消耗更多系统资源，有可能导致系统卡顿。\n请按需设置。（默认为2秒" +
    "）";
            // 
            // check_output_as_png
            // 
            this.check_output_as_png.AutoSize = true;
            this.check_output_as_png.Enabled = false;
            this.check_output_as_png.Location = new System.Drawing.Point(18, 289);
            this.check_output_as_png.Name = "check_output_as_png";
            this.check_output_as_png.Size = new System.Drawing.Size(128, 17);
            this.check_output_as_png.TabIndex = 8;
            this.check_output_as_png.Text = "输出为图片(施工中)";
            this.check_output_as_png.UseVisualStyleBackColor = true;
            this.check_output_as_png.CheckedChanged += new System.EventHandler(this.check_output_as_png_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 373);
            this.Controls.Add(this.check_output_as_png);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.catch_speed);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.status);
            this.Controls.Add(this.status_lable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_save_location);
            this.Controls.Add(this.label_catch_speed_value);
            this.Controls.Add(this.label_catch_speed);
            this.Controls.Add(this.lable_save_location);
            this.Controls.Add(this.run);
            this.Controls.Add(this.browse_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "网易云音乐播放捕获";
            ((System.ComponentModel.ISupportInitialize)(this.catch_speed)).EndInit();
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
        private System.Windows.Forms.TextBox logBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar catch_speed;
        private System.Windows.Forms.Label label_catch_speed;
        private System.Windows.Forms.Label label_catch_speed_value;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox check_output_as_png;
    }
}

