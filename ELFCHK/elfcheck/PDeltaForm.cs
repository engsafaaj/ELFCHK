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
    public partial class PDeltaForm : DevExpress.XtraEditors.XtraUserControl
    {
        DBELFEntities db;
        StoryDefiniton tbstorydefinition;
        CenterOfMassDisplacmnet tbcenterofmassdiplacmnet;
        StoryForce tbsoryforces;
        StoryForce tbsoryforces1;
        TBPDelta tbdelta;
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
        double Uvalueup;
        double Uvaluedowun;
        double Vvalue;
        private string forceloadcase;
        private string displacmentloadcase;
        private string loaduxuy;

        public PDeltaForm(cSapModel sapModel, Main mainform)
        {
            InitializeComponent();
            db = new DBELFEntities();
            model = sapModel;
            main = mainform;
          
        }

        private void LoadStoryDefiniton()
        {

            gridControl2.DataSource = null;
            gridView1.Columns.Clear();
            ELFCHK.DBELFEntities dbContext = new ELFCHK.DBELFEntities();
            gridControl2.DataSource = dbContext.StoryDefinitons.ToList();
        }

        private void LoadStroyDisplacment()
        {
            gridControl2.DataSource = null;
            gridView1.Columns.Clear();
            ELFCHK.DBELFEntities dbContext = new ELFCHK.DBELFEntities();
            gridControl2.DataSource = dbContext.CenterOfMassDisplacmnets.ToList();


        }
        private void StoryForces()
        {
            gridControl2.DataSource = null;
            gridView1.Columns.Clear();
            ELFCHK.DBELFEntities dbContext = new ELFCHK.DBELFEntities();
            gridControl2.DataSource = dbContext.StoryForces.Where(x=>x.Location=="Bottom").ToList();


        }
        private void Pdelta()
        {
            gridControl2.DataSource = null;
            gridView1.Columns.Clear();
            ELFCHK.DBELFEntities dbContext = new ELFCHK.DBELFEntities();
            gridControl2.DataSource = dbContext.TBPDeltas.ToList();


        }


        // Get Center of Mass and Rigigdity Data
        private void GetStoryDefinitionsData()
        {
      
            try
            {
                // Center of Mass and Rigidy Table
                model.DatabaseTables.GetAllTables(ref NumberTables, ref TableKey1, ref TableName, ref ImportType, ref IsEmpty);
                model.DatabaseTables.GetTableForDisplayArray(TableKey1[815], ref FieldKeyList, " ", ref TableVersion, ref FieldsKeysIncluded, ref NumberRecords, ref TableData);
                state = true;
            }
            catch
            {
                state = false;
            }
        }

        // Get Grid Definition Grid lines Data
        private void GetDiaphragmCenterOfMassDisplacements()
        {
            try
            {
                // Grid Definitions Grid LinesData
                model.DatabaseTables.GetAllTables(ref NumberTables, ref TableKey1, ref TableName, ref ImportType, ref IsEmpty);
                model.DatabaseTables.GetTableForDisplayArray(TableKey1[206], ref FieldKeyList, " ", ref TableVersion, ref FieldsKeysIncluded, ref NumberRecords, ref TableData);
                state = true;
            }
            catch
            {
                state = false;
            }
        }
        // Get Grid Definition Grid lines Data
        private void GetSoryForcesData()
        {
            try
            {
                // Grid Definitions Grid LinesData
                model.DatabaseTables.GetAllTables(ref NumberTables, ref TableKey1, ref TableName, ref ImportType, ref IsEmpty);
                model.DatabaseTables.GetTableForDisplayArray(TableKey1[817], ref FieldKeyList, " ", ref TableVersion, ref FieldsKeysIncluded, ref NumberRecords, ref TableData);
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
                main.lb_statuse.Text = "Get Story Definitions Data..";
                await Task.Run(() => GetStoryDefinitionsData());
                main.lb_statuse.Text = "Add Story Definitions Data to DataBase..";
                await Task.Run(() => AddStoryDefinitionsData());
                main.lb_statuse.Text = "Get Diaphragm Center Of Mass Displacements Data..";
                await Task.Run(() => GetDiaphragmCenterOfMassDisplacements());
                main.lb_statuse.Text = "Add Diaphragm Center Of Mass Displacements Data..";
                await Task.Run(() => AddDiaphragmCenterOfMassDisplacementsData());
                main.lb_statuse.Text = "Get Story Forces Data..";
                await Task.Run(() => GetSoryForcesData());
                main.lb_statuse.Text = "Add Story Forces Data..";
                await Task.Run(() => AddSoryForcesData());
                StoryForces();
                LoadCase1();
                LoadCase2();

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
        }

      
    
        // Add Center of Mass and Rigidity Data
        private void AddStoryDefinitionsData()
        {
            try
            {
                for (i = 0; i < TableData.Length; i++)
                {
                    tbstorydefinition = new StoryDefiniton
                    {
                        Name = TableData[i=i+1],
                        Height = Convert.ToDouble(TableData[i = i + 1]),
                        Master_Story =TableData[i = i + 1],
                        Similar_To = TableData[i = i + 1],
                        Splice_Story = TableData[i = i + 1],
                        Color = TableData[i = i + 1],
                        Guid = TableData[i = i + 1],
                     
                    };
                    // Add data
                    db.StoryDefinitons.Add(tbstorydefinition);
                    // Save Data
                }
                db.SaveChanges();

                state = true;
            }
            catch (Exception ex) { state = false; }
        }


        // Add Grid Definitions Grid Lines Data
        private void AddDiaphragmCenterOfMassDisplacementsData()
        {
            try
            {
                for (i = 0; i < TableData.Length; i++)
                {
                    tbcenterofmassdiplacmnet = new CenterOfMassDisplacmnet
                    {
                        Story = TableData[i],
                        Diaphragm = TableData[i = i + 1],
                        Output_Case = TableData[i = i + 1],
                        Case_Type = TableData[i = i + 1],
                        Step_Type = TableData[i = i + 1],
                        UX = Convert.ToDouble(TableData[i = i + 1]),
                        UY = Convert.ToDouble(TableData[i = i + 1]),
                        RZ = Convert.ToDouble(TableData[i = i + 1]),
                        Point = Convert.ToInt32(TableData[i = i + 1]),
                        X = Convert.ToDouble(TableData[i = i + 1]),
                        Y = Convert.ToDouble(TableData[i = i + 1]),
                        Z = Convert.ToDouble(TableData[i = i + 1]),


                    };
                    // Add data
                    db.CenterOfMassDisplacmnets.Add(tbcenterofmassdiplacmnet);
                }
                // Save Data
                db.SaveChanges();
                state = true;
            }
            catch { state = false; }
        }

        private void AddSoryForcesData()
        {
            try
            {
                for (i = 0; i < TableData.Length; i++)
                {
                    tbsoryforces = new StoryForce
                    {
                        Story = TableData[i],
                        output_Case = TableData[i = i + 1],
                        Case_Type = TableData[i = i + 1],
                        Step_Type = TableData[i = i + 1],
                        Location = TableData[i = i + 1],
                        P = (Convert.ToDouble(TableData[i = i + 1]))/1000,
                        VX = (Convert.ToDouble(TableData[i = i + 1]))/1000,
                        VY = (Convert.ToDouble(TableData[i = i + 1]))/1000,
                        T = Convert.ToDouble(TableData[i = i + 1]),
                        MX = Convert.ToDouble(TableData[i = i + 1]),
                        MY= Convert.ToDouble(TableData[i = i + 1]),


                    };
                    // Add data
                    db.StoryForces.Add(tbsoryforces);
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
                var Cd = Properties.Settings.Default.Cd;
                var Ifactor = Properties.Settings.Default.I;
                var emax = 0.5 / Cd;
                if (emax > 0.25)
                {
                    emax = 0.25;
                }
                emax = Math.Round((double)emax, 3, MidpointRounding.ToEven);

                var storyID = db.StoryDefinitons.Select(x => x.ID).ToArray();
                var StoryForceID = db.StoryForces.Where(x => x.output_Case == forceloadcase && x.Location == "Bottom").Select(x => x.ID).ToArray();
                var StoryForceID1 = db.StoryForces.Where(x => x.output_Case == displacmentloadcase && x.Location == "Bottom").Select(x => x.ID).ToArray();
                var DisplacmentID = db.CenterOfMassDisplacmnets.Where(x=> x.Output_Case == displacmentloadcase).Select(x => x.ID).ToArray();

                tbsoryforces = new StoryForce();
                tbsoryforces1 = new StoryForce();
                tbcenterofmassdiplacmnet = new CenterOfMassDisplacmnet();
                tbstorydefinition = new StoryDefiniton();
                tbdelta = new TBPDelta();

                for (i = 0; i < storyID.Length; i++)
                {
                    var storyid = storyID[i];
                    var stroyforceid = StoryForceID[i];
                    var stroyforceid1 = StoryForceID1[i];
                    var storydisplacmentid = DisplacmentID[i];
                    tbstorydefinition = db.StoryDefinitons.Where(X => X.ID == storyid).FirstOrDefault();
                    tbsoryforces = db.StoryForces.Where(x => x.ID == stroyforceid).FirstOrDefault();
                    tbsoryforces1 = db.StoryForces.Where(x => x.ID == stroyforceid1).FirstOrDefault();
                    var j = i;
                    tbcenterofmassdiplacmnet = db.CenterOfMassDisplacmnets.Where(x => x.ID == storydisplacmentid).FirstOrDefault();

                    if (loaduxuy == "UX")
                    {
                        tbcenterofmassdiplacmnet = db.CenterOfMassDisplacmnets.Where(x => x.ID == storydisplacmentid).FirstOrDefault();
                        Uvalueup = (double)tbcenterofmassdiplacmnet.UX;
                        var storyid1 = DisplacmentID[j = j+ 1];
                        tbcenterofmassdiplacmnet = db.CenterOfMassDisplacmnets.Where(x => x.ID == storyid1).FirstOrDefault();
                        Uvaluedowun = (double)tbcenterofmassdiplacmnet.UX;
                        Vvalue = (double)tbsoryforces1.VX;
                    }
                    else
                    {
                        tbcenterofmassdiplacmnet = db.CenterOfMassDisplacmnets.Where(x => x.ID == storydisplacmentid).FirstOrDefault();
                        Uvalueup = (double)tbcenterofmassdiplacmnet.UY;
                        var storyid1 = DisplacmentID[j = j + 1];
                        tbcenterofmassdiplacmnet = db.CenterOfMassDisplacmnets.Where(x => x.ID == storyid1).FirstOrDefault();
                        Uvaluedowun = (double)tbcenterofmassdiplacmnet.UY;
                        Vvalue = (double)tbsoryforces1.VY;

                    }

                    // find Delta value
                    var delta = (Uvalueup - Uvaluedowun) * (Cd / Ifactor);
                    delta = Math.Round((double)delta, 4, MidpointRounding.ToEven);

                    var deltaP = delta * tbsoryforces.P;
                    if (deltaP < 0)
                    {
                        deltaP = deltaP * -1;
                    }
                    if (Vvalue < 0)
                    {
                        Vvalue = Vvalue * -1;
                    }
                    //  Find Theta Value
                    var Height = tbstorydefinition.Height;
                    var Theta = deltaP / (Cd * Height * Vvalue);
                    // Set Data
                    Theta = Math.Round((double)Theta, 4, MidpointRounding.ToEven);
                    tbdelta.Story = tbstorydefinition.Name;
                    tbdelta.H = tbstorydefinition.Height;
                    tbdelta.P = tbsoryforces.P;
                    tbdelta.V = Vvalue;
                    tbdelta.U = Uvalueup;
                    tbdelta.Delta = delta;
                    tbdelta.Theta = Theta;
                    tbdelta.Theta_Max = emax;
                    // Check State
                    if (Theta > 0.25)
                    {
                        tbdelta.State = "Redsign";
                    }
                    else if (Theta > emax)
                    {
                        tbdelta.State = "Redsign";

                    }
                    else if (Theta <= 0.1)
                    {
                        tbdelta.State = "No p-delta";

                    }
                    else 
                    {
                        tbdelta.State = "p-delta";

                    }


                    // Add data
                    db.TBPDeltas.Add(tbdelta);
                    db.SaveChanges();

                }
                // Save Data
                state = true;
            }
            catch (Exception EX) { state = false; }
        }

        // Delete Old Data for Center of Mass and Grid Def
        private void DeletOldData()
        {
            try
            {
                db = new DBELFEntities();
                db.StoryDefinitons.RemoveRange(db.StoryDefinitons);
                db.CenterOfMassDisplacmnets.RemoveRange(db.CenterOfMassDisplacmnets);
                db.StoryForces.RemoveRange(db.StoryForces);
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
                db.TBPDeltas.RemoveRange(db.TBPDeltas);
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

                MessageBox.Show("Data Deleted successfully", "ELFCHK", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }


        // btn check data void
        private async void btn_check_Click(object sender, EventArgs e)
        {
            // Get Data
            forceloadcase = combo_loadcase.SelectedItem.ToString();
            displacmentloadcase = combo_loaddisplacmnet.SelectedItem.ToString();
            loaduxuy = load_uxuy.SelectedItem.ToString();
            main.lb_statuse.Text = "Clear old data..";
            main.progressbar.Visible = true;
            await Task.Run(() => DeleteOldEccData());
            main.lb_statuse.Text = "Check P-Delta Data";
            await Task.Run(() => CheckData());


            if (state == true)
            {
                main.lb_statuse.Text = "Data Checked successfully";
                main.progressbar.Visible = true;
                Pdelta();
            }
            else
            {
                main.lb_statuse.Text = "Data Checked successfully";
                main.progressbar.Visible = true;
                Pdelta();

            }
            main.progressbar.Visible = false;


            FieldKeyList = null;
            FieldsKeysIncluded = null;
            TableData = null;
            TableKey1 = null;
            TableName = null;
            ImportType = null;
            IsEmpty = null;
            gridControl2.BringToFront();
            combo_selectTable.BringToFront();
        }

        // btn save data // re save data
        private void btn_save_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
            MessageBox.Show("Data saved successfully","Data Saved",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        // Combo Select Table to show it
        private void combo_selectTable_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (combo_selectTable.SelectedIndex == 0)
            {
                LoadStoryDefiniton();
            }
            else if (combo_selectTable.SelectedIndex == 1)
            {
                LoadStroyDisplacment();

            }
            else if (combo_selectTable.SelectedIndex == 2)
            {
                StoryForces();

            }
            else if (combo_selectTable.SelectedIndex == 3)
            {
                Pdelta();
            }

        }

        // Ecc Load form event
        private void EccentricityForm_Load(object sender, EventArgs e)
        {
            LoadCase1();
            LoadCase2();
            load_uxuy.SelectedIndex = 0;
            combo_selectTable.SelectedIndex = 3;
            
        }

        // Print view
        private void btn_print_Click(object sender, EventArgs e)
        {
            if (combo_selectTable.SelectedIndex==0)
            {

            }
            else
            {
                gridControl2.ShowPrintPreview();

            }
        }

        // SEt cond 
        private void SetConditionalFormatting()
        {
            DevExpress.XtraGrid.StyleFormatCondition condition = new DevExpress.XtraGrid.StyleFormatCondition();
            //gridView2.FormatConditions.Add()
        }

        private void LoadCase1()
        {
            try
            {

                db = new DBELFEntities();
                var loadcase = db.CenterOfMassDisplacmnets.Select(X => X.Output_Case).ToList();
                combo_loadcase.DataSource = loadcase;
                AutoCompleteStringCollection autoCompleteString = new AutoCompleteStringCollection();
                autoCompleteString.AddRange(loadcase.ToArray());
                combo_loadcase.AutoCompleteCustomSource = autoCompleteString;
            }
            catch { }
        }
        private void LoadCase2()
        {
            try
            {

                db = new DBELFEntities();
                var loadcase = db.CenterOfMassDisplacmnets.Select(X => X.Output_Case).ToList();
                combo_loaddisplacmnet.DataSource = loadcase;
                AutoCompleteStringCollection autoCompleteString = new AutoCompleteStringCollection();
                autoCompleteString.AddRange(loadcase.ToArray());
                combo_loaddisplacmnet.AutoCompleteCustomSource = autoCompleteString;
            }
            catch { }
        }

        private void combo_loadcase_SelectedIndexChanged(object sender, EventArgs e)
        {
            var outputcase = combo_loadcase.SelectedItem.ToString();
            gridControl2.DataSource = null;
            gridView1.Columns.Clear();
            ELFCHK.DBELFEntities dbContext = new ELFCHK.DBELFEntities();
            gridControl2.DataSource = dbContext.StoryForces.Where(x => x.Location == "Bottom" &&x.output_Case== outputcase).ToList();
        }

        private void combo_loaddisplacmnet_SelectedIndexChanged(object sender, EventArgs e)
        {
            var outputcase = combo_loaddisplacmnet.SelectedItem.ToString();
            gridControl2.DataSource = null;
            gridView1.Columns.Clear();
            ELFCHK.DBELFEntities dbContext = new ELFCHK.DBELFEntities();
            gridControl2.DataSource = dbContext.CenterOfMassDisplacmnets.Where( x=> x.Output_Case == outputcase).ToList();
        }
    }
}
