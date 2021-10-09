using CoorTransNet;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TileFetcher
{ 
    [ComVisible(true)]
    public partial class FormMain : Form
    {
                
        /// <summary>
        /// 下载范围
        /// </summary>
        string[] extent;
        /// <summary>
        /// 瓦片数量
        /// </summary>
        int tileCount=0;

        /// <summary>
        /// 下载日志
        /// </summary>
        string log = "";

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
           
            string url = "file:///" + (Application.StartupPath + @"\WebPage\index.html").Replace("\\", "/");
            //webBrowser1.Navigate(Application.StartupPath + @".\WebPage\index.html");
            this.webBrowser1.Navigate(url);
            this.btnLocate_Click(null, null);//定位到中南大学地学楼
        }

        protected override void OnLoad(EventArgs e)
        {
            
            webBrowser1.AllowWebBrowserDrop = false;
            webBrowser1.IsWebBrowserContextMenuEnabled = false;
            webBrowser1.WebBrowserShortcutsEnabled = false;
            webBrowser1.ObjectForScripting = this;//new MyScriptObject(this);
            
            base.OnLoad(e);

        }

        /// <summary>
        /// 执行JS函数
        /// </summary>
        /// <param name="cmd"></param>
        /// <param name="param"></param>
        public void ExecJS(string cmd, object[] param)
        {
            webBrowser1.Document.InvokeScript(cmd, param);
        }


        /// <summary>
        /// 接收JS调用函数（测试）
        /// </summary>
        /// <param name="message"></param>
        public void Test(string message)
        {
            MessageBox.Show(message, "From JS");
        }

        /// <summary>
        /// Display the postion of the current mouse.
        /// </summary>
        /// <param name="lng"></param>
        /// <param name="lat"></param>
        public void DisplayCoor(double lng, double lat)
        {
            Coordinate coor= CoorTransNet.CoordinateCorrectionManager.BD09_To_WGS84(lat, lng);
            this.tslPosition.Text = string.Format("WGS84: {0} , {1}",coor.Lon.ToString("f6"), coor.Lat.ToString("f6"));
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            string url = "file:///" + (Application.StartupPath + @"\WebPage\index.html").Replace("\\", "/");
            //webBrowser1.Navigate(Application.StartupPath + @".\WebPage\index.html");
            this.webBrowser1.Navigate(url);
            this.Reset();
        }

        private void btnDrawRect_Click(object sender, EventArgs e)
        {
            this.Reset();
            this.ExecJS("draw", null);
            this.tslMain.Text = " 提示：点击地图开始绘制要下载的瓦片范围.";
        }

        /// <summary>
        /// 从js接收绘制的矩形坐标
        /// </summary>
        /// <param name="rect"></param>
        public void SetExtent(string rect)
        {
            if (rect == "")
            {
                MessageBox.Show("你可能没有绘制矩形！", "Error");
                return;
            }
            this.extent = rect.Split(',');
            if (extent.Length != 4)
            {
                MessageBox.Show("地图返回的数据格式不正确！", "Error");
                extent = null;
                return;
            }
            try
            {
                //将BD09转为WGS84
                double w = double.Parse(extent[0]);
                double s = double.Parse(extent[1]);
                double e = double.Parse(extent[2]);
                double n = double.Parse(extent[3]);

                Coordinate start = CoordinateCorrectionManager.BD09_To_WGS84(s, w);
                Coordinate end = CoordinateCorrectionManager.BD09_To_WGS84(n, e);

                extent[0] = start.Lon.ToString("f6");
                extent[1] = start.Lat.ToString("f6");
                extent[2] = end.Lon.ToString("f6");
                extent[3] = end.Lat.ToString("f6");

                this.lblWest.Text = extent[0];
                this.lblSouth.Text = extent[1];
                this.lblEast.Text = extent[2];
                this.lblNorth.Text = extent[3];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnCalTileCount_Click(object sender, EventArgs e)
        {
            if (this.extent == null)
            {
                MessageBox.Show("请先绘制要下载的范围！", "Exclaim");
                return;
            }

            string python = "\"" + Application.StartupPath + "\\python39\\python.exe\"";
            string pyfile = Application.StartupPath + @"\py-script\tile.py "+
                string.Format("--west={0} --north={1} --east={2} --south={3} --zoom={4}"
                             ,this.extent[0],this.extent[1],this.extent[2],this.extent[3],this.cmbLevel.Text);
            try
            {
                this.tslMain.Text = " 正在计算瓦片数量，请稍候...";
                this.Cursor = Cursors.WaitCursor;
                string result = MyConsole.RunExternalExe(python, pyfile).Trim();
                //返回数据格式：'{"x_count":'+str(lenx)+' , "y_count":'+str(leny)+'"x_start":'+str(pos1x)+'"y_start":'+str(pos1y)+"}";
                result = result.Replace("{","").Replace("}","")
                               .Replace("\"x_count\":", "")
                               .Replace("\"y_count\":", "")
                               .Replace("\"x_start\":", "")
                               .Replace("\"y_start\":", "");
                string[] arr = result.Split(',');
                this.txtXcount.Text = arr[0].Trim();
                this.txtYcount.Text = arr[1].Trim();
                this.txtXcode.Text = arr[2].Trim();
                this.txtYcode.Text = arr[3].Trim();

                this.tileCount = int.Parse(this.txtXcount.Text) * int.Parse(this.txtYcount.Text);
                this.lblTileCount.Text = "瓦片总数：" + this.tileCount.ToString();
            }
            catch (Exception ex)
            {
#if DEBUG
                Debug.WriteLine(" #Exception: " + ex.Message);
#endif
                MessageBox.Show("Error: " + ex.Message, "Exception");
            }
            finally {
                this.tslMain.Text = " 计算瓦片数量完毕.";
                this.Cursor = Cursors.Default;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Reset();
            this.ExecJS("clearAll", null);
            this.tslMain.Text = " 提示：范围已清除.";
        }

        private void cmbServer_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnLocate_Click(object sender, EventArgs e)
        {
            try {
                double lng = double.Parse(this.txtLng.Text);
                double lat = double.Parse(this.txtLat.Text);
                //转为百度坐标
                Coordinate coor = CoordinateCorrectionManager.WGS84_To_BD09(lat, lng);
                object[] param = { lng, lat };
                this.ExecJS("locate", param);
            }
            catch (Exception ex)
            { 
            }

        }



        /// <summary>
        /// 开始下载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (this.extent == null)
            {
                MessageBox.Show("请先绘制要下载的范围！", "Exclaim");
                return;
            }
            if (this.txtSaveTo.Text.Trim() == "")
            {
                MessageBox.Show("请选择要保存的文件！", "Error");
                return;
            }

            string python = "\"" + Application.StartupPath + "\\python39\\python.exe\"";
            string pyfile = Application.StartupPath + @"\py-script\main.py " +
                string.Format("--west={0} --north={1} --east={2} --south={3} --zoom={4} --file={5} --server={6}"
                             , this.extent[0], this.extent[1], this.extent[2], this.extent[3], this.cmbLevel.Text
                             , this.txtSaveTo.Text,this.cmbServer.Text);
            try
            {
                this.tslMain.Text = " 正在下载数据，请稍候...";
                this.Cursor = Cursors.WaitCursor;

                this.tslProgressBar.Value = 0;
                this.tslProgressBar.Maximum = this.tileCount;

                this.timer1.Enabled = false;
                this.timer1.Start();
                
                this.log = MyConsole.RunExternalExe(python, pyfile).Trim();

                if (MessageBox.Show("下载完毕，是否查看下载日志？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    FormLog frm = new FormLog();
                    frm.txtLog.Text = this.log;
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
#if DEBUG
                Debug.WriteLine(" #Exception: " + ex.Message);
#endif
                MessageBox.Show("Error: " + ex.Message, "Exception");
            }
            finally
            {
                this.tslMain.Text = " 下载完成，瓦片已合并且已保存.";
                this.Cursor = Cursors.Default;
                this.tslProgressBar.Value = this.tslProgressBar.Maximum;
                this.timer1.Enabled = false;
                this.timer1.Stop();
            }
        }

        /// <summary>
        /// 控制进度条显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.tslProgressBar.Value++;
            if (this.tslProgressBar.Value >= tslProgressBar.Maximum)
                this.tslProgressBar.Value = 0;

            this.statusStrip1.Refresh();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            FormLog frm = new FormLog();
            frm.txtLog.Text = this.log;
            frm.ShowDialog();
        }

        private void btnSaveTo_Click(object sender, EventArgs e)
        {
            if (this.saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            this.txtSaveTo.Text = this.saveFileDialog1.FileName;
        }

        /// <summary>
        /// 重置参数
        /// </summary>
        private void Reset()
        {
            this.lblEast.Text = "east";
            this.lblWest.Text = "west";
            this.lblNorth.Text = "north";
            this.lblSouth.Text = "south";
            this.txtSaveTo.Text = "";
            this.txtXcode.Text = "";
            this.txtXcount.Text = "";
            this.txtYcode.Text = "";
            this.txtYcount.Text = "";
            this.extent = null;
            this.tileCount = 0;
        }
    }

}
