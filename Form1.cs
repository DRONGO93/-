using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.ServiceProcess;

namespace Настройщик_ПК
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // <summary> Загрузка фармы. </summary>
        public void LoadFormMainWindow(object sender, EventArgs e)
        {
            // <summary> Заполнение списка служб. </summary>
            try
            {
                RegistryKey rk = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services");
                String[] names = rk.GetSubKeyNames();
                for (int i = 0; i < names.Length; i++)
                {
                    CheckedListRegistryKey.Items.Add(names[i]);
                }
                rk.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            // <summary> Заполнение СomboBox. </summary>
            СomboBox.Items.Add(1); СomboBox.Items.Add(2); СomboBox.Items.Add(3); СomboBox.Items.Add(4); СomboBox.Items.Add(" ");
        }

        private void ButtonRunService_Click(object sender, EventArgs e)
        {
            ButtonRunService.Enabled = false;
            ServiceRunStop(false);
            ButtonRunService.Enabled = true;
        }

        private void ButtonStopService_Click(object sender, EventArgs e)
        {
            ButtonStopService.Enabled = false;
            ServiceRunStop(true);
            ButtonStopService.Enabled = true;
        }
        // <summary> Реализация запуска и остановки службы. </summary>
        public void ServiceRunStop(bool Choice)
        {
            try
            {
                foreach (string Serv in CheckedListRegistryKey.CheckedItems)
                {
                    ServiceController service = new ServiceController(Serv);
                    if (Choice == false)
                    {
                        if (service.Status != ServiceControllerStatus.Running)
                        {
                            service.Start();
                            service.WaitForStatus(ServiceControllerStatus.Running, TimeSpan.FromMinutes(1));
                        }
                        else { }
                    }

                    if (Choice == true)
                    {
                        if (service.Status == ServiceControllerStatus.Running)
                        {
                            service.Stop();
                            service.WaitForStatus(ServiceControllerStatus.Running, TimeSpan.FromMinutes(1));
                        }
                        else { }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Что-то совсем пошло не так." + ex);
            }
        }
    }
}
