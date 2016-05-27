using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

namespace Serialize_Lab
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            LoadAssemblies("HelicopterPlugin.dll");
        }


        private void LoadAssemblies(string asmName)
        {
            checkSumComboBox.SelectedIndex = 0;
            Assembly asm = Assembly.LoadFrom(asmName);
            AssemblyConfigurationAttribute atrDescr = (AssemblyConfigurationAttribute)AssemblyConfigurationAttribute.GetCustomAttribute(asm, typeof(AssemblyConfigurationAttribute));
            string[] config = atrDescr.Configuration.Split(' ');
            try
            {
                for (int i = 0; i < config.Length; i++)
                {
                    string[] configParametrs = config[i].Split('/');

                    if (configParametrs[1] == "C")
                    {
                        checkSumComboBox.Items.Add(configParametrs[0]);
                    }
                    else
                    {
                        fileNameTextEdit.Text = configParametrs[0];
                    }
                }
            }
            catch (IndexOutOfRangeException ex)
            {
            }
        }

        private void setSettingsButton_Click(object sender, EventArgs e)
        {
            try
            {

                System.IO.File.WriteAllText("settings.txt", fileNameTextEdit.Text + "\r\n" + Convert.ToString(checkSumComboBox.SelectedIndex));
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
            Close();
        }
    }
}
