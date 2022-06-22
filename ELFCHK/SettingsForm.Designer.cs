
namespace ELFCHK
{
    partial class SettingsForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.btn_save = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.edt_eccentrcityvalue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabNavigationPage3 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabNavigationPage4 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabNavigationPage5 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.edt_cd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_savepdelta = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.edt_ie = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabNavigationPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Controls.Add(this.tabNavigationPage3);
            this.tabPane1.Controls.Add(this.tabNavigationPage4);
            this.tabPane1.Controls.Add(this.tabNavigationPage5);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPane1.Location = new System.Drawing.Point(0, 0);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2,
            this.tabNavigationPage3,
            this.tabNavigationPage4,
            this.tabNavigationPage5});
            this.tabPane1.RegularSize = new System.Drawing.Size(845, 586);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(845, 586);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "tabNavigationPage1";
            this.tabNavigationPage1.Controls.Add(this.btn_save);
            this.tabNavigationPage1.Controls.Add(this.groupBox1);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.PageText = "Eccentricity";
            this.tabNavigationPage1.Size = new System.Drawing.Size(845, 545);
            // 
            // btn_save
            // 
            this.btn_save.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_save.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_save.ImageOptions.SvgImage")));
            this.btn_save.Location = new System.Drawing.Point(686, 458);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(147, 75);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "Save changes";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.edt_eccentrcityvalue);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox1.Location = new System.Drawing.Point(27, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(764, 388);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "The Eccentricity Settings";
            // 
            // edt_eccentrcityvalue
            // 
            this.edt_eccentrcityvalue.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_eccentrcityvalue.Location = new System.Drawing.Point(361, 180);
            this.edt_eccentrcityvalue.Name = "edt_eccentrcityvalue";
            this.edt_eccentrcityvalue.Size = new System.Drawing.Size(308, 32);
            this.edt_eccentrcityvalue.TabIndex = 1;
            this.edt_eccentrcityvalue.Text = "15";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(15, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "\r\nEccentricity Check Value\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(692, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "%";
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "tabNavigationPage2";
            this.tabNavigationPage2.Controls.Add(this.btn_savepdelta);
            this.tabNavigationPage2.Controls.Add(this.groupBox2);
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.PageText = "P-Delta";
            this.tabNavigationPage2.Size = new System.Drawing.Size(845, 545);
            this.tabNavigationPage2.Paint += new System.Windows.Forms.PaintEventHandler(this.tabNavigationPage2_Paint);
            // 
            // tabNavigationPage3
            // 
            this.tabNavigationPage3.Caption = "tabNavigationPage3";
            this.tabNavigationPage3.Name = "tabNavigationPage3";
            this.tabNavigationPage3.PageText = "Irregularity ";
            this.tabNavigationPage3.Size = new System.Drawing.Size(845, 545);
            // 
            // tabNavigationPage4
            // 
            this.tabNavigationPage4.Caption = "tabNavigationPage4";
            this.tabNavigationPage4.Name = "tabNavigationPage4";
            this.tabNavigationPage4.PageText = "Drift ";
            this.tabNavigationPage4.Size = new System.Drawing.Size(845, 545);
            // 
            // tabNavigationPage5
            // 
            this.tabNavigationPage5.Caption = "tabNavigationPage5";
            this.tabNavigationPage5.Name = "tabNavigationPage5";
            this.tabNavigationPage5.PageText = "General";
            this.tabNavigationPage5.Size = new System.Drawing.Size(845, 545);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.edt_ie);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.edt_cd);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox2.Location = new System.Drawing.Point(27, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(764, 365);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "The P-Delta Settings";
            // 
            // edt_cd
            // 
            this.edt_cd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_cd.Location = new System.Drawing.Point(351, 84);
            this.edt_cd.Name = "edt_cd";
            this.edt_cd.Size = new System.Drawing.Size(308, 32);
            this.edt_cd.TabIndex = 1;
            this.edt_cd.Text = "4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(27, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cd";
            // 
            // btn_savepdelta
            // 
            this.btn_savepdelta.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_savepdelta.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.btn_savepdelta.Location = new System.Drawing.Point(686, 458);
            this.btn_savepdelta.Name = "btn_savepdelta";
            this.btn_savepdelta.Size = new System.Drawing.Size(147, 75);
            this.btn_savepdelta.TabIndex = 4;
            this.btn_savepdelta.Text = "Save changes";
            this.btn_savepdelta.Click += new System.EventHandler(this.btn_savepdelta_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(69, 234);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(644, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label4.Location = new System.Drawing.Point(27, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ie";
            // 
            // edt_ie
            // 
            this.edt_ie.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_ie.Location = new System.Drawing.Point(351, 132);
            this.edt_ie.Name = "edt_ie";
            this.edt_ie.Size = new System.Drawing.Size(308, 32);
            this.edt_ie.TabIndex = 1;
            this.edt_ie.Text = "1";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 586);
            this.Controls.Add(this.tabPane1);
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabNavigationPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox edt_eccentrcityvalue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btn_save;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage3;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage4;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage5;
        private DevExpress.XtraEditors.SimpleButton btn_savepdelta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox edt_cd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox edt_ie;
        private System.Windows.Forms.Label label4;
    }
}