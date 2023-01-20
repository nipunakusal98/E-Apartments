
namespace Eapartments
{
    partial class frmOccupant
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtOccupantNICPassportID = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvOccupant = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelephoneNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOccupantAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOccuapntLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOccupantFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOccupantID = new System.Windows.Forms.TextBox();
            this.eApartmentsDataSet1 = new Eapartments.EApartmentsDataSet1();
            this.eApartmentsDataSet = new Eapartments.EApartmentsDataSet();
            this.occupantNICPassportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.occupantEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.occupantTelephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.occupantAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.occupantLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.occupantFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.occupantIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbl_OccupantTableAdapter = new Eapartments.EApartmentsDataSet1TableAdapters.tbl_OccupantTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOccupant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eApartmentsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eApartmentsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtOccupantNICPassportID);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.dgvOccupant);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtEmailAddress);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTelephoneNo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtOccupantAddress);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtOccuapntLastName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtOccupantFirstName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtOccupantID);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1446, 681);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Occupant Details";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 369);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(115, 17);
            this.label15.TabIndex = 29;
            this.label15.Text = "NIC / Passport ID";
            // 
            // txtOccupantNICPassportID
            // 
            this.txtOccupantNICPassportID.Location = new System.Drawing.Point(130, 366);
            this.txtOccupantNICPassportID.Name = "txtOccupantNICPassportID";
            this.txtOccupantNICPassportID.Size = new System.Drawing.Size(201, 22);
            this.txtOccupantNICPassportID.TabIndex = 28;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(449, 409);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 36);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(317, 409);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(113, 36);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(177, 409);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 36);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(43, 409);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(113, 36);
            this.btnSearch.TabIndex = 24;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvOccupant
            // 
            this.dgvOccupant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOccupant.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.occupantIDDataGridViewTextBoxColumn,
            this.occupantFirstNameDataGridViewTextBoxColumn,
            this.occupantLastNameDataGridViewTextBoxColumn,
            this.occupantAddressDataGridViewTextBoxColumn,
            this.occupantTelephoneDataGridViewTextBoxColumn,
            this.occupantEmailDataGridViewTextBoxColumn,
            this.occupantNICPassportDataGridViewTextBoxColumn});
            this.dgvOccupant.Location = new System.Drawing.Point(449, 21);
            this.dgvOccupant.Name = "dgvOccupant";
            this.dgvOccupant.RowHeadersWidth = 51;
            this.dgvOccupant.RowTemplate.Height = 24;
            this.dgvOccupant.Size = new System.Drawing.Size(966, 351);
            this.dgvOccupant.TabIndex = 12;
            this.dgvOccupant.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOccupant_CellContentClick);
            this.dgvOccupant.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOccupant_CellDoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Email Address";
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(130, 304);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(201, 22);
            this.txtEmailAddress.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Telephone No";
            // 
            // txtTelephoneNo
            // 
            this.txtTelephoneNo.Location = new System.Drawing.Point(130, 244);
            this.txtTelephoneNo.Name = "txtTelephoneNo";
            this.txtTelephoneNo.Size = new System.Drawing.Size(201, 22);
            this.txtTelephoneNo.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Address";
            // 
            // txtOccupantAddress
            // 
            this.txtOccupantAddress.Location = new System.Drawing.Point(130, 185);
            this.txtOccupantAddress.Name = "txtOccupantAddress";
            this.txtOccupantAddress.Size = new System.Drawing.Size(201, 22);
            this.txtOccupantAddress.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last Name";
            // 
            // txtOccuapntLastName
            // 
            this.txtOccuapntLastName.Location = new System.Drawing.Point(130, 128);
            this.txtOccuapntLastName.Name = "txtOccuapntLastName";
            this.txtOccuapntLastName.Size = new System.Drawing.Size(201, 22);
            this.txtOccuapntLastName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "First Name";
            // 
            // txtOccupantFirstName
            // 
            this.txtOccupantFirstName.Location = new System.Drawing.Point(130, 78);
            this.txtOccupantFirstName.Name = "txtOccupantFirstName";
            this.txtOccupantFirstName.Size = new System.Drawing.Size(201, 22);
            this.txtOccupantFirstName.TabIndex = 2;
            this.txtOccupantFirstName.TextChanged += new System.EventHandler(this.txtOccupantFirstName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Occupant ID";
            // 
            // txtOccupantID
            // 
            this.txtOccupantID.Location = new System.Drawing.Point(130, 31);
            this.txtOccupantID.Name = "txtOccupantID";
            this.txtOccupantID.Size = new System.Drawing.Size(201, 22);
            this.txtOccupantID.TabIndex = 0;
            // 
            // eApartmentsDataSet1
            // 
            this.eApartmentsDataSet1.DataSetName = "EApartmentsDataSet1";
            this.eApartmentsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eApartmentsDataSet
            // 
            this.eApartmentsDataSet.DataSetName = "EApartmentsDataSet";
            this.eApartmentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // occupantNICPassportDataGridViewTextBoxColumn
            // 
            this.occupantNICPassportDataGridViewTextBoxColumn.DataPropertyName = "occupant_NICPassport";
            this.occupantNICPassportDataGridViewTextBoxColumn.HeaderText = "occupant_NICPassport";
            this.occupantNICPassportDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.occupantNICPassportDataGridViewTextBoxColumn.Name = "occupantNICPassportDataGridViewTextBoxColumn";
            this.occupantNICPassportDataGridViewTextBoxColumn.Width = 125;
            // 
            // occupantEmailDataGridViewTextBoxColumn
            // 
            this.occupantEmailDataGridViewTextBoxColumn.DataPropertyName = "occupant_Email";
            this.occupantEmailDataGridViewTextBoxColumn.HeaderText = "occupant_Email";
            this.occupantEmailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.occupantEmailDataGridViewTextBoxColumn.Name = "occupantEmailDataGridViewTextBoxColumn";
            this.occupantEmailDataGridViewTextBoxColumn.Width = 125;
            // 
            // occupantTelephoneDataGridViewTextBoxColumn
            // 
            this.occupantTelephoneDataGridViewTextBoxColumn.DataPropertyName = "occupant_Telephone";
            this.occupantTelephoneDataGridViewTextBoxColumn.HeaderText = "occupant_Telephone";
            this.occupantTelephoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.occupantTelephoneDataGridViewTextBoxColumn.Name = "occupantTelephoneDataGridViewTextBoxColumn";
            this.occupantTelephoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // occupantAddressDataGridViewTextBoxColumn
            // 
            this.occupantAddressDataGridViewTextBoxColumn.DataPropertyName = "occupant_Address";
            this.occupantAddressDataGridViewTextBoxColumn.HeaderText = "occupant_Address";
            this.occupantAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.occupantAddressDataGridViewTextBoxColumn.Name = "occupantAddressDataGridViewTextBoxColumn";
            this.occupantAddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // occupantLastNameDataGridViewTextBoxColumn
            // 
            this.occupantLastNameDataGridViewTextBoxColumn.DataPropertyName = "occupant_Last_Name";
            this.occupantLastNameDataGridViewTextBoxColumn.HeaderText = "occupant_Last_Name";
            this.occupantLastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.occupantLastNameDataGridViewTextBoxColumn.Name = "occupantLastNameDataGridViewTextBoxColumn";
            this.occupantLastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // occupantFirstNameDataGridViewTextBoxColumn
            // 
            this.occupantFirstNameDataGridViewTextBoxColumn.DataPropertyName = "occupant_First_Name";
            this.occupantFirstNameDataGridViewTextBoxColumn.HeaderText = "occupant_First_Name";
            this.occupantFirstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.occupantFirstNameDataGridViewTextBoxColumn.Name = "occupantFirstNameDataGridViewTextBoxColumn";
            this.occupantFirstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // occupantIDDataGridViewTextBoxColumn
            // 
            this.occupantIDDataGridViewTextBoxColumn.DataPropertyName = "occupant_ID";
            this.occupantIDDataGridViewTextBoxColumn.HeaderText = "occupant_ID";
            this.occupantIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.occupantIDDataGridViewTextBoxColumn.Name = "occupantIDDataGridViewTextBoxColumn";
            this.occupantIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.occupantIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // tbl_OccupantTableAdapter
            // 
            this.tbl_OccupantTableAdapter.ClearBeforeFill = true;
            // 
            // frmOccupant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1489, 577);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmOccupant";
            this.Text = "Occupant";
            this.Load += new System.EventHandler(this.frmOccupant_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOccupant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eApartmentsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eApartmentsDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvOccupant;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelephoneNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOccupantAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOccuapntLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOccupantFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOccupantID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtOccupantNICPassportID;
        private EApartmentsDataSet1 eApartmentsDataSet1;
        private System.Windows.Forms.DataGridViewTextBoxColumn occupantIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn occupantFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn occupantLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn occupantAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn occupantTelephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn occupantEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn occupantNICPassportDataGridViewTextBoxColumn;
        private EApartmentsDataSet eApartmentsDataSet;
        private EApartmentsDataSet1TableAdapters.tbl_OccupantTableAdapter tbl_OccupantTableAdapter;
    }
}