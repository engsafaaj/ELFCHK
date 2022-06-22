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
    public partial class Main : DevExpress.XtraEditors.XtraForm
    {
        bool state;
        ETABSv1.cSapModel mySapModel;
        public Main()
        {
            InitializeComponent();
        }

        private async void btn_openedbfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "EDB File (*.EDB)|*.EDB";
           var rs= openFileDialog.ShowDialog();
            if (rs == DialogResult.OK)
            {
                // Open EDB File
                lb_statuse.Text = "Open EDB File..";
                progressbar.Visible = true;
                await Task.Run(() => OpenEDBFile(openFileDialog));
                if (state == true)
                {
                    this.Text ="ELFCHK | "+  mySapModel.GetModelFilename(false);
                    lb_statuse.Text = "ETABS model initialize successfuly";
                    progressbar.Visible = false;
                    btn_drift.Enabled = true;
                    btn_eccentricity.Enabled = true;
                    btn_irreqularity.Enabled = true;
                    btn_pdelta.Enabled = true;


                }
                else
                {
                    progressbar.Visible = false;
                    MessageBox.Show("Model initialization failed");
                    lb_statuse.Text = "Model initialization failed";

                }


            }
            HomePage page = new HomePage();
            SetView(page);
        }

        private void OpenEDBFile(OpenFileDialog openFileDialog)
        {
            //set the following flag to true to attach to an existing instance of the program 
            //otherwise a new instance of the program will be started 
            bool AttachToInstance;
            AttachToInstance = false;

            //set the following flag to true to manually specify the path to ETABS.exe
            //this allows for a connection to a version of ETABS other than the latest installation
            //otherwise the latest installed version of ETABS will be launched
            bool SpecifyPath;
            SpecifyPath = false;

            //if the above flag is set to true, specify the path to ETABS below
            string ProgramPath;
            ProgramPath = @"C:\Program Files\Computers and Structures\ETABS 19\ETABS.exe";

           
            string ModelName = openFileDialog.FileName;
            string ModelPath = ModelName;

            //dimension the ETABS Object as cOAPI type
            ETABSv1.cOAPI myETABSObject = null;

            //Use ret to check if functions return successfully (ret = 0) or fail (ret = nonzero) 
            int ret = 0;

            //create API helper object
            ETABSv1.cHelper myHelper;
            try
            {
                myHelper = new ETABSv1.Helper();
            }
            catch (Exception ex)
            {
                return;
            }

            if (AttachToInstance)
            {
                //attach to a running instance of ETABS 
                try
                {
                    //get the active ETABS object
                    myETABSObject = myHelper.GetObject("CSI.ETABS.API.ETABSObject");
                }
                catch (Exception ex)
                {
                    return;
                }
            }
            else
            {
                if (SpecifyPath)
                {
                    //'create an instance of the ETABS object from the specified path
                    try
                    {
                        //create ETABS object
                        myETABSObject = myHelper.CreateObject(ProgramPath);
                    }
                    catch (Exception ex)
                    {
                        return;
                    }
                }
                else
                {
                    //'create an instance of the ETABS object from the latest installed ETABS
                    try
                    {
                        //create ETABS object
                        myETABSObject = myHelper.CreateObjectProgID("CSI.ETABS.API.ETABSObject");
                    }
                    catch (Exception ex)
                    {
                        return;
                    }
                }
                //start ETABS application
                ret = myETABSObject.ApplicationStart();
            }

            //Get a reference to cSapModel to access all API classes and functions
            mySapModel = default(ETABSv1.cSapModel);
            mySapModel = myETABSObject.SapModel;

            //Initialize model
            ret = mySapModel.File.OpenFile(openFileDialog.FileName);

            if (ret == 0)
            {
                state = true;
            }
            else
            {
                state = false;
            }

        
          
        }


        private void SetView(DevExpress.XtraEditors.XtraUserControl page)
        {
            try
            {
                var ExiPage = pn_container.Controls.OfType<DevExpress.XtraEditors.XtraUserControl>().FirstOrDefault();
                if (ExiPage !=null)
                {
                    pn_container.Controls.Remove(ExiPage);
                    ExiPage.Dispose();        
                }
                page.Dock = DockStyle.Fill;
                pn_container.Controls.Add(page);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_eccentricity_Click(object sender, EventArgs e)
        {
            elfcheck.EccentricityForm eccentricity = new elfcheck.EccentricityForm(mySapModel,this);
            SetView(eccentricity);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            HomePage page = new HomePage();
            SetView(page);
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Show();
        }

        public void btn_pdelta_Click(object sender, EventArgs e)
        {
            elfcheck.PDeltaForm eccentricity = new elfcheck.PDeltaForm(mySapModel, this);
            SetView(eccentricity);
        }
    }
}

