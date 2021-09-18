using CircleLoadingBar;
using OpenHardwareMonitor.Hardware;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HardwareDashboard.GPUCPU;

namespace HardwareDashboard
{
    public partial class Form1 : Form
    {
        Computer comp = new Computer();
        Random rnd = new Random();
        bool created = false;
        List<VerticalProgressBar> bars = new List<VerticalProgressBar>();
        List<Label> labels = new List<Label>();
        List<List<float>> values = new List<List<float>>();
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        public Form1()
        {
            InitializeComponent();
            modernSlider1.ValueChanged += ModernSlider1_ValueChanged;
            comp.Open();
            UpdateHardware();
        }

        private void ModernSlider1_ValueChanged(object sender, EventArgs e)
        {
            sliderValue.Text = "Value: " + modernSlider1.Value.ToString("0.0") + " | " + modernSlider1.MaxValue;
        }

        public async void UpdateHardware()
        {
            Stopwatch sw = Stopwatch.StartNew();
            (CPU cpu, GPU gpu) = await GPUCPU.GetLoad(comp);
            int i = 0;
            int maxWidth = cpuCorePanel.ContentsPanel.Width;
            foreach (var load in cpu.loadCores)
            {
                if (!created)
                {
                    Point barLocation = new Point(maxWidth / 8 * i + (int)(maxWidth - (maxWidth / 8 * cpu.loadCores.Count * 1.5) + maxWidth / 32), 40);
                    VerticalProgressBar bar = new VerticalProgressBar();
                    bar.Value = load.Value;
                    bar.Width = maxWidth / 16;
                    bar.Height = (int)(cpuCorePanel.Height * 0.70);
                    bar.Location = barLocation;
                    bar.EdgeColor = Color.DimGray;
                    Label lbl = new Label();
                    lbl.Location = new Point((int)(maxWidth * 0.8), 25 * i++ + 40); //new Point(barLocation.X - 10, (int)(cpuCorePanel.Height * 0.70 + 45));
                    lbl.Text = i + ": " + load.Value.ToString("0.0") + "%";
                    lbl.ForeColor = Color.WhiteSmoke;
                    bars.Add(bar);
                    labels.Add(lbl);
                    values.Add(new List<float>());
                    cpuLbl.Text = "CPU Load | " + cpu.Name;
                    gpuLbl.Text = "GPU Load | " + gpu.Name;
                }
                else
                {
                    bars[i].Value = load.Value;
                    labels[i].Text = i + ": " + load.Value.ToString("0.0") + "%";
                    values[i].Add(load.Value);
                    if (load.Value <= 33)
                        bars[i].BarColor = new Color[] { Color.FromArgb(124, 187, 0), Color.FromArgb(111, 168, 0) };
                    if (load.Value > 33 && load.Value <= 66)
                        bars[i].BarColor = new Color[] { Color.FromArgb(246, 83, 20), Color.FromArgb(221, 74, 18) };
                    if (load.Value > 66)
                        bars[i].BarColor = new Color[] { Color.FromArgb(255, 50, 35), Color.FromArgb(229, 45, 31) };
                    i++;
                }
            }
            if (cpu.loadTotal != null && cpuLoadCheck.Checked)
                cpuLoadGauge.Value = cpu.loadTotal.Value;
            if (gpu.Load != null && gpuLoadCheck.Checked)
                gpuLoadGauge.Value = rnd.Next(0, 300);

            PerfomanceInfoData data = await GetMemory();
            memoryLoad.Value = (double)data.PhysicalAvailableBytes / (double)data.PhysicalTotalBytes * 100.0;
            hddBar.Value = 100 - (double)DriveInfo.GetDrives()[0].TotalFreeSpace / (double)DriveInfo.GetDrives()[0].TotalSize * 100.0;


            foreach (var progressbar in bars)
                cpuCorePanel.ContentsPanel.Controls.Add(progressbar);
            i = 1;
            foreach (var lbl in labels)
            {
                cpuCorePanel.ContentsPanel.Controls.Add(lbl);
                lineGraph.Captions.Add("Core #" + i++);
            }
            if (bars.Count > 0 && labels.Count > 0)
                created = true;
            lineGraph.Values = values;
            if (sw.ElapsedMilliseconds < 1000)
                await Task.Delay(1000 - (int)sw.ElapsedMilliseconds);
            UpdateHardware();
        }

        public async Task<PerfomanceInfoData> GetMemory()
        {
            return await PsApiWrapper.GetPerformanceInfo();
        }

        private void testIcon_Click(object sender, EventArgs e)
        {
        }

        private void topPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
                this.WindowState = FormWindowState.Minimized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void cpuLoadGauge_Load(object sender, EventArgs e)
        {

        }

        private void multilineCheck_CheckedChanged(object sender, EventArgs e)
        {
            lineGraph.FillBackground = multilineCheck.Checked;
        }

        private void multilineBorder_CheckedChanged(object sender, EventArgs e)
        {
            lineGraph.OutlineLeft = multilineBorder.Checked;
            lineGraph.OutlineBottom = multilineBorder.Checked;
        }

        private void modernCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            lineGraph.DisplayDots = modernCheckBox1.Checked;
        }

        private void modernCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            lineGraph.DisplayText = modernCheckBox2.Checked;
        }

        private void modernCheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            lineGraph.DisplayLegend = modernCheckBox3.Checked;
        }

        private void settingsIcon_MouseEnter(object sender, EventArgs e)
        {
            settingsPanel.BackColor = Color.FromArgb(66, 87, 160);
        }

        private void settingsIcon_MouseLeave(object sender, EventArgs e)
        {
            settingsPanel.BackColor = Color.FromArgb(74, 97, 178);           
        }
    }
}
