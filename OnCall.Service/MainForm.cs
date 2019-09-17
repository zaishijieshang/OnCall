using OnCall.Service.Domain;
using OnCall.Service.Domain.Ext;
using Quartz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace OnCall.Service
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text = ConfigUtil.GetConfigVal("ServerName");


            InitialTray();

            InitAction();
        }

        private void InitAction()
        {
            JobDispatch.UIExeJobData += ((jobData) =>
            {
                Invoke(new Action(() =>
                {
                    if (listViewService.Items.Count > 200)
                    {
                        listViewService.Items.Clear();
                    }

                    ListViewItem item = new ListViewItem(new string[] {
                        jobData.ExeTime.ToDateTime2(),
                        jobData.JobTitle,
                        jobData.ExeResult,
                        jobData.Status.ToJobStatus()
                     });

                    listViewService.Items.Add(item);

                }));

            });

            JobDispatch.UIExeAlarmData += ((jobData) =>
            {
                Invoke(new Action(() =>
                {
                    if (listViewAlarm.Items.Count > 200)
                    {
                        listViewAlarm.Items.Clear();
                    }

                    ListViewItem item = new ListViewItem(new string[] {
                        jobData.ExeTime.ToDateTime2(),
                        jobData.StationTitle,
                        jobData.AlarmContent,
                        jobData.AlarmLevel,
                        jobData.Status
                     });

                    listViewAlarm.Items.Add(item);

                }));

            });


            JobDispatch.UIJobStatus += ((isRunning) =>
            {
                Invoke(new Action(() =>
                {
                    tssJobStatus.Text = isRunning ? "运行" : "停止";
                    tssJobStatus.ForeColor = isRunning ? Color.Green : Color.Red;
                }));
            });


            JobDispatch.UIFaultAlarmCount += ((alarmCount) =>
            {
                Invoke(new Action(() =>
                {
                    tsAlarmCount.Text = (Convert.ToInt32(tsAlarmCount.Text) + alarmCount).ToString();
                }));
            });

            JobDispatch.UIVBitCount += ((alarmCount) =>
            {
                Invoke(new Action(() =>
                {
                    tsVBitCount.Text = (Convert.ToInt32(tsVBitCount.Text) + alarmCount).ToString();
                }));
            });

            

            JobDispatch.UISMSCount += ((smsCount) =>
            {
                Invoke(new Action(() =>
                {
                    tsVBitLab.Text = (Convert.ToInt32(tsVBitLab.Text) + smsCount).ToString();
                }));
            });

        }

        private void TsStartBtn_Click(object sender, EventArgs e)
        {
            tsStartBtn.Enabled = false;

            JobDispatch._Scheduler.Start();

            JobDispatch.Start(JobDispatch.AlarmCrewJob, 3);//三秒检查一次
            JobDispatch.Start(JobDispatch.AlarmVariableBitJob, 3);//三秒检查一次
            
            JobDispatch.Start(JobDispatch.SMSSendJob, 1);//一秒检查一次

            tsStopBtn.Enabled = true;


        }

        private void TsStopBtn_Click(object sender, EventArgs e)
        {
            tsStartBtn.Enabled = true;

            JobDispatch.Stop(JobDispatch.AlarmCrewJob);
            JobDispatch.Stop(JobDispatch.AlarmVariableBitJob);

            JobDispatch.Stop(JobDispatch.SMSSendJob);

            tsStopBtn.Enabled = false;

        }

        private void TsBtnSeting_Click(object sender, EventArgs e)
        {

        }


        private NotifyIcon notifyIcon = null;

        public string ConfitUtil { get; private set; }

        /// <summary>
        /// 此方法用于制作右下角的图标。
        /// </summary>
        private void InitialTray()
        {
            //窗体打开的时候隐藏。
            //this.Visibility = Visibility.Hidden;
            //实例化NotifyIcon以及为其设置属性。
            notifyIcon = new NotifyIcon();
            //当运行程序的时候右下角先显示服务开启中。
            notifyIcon.BalloonTipText = "服务开启中。";
            //服务开启中这几个字显示的秒数。
            notifyIcon.ShowBalloonTip(2000);
            //当光标放在上面之后，显示视频预览几个字。 
            notifyIcon.Text = ConfigUtil.GetConfigVal("AppTitle");
            //图标在通知栏区域中可见。
            notifyIcon.Visible = true;
            //要显示图标的路径。
            //if (icoPath.Contains("bin"))
            //{
            //int indexNumber = icoPath.IndexOf("bin");
            //得到完整路径。
            //icoPath = icoPath.Substring(0, indexNumber) + "//Images//2.ico";
            //}
            //设置图标。
            notifyIcon.Icon = new System.Drawing.Icon(PathUtil.BaseDirectoryPath + "\\logo.ico");
            //设置菜单栏。有3个item选项，分别是显示、隐藏、退出。并为其添加事件。
            //System.Windows.Forms.MenuItem showMenuItem = new System.Windows.Forms.MenuItem("显示");
            //showMenuItem.Click += new EventHandler(showMenuItem_Click);
            //System.Windows.Forms.MenuItem hideMenuItem = new System.Windows.Forms.MenuItem("隐藏");
            //hideMenuItem.Click += new EventHandler(hideMenuItem_Click);
            System.Windows.Forms.MenuItem quitMenuItem = new System.Windows.Forms.MenuItem("退出");
            quitMenuItem.Click += new EventHandler(quitMenuItem_Click);
            //将上面的3个自选项加入到parentMenuitem中。
            System.Windows.Forms.MenuItem[] parentMenuitem = new System.Windows.Forms.MenuItem[] { quitMenuItem };//showMenuItem, hideMenuItem,
            //为notifyIconContextMenu。
            notifyIcon.ContextMenu = new System.Windows.Forms.ContextMenu(parentMenuitem);
            //notifyIcon的MouseDown事件。
            notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(notifyIcon_MouseDoubleClick);
            //窗体的StateChanged事件。
            //this.StateChanged += new EventHandler(MainWindow_StateChanged);
            //不让在任务栏显示。
            this.ShowInTaskbar = false;
        }

        private void quitMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("你确定要退出吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
                Environment.Exit(0);
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //如果点击了鼠标左键。
            if (e.Button == MouseButtons.Left)
            {
                this.Visible = true;
                this.WindowState = FormWindowState.Normal;
                //将窗口至于前台并激活。
                this.Activate();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)//当用户点击窗体右上角X按钮或(Alt + F4)时 发生          
            {
                e.Cancel = true;
                this.ShowInTaskbar = false;
                this.Icon = this.Icon;
                this.Hide();
            }
        }


    }
}
