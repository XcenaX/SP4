using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;


namespace ListView_Processes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeColumns();
            listProcesses.View = View.Details;
            listProcesses.GridLines = true;
            listProcesses.FullRowSelect = true;
            AddItem = new Action<int>(delegate (object item) {
                listProcesses.Items.Add(item as ListViewItem);
            });
            ReplaceItem = new Replace<int>(delegate (object item, int index) {
                listProcesses.Items[index]= item as ListViewItem;
            });
        }

        private delegate void Action<T>(object item);
        private delegate void Replace<T>(object item, int index);
        private Action<int> AddItem;
        private Replace<int> ReplaceItem;

        private void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(ShowInfoAboutProcesses))
            {
                IsBackground = true,
                Name = "Z UpdateProcesses"
            };
            thread.Start();            
        }

        private void InitializeColumns()
        {
            listProcesses.Columns.Add("Имя",-2,HorizontalAlignment.Left);
            listProcesses.Columns.Add("Id", -2, HorizontalAlignment.Left);
            listProcesses.Columns.Add("Пользователь", - 2, HorizontalAlignment.Left);
            listProcesses.Columns.Add("Приоритет", -2, HorizontalAlignment.Left);
            listProcesses.Columns.Add("Id Сессии", -2, HorizontalAlignment.Left);
            listProcesses.Columns.Add("Подпись", -2, HorizontalAlignment.Left);
        }

        private void ShowInfoAboutProcesses()
        {            
            
            var processes = Process.GetProcesses();
            if (listProcesses.Items.Count <= 0)
            {
                foreach (var process in processes)
                {
                    var item1 = new ListViewItem(process.ProcessName);
                    item1.SubItems.Add(process.Id.ToString());
                    item1.SubItems.Add(process.MachineName);
                    item1.SubItems.Add(process.BasePriority.ToString());
                    item1.SubItems.Add(process.SessionId.ToString());
                    item1.SubItems.Add(process.MainWindowTitle);

                    AddItem(item1);

                }
            }
            else
            {
                
                for(int i = 0; i < listProcesses.Items.Count; i++){
                    var item1 = new ListViewItem(listProcesses.Items[i].Text);
                    item1.SubItems.Add(listProcesses.Items[i].SubItems[1]);
                    item1.SubItems.Add(listProcesses.Items[i].SubItems[2]);
                    item1.SubItems.Add(listProcesses.Items[i].SubItems[3]);
                    item1.SubItems.Add(listProcesses.Items[i].SubItems[4]);
                    item1.SubItems.Add(listProcesses.Items[i].SubItems[5]);

                    ReplaceItem(item1,i);
                }
            }
        }

        private void TimeTriggerStart(object sender, EventArgs e)
        {
           

        }

        

        private void OpenNewForm(object sender, EventArgs e)
        {
            TimeTrigger form = new TimeTrigger();
            form.Show();
        }
    }
}
