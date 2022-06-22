
namespace ELFCHK
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lb_statuse = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressbar = new System.Windows.Forms.ToolStripProgressBar();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_openedbfile = new System.Windows.Forms.Button();
            this.btn_eccentricity = new System.Windows.Forms.Button();
            this.btn_pdelta = new System.Windows.Forms.Button();
            this.btn_irreqularity = new System.Windows.Forms.Button();
            this.btn_drift = new System.Windows.Forms.Button();
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_help = new System.Windows.Forms.Button();
            this.pn_container = new System.Windows.Forms.Panel();
            this.btn_softstory = new System.Windows.Forms.Button();
            this.btn_heavystory = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lb_statuse,
            this.progressbar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 694);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 22, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1248, 29);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lb_statuse
            // 
            this.lb_statuse.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lb_statuse.Name = "lb_statuse";
            this.lb_statuse.Size = new System.Drawing.Size(56, 23);
            this.lb_statuse.Text = "Ready";
            // 
            // progressbar
            // 
            this.progressbar.Name = "progressbar";
            this.progressbar.Size = new System.Drawing.Size(300, 26);
            this.progressbar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressbar.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.btn_openedbfile);
            this.flowLayoutPanel1.Controls.Add(this.btn_eccentricity);
            this.flowLayoutPanel1.Controls.Add(this.btn_softstory);
            this.flowLayoutPanel1.Controls.Add(this.btn_heavystory);
            this.flowLayoutPanel1.Controls.Add(this.btn_pdelta);
            this.flowLayoutPanel1.Controls.Add(this.btn_irreqularity);
            this.flowLayoutPanel1.Controls.Add(this.btn_drift);
            this.flowLayoutPanel1.Controls.Add(this.btn_settings);
            this.flowLayoutPanel1.Controls.Add(this.btn_help);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1248, 75);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btn_openedbfile
            // 
            this.btn_openedbfile.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_openedbfile.Image = ((System.Drawing.Image)(resources.GetObject("btn_openedbfile.Image")));
            this.btn_openedbfile.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_openedbfile.Location = new System.Drawing.Point(10, 10);
            this.btn_openedbfile.Margin = new System.Windows.Forms.Padding(5);
            this.btn_openedbfile.Name = "btn_openedbfile";
            this.btn_openedbfile.Size = new System.Drawing.Size(163, 57);
            this.btn_openedbfile.TabIndex = 0;
            this.btn_openedbfile.Text = "Open EDB";
            this.btn_openedbfile.UseVisualStyleBackColor = true;
            this.btn_openedbfile.Click += new System.EventHandler(this.btn_openedbfile_Click);
            // 
            // btn_eccentricity
            // 
            this.btn_eccentricity.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eccentricity.Image = ((System.Drawing.Image)(resources.GetObject("btn_eccentricity.Image")));
            this.btn_eccentricity.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_eccentricity.Location = new System.Drawing.Point(183, 10);
            this.btn_eccentricity.Margin = new System.Windows.Forms.Padding(5);
            this.btn_eccentricity.Name = "btn_eccentricity";
            this.btn_eccentricity.Size = new System.Drawing.Size(163, 57);
            this.btn_eccentricity.TabIndex = 1;
            this.btn_eccentricity.Text = "Eccentricity";
            this.btn_eccentricity.UseVisualStyleBackColor = true;
            this.btn_eccentricity.Click += new System.EventHandler(this.btn_eccentricity_Click);
            // 
            // btn_pdelta
            // 
            this.btn_pdelta.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pdelta.Image = ((System.Drawing.Image)(resources.GetObject("btn_pdelta.Image")));
            this.btn_pdelta.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_pdelta.Location = new System.Drawing.Point(702, 10);
            this.btn_pdelta.Margin = new System.Windows.Forms.Padding(5);
            this.btn_pdelta.Name = "btn_pdelta";
            this.btn_pdelta.Size = new System.Drawing.Size(163, 57);
            this.btn_pdelta.TabIndex = 2;
            this.btn_pdelta.Text = "P-Delta";
            this.btn_pdelta.UseVisualStyleBackColor = true;
            this.btn_pdelta.Click += new System.EventHandler(this.btn_pdelta_Click);
            // 
            // btn_irreqularity
            // 
            this.btn_irreqularity.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_irreqularity.Image = ((System.Drawing.Image)(resources.GetObject("btn_irreqularity.Image")));
            this.btn_irreqularity.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_irreqularity.Location = new System.Drawing.Point(875, 10);
            this.btn_irreqularity.Margin = new System.Windows.Forms.Padding(5);
            this.btn_irreqularity.Name = "btn_irreqularity";
            this.btn_irreqularity.Size = new System.Drawing.Size(163, 57);
            this.btn_irreqularity.TabIndex = 3;
            this.btn_irreqularity.Text = "Irregularity ";
            this.btn_irreqularity.UseVisualStyleBackColor = true;
            // 
            // btn_drift
            // 
            this.btn_drift.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_drift.Image = ((System.Drawing.Image)(resources.GetObject("btn_drift.Image")));
            this.btn_drift.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_drift.Location = new System.Drawing.Point(1048, 10);
            this.btn_drift.Margin = new System.Windows.Forms.Padding(5);
            this.btn_drift.Name = "btn_drift";
            this.btn_drift.Size = new System.Drawing.Size(163, 57);
            this.btn_drift.TabIndex = 4;
            this.btn_drift.Text = "Drift";
            this.btn_drift.UseVisualStyleBackColor = true;
            // 
            // btn_settings
            // 
            this.btn_settings.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_settings.Image = ((System.Drawing.Image)(resources.GetObject("btn_settings.Image")));
            this.btn_settings.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_settings.Location = new System.Drawing.Point(10, 77);
            this.btn_settings.Margin = new System.Windows.Forms.Padding(5);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(163, 57);
            this.btn_settings.TabIndex = 5;
            this.btn_settings.Text = "Settings";
            this.btn_settings.UseVisualStyleBackColor = true;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // btn_help
            // 
            this.btn_help.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_help.Image = ((System.Drawing.Image)(resources.GetObject("btn_help.Image")));
            this.btn_help.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_help.Location = new System.Drawing.Point(183, 77);
            this.btn_help.Margin = new System.Windows.Forms.Padding(5);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(163, 57);
            this.btn_help.TabIndex = 6;
            this.btn_help.Text = "Help";
            this.btn_help.UseVisualStyleBackColor = true;
            // 
            // pn_container
            // 
            this.pn_container.BackColor = System.Drawing.Color.White;
            this.pn_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_container.Location = new System.Drawing.Point(0, 75);
            this.pn_container.Name = "pn_container";
            this.pn_container.Size = new System.Drawing.Size(1248, 619);
            this.pn_container.TabIndex = 2;
            // 
            // btn_softstory
            // 
            this.btn_softstory.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_softstory.Image = ((System.Drawing.Image)(resources.GetObject("btn_softstory.Image")));
            this.btn_softstory.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_softstory.Location = new System.Drawing.Point(356, 10);
            this.btn_softstory.Margin = new System.Windows.Forms.Padding(5);
            this.btn_softstory.Name = "btn_softstory";
            this.btn_softstory.Size = new System.Drawing.Size(163, 57);
            this.btn_softstory.TabIndex = 7;
            this.btn_softstory.Text = "Soft Story";
            this.btn_softstory.UseVisualStyleBackColor = true;
            // 
            // btn_heavystory
            // 
            this.btn_heavystory.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_heavystory.Image = ((System.Drawing.Image)(resources.GetObject("btn_heavystory.Image")));
            this.btn_heavystory.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_heavystory.Location = new System.Drawing.Point(529, 10);
            this.btn_heavystory.Margin = new System.Windows.Forms.Padding(5);
            this.btn_heavystory.Name = "btn_heavystory";
            this.btn_heavystory.Size = new System.Drawing.Size(163, 57);
            this.btn_heavystory.TabIndex = 8;
            this.btn_heavystory.Text = "Heavy Story";
            this.btn_heavystory.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 723);
            this.Controls.Add(this.pn_container);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("Main.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Main";
            this.Text = "ELFCECHK";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_openedbfile;
        private System.Windows.Forms.Panel pn_container;
        private System.Windows.Forms.Button btn_eccentricity;
        private System.Windows.Forms.Button btn_irreqularity;
        private System.Windows.Forms.Button btn_drift;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Button btn_help;
        public System.Windows.Forms.ToolStripStatusLabel lb_statuse;
        public System.Windows.Forms.ToolStripProgressBar progressbar;
        public System.Windows.Forms.Button btn_pdelta;
        private System.Windows.Forms.Button btn_softstory;
        private System.Windows.Forms.Button btn_heavystory;
    }
}

