using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Netease_music_tltle_to_PNG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;

        }

        private void lable_save_location_Click(object sender, EventArgs e)
        {

        }

        private void folderBrowser_save_location_HelpRequest(object sender, EventArgs e)
        {

        }

        private void textBox_save_location_TextChanged(object sender, EventArgs e)
        {

        }

        private void browse_button_Click(object sender, EventArgs e)
        {
            folderBrowser_save_location.Description = "请选择目前播放歌曲信息的存放路径：";
            //指定folder根=桌面
            folderBrowser_save_location.RootFolder = Environment.SpecialFolder.Desktop;
            //是否添加新建文件夹的按钮
            folderBrowser_save_location.ShowNewFolderButton = true;

            if (folderBrowser_save_location.ShowDialog() == DialogResult.OK)
            {
                textBox_save_location.Text = folderBrowser_save_location.SelectedPath;
            }
        }

        private void status_lable_Click(object sender, EventArgs e)
        {

        }
        private void status_Click(object sender, EventArgs e)
        {

        }
        private void run_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBox_save_location.Text))
            {
                MessageBox.Show("路径为空", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else
            {
                browse_button.Enabled = !browse_button.Enabled;
                textBox_save_location.Enabled = !textBox_save_location.Enabled;


                if (!browse_button.Enabled)
                {
                    background_loop.RunWorkerAsync();
                }
                else
                {
                    background_loop.CancelAsync();
                    this.status.Text = "未捕获";
                }
            }
        }

        private void background_loop_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {

                var running = !browse_button.Enabled;
                var title = "";

                if (background_loop.CancellationPending)
                {
                    break;
                }

                if (running) {
                    
                    status.Text = "正在捕获网易云音乐进程";
                    var info = System.Diagnostics.Process.GetProcessesByName("cloudmusic");
                    if (info != null)
                    {
                        foreach (var process in info)
                        {
                            status.Text = "成功捕获网易云音乐进程";
                            title = process.MainWindowTitle;
                        }

                        var file_path = textBox_save_location.Text + "\\song_info.txt";
                        if (!System.IO.File.Exists(file_path))
                        {
                            System.IO.FileStream stream = System.IO.File.Create(file_path);
                            stream.Close();
                            stream.Dispose();
                        }
                        using (System.IO.StreamWriter writer = new System.IO.StreamWriter(file_path, false))
                        {
                            writer.WriteLine(title);
                        }

                        System.Threading.Thread.Sleep(2000);
                    }
                    else
                    {
                        status.Text = "未捕获 - 没有找到网易云音乐进程";
                        browse_button.Enabled = !browse_button.Enabled;
                        textBox_save_location.Enabled = !textBox_save_location.Enabled;
                        break;
                    }

                }


            }
        }
    }
}
