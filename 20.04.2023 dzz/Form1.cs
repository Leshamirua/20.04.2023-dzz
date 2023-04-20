using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _20._04._2023_dzz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Method();
        }
        void Method()
        {

            Process[] processes = Process.GetProcesses();
            var sortedProcesses = processes.OrderByDescending(p => p.WorkingSet64);

            foreach (Process p in sortedProcesses)
            {
                ListViewItem listView = new ListViewItem(p.ProcessName);
                listView.SubItems.Add(p.Id.ToString());
                double mb = Convert.ToDouble(p.WorkingSet64) / 1048576;
                listView.SubItems.Add(mb.ToString());
                TaskManeger.Items.Add(listView);
            }
        }
        void RefreshTasks()
        {
            TaskManeger.Items.Clear();
            Process[] processes = Process.GetProcesses();
            foreach (Process p in processes)
            {
                p.Refresh();
            }
            Method();
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            Process proc = new Process();
            if (textBox2.Text.Length <= 0)
            {
                MessageBox.Show("No process name!");
            }
            else
            {
                proc.StartInfo.FileName = textBox2.Text;
                proc.Start();
            }
            RefreshTasks();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            RefreshTasks();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}