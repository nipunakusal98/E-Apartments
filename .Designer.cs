
namespace Eapartments
{
    partial class frmBuildings
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
            this.txtBuildingID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuildingName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumOfFloors = new System.Windows.Forms.TextBox();
            this.txtBuildingLocation = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumOfParkingSpaces = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumofApartments = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.eApartmentsDataSet = new Eapartments.EApartmentsDataSet();
            this.dgvBuilding = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.eApartmentsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuilding)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuildingID
            // 
            this.txtBuildingID.Location = new System.Drawing.Point(192, 24);
            this.txtBuildingID.Name = "txtBuildingID";
            this.txtBuildingID.Size = new System.Drawing.Size(209, 22);
            this.txtBuildingID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Building ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Building Name";
            // 
            // txtBuildingName
            // 
            this.txtBuildingName.Location = new System.Drawing.Point(192, 83);
            this.txtBuildingName.Name = "txtBuildingName";
            this.txtBuildingName.Size = new System.Drawing.Size(209, 22);
            this.txtBuildingName.TabIndex = 3;
            this.txtBuildingName.TextChanged += new System.EventHandler(this.txtBuildingName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Number of Floors";
            // 
            // txtNumOfFloors
            // 
            this.txtNumOfFloors.Location = new System.Drawing.Point(192, 207);
            this.txtNumOfFloors.Name = "txtNumOfFloors";
            this.txtNumOfFloors.Size = new System.Drawing.Size(209, 22);
            this.txtNumOfFloors.TabIndex = 7;
            // 
            // txtBuildingLocation
            // 
            this.txtBuildingLocation.Location = new System.Drawing.Point(192, 148);
            this.txtBuildingLocation.Name = "txtBuildingLocation";
            this.txtBuildingLocation.Size = new System.Drawing.Size(209, 22);
            this.txtBuildingLocation.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Number of Parking Spaces";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtNumOfParkingSpaces
            // 
            this.txtNumOfParkingSpaces.Location = new System.Drawing.Point(192, 346);
            this.txtNumOfParkingSpaces.Name = "txtNumOfParkingSpaces";
            this.txtNumOfParkingSpaces.Size = new System.Drawing.Size(209, 22);
            this.txtNumOfParkingSpaces.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Number of Apartments";
            // 
            // txtNumofApartments
            // 
            this.txtNumofApartments.Location = new System.Drawing.Point(192, 281);
            this.txtNumofApartments.Name = "txtNumofApartments";
            this.txtNumofApartments.Size = new System.Drawing.Size(209, 22);
            this.txtNumofApartments.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Location";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(25, 602);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(113, 36);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(159, 602);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 36);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Telephone Number";
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(192, 400);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(209, 22);
            this.txtTelephone.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(87, 469);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Email Address";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(192, 466);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(209, 22);
            this.txtEmail.TabIndex = 20;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(299, 602);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(113, 36);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(431, 602);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 36);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // eApartmentsDataSet
            // 
            this.eApartmentsDataSet.DataSetName = "EApartmentsDataSet";
            this.eApartmentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvBuilding
            // 
            this.dgvBuilding.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuilding.Location = new System.Drawing.Point(452, 14);
            this.dgvBuilding.Name = "dgvBuilding";
            this.dgvBuilding.RowHeadersWidth = 51;
            this.dgvBuilding.RowTemplate.Height = 24;
            this.dgvBuilding.Size = new System.Drawing.Size(1303, 545);
            this.dgvBuilding.TabIndex = 24;
            this.dgvBuilding.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuilding_CellContentClick);
            this.dgvBuilding.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuilding_CellDoubleClick);
            // 
            // frmBuildings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1780, 686);
            this.Controls.Add(this.dgvBuilding);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNumOfParkingSpaces);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNumofApartments);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumOfFloors);
            this.Controls.Add(this.txtBuildingLocation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBuildingName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuildingID);
            this.Name = "frmBuildings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buildings";
            this.Load += new System.EventHandler(this.frmBuildings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eApartmentsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuilding)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBuildingID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuildingName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumOfFloors;
        private System.Windows.Forms.TextBox txtBuildingLocation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNumOfParkingSpaces;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNumofApartments;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private EApartmentsDataSet eApartmentsDataSet;
        private System.Windows.Forms.DataGridView dgvBuilding;
    }
}

