using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView_Processes
{
    public partial class TimeTrigger : Form
    {
        public TimeTrigger()
        {
            InitializeComponent();
            FillProgrammsToClose();
        }

        private void FillProgrammsToClose()
        {
            var processes = Process.GetProcesses();
            programmsToClose.Items.Clear();
            foreach(var process in processes)
            {
                programmsToClose.Items.Add(process.ProcessName + "-" + process.Id);
            }
        }

        bool openOrClose;

        private void SelectFile(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = dialog.FileName;
            }
        }

        private bool CompareDates(DateTime picker, DateTime time , int hours, int minutes, int seconds)
        {
            if (picker.Year <= time.Year && picker.Month <= time.Month && picker.Day <= time.Day && hours <= time.Hour && minutes <= time.Minute && seconds <= time.Second) return true;
            return false;
        }

        private void OpenProgrammInTime()
        {
            var hours = Convert.ToInt32(hoursText.Text);
            var minutes = Convert.ToInt32(minutesText.Text);
            var seconds = Convert.ToInt32(secondsText.Text);

            Open(dateTimePicker1.Value, textBox1.Text, hours,minutes,seconds, openOrClose);
        }

        private void Open(DateTime value, string programmName, int hours, int minutes, int seconds, bool openOrClose)
        {
            while (true)
            {
                if(CompareDates(value ,DateTime.Now,hours,minutes,seconds))
                {
                    Process myProc = new Process();
                    myProc.StartInfo.FileName = programmName;

                    if (openOrClose)
                    {
                        myProc.Start();
                        using (var writer = new StreamWriter("Info.txt", true))
                        {
                            string info = "Process with name " + myProc.ProcessName + " and Id = " + myProc.Id + " starts at " + DateTime.Now + "\r\n";
                            writer.WriteLine(info);
                        }
                        FillProgrammsToClose();
                    }
                    else
                    {
                        var splitedItem = programmsToClose.SelectedItem.ToString().Split('-');
                        var id = Convert.ToInt32(splitedItem[splitedItem.Length - 1]);
                        var process = Process.GetProcessById(id);
                        using (var writer = new StreamWriter("Info.txt", true))
                        {
                            string info = "Process with name " + process.ProcessName + " and Id = " + process.Id + " ends at " + DateTime.Now + "\n";
                            writer.WriteLine(info);                            
                        }
                        process.Kill();
                        FillProgrammsToClose();                        
                    }
                    break;
                }
            }            
        }

        private bool CheckDate()
        {
            int hours = 0, minutes = 0, seconds = 0;
            try
            {
                hours = Convert.ToInt32(hoursText.Text);
                minutes = Convert.ToInt32(minutesText.Text);
                seconds = Convert.ToInt32(secondsText.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Некорректный ввод времени!");
                return false;
            }
            if (hours < 0 || hours > 23 || minutes < 0 || minutes > 59 || seconds < 0 || seconds > 59) return false;
            return true;
        }

        private void StartTimeTrigger(object sender, EventArgs e)
        {
            if ((sender as Button).Text == "Запуск") openOrClose = true;
            else openOrClose = false;
            
            if (!CheckDate()) return;
            Thread thread = new Thread(OpenProgrammInTime)
            {
                IsBackground = false,
                Name = "Ождание запуска : " + textBox1.Text
            };
            thread.Start();
        }
    }
}
