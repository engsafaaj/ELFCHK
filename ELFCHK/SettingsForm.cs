using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELFCHK
{
    public partial class SettingsForm : DevExpress.XtraEditors.XtraForm
    {
        public SettingsForm()
        {
            InitializeComponent();
        }


        private void GetData()
        {
            try
            {
                edt_eccentrcityvalue.Text = Properties.Settings.Default.EccentricitiesvValue.ToString();
                edt_cd.Text = Properties.Settings.Default.Cd.ToString();
                edt_ie.Text = Properties.Settings.Default.I.ToString();
            }
            catch { }
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void SaveData()
        {
            try
            {
                Properties.Settings.Default.EccentricitiesvValue =Convert.ToDouble( edt_eccentrcityvalue.Text);
                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show( "Data Saved Successfuly", "Data Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void tabNavigationPage2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_savepdelta_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.Cd = Convert.ToDouble(edt_cd.Text);
                Properties.Settings.Default.I = Convert.ToDouble(edt_ie.Text);
                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Data Saved Successfuly", "Data Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    }

