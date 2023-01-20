
namespace Eapartments
{
    partial class frmmainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.buildingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildingDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apartmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apartmentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apartmentClassesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apartmentLeaseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.occupantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.occupantDetialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dependantDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dashobardDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.buildingToolStripMenuItem,
            this.apartmentsToolStripMenuItem,
            this.occupantsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1433, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // buildingToolStripMenuItem
            // 
            this.buildingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buildingDetailsToolStripMenuItem});
            this.buildingToolStripMenuItem.Name = "buildingToolStripMenuItem";
            this.buildingToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.buildingToolStripMenuItem.Text = "Building";
            // 
            // buildingDetailsToolStripMenuItem
            // 
            this.buildingDetailsToolStripMenuItem.Name = "buildingDetailsToolStripMenuItem";
            this.buildingDetailsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.buildingDetailsToolStripMenuItem.Text = "Building Details";
            this.buildingDetailsToolStripMenuItem.Click += new System.EventHandler(this.buildingDetailsToolStripMenuItem_Click);
            // 
            // apartmentsToolStripMenuItem
            // 
            this.apartmentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apartmentDetailsToolStripMenuItem,
            this.apartmentClassesToolStripMenuItem,
            this.apartmentLeaseDetailsToolStripMenuItem});
            this.apartmentsToolStripMenuItem.Name = "apartmentsToolStripMenuItem";
            this.apartmentsToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.apartmentsToolStripMenuItem.Text = "Apartments";
            // 
            // apartmentDetailsToolStripMenuItem
            // 
            this.apartmentDetailsToolStripMenuItem.Name = "apartmentDetailsToolStripMenuItem";
            this.apartmentDetailsToolStripMenuItem.Size = new System.Drawing.Size(254, 26);
            this.apartmentDetailsToolStripMenuItem.Text = "Apartment Details";
            this.apartmentDetailsToolStripMenuItem.Click += new System.EventHandler(this.apartmentDetailsToolStripMenuItem_Click);
            // 
            // apartmentClassesToolStripMenuItem
            // 
            this.apartmentClassesToolStripMenuItem.Name = "apartmentClassesToolStripMenuItem";
            this.apartmentClassesToolStripMenuItem.Size = new System.Drawing.Size(254, 26);
            this.apartmentClassesToolStripMenuItem.Text = "Apartment Classes";
            // 
            // apartmentLeaseDetailsToolStripMenuItem
            // 
            this.apartmentLeaseDetailsToolStripMenuItem.Name = "apartmentLeaseDetailsToolStripMenuItem";
            this.apartmentLeaseDetailsToolStripMenuItem.Size = new System.Drawing.Size(254, 26);
            this.apartmentLeaseDetailsToolStripMenuItem.Text = "Apartment Lease Details";
            this.apartmentLeaseDetailsToolStripMenuItem.Click += new System.EventHandler(this.apartmentLeaseDetailsToolStripMenuItem_Click);
            // 
            // occupantsToolStripMenuItem
            // 
            this.occupantsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.occupantDetialsToolStripMenuItem,
            this.dependantDetailsToolStripMenuItem});
            this.occupantsToolStripMenuItem.Name = "occupantsToolStripMenuItem";
            this.occupantsToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.occupantsToolStripMenuItem.Text = "Occupants";
            // 
            // occupantDetialsToolStripMenuItem
            // 
            this.occupantDetialsToolStripMenuItem.Name = "occupantDetialsToolStripMenuItem";
            this.occupantDetialsToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.occupantDetialsToolStripMenuItem.Text = "Occupant Details";
            this.occupantDetialsToolStripMenuItem.Click += new System.EventHandler(this.occupantDetialsToolStripMenuItem_Click);
            // 
            // dependantDetailsToolStripMenuItem
            // 
            this.dependantDetailsToolStripMenuItem.Name = "dependantDetailsToolStripMenuItem";
            this.dependantDetailsToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.dependantDetailsToolStripMenuItem.Text = "Dependant Details";
            this.dependantDetailsToolStripMenuItem.Click += new System.EventHandler(this.dependantDetailsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashobardDetailsToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(96, 24);
            this.toolStripMenuItem1.Text = "Dashboard";
            // 
            // dashobardDetailsToolStripMenuItem
            // 
            this.dashobardDetailsToolStripMenuItem.Name = "dashobardDetailsToolStripMenuItem";
            this.dashobardDetailsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dashobardDetailsToolStripMenuItem.Text = "Dashobard Details";
            this.dashobardDetailsToolStripMenuItem.Click += new System.EventHandler(this.dashobardDetailsToolStripMenuItem_Click);
            // 
            // frmmainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 747);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmmainForm";
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem buildingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildingDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apartmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apartmentDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem occupantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem occupantDetialsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dependantDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apartmentClassesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apartmentLeaseDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dashobardDetailsToolStripMenuItem;
    }
}