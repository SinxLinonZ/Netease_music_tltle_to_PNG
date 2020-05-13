using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Netease_music_tltle_to_PNG
{
    public partial class Form1 : Form
    {
        public static int G_catch_speed;
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            logBox.Text += "Program started successfully.\r\n";
            label_catch_speed_value.Text = catch_speed.Value.ToString() + "ms";
            G_catch_speed = catch_speed.Value;

        }

        private void lable_save_location_Click(object sender, EventArgs e)
        {

        }

        private void label_catch_speed_Click(object sender, EventArgs e)
        {

        }
        private void label_catch_speed_value_Click(object sender, EventArgs e)
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
                    run.Text = "停止捕获";
                    background_loop.RunWorkerAsync();
                }
                else
                {
                    run.Text = "正在中止...";
                    run.Enabled = false;
                    background_loop.CancelAsync();

                    System.Threading.Thread.Sleep(G_catch_speed);

                    status.Text = "未捕获";
                    run.Text = "捕获";
                    run.Enabled = true;
                }
            }
        }

        private void background_loop_DoWork(object sender, DoWorkEventArgs e)
        {
            var last_title = "";

            while (true)
            {

                var running = !browse_button.Enabled;
                var title = "";

                if (background_loop.CancellationPending)
                {
                    logBox.Text += "Stop catching song title.\r\n";
                    break;
                }

                if (running) {

                    //logBox.Text += "Start catching song title.\r\n";
                    status.Text = "正在捕获网易云音乐进程";
                    var info = System.Diagnostics.Process.GetProcessesByName("cloudmusic");
                    if (info.Length > 0)
                    {
                        //logBox.Text += "Successfully catched song title.\r\n";
                        status.Text = "成功捕获网易云音乐进程";
                        foreach (var process in info)
                        {
                            if (!string.IsNullOrEmpty(process.MainWindowTitle))
                            {
                                title = process.MainWindowTitle;
                                //Console.WriteLine("Log: " + process.MainWindowTitle + " END.");
                            }
                        }

                        if (string.IsNullOrEmpty(title) && !string.IsNullOrEmpty(last_title))
                        {
                            logBox.Text += "Err: Netease music process may be killed.\r\n";
                            status.Text = "未捕获 - 网易云音乐进程可能被关闭";
                            browse_button.Enabled = !browse_button.Enabled;
                            textBox_save_location.Enabled = !textBox_save_location.Enabled;
                            run.Text = "捕获";
                            background_loop.CancelAsync();
                        }

                        if (title == last_title)
                        {
                            //logBox.Text += "Song title not changed.\r\n";
                            System.Threading.Thread.Sleep(G_catch_speed);
                            continue;
                        } else
                        {
                            last_title = title;

                            var file_path = textBox_save_location.Text + "\\song_info.txt";
                            if (!System.IO.File.Exists(file_path))
                            {
                                logBox.Text += "File not exist. Creating file song_info.txt.\r\n";
                                System.IO.FileStream stream = System.IO.File.Create(file_path);
                                stream.Close();
                                stream.Dispose();
                            }
                            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(file_path, false))
                            {
                                logBox.Text += "Song title changed. Writing into file.\r\n";
                                writer.WriteLine(title);
                            }
                        }

                        System.Threading.Thread.Sleep(G_catch_speed);
                    }
                    else
                    {
                        logBox.Text += "Err: Netease music process not found.\r\n";
                        status.Text = "未捕获 - 没有找到网易云音乐进程";
                        browse_button.Enabled = !browse_button.Enabled;
                        textBox_save_location.Enabled = !textBox_save_location.Enabled;
                        run.Text = "捕获";
                        background_loop.CancelAsync();
                    }

                }


            }
        }

        private void logBox_TextChanged(object sender, EventArgs e)
        {
            logBox.SelectionStart = logBox.Text.Length;
            logBox.ScrollToCaret();
        }

        private void catch_speed_Scroll(object sender, EventArgs e)
        {
            label_catch_speed_value.Text = catch_speed.Value.ToString() + "ms";
            G_catch_speed = catch_speed.Value;
        }

        private void check_output_as_png_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
