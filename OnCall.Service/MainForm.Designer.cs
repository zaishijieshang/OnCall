namespace OnCall.Service
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsStartBtn = new System.Windows.Forms.ToolStripButton();
            this.tsStopBtn = new System.Windows.Forms.ToolStripButton();
            this.tsBtnSeting = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssJobStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsWebSocketStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsAlarmCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsVBitLab = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listViewService = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listViewAlarm = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tsVBitCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtSMSLab = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsSMSCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStartBtn,
            this.tsStopBtn,
            this.tsBtnSeting});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(784, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // tsStartBtn
            // 
            this.tsStartBtn.Image = ((System.Drawing.Image)(resources.GetObject("tsStartBtn.Image")));
            this.tsStartBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsStartBtn.Name = "tsStartBtn";
            this.tsStartBtn.Size = new System.Drawing.Size(52, 22);
            this.tsStartBtn.Text = "开始";
            this.tsStartBtn.Click += new System.EventHandler(this.TsStartBtn_Click);
            // 
            // tsStopBtn
            // 
            this.tsStopBtn.Enabled = false;
            this.tsStopBtn.Image = ((System.Drawing.Image)(resources.GetObject("tsStopBtn.Image")));
            this.tsStopBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsStopBtn.Name = "tsStopBtn";
            this.tsStopBtn.Size = new System.Drawing.Size(52, 22);
            this.tsStopBtn.Text = "停止";
            this.tsStopBtn.Click += new System.EventHandler(this.TsStopBtn_Click);
            // 
            // tsBtnSeting
            // 
            this.tsBtnSeting.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnSeting.Image")));
            this.tsBtnSeting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnSeting.Name = "tsBtnSeting";
            this.tsBtnSeting.Size = new System.Drawing.Size(52, 22);
            this.tsBtnSeting.Text = "设置";
            this.tsBtnSeting.Click += new System.EventHandler(this.TsBtnSeting_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tssJobStatus,
            this.toolStripStatusLabel2,
            this.tsWebSocketStatus,
            this.toolStripStatusLabel3,
            this.tsAlarmCount,
            this.toolStripStatusLabel4,
            this.tsVBitLab,
            this.tsVBitCount,
            this.txtSMSLab,
            this.tsSMSCount});
            this.statusStrip.Location = new System.Drawing.Point(0, 339);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(784, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(72, 17);
            this.toolStripStatusLabel1.Text = " 消息服务：";
            // 
            // tssJobStatus
            // 
            this.tssJobStatus.Name = "tssJobStatus";
            this.tssJobStatus.Size = new System.Drawing.Size(13, 17);
            this.tssJobStatus.Text = "-";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(103, 17);
            this.toolStripStatusLabel2.Text = "          WS服务：";
            // 
            // tsWebSocketStatus
            // 
            this.tsWebSocketStatus.Name = "tsWebSocketStatus";
            this.tsWebSocketStatus.Size = new System.Drawing.Size(13, 17);
            this.tsWebSocketStatus.Text = "-";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(108, 17);
            this.toolStripStatusLabel3.Text = "          故障告警：";
            // 
            // tsAlarmCount
            // 
            this.tsAlarmCount.Name = "tsAlarmCount";
            this.tsAlarmCount.Size = new System.Drawing.Size(15, 17);
            this.tsAlarmCount.Text = "0";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(0, 17);
            // 
            // tsVBitLab
            // 
            this.tsVBitLab.Name = "tsVBitLab";
            this.tsVBitLab.Size = new System.Drawing.Size(103, 17);
            this.tsVBitLab.Text = "           变位告警:";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 25);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(784, 314);
            this.tabControl.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listViewService);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(776, 288);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "服务状态";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listViewService
            // 
            this.listViewService.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewService.FullRowSelect = true;
            this.listViewService.GridLines = true;
            this.listViewService.Location = new System.Drawing.Point(3, 3);
            this.listViewService.Name = "listViewService";
            this.listViewService.Size = new System.Drawing.Size(770, 282);
            this.listViewService.TabIndex = 0;
            this.listViewService.UseCompatibleStateImageBehavior = false;
            this.listViewService.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "执行时间";
            this.columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "任务";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "执行反馈";
            this.columnHeader3.Width = 350;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "状态";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 120;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listViewAlarm);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(776, 288);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "告警信息";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listViewAlarm
            // 
            this.listViewAlarm.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listViewAlarm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewAlarm.FullRowSelect = true;
            this.listViewAlarm.GridLines = true;
            this.listViewAlarm.Location = new System.Drawing.Point(3, 3);
            this.listViewAlarm.Name = "listViewAlarm";
            this.listViewAlarm.Size = new System.Drawing.Size(770, 282);
            this.listViewAlarm.TabIndex = 0;
            this.listViewAlarm.UseCompatibleStateImageBehavior = false;
            this.listViewAlarm.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "告警时间";
            this.columnHeader5.Width = 130;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "厂站ID";
            this.columnHeader6.Width = 150;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "描述";
            this.columnHeader7.Width = 250;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "告警级别";
            this.columnHeader8.Width = 120;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "状态";
            this.columnHeader9.Width = 110;
            // 
            // tsVBitCount
            // 
            this.tsVBitCount.Name = "tsVBitCount";
            this.tsVBitCount.Size = new System.Drawing.Size(15, 17);
            this.tsVBitCount.Text = "0";
            // 
            // txtSMSLab
            // 
            this.txtSMSLab.Name = "txtSMSLab";
            this.txtSMSLab.Size = new System.Drawing.Size(107, 17);
            this.txtSMSLab.Text = "            短信发送:";
            // 
            // tsSMSCount
            // 
            this.tsSMSCount.Name = "tsSMSCount";
            this.tsSMSCount.Size = new System.Drawing.Size(15, 17);
            this.tsSMSCount.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "MainForm";
            this.Text = "消息推送服务";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripButton tsStartBtn;
        private System.Windows.Forms.ToolStripButton tsStopBtn;
        private System.Windows.Forms.ToolStripButton tsBtnSeting;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView listViewService;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView listViewAlarm;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tssJobStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tsWebSocketStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel tsAlarmCount;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel tsVBitLab;
        private System.Windows.Forms.ToolStripStatusLabel tsVBitCount;
        private System.Windows.Forms.ToolStripStatusLabel txtSMSLab;
        private System.Windows.Forms.ToolStripStatusLabel tsSMSCount;
    }
}

