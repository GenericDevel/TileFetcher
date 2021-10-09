using System.Windows.Forms;

namespace TileFetcher
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslMain = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslPosition = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnSaveTo = new System.Windows.Forms.Button();
            this.txtSaveTo = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblTileCount = new System.Windows.Forms.Label();
            this.txtYcode = new System.Windows.Forms.TextBox();
            this.txtXcode = new System.Windows.Forms.TextBox();
            this.txtYcount = new System.Windows.Forms.TextBox();
            this.txtXcount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLog = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCalTileCount = new System.Windows.Forms.Button();
            this.cmbLevel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbServer = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDrawRect = new System.Windows.Forms.Button();
            this.lblSouth = new System.Windows.Forms.Label();
            this.lblEast = new System.Windows.Forms.Label();
            this.lblWest = new System.Windows.Forms.Label();
            this.lblNorth = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtLng = new System.Windows.Forms.TextBox();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnLocate = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslMain,
            this.toolStripStatusLabel2,
            this.tslPosition,
            this.tslProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 798);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1227, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslMain
            // 
            this.tslMain.AutoSize = false;
            this.tslMain.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tslMain.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.tslMain.Image = ((System.Drawing.Image)(resources.GetObject("tslMain.Image")));
            this.tslMain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tslMain.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tslMain.Name = "tslMain";
            this.tslMain.Size = new System.Drawing.Size(330, 17);
            this.tslMain.Text = " OK.";
            this.tslMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel2.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(200, 17);
            this.toolStripStatusLabel2.Text = "版权：中南大学-李光强., 2021.";
            // 
            // tslPosition
            // 
            this.tslPosition.AutoSize = false;
            this.tslPosition.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tslPosition.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.tslPosition.Name = "tslPosition";
            this.tslPosition.Size = new System.Drawing.Size(230, 17);
            this.tslPosition.Text = "lng=,lat=";
            // 
            // tslProgressBar
            // 
            this.tslProgressBar.Name = "tslProgressBar";
            this.tslProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.btnLog);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 798);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(179, 26);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 23);
            this.btnReload.TabIndex = 4;
            this.btnReload.Text = "地图重载";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(49, 749);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "开始下载";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnSaveTo);
            this.groupBox6.Controls.Add(this.txtSaveTo);
            this.groupBox6.Location = new System.Drawing.Point(12, 626);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(263, 95);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "文件保存";
            // 
            // btnSaveTo
            // 
            this.btnSaveTo.Location = new System.Drawing.Point(179, 62);
            this.btnSaveTo.Name = "btnSaveTo";
            this.btnSaveTo.Size = new System.Drawing.Size(75, 23);
            this.btnSaveTo.TabIndex = 1;
            this.btnSaveTo.Text = "保存文件";
            this.btnSaveTo.UseVisualStyleBackColor = true;
            this.btnSaveTo.Click += new System.EventHandler(this.btnSaveTo_Click);
            // 
            // txtSaveTo
            // 
            this.txtSaveTo.Location = new System.Drawing.Point(6, 31);
            this.txtSaveTo.Name = "txtSaveTo";
            this.txtSaveTo.ReadOnly = true;
            this.txtSaveTo.Size = new System.Drawing.Size(251, 21);
            this.txtSaveTo.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblTileCount);
            this.groupBox5.Controls.Add(this.txtYcode);
            this.groupBox5.Controls.Add(this.txtXcode);
            this.groupBox5.Controls.Add(this.txtYcount);
            this.groupBox5.Controls.Add(this.txtXcount);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Location = new System.Drawing.Point(12, 428);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(263, 183);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tile Count";
            // 
            // lblTileCount
            // 
            this.lblTileCount.AutoSize = true;
            this.lblTileCount.Location = new System.Drawing.Point(16, 151);
            this.lblTileCount.Name = "lblTileCount";
            this.lblTileCount.Size = new System.Drawing.Size(71, 12);
            this.lblTileCount.TabIndex = 1;
            this.lblTileCount.Text = "瓦片总数：0";
            // 
            // txtYcode
            // 
            this.txtYcode.Location = new System.Drawing.Point(127, 106);
            this.txtYcode.Name = "txtYcode";
            this.txtYcode.ReadOnly = true;
            this.txtYcode.Size = new System.Drawing.Size(100, 21);
            this.txtYcode.TabIndex = 1;
            this.txtYcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtXcode
            // 
            this.txtXcode.Location = new System.Drawing.Point(127, 80);
            this.txtXcode.Name = "txtXcode";
            this.txtXcode.ReadOnly = true;
            this.txtXcode.Size = new System.Drawing.Size(100, 21);
            this.txtXcode.TabIndex = 1;
            this.txtXcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtYcount
            // 
            this.txtYcount.Location = new System.Drawing.Point(127, 54);
            this.txtYcount.Name = "txtYcount";
            this.txtYcount.ReadOnly = true;
            this.txtYcount.Size = new System.Drawing.Size(100, 21);
            this.txtYcount.TabIndex = 1;
            this.txtYcount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtXcount
            // 
            this.txtXcount.Location = new System.Drawing.Point(127, 28);
            this.txtXcount.Name = "txtXcount";
            this.txtXcount.ReadOnly = true;
            this.txtXcount.Size = new System.Drawing.Size(100, 21);
            this.txtXcount.TabIndex = 1;
            this.txtXcount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "Start code on Y : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "Start code on X : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tile count on Y : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tile count on X : ";
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(164, 749);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(75, 23);
            this.btnLog.TabIndex = 2;
            this.btnLog.Text = "显示日志";
            this.toolTip1.SetToolTip(this.btnLog, "查看下载日志");
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnCalTileCount);
            this.groupBox4.Controls.Add(this.cmbLevel);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.cmbServer);
            this.groupBox4.Location = new System.Drawing.Point(12, 277);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(263, 137);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tile setting";
            // 
            // btnCalTileCount
            // 
            this.btnCalTileCount.Location = new System.Drawing.Point(77, 104);
            this.btnCalTileCount.Name = "btnCalTileCount";
            this.btnCalTileCount.Size = new System.Drawing.Size(100, 23);
            this.btnCalTileCount.TabIndex = 1;
            this.btnCalTileCount.Text = "计算瓦片数量";
            this.toolTip1.SetToolTip(this.btnCalTileCount, "根据划定的范围及瓦片层级，计算要载的瓦片数量");
            this.btnCalTileCount.UseVisualStyleBackColor = true;
            this.btnCalTileCount.Click += new System.EventHandler(this.btnCalTileCount_Click);
            // 
            // cmbLevel
            // 
            this.cmbLevel.FormattingEnabled = true;
            this.cmbLevel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cmbLevel.Location = new System.Drawing.Point(71, 64);
            this.cmbLevel.Name = "cmbLevel";
            this.cmbLevel.Size = new System.Drawing.Size(120, 20);
            this.cmbLevel.TabIndex = 2;
            this.cmbLevel.Text = "12";
            this.toolTip1.SetToolTip(this.cmbLevel, "选择要下载的层级");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Level:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Server:";
            // 
            // cmbServer
            // 
            this.cmbServer.FormattingEnabled = true;
            this.cmbServer.Items.AddRange(new object[] {
            "Google",
            "Google-China",
            "ESRI",
            "Bing",
            "Tianditu"});
            this.cmbServer.Location = new System.Drawing.Point(71, 29);
            this.cmbServer.Name = "cmbServer";
            this.cmbServer.Size = new System.Drawing.Size(120, 20);
            this.cmbServer.TabIndex = 1;
            this.cmbServer.Text = "Google";
            this.toolTip1.SetToolTip(this.cmbServer, "选择要下载的服务器，Google服务器需要翻墙!");
            this.cmbServer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbServer_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnClear);
            this.groupBox3.Controls.Add(this.btnDrawRect);
            this.groupBox3.Controls.Add(this.lblSouth);
            this.groupBox3.Controls.Add(this.lblEast);
            this.groupBox3.Controls.Add(this.lblWest);
            this.groupBox3.Controls.Add(this.lblNorth);
            this.groupBox3.Location = new System.Drawing.Point(12, 121);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(263, 147);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "下载范围(WGS84)";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(140, 109);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "清 除";
            this.toolTip1.SetToolTip(this.btnClear, "清除当前绘制的矩形框");
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDrawRect
            // 
            this.btnDrawRect.Location = new System.Drawing.Point(37, 109);
            this.btnDrawRect.Name = "btnDrawRect";
            this.btnDrawRect.Size = new System.Drawing.Size(81, 23);
            this.btnDrawRect.TabIndex = 1;
            this.btnDrawRect.Text = "划定区域";
            this.toolTip1.SetToolTip(this.btnDrawRect, "在地图上绘制矩形框，划定要下载的范围");
            this.btnDrawRect.UseVisualStyleBackColor = true;
            this.btnDrawRect.Click += new System.EventHandler(this.btnDrawRect_Click);
            // 
            // lblSouth
            // 
            this.lblSouth.AutoSize = true;
            this.lblSouth.Location = new System.Drawing.Point(105, 79);
            this.lblSouth.Name = "lblSouth";
            this.lblSouth.Size = new System.Drawing.Size(35, 12);
            this.lblSouth.TabIndex = 1;
            this.lblSouth.Text = "South";
            // 
            // lblEast
            // 
            this.lblEast.AutoSize = true;
            this.lblEast.Location = new System.Drawing.Point(177, 47);
            this.lblEast.Name = "lblEast";
            this.lblEast.Size = new System.Drawing.Size(29, 12);
            this.lblEast.TabIndex = 1;
            this.lblEast.Text = "East";
            // 
            // lblWest
            // 
            this.lblWest.AutoSize = true;
            this.lblWest.Location = new System.Drawing.Point(28, 47);
            this.lblWest.Name = "lblWest";
            this.lblWest.Size = new System.Drawing.Size(29, 12);
            this.lblWest.TabIndex = 1;
            this.lblWest.Text = "West";
            // 
            // lblNorth
            // 
            this.lblNorth.AutoSize = true;
            this.lblNorth.Location = new System.Drawing.Point(105, 29);
            this.lblNorth.Name = "lblNorth";
            this.lblNorth.Size = new System.Drawing.Size(35, 12);
            this.lblNorth.TabIndex = 1;
            this.lblNorth.Text = "North";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.webBrowser1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(304, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(923, 798);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "WebMap";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 17);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(917, 778);
            this.webBrowser1.TabIndex = 0;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Tiff File|*.tif";
            this.saveFileDialog1.Title = "Save merged tiff to";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnLocate);
            this.groupBox7.Controls.Add(this.btnReload);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Controls.Add(this.txtLat);
            this.groupBox7.Controls.Add(this.txtLng);
            this.groupBox7.Location = new System.Drawing.Point(12, 17);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(263, 90);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "地图定位[WGS84]";
            // 
            // txtLng
            // 
            this.txtLng.Location = new System.Drawing.Point(57, 29);
            this.txtLng.Name = "txtLng";
            this.txtLng.Size = new System.Drawing.Size(100, 21);
            this.txtLng.TabIndex = 1;
            this.txtLng.Text = "112.926314";
            // 
            // txtLat
            // 
            this.txtLat.Location = new System.Drawing.Point(57, 57);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(100, 21);
            this.txtLat.TabIndex = 1;
            this.txtLat.Text = " 28.165375";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "经度：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "纬度：";
            // 
            // btnLocate
            // 
            this.btnLocate.Location = new System.Drawing.Point(179, 55);
            this.btnLocate.Name = "btnLocate";
            this.btnLocate.Size = new System.Drawing.Size(75, 23);
            this.btnLocate.TabIndex = 1;
            this.btnLocate.Text = "定 位";
            this.btnLocate.UseVisualStyleBackColor = true;
            this.btnLocate.Click += new System.EventHandler(this.btnLocate_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 820);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "瓦片下载器 [Tile fetcher]";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private ToolStripStatusLabel tslMain;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel tslPosition;
        private ToolStripProgressBar tslProgressBar;
        private GroupBox groupBox3;
        private Label lblSouth;
        private Label lblEast;
        private Label lblWest;
        private Label lblNorth;
        private GroupBox groupBox4;
        private Label label1;
        private ComboBox cmbServer;
        private Label label3;
        private ComboBox cmbLevel;
        private Button btnLog;
        private GroupBox groupBox5;
        private TextBox txtYcode;
        private TextBox txtXcode;
        private TextBox txtYcount;
        private TextBox txtXcount;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private GroupBox groupBox6;
        private Button btnSaveTo;
        private TextBox txtSaveTo;
        private SaveFileDialog saveFileDialog1;
        private Button btnStart;
        private Button btnReload;
        private Button btnClear;
        private Button btnDrawRect;
        private ToolTip toolTip1;
        private Button btnCalTileCount;
        private Label lblTileCount;
        private GroupBox groupBox7;
        private Label label8;
        private Label label7;
        private TextBox txtLat;
        private TextBox txtLng;
        private Button btnLocate;
        private Timer timer1;
    }
}

