
namespace ELFCHK.elfcheck
{
    partial class EccentricityForm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EccentricityForm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.combo_selectTable = new System.Windows.Forms.ComboBox();
            this.btn_check = new DevExpress.XtraEditors.SimpleButton();
            this.btn_save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_print = new DevExpress.XtraEditors.SimpleButton();
            this.btn_clear = new DevExpress.XtraEditors.SimpleButton();
            this.btn_getdata = new DevExpress.XtraEditors.SimpleButton();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colStory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaphragm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMassX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMassY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXCM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYCM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCummX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCummY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXCCM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYCCM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXCR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYCR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDx = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tBEccentricitiesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tBEccentricitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colStory1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDx1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colexResult = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colexState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDy1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coley = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coleyResult = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coleyState = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBEccentricitiesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBEccentricitiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.combo_selectTable);
            this.panelControl1.Controls.Add(this.btn_check);
            this.panelControl1.Controls.Add(this.btn_save);
            this.panelControl1.Controls.Add(this.btn_print);
            this.panelControl1.Controls.Add(this.btn_clear);
            this.panelControl1.Controls.Add(this.btn_getdata);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 621);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1159, 100);
            this.panelControl1.TabIndex = 0;
            // 
            // combo_selectTable
            // 
            this.combo_selectTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.combo_selectTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_selectTable.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_selectTable.FormattingEnabled = true;
            this.combo_selectTable.Items.AddRange(new object[] {
            "Centers Of Mass And Rigidity Data",
            "Eccentricity Results"});
            this.combo_selectTable.Location = new System.Drawing.Point(783, 44);
            this.combo_selectTable.Name = "combo_selectTable";
            this.combo_selectTable.Size = new System.Drawing.Size(371, 32);
            this.combo_selectTable.TabIndex = 2;
            this.combo_selectTable.SelectedIndexChanged += new System.EventHandler(this.combo_selectTable_SelectedIndexChanged);
            // 
            // btn_check
            // 
            this.btn_check.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_check.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_check.ImageOptions.SvgImage")));
            this.btn_check.Location = new System.Drawing.Point(161, 15);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(147, 75);
            this.btn_check.TabIndex = 0;
            this.btn_check.Text = "Check";
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // btn_save
            // 
            this.btn_save.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_save.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_save.ImageOptions.SvgImage")));
            this.btn_save.Location = new System.Drawing.Point(314, 15);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(147, 75);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "Save changes";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_print
            // 
            this.btn_print.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_print.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_print.ImageOptions.SvgImage")));
            this.btn_print.Location = new System.Drawing.Point(620, 15);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(147, 75);
            this.btn_print.TabIndex = 0;
            this.btn_print.Text = "Print ";
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_clear.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_clear.ImageOptions.SvgImage")));
            this.btn_clear.Location = new System.Drawing.Point(467, 15);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(147, 75);
            this.btn_clear.TabIndex = 0;
            this.btn_clear.Text = "Clear Data";
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_getdata
            // 
            this.btn_getdata.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_getdata.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_getdata.ImageOptions.SvgImage")));
            this.btn_getdata.Location = new System.Drawing.Point(8, 15);
            this.btn_getdata.Name = "btn_getdata";
            this.btn_getdata.Size = new System.Drawing.Size(147, 75);
            this.btn_getdata.TabIndex = 0;
            this.btn_getdata.Text = "Get Data From Etabs";
            this.btn_getdata.Click += new System.EventHandler(this.btn_getdata_Click);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridView1.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseTextOptions = true;
            this.gridView1.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.ColumnFilterButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.ColumnFilterButtonActive.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseFont = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseTextOptions = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.ColumnFilterButtonActive.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridView1.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.gridView1.Appearance.CustomizationFormHint.Options.UseTextOptions = true;
            this.gridView1.Appearance.CustomizationFormHint.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.CustomizationFormHint.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.DetailTip.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridView1.Appearance.DetailTip.Options.UseFont = true;
            this.gridView1.Appearance.DetailTip.Options.UseTextOptions = true;
            this.gridView1.Appearance.DetailTip.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.DetailTip.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.Empty.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridView1.Appearance.Empty.Options.UseFont = true;
            this.gridView1.Appearance.Empty.Options.UseTextOptions = true;
            this.gridView1.Appearance.Empty.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Empty.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.EvenRow.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridView1.Appearance.EvenRow.Options.UseFont = true;
            this.gridView1.Appearance.EvenRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.EvenRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.FilterCloseButton.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridView1.Appearance.FilterCloseButton.Options.UseFont = true;
            this.gridView1.Appearance.FilterCloseButton.Options.UseTextOptions = true;
            this.gridView1.Appearance.FilterCloseButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FilterCloseButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.FilterPanel.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridView1.Appearance.FilterPanel.Options.UseFont = true;
            this.gridView1.Appearance.FilterPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FilterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.FixedLine.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridView1.Appearance.FixedLine.Options.UseFont = true;
            this.gridView1.Appearance.FixedLine.Options.UseTextOptions = true;
            this.gridView1.Appearance.FixedLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FixedLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridView1.Appearance.FocusedCell.Options.UseFont = true;
            this.gridView1.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.gridView1.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridView1.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView1.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FocusedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridView1.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView1.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FooterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.GroupButton.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridView1.Appearance.GroupButton.Options.UseFont = true;
            this.gridView1.Appearance.GroupButton.Options.UseTextOptions = true;
            this.gridView1.Appearance.GroupButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.GroupButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridView1.Appearance.GroupFooter.Options.UseFont = true;
            this.gridView1.Appearance.GroupFooter.Options.UseTextOptions = true;
            this.gridView1.Appearance.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.GroupFooter.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridView1.Appearance.GroupPanel.Options.UseFont = true;
            this.gridView1.Appearance.GroupPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.GroupPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridView1.Appearance.GroupRow.Options.UseFont = true;
            this.gridView1.Appearance.GroupRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridView1.Appearance.HideSelectionRow.Options.UseFont = true;
            this.gridView1.Appearance.HideSelectionRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.HideSelectionRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HideSelectionRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.HorzLine.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridView1.Appearance.HorzLine.Options.UseFont = true;
            this.gridView1.Appearance.HorzLine.Options.UseTextOptions = true;
            this.gridView1.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HorzLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.HotTrackedRow.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridView1.Appearance.HotTrackedRow.Options.UseFont = true;
            this.gridView1.Appearance.HotTrackedRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.HotTrackedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HotTrackedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.OddRow.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridView1.Appearance.OddRow.Options.UseFont = true;
            this.gridView1.Appearance.OddRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.OddRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.Preview.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridView1.Appearance.Preview.Options.UseFont = true;
            this.gridView1.Appearance.Preview.Options.UseTextOptions = true;
            this.gridView1.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Preview.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.Row.Options.UseTextOptions = true;
            this.gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.RowSeparator.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridView1.Appearance.RowSeparator.Options.UseFont = true;
            this.gridView1.Appearance.RowSeparator.Options.UseTextOptions = true;
            this.gridView1.Appearance.RowSeparator.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.RowSeparator.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.SelectedRow.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridView1.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView1.Appearance.SelectedRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.SelectedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.TopNewRow.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridView1.Appearance.TopNewRow.Options.UseFont = true;
            this.gridView1.Appearance.TopNewRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.TopNewRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.VertLine.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridView1.Appearance.VertLine.Options.UseFont = true;
            this.gridView1.Appearance.VertLine.Options.UseTextOptions = true;
            this.gridView1.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.VertLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.ViewCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridView1.Appearance.ViewCaption.Options.UseFont = true;
            this.gridView1.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.gridView1.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.AppearancePrint.EvenRow.Options.UseTextOptions = true;
            this.gridView1.AppearancePrint.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.AppearancePrint.EvenRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.AppearancePrint.FilterPanel.Options.UseTextOptions = true;
            this.gridView1.AppearancePrint.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.AppearancePrint.FilterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.AppearancePrint.FooterPanel.Options.UseTextOptions = true;
            this.gridView1.AppearancePrint.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.AppearancePrint.FooterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.AppearancePrint.GroupFooter.Options.UseTextOptions = true;
            this.gridView1.AppearancePrint.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.AppearancePrint.GroupFooter.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.AppearancePrint.GroupRow.Options.UseTextOptions = true;
            this.gridView1.AppearancePrint.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.AppearancePrint.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.AppearancePrint.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.AppearancePrint.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.AppearancePrint.Lines.Options.UseTextOptions = true;
            this.gridView1.AppearancePrint.Lines.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.AppearancePrint.Lines.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.AppearancePrint.OddRow.Options.UseTextOptions = true;
            this.gridView1.AppearancePrint.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.AppearancePrint.OddRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.AppearancePrint.Preview.Options.UseTextOptions = true;
            this.gridView1.AppearancePrint.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.AppearancePrint.Preview.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.AppearancePrint.Row.Options.UseTextOptions = true;
            this.gridView1.AppearancePrint.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.AppearancePrint.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colStory,
            this.colDiaphragm,
            this.colMassX,
            this.colMassY,
            this.colXCM,
            this.colYCM,
            this.colCummX,
            this.colCummY,
            this.colXCCM,
            this.colYCCM,
            this.colXCR,
            this.colYCR,
            this.colDx,
            this.colDy});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsPrint.EnableAppearanceOddRow = true;
            // 
            // colStory
            // 
            this.colStory.FieldName = "Story";
            this.colStory.MinWidth = 25;
            this.colStory.Name = "colStory";
            this.colStory.Visible = true;
            this.colStory.VisibleIndex = 0;
            this.colStory.Width = 94;
            // 
            // colDiaphragm
            // 
            this.colDiaphragm.FieldName = "Diaphragm";
            this.colDiaphragm.MinWidth = 25;
            this.colDiaphragm.Name = "colDiaphragm";
            this.colDiaphragm.Visible = true;
            this.colDiaphragm.VisibleIndex = 1;
            this.colDiaphragm.Width = 94;
            // 
            // colMassX
            // 
            this.colMassX.FieldName = "MassX";
            this.colMassX.MinWidth = 25;
            this.colMassX.Name = "colMassX";
            this.colMassX.Visible = true;
            this.colMassX.VisibleIndex = 2;
            this.colMassX.Width = 94;
            // 
            // colMassY
            // 
            this.colMassY.FieldName = "MassY";
            this.colMassY.MinWidth = 25;
            this.colMassY.Name = "colMassY";
            this.colMassY.Visible = true;
            this.colMassY.VisibleIndex = 3;
            this.colMassY.Width = 94;
            // 
            // colXCM
            // 
            this.colXCM.FieldName = "XCM";
            this.colXCM.MinWidth = 25;
            this.colXCM.Name = "colXCM";
            this.colXCM.Visible = true;
            this.colXCM.VisibleIndex = 4;
            this.colXCM.Width = 94;
            // 
            // colYCM
            // 
            this.colYCM.FieldName = "YCM";
            this.colYCM.MinWidth = 25;
            this.colYCM.Name = "colYCM";
            this.colYCM.Visible = true;
            this.colYCM.VisibleIndex = 5;
            this.colYCM.Width = 94;
            // 
            // colCummX
            // 
            this.colCummX.FieldName = "CummX";
            this.colCummX.MinWidth = 25;
            this.colCummX.Name = "colCummX";
            this.colCummX.Visible = true;
            this.colCummX.VisibleIndex = 6;
            this.colCummX.Width = 94;
            // 
            // colCummY
            // 
            this.colCummY.FieldName = "CummY";
            this.colCummY.MinWidth = 25;
            this.colCummY.Name = "colCummY";
            this.colCummY.Visible = true;
            this.colCummY.VisibleIndex = 7;
            this.colCummY.Width = 94;
            // 
            // colXCCM
            // 
            this.colXCCM.FieldName = "XCCM";
            this.colXCCM.MinWidth = 25;
            this.colXCCM.Name = "colXCCM";
            this.colXCCM.Visible = true;
            this.colXCCM.VisibleIndex = 8;
            this.colXCCM.Width = 94;
            // 
            // colYCCM
            // 
            this.colYCCM.FieldName = "YCCM";
            this.colYCCM.MinWidth = 25;
            this.colYCCM.Name = "colYCCM";
            this.colYCCM.Visible = true;
            this.colYCCM.VisibleIndex = 9;
            this.colYCCM.Width = 94;
            // 
            // colXCR
            // 
            this.colXCR.FieldName = "XCR";
            this.colXCR.MinWidth = 25;
            this.colXCR.Name = "colXCR";
            this.colXCR.Visible = true;
            this.colXCR.VisibleIndex = 10;
            this.colXCR.Width = 94;
            // 
            // colYCR
            // 
            this.colYCR.FieldName = "YCR";
            this.colYCR.MinWidth = 25;
            this.colYCR.Name = "colYCR";
            this.colYCR.Visible = true;
            this.colYCR.VisibleIndex = 11;
            this.colYCR.Width = 94;
            // 
            // colDx
            // 
            this.colDx.FieldName = "Dx";
            this.colDx.MinWidth = 25;
            this.colDx.Name = "colDx";
            this.colDx.Visible = true;
            this.colDx.VisibleIndex = 12;
            this.colDx.Width = 94;
            // 
            // colDy
            // 
            this.colDy.FieldName = "Dy";
            this.colDy.MinWidth = 25;
            this.colDy.Name = "colDy";
            this.colDy.Visible = true;
            this.colDy.VisibleIndex = 13;
            this.colDy.Width = 94;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.tBEccentricitiesBindingSource1;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1159, 630);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tBEccentricitiesBindingSource1
            // 
            this.tBEccentricitiesBindingSource1.DataSource = typeof(ELFCHK.TBEccentricity);
            // 
            // tBEccentricitiesBindingSource
            // 
            this.tBEccentricitiesBindingSource.DataSource = typeof(ELFCHK.TBEccentricity);
            // 
            // gridControl2
            // 
            this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl2.DataSource = typeof(ELFCHK.Eccentricity);
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(1159, 630);
            this.gridControl2.TabIndex = 2;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridView2.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridView2.Appearance.ColumnFilterButton.Options.UseTextOptions = true;
            this.gridView2.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.ColumnFilterButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView2.Appearance.ColumnFilterButtonActive.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridView2.Appearance.ColumnFilterButtonActive.Options.UseFont = true;
            this.gridView2.Appearance.ColumnFilterButtonActive.Options.UseTextOptions = true;
            this.gridView2.Appearance.ColumnFilterButtonActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.ColumnFilterButtonActive.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView2.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridView2.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.gridView2.Appearance.CustomizationFormHint.Options.UseTextOptions = true;
            this.gridView2.Appearance.CustomizationFormHint.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.CustomizationFormHint.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView2.Appearance.DetailTip.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridView2.Appearance.DetailTip.Options.UseFont = true;
            this.gridView2.Appearance.DetailTip.Options.UseTextOptions = true;
            this.gridView2.Appearance.DetailTip.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.DetailTip.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView2.Appearance.Empty.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridView2.Appearance.Empty.Options.UseFont = true;
            this.gridView2.Appearance.Empty.Options.UseTextOptions = true;
            this.gridView2.Appearance.Empty.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.Empty.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView2.Appearance.EvenRow.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridView2.Appearance.EvenRow.Options.UseFont = true;
            this.gridView2.Appearance.EvenRow.Options.UseTextOptions = true;
            this.gridView2.Appearance.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.EvenRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView2.Appearance.FilterCloseButton.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridView2.Appearance.FilterCloseButton.Options.UseFont = true;
            this.gridView2.Appearance.FilterCloseButton.Options.UseTextOptions = true;
            this.gridView2.Appearance.FilterCloseButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.FilterCloseButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView2.Appearance.FilterPanel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridView2.Appearance.FilterPanel.Options.UseFont = true;
            this.gridView2.Appearance.FilterPanel.Options.UseTextOptions = true;
            this.gridView2.Appearance.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.FilterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView2.Appearance.FixedLine.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridView2.Appearance.FixedLine.Options.UseFont = true;
            this.gridView2.Appearance.FixedLine.Options.UseTextOptions = true;
            this.gridView2.Appearance.FixedLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.FixedLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView2.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridView2.Appearance.FocusedCell.Options.UseFont = true;
            this.gridView2.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.gridView2.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView2.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridView2.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView2.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.gridView2.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.FocusedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView2.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridView2.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView2.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.gridView2.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.FooterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView2.Appearance.GroupButton.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridView2.Appearance.GroupButton.Options.UseFont = true;
            this.gridView2.Appearance.GroupButton.Options.UseTextOptions = true;
            this.gridView2.Appearance.GroupButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.GroupButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView2.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridView2.Appearance.GroupFooter.Options.UseFont = true;
            this.gridView2.Appearance.GroupFooter.Options.UseTextOptions = true;
            this.gridView2.Appearance.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.GroupFooter.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView2.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridView2.Appearance.GroupPanel.Options.UseFont = true;
            this.gridView2.Appearance.GroupPanel.Options.UseTextOptions = true;
            this.gridView2.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.GroupPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView2.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridView2.Appearance.GroupRow.Options.UseFont = true;
            this.gridView2.Appearance.GroupRow.Options.UseTextOptions = true;
            this.gridView2.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView2.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridView2.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView2.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView2.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView2.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridView2.Appearance.HideSelectionRow.Options.UseFont = true;
            this.gridView2.Appearance.HideSelectionRow.Options.UseTextOptions = true;
            this.gridView2.Appearance.HideSelectionRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.HideSelectionRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView2.Appearance.HorzLine.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridView2.Appearance.HorzLine.Options.UseFont = true;
            this.gridView2.Appearance.HorzLine.Options.UseTextOptions = true;
            this.gridView2.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.HorzLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView2.Appearance.HotTrackedRow.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridView2.Appearance.HotTrackedRow.Options.UseFont = true;
            this.gridView2.Appearance.HotTrackedRow.Options.UseTextOptions = true;
            this.gridView2.Appearance.HotTrackedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.HotTrackedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView2.Appearance.OddRow.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridView2.Appearance.OddRow.Options.UseFont = true;
            this.gridView2.Appearance.OddRow.Options.UseTextOptions = true;
            this.gridView2.Appearance.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.OddRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView2.Appearance.Preview.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridView2.Appearance.Preview.Options.UseFont = true;
            this.gridView2.Appearance.Preview.Options.UseTextOptions = true;
            this.gridView2.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.Preview.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView2.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridView2.Appearance.Row.Options.UseFont = true;
            this.gridView2.Appearance.Row.Options.UseTextOptions = true;
            this.gridView2.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView2.Appearance.RowSeparator.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridView2.Appearance.RowSeparator.Options.UseFont = true;
            this.gridView2.Appearance.RowSeparator.Options.UseTextOptions = true;
            this.gridView2.Appearance.RowSeparator.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.RowSeparator.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView2.Appearance.SelectedRow.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridView2.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView2.Appearance.SelectedRow.Options.UseTextOptions = true;
            this.gridView2.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.SelectedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView2.Appearance.TopNewRow.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridView2.Appearance.TopNewRow.Options.UseFont = true;
            this.gridView2.Appearance.TopNewRow.Options.UseTextOptions = true;
            this.gridView2.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.TopNewRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView2.Appearance.VertLine.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridView2.Appearance.VertLine.Options.UseFont = true;
            this.gridView2.Appearance.VertLine.Options.UseTextOptions = true;
            this.gridView2.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.VertLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView2.Appearance.ViewCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridView2.Appearance.ViewCaption.Options.UseFont = true;
            this.gridView2.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.gridView2.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView2.AppearancePrint.EvenRow.Options.UseTextOptions = true;
            this.gridView2.AppearancePrint.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.AppearancePrint.EvenRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView2.AppearancePrint.FilterPanel.Options.UseTextOptions = true;
            this.gridView2.AppearancePrint.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.AppearancePrint.FilterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView2.AppearancePrint.FooterPanel.Options.UseTextOptions = true;
            this.gridView2.AppearancePrint.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.AppearancePrint.FooterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView2.AppearancePrint.GroupFooter.Options.UseTextOptions = true;
            this.gridView2.AppearancePrint.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.AppearancePrint.GroupFooter.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView2.AppearancePrint.GroupRow.Options.UseTextOptions = true;
            this.gridView2.AppearancePrint.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.AppearancePrint.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView2.AppearancePrint.HeaderPanel.Options.UseTextOptions = true;
            this.gridView2.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.AppearancePrint.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView2.AppearancePrint.Lines.Options.UseTextOptions = true;
            this.gridView2.AppearancePrint.Lines.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.AppearancePrint.Lines.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView2.AppearancePrint.OddRow.Options.UseTextOptions = true;
            this.gridView2.AppearancePrint.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.AppearancePrint.OddRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView2.AppearancePrint.Preview.Options.UseTextOptions = true;
            this.gridView2.AppearancePrint.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.AppearancePrint.Preview.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView2.AppearancePrint.Row.Options.UseTextOptions = true;
            this.gridView2.AppearancePrint.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.AppearancePrint.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colStory1,
            this.colDx1,
            this.colex,
            this.colexResult,
            this.colexState,
            this.colDy1,
            this.coley,
            this.coleyResult,
            this.coleyState});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView2.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView2.OptionsMenu.ShowConditionalFormattingItem = true;
            this.gridView2.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gridView2.OptionsPrint.EnableAppearanceOddRow = true;
            // 
            // colStory1
            // 
            this.colStory1.FieldName = "Story";
            this.colStory1.MinWidth = 25;
            this.colStory1.Name = "colStory1";
            this.colStory1.OptionsColumn.AllowEdit = false;
            this.colStory1.Visible = true;
            this.colStory1.VisibleIndex = 0;
            this.colStory1.Width = 94;
            // 
            // colDx1
            // 
            this.colDx1.Caption = "Dx (m)";
            this.colDx1.FieldName = "Dx";
            this.colDx1.MinWidth = 25;
            this.colDx1.Name = "colDx1";
            this.colDx1.OptionsColumn.AllowEdit = false;
            this.colDx1.Visible = true;
            this.colDx1.VisibleIndex = 1;
            this.colDx1.Width = 94;
            // 
            // colex
            // 
            this.colex.Caption = "Ex";
            this.colex.FieldName = "ex";
            this.colex.MinWidth = 25;
            this.colex.Name = "colex";
            this.colex.OptionsColumn.AllowEdit = false;
            this.colex.Visible = true;
            this.colex.VisibleIndex = 2;
            this.colex.Width = 94;
            // 
            // colexResult
            // 
            this.colexResult.Caption = "Ex %";
            this.colexResult.FieldName = "exResult";
            this.colexResult.MinWidth = 25;
            this.colexResult.Name = "colexResult";
            this.colexResult.OptionsColumn.AllowEdit = false;
            this.colexResult.Visible = true;
            this.colexResult.VisibleIndex = 3;
            this.colexResult.Width = 94;
            // 
            // colexState
            // 
            this.colexState.Caption = "State";
            this.colexState.FieldName = "exState";
            this.colexState.MinWidth = 25;
            this.colexState.Name = "colexState";
            this.colexState.OptionsColumn.AllowEdit = false;
            this.colexState.Visible = true;
            this.colexState.VisibleIndex = 4;
            this.colexState.Width = 94;
            // 
            // colDy1
            // 
            this.colDy1.Caption = "Dy (m)";
            this.colDy1.FieldName = "Dy";
            this.colDy1.MinWidth = 25;
            this.colDy1.Name = "colDy1";
            this.colDy1.OptionsColumn.AllowEdit = false;
            this.colDy1.Visible = true;
            this.colDy1.VisibleIndex = 5;
            this.colDy1.Width = 94;
            // 
            // coley
            // 
            this.coley.Caption = "Ey";
            this.coley.FieldName = "ey";
            this.coley.MinWidth = 25;
            this.coley.Name = "coley";
            this.coley.OptionsColumn.AllowEdit = false;
            this.coley.Visible = true;
            this.coley.VisibleIndex = 6;
            this.coley.Width = 94;
            // 
            // coleyResult
            // 
            this.coleyResult.Caption = "Ey %";
            this.coleyResult.FieldName = "eyResult";
            this.coleyResult.MinWidth = 25;
            this.coleyResult.Name = "coleyResult";
            this.coleyResult.OptionsColumn.AllowEdit = false;
            this.coleyResult.Visible = true;
            this.coleyResult.VisibleIndex = 7;
            this.coleyResult.Width = 94;
            // 
            // coleyState
            // 
            this.coleyState.Caption = "State";
            this.coleyState.FieldName = "eyState";
            this.coleyState.MinWidth = 25;
            this.coleyState.Name = "coleyState";
            this.coleyState.OptionsColumn.AllowEdit = false;
            this.coleyState.Visible = true;
            this.coleyState.VisibleIndex = 8;
            this.coleyState.Width = 94;
            // 
            // EccentricityForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.gridControl1);
            this.Name = "EccentricityForm";
            this.Size = new System.Drawing.Size(1159, 721);
            this.Load += new System.EventHandler(this.EccentricityForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBEccentricitiesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBEccentricitiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_getdata;
        private DevExpress.XtraEditors.SimpleButton btn_print;
        private DevExpress.XtraEditors.SimpleButton btn_clear;
        private DevExpress.XtraEditors.SimpleButton btn_check;
        private DevExpress.XtraEditors.SimpleButton btn_save;
        private System.Windows.Forms.ComboBox combo_selectTable;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource tBEccentricitiesBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colStory;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaphragm;
        private DevExpress.XtraGrid.Columns.GridColumn colMassX;
        private DevExpress.XtraGrid.Columns.GridColumn colMassY;
        private DevExpress.XtraGrid.Columns.GridColumn colXCM;
        private DevExpress.XtraGrid.Columns.GridColumn colYCM;
        private DevExpress.XtraGrid.Columns.GridColumn colCummX;
        private DevExpress.XtraGrid.Columns.GridColumn colCummY;
        private DevExpress.XtraGrid.Columns.GridColumn colXCCM;
        private DevExpress.XtraGrid.Columns.GridColumn colYCCM;
        private DevExpress.XtraGrid.Columns.GridColumn colXCR;
        private DevExpress.XtraGrid.Columns.GridColumn colYCR;
        private DevExpress.XtraGrid.Columns.GridColumn colDx;
        private DevExpress.XtraGrid.Columns.GridColumn colDy;
        private System.Windows.Forms.BindingSource tBEccentricitiesBindingSource1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colStory1;
        private DevExpress.XtraGrid.Columns.GridColumn colDx1;
        private DevExpress.XtraGrid.Columns.GridColumn colex;
        private DevExpress.XtraGrid.Columns.GridColumn colexResult;
        private DevExpress.XtraGrid.Columns.GridColumn colexState;
        private DevExpress.XtraGrid.Columns.GridColumn colDy1;
        private DevExpress.XtraGrid.Columns.GridColumn coley;
        private DevExpress.XtraGrid.Columns.GridColumn coleyResult;
        private DevExpress.XtraGrid.Columns.GridColumn coleyState;
    }
}
