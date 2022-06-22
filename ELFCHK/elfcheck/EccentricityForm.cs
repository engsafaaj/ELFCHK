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
using ETABSv1;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using DevExpress.XtraGrid.Views.Grid;

namespace ELFCHK.elfcheck
{
    public partial class EccentricityForm : DevExpress.XtraEditors.XtraUserControl
    {
        DBELFEntities db;
        TBEccentricity tbaddcenterofmassdata;
        Eccentricity tbeccentricity;
        GridDefinitionsGridLinesData Tbgridline;
        cSapModel model;
        Main main;
        bool state;
        string[] FieldKeyList;
        int TableVersion;
        string[] FieldsKeysIncluded;
        int NumberRecords;
        string[] TableData;
        int i;
        int NumberTables;
        string[] TableKey1;
        string[] TableName;
        int[] ImportType;
        bool[] IsEmpty ;

        public EccentricityForm(cSapModel sapModel, Main mainform)
        {
            InitializeComponent();
            db = new DBELFEntities();
            model = sapModel;
            main = mainform;
            LoadData();
            LoadData2();
        }
        // Load Center of Mass Data
        private void LoadData()
        {
          
            db = new ELFCHK.DBELFEntities();
            db.TBEccentricities.LoadAsync().ContinueWith(loadTask =>
            {
                tBEccentricitiesBindingSource1.DataSource = db.TBEccentricities.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }
        // Load Ecc Data
        private void LoadData2()
        {

            ELFCHK.DBELFEntities dbContext = new ELFCHK.DBELFEntities();
            dbContext.Eccentricities.LoadAsync().ContinueWith(loadTask =>
            {
                gridControl2.DataSource = dbContext.Eccentricities.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }
       

        // Get Center of Mass and Rigigdity Data
        private void GetCentersOfMassAndRigidityData()
        {
      
            try
            {
                // Center of Mass and Rigidy Table
                model.DatabaseTables.GetAllTables(ref NumberTables, ref TableKey1, ref TableName, ref ImportType, ref IsEmpty);
                model.DatabaseTables.GetTableForDisplayArray(TableKey1[48], ref FieldKeyList, " ", ref TableVersion, ref FieldsKeysIncluded, ref NumberRecords, ref TableData);
                state = true;
            }
            catch
            {
                state = false;
            }
        }

        // Get Grid Definition Grid lines Data
        private void GridDefinitionsGridLinesData()
        {
            try
            {
                // Grid Definitions Grid LinesData
                model.DatabaseTables.GetAllTables(ref NumberTables, ref TableKey1, ref TableName, ref ImportType, ref IsEmpty);
                model.DatabaseTables.GetTableForDisplayArray(TableKey1[405], ref FieldKeyList, " ", ref TableVersion, ref FieldsKeysIncluded, ref NumberRecords, ref TableData);
                state = true;
            }
            catch
            {
                state = false;
            }
        }
        // btn get data void
        private async void btn_getdata_Click(object sender, EventArgs e)
        {
            if (model != null)
            {
                // Get Data
                main.lb_statuse.Text = "Remove Old Data...";
                main.progressbar.Visible = true;
                await Task.Run(() => DeletOldData());
                main.lb_statuse.Text = "Get Centers Of Mass And Rigidity Data..";
                await Task.Run(() => GetCentersOfMassAndRigidityData());
                main.lb_statuse.Text = "Add Centers Of Mass And Rigidity Data to DataBase..";
                await Task.Run(() => AddCentersOfMassAndRigidityData());
                main.lb_statuse.Text = "Get Grid Definitions Grid Lines Data..";
                await Task.Run(() => GridDefinitionsGridLinesData());
                main.lb_statuse.Text = "Add Grid Definitions Grid Lines Data to DataBase..";
                await Task.Run(() => AddGridDefinitionsGridLinesData());
                main.lb_statuse.Text = "Add Dx & Dy Data to Table ..";
                await Task.Run(() => AddDxDyData());
                if (state == true)
                {
                    main.lb_statuse.Text = "Data imported successfully";
                    main.progressbar.Visible = true;
                }
                else
                {
                    main.progressbar.Visible = false;

                    MessageBox.Show("Can not Get Data From ETABS Model","ELFCHK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                main.progressbar.Visible = false;

                LoadData();

                FieldKeyList = null;
                FieldsKeysIncluded = null;
                TableData = null;
                TableKey1 = null;
                TableName = null;
                ImportType = null;
                IsEmpty = null;
            }
            else
            {
                MessageBox.Show("Open Etabs model first !","ELFCHK",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            gridControl1.BringToFront();
        }

      
    
        // Add Center of Mass and Rigidity Data
        private void AddCentersOfMassAndRigidityData()
        {
            try
            {
                for (i = 0; i < TableData.Length; i++)
                {
                    tbaddcenterofmassdata = new TBEccentricity
                    {
                        Story = TableData[i],
                        Diaphragm = TableData[i = i + 1],
                        MassX = (Convert.ToDouble(TableData[i = i + 1]))*1000,
                        MassY = (Convert.ToDouble(TableData[i = i + 1]))*1000,
                        XCM = (Convert.ToDouble(TableData[i = i + 1]))/1000,
                        YCM = (Convert.ToDouble(TableData[i = i + 1]))/ 1000,
                        CummX = (Convert.ToDouble(TableData[i = i + 1]))*1000,
                        CummY = (Convert.ToDouble(TableData[i = i + 1]))*1000,
                        XCCM = (Convert.ToDouble(TableData[i = i + 1]))/ 1000,
                        YCCM = (Convert.ToDouble(TableData[i = i + 1]))/ 1000,
                        XCR = (Convert.ToDouble(TableData[i = i + 1]))/ 1000,
                        YCR = (Convert.ToDouble(TableData[i = i + 1]))/ 1000,
                    };
                    // Add data
                    db.TBEccentricities.Add(tbaddcenterofmassdata);
                }
                // Save Data
                db.SaveChanges();
                state = true;
            }
            catch { state = false; }
        }


        // Add Grid Definitions Grid Lines Data
        private void AddGridDefinitionsGridLinesData()
        {
            try
            {
                for (i = 0; i < TableData.Length; i++)
                {
                    Tbgridline = new GridDefinitionsGridLinesData
                    {
                        Name = TableData[i],
                        Grid_Line_Type = TableData[i = i + 1],
                        IDT = (TableData[i = i + 1]),
                        Ordinate = (Convert.ToDouble(TableData[i = i + 1]))/1000,
                        Bubble_Location =(TableData[i = i + 1]),
                        Visible = (TableData[i = i + 1]),
                    };
                    // Add data
                    db.GridDefinitionsGridLinesDatas.Add(Tbgridline);
                }
                // Save Data
                db.SaveChanges();
                state = true;
            }
            catch { state = false; }
        }

        // Add Dx and Dy Data
        private void AddDxDyData()
        {
            try
            {
                db = new DBELFEntities();
                tbaddcenterofmassdata = new TBEccentricity();
                var datlist = db.TBEccentricities.Select(x => x.ID).ToArray();
                var Dx = db.GridDefinitionsGridLinesDatas.Where(x => x.Grid_Line_Type == "X (Cartesian)").Select(x => x.Ordinate).ToArray();
                var Dy = db.GridDefinitionsGridLinesDatas.Where(x => x.Grid_Line_Type == "Y (Cartesian)").Select(x => x.Ordinate).ToArray();

                for (i = 0; i < datlist.Length; i++)
                {
                    var id = datlist[i];
                    tbaddcenterofmassdata = db.TBEccentricities.Where(x => x.ID == id).FirstOrDefault();
                    tbaddcenterofmassdata.Dx = Dx.Max();
                    tbaddcenterofmassdata.Dy = Dy.Max();
                    db.Set<TBEccentricity>().AddOrUpdate(tbaddcenterofmassdata);
                }
                // Save Data
                db.SaveChanges();
                state = true;
            }
            catch { state = false; }
        }

        // Check Data 
        private void CheckData()
        {
            try
            {
                db = new DBELFEntities();
                var EccP = Properties.Settings.Default.EccentricitiesvValue;
                var datlist = db.TBEccentricities.Select(x => x.ID).ToArray();
                tbeccentricity = new Eccentricity();
                for (i = 0; i < datlist.Length; i++)
                {
                    var id = datlist[i];
                    tbaddcenterofmassdata = db.TBEccentricities.Where(x => x.ID == id).FirstOrDefault();
                    var ex =Math.Round((double)(tbaddcenterofmassdata.XCM - tbaddcenterofmassdata.XCR),2,MidpointRounding.ToEven);
                    var ey=Math.Round((double)(tbaddcenterofmassdata.YCM - tbaddcenterofmassdata.YCR),3,MidpointRounding.ToEven);
                    tbeccentricity.Dx = tbaddcenterofmassdata.Dx;
                    tbeccentricity.Dy = tbaddcenterofmassdata.Dy;
                    tbeccentricity.Story = tbaddcenterofmassdata.Story;
                    if (ex < 0)
                    {
                        ex = ex * -1;
                    }
                    if (ey < 0)
                    {
                        ey = ey * -1;
                    }
                    tbeccentricity.ex = ex;
                    tbeccentricity.ey = ey;
                    var ExP =Math.Round((double)(( ex / tbaddcenterofmassdata.Dx)*100), 3,MidpointRounding.ToEven);
                    var EyP =Math.Round((double)((ey / tbaddcenterofmassdata.Dy)*100), 3,MidpointRounding.ToEven);
                    tbeccentricity.exResult = ExP;
                    tbeccentricity.eyResult = EyP;
                    if(ExP<= EccP)
                    {
                        tbeccentricity.exState = "OK";
                    }
                    else
                    {
                        tbeccentricity.exState = "Not ok";

                    }
                    if (EyP <= EccP)
                    {
                        tbeccentricity.eyState = "OK";
                    }
                    else
                    {
                        tbeccentricity.eyState = "Not ok";

                    }

                    // Add data
                    db.Eccentricities.Add(tbeccentricity);
                    db.SaveChanges();

                }
                // Save Data
                state = true;
            }
            catch { state = false; }
        }

        // Delete Old Data for Center of Mass and Grid Def
        private void DeletOldData()
        {
            try
            {
                db = new DBELFEntities();
                db.TBEccentricities.RemoveRange(db.TBEccentricities);
                db.GridDefinitionsGridLinesDatas.RemoveRange(db.GridDefinitionsGridLinesDatas);
                db.SaveChanges();
            }
            catch { }
        }

        // Delete Ecc Data
        private void DeleteOldEccData()
        {
            try
            {
                db = new DBELFEntities();
                db.Eccentricities.RemoveRange(db.Eccentricities);
                db.SaveChanges();
            }
            catch { }
        }

        // btn clear void
        // Clear all data
        private async void btn_clear_Click(object sender, EventArgs e)
        {
            var rs = MessageBox.Show("Are you sure clear all data !", "Delete Action", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                // Get Data
                main.lb_statuse.Text = "Remove Old Data...";
                main.progressbar.Visible = true;
                await Task.Run(() => DeletOldData());
                await Task.Run(() => DeleteOldEccData());
                main.lb_statuse.Text = "Ready";
                main.progressbar.Visible = false;
                LoadData();

                gridControl1.BringToFront();
                MessageBox.Show("Data Deleted successfully", "ELFCHK", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }


        // btn check data void
        private async void btn_check_Click(object sender, EventArgs e)
        {
            // Get Data
            main.lb_statuse.Text = "Clear old data..";
            main.progressbar.Visible = true;
            await Task.Run(() => DeleteOldEccData());
            main.lb_statuse.Text = "Check Data";
            await Task.Run(() => CheckData());


            if (state == true)
            {
                main.lb_statuse.Text = "Data Checked successfully";
                main.progressbar.Visible = true;
            }
            else
            {
                main.progressbar.Visible = false;

                MessageBox.Show("Make sure  analyze the project", "Can not Check Data", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            main.progressbar.Visible = false;

            LoadData();

            FieldKeyList = null;
            FieldsKeysIncluded = null;
            TableData = null;
            TableKey1 = null;
            TableName = null;
            ImportType = null;
            IsEmpty = null;
            gridControl2.BringToFront();
            LoadData2();
        }

        // btn save data // re save data
        private void btn_save_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
            MessageBox.Show("Data saved successfully","Data Saved",MessageBoxButtons.OK,MessageBoxIcon.Information);
            LoadData();

        }

        // Combo Select Table to show it
        private void combo_selectTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_selectTable.SelectedIndex == 0)
            {
                LoadData();
                gridControl1.BringToFront();
            }
            else if (combo_selectTable.SelectedIndex == 1)
            {
                LoadData2();
                gridControl2.BringToFront();

            }
         
        }

        // Ecc Load form event
        private void EccentricityForm_Load(object sender, EventArgs e)
        {
            combo_selectTable.SelectedIndex = 0;
        }

        // Print view
        private void btn_print_Click(object sender, EventArgs e)
        {
            if (combo_selectTable.SelectedIndex==0)
            {
                gridControl1.ShowPrintPreview();

            }
            else
            {
                gridControl2.ShowPrintPreview();

            }
        }

       
    }
}
