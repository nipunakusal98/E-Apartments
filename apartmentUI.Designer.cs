
namespace Eapartments
{
    partial class frmApartments
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtApartmentID = new System.Windows.Forms.TextBox();
            this.txtBuildingID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFloorID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvApartment = new System.Windows.Forms.DataGridView();
            this.eApartmentsDataSet = new Eapartments.EApartmentsDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbAvalibilty = new System.Windows.Forms.ComboBox();
            this.txtClassID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eApartmentsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Apartment ID";
            // 
            // txtApartmentID
            // 
            this.txtApartmentID.Location = new System.Drawing.Point(147, 35);
            this.txtApartmentID.Name = "txtApartmentID";
            this.txtApartmentID.Size = new System.Drawing.Size(218, 22);
            this.txtApartmentID.TabIndex = 1;
            this.txtApartmentID.TextChanged += new System.EventHandler(this.txtApartmentID_TextChanged);
            // 
            // txtBuildingID
            // 
            this.txtBuildingID.Location = new System.Drawing.Point(147, 94);
            this.txtBuildingID.Name = "txtBuildingID";
            this.txtBuildingID.Size = new System.Drawing.Size(218, 22);
            this.txtBuildingID.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Building ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Class ID";
            // 
            // txtFloorID
            // 
            this.txtFloorID.Location = new System.Drawing.Point(147, 228);
            this.txtFloorID.Name = "txtFloorID";
            this.txtFloorID.Size = new System.Drawing.Size(218, 22);
            this.txtFloorID.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Floor ID";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(415, 342);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 36);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(283, 342);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(113, 36);
            this.btnUpdate.TabIndex = 30;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(143, 342);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 36);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(9, 342);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(113, 36);
            this.btnSearch.TabIndex = 28;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvApartment
            // 
            this.dgvApartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApartment.Location = new System.Drawing.Point(627, 35);
            this.dgvApartment.Name = "dgvApartment";
            this.dgvApartment.RowHeadersWidth = 51;
            this.dgvApartment.RowTemplate.Height = 24;
            this.dgvApartment.Size = new System.Drawing.Size(644, 384);
            this.dgvApartment.TabIndex = 32;
            // 
            // eApartmentsDataSet
            // 
            this.eApartmentsDataSet.DataSetName = "EApartmentsDataSet";
            this.eApartmentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Avalibility";
            // 
            // cmbAvalibilty
            // 
            this.cmbAvalibilty.FormattingEnabled = true;
            this.cmbAvalibilty.Location = new System.Drawing.Point(135, 288);
            this.cmbAvalibilty.Name = "cmbAvalibilty";
            this.cmbAvalibilty.Size = new System.Drawing.Size(163, 24);
            this.cmbAvalibilty.TabIndex = 34;
            // 
            // txtClassID
            // 
            this.txtClassID.Location = new System.Drawing.Point(147, 161);
            this.txtClassID.Name = "txtClassID";
            this.txtClassID.Size = new System.Drawing.Size(218, 22);
            this.txtClassID.TabIndex = 5;
            // 
            // frmApartments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 479);
            this.Controls.Add(this.cmbAvalibilty);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvApartment);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtFloorID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtClassID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBuildingID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtApartmentID);
            this.Controls.Add(this.label1);
            this.Name = "frmApartments";
            this.Text = "Apartments";
            this.Load += new System.EventHandler(this.frmApartments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eApartmentsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtApartmentID;
        private System.Windows.Forms.TextBox txtBuildingID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFloorID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvApartment;
        private EApartmentsDataSet eApartmentsDataSet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbAvalibilty;
        private System.Windows.Forms.TextBox txtClassID;
    }
}