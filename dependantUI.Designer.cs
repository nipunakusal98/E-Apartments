
namespace Eapartments
{
    partial class frmDependant
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbDepType = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDependantID = new System.Windows.Forms.TextBox();
            this.txtDepDelete = new System.Windows.Forms.Button();
            this.txtDepUpdate = new System.Windows.Forms.Button();
            this.txtDepAdd = new System.Windows.Forms.Button();
            this.txtDepSearch = new System.Windows.Forms.Button();
            this.dgvDependant = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDepEmailAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtDepTelephoneNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDepAddress = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDependantLastName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDependantFirstName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtOccID = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDependant)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbDepType);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtDependantID);
            this.groupBox2.Controls.Add(this.txtDepDelete);
            this.groupBox2.Controls.Add(this.txtDepUpdate);
            this.groupBox2.Controls.Add(this.txtDepAdd);
            this.groupBox2.Controls.Add(this.txtDepSearch);
            this.groupBox2.Controls.Add(this.dgvDependant);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtDepEmailAddress);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.TxtDepTelephoneNo);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtDepAddress);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtDependantLastName);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtDependantFirstName);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtOccID);
            this.groupBox2.Location = new System.Drawing.Point(12, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1423, 698);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dependant Details";
            // 
            // cmbDepType
            // 
            this.cmbDepType.FormattingEnabled = true;
            this.cmbDepType.Items.AddRange(new object[] {
            "Spouce",
            "child",
            "Parent",
            "Sibiling",
            "Servent"});
            this.cmbDepType.Location = new System.Drawing.Point(163, 247);
            this.cmbDepType.Name = "cmbDepType";
            this.cmbDepType.Size = new System.Drawing.Size(167, 24);
            this.cmbDepType.TabIndex = 31;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(26, 250);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(114, 17);
            this.label14.TabIndex = 30;
            this.label14.Text = "Dependant Type";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(26, 42);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 17);
            this.label13.TabIndex = 29;
            this.label13.Text = "Dependant ID";
            // 
            // txtDependantID
            // 
            this.txtDependantID.Location = new System.Drawing.Point(130, 39);
            this.txtDependantID.Name = "txtDependantID";
            this.txtDependantID.Size = new System.Drawing.Size(201, 22);
            this.txtDependantID.TabIndex = 28;
            this.txtDependantID.TextChanged += new System.EventHandler(this.txtDependantID_TextChanged);
            // 
            // txtDepDelete
            // 
            this.txtDepDelete.Location = new System.Drawing.Point(413, 552);
            this.txtDepDelete.Name = "txtDepDelete";
            this.txtDepDelete.Size = new System.Drawing.Size(113, 36);
            this.txtDepDelete.TabIndex = 27;
            this.txtDepDelete.Text = "Delete";
            this.txtDepDelete.UseVisualStyleBackColor = true;
            // 
            // txtDepUpdate
            // 
            this.txtDepUpdate.Location = new System.Drawing.Point(281, 552);
            this.txtDepUpdate.Name = "txtDepUpdate";
            this.txtDepUpdate.Size = new System.Drawing.Size(113, 36);
            this.txtDepUpdate.TabIndex = 26;
            this.txtDepUpdate.Text = "Update";
            this.txtDepUpdate.UseVisualStyleBackColor = true;
            // 
            // txtDepAdd
            // 
            this.txtDepAdd.Location = new System.Drawing.Point(141, 552);
            this.txtDepAdd.Name = "txtDepAdd";
            this.txtDepAdd.Size = new System.Drawing.Size(113, 36);
            this.txtDepAdd.TabIndex = 25;
            this.txtDepAdd.Text = "Add";
            this.txtDepAdd.UseVisualStyleBackColor = true;
            // 
            // txtDepSearch
            // 
            this.txtDepSearch.Location = new System.Drawing.Point(7, 552);
            this.txtDepSearch.Name = "txtDepSearch";
            this.txtDepSearch.Size = new System.Drawing.Size(113, 36);
            this.txtDepSearch.TabIndex = 24;
            this.txtDepSearch.Text = "Search";
            this.txtDepSearch.UseVisualStyleBackColor = true;
            // 
            // dgvDependant
            // 
            this.dgvDependant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDependant.Location = new System.Drawing.Point(369, 21);
            this.dgvDependant.Name = "dgvDependant";
            this.dgvDependant.RowHeadersWidth = 51;
            this.dgvDependant.RowTemplate.Height = 24;
            this.dgvDependant.Size = new System.Drawing.Size(1030, 500);
            this.dgvDependant.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Email Address";
            // 
            // txtDepEmailAddress
            // 
            this.txtDepEmailAddress.Location = new System.Drawing.Point(130, 347);
            this.txtDepEmailAddress.Name = "txtDepEmailAddress";
            this.txtDepEmailAddress.Size = new System.Drawing.Size(201, 22);
            this.txtDepEmailAddress.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Telephone No";
            // 
            // TxtDepTelephoneNo
            // 
            this.TxtDepTelephoneNo.Location = new System.Drawing.Point(130, 287);
            this.TxtDepTelephoneNo.Name = "TxtDepTelephoneNo";
            this.TxtDepTelephoneNo.Size = new System.Drawing.Size(201, 22);
            this.TxtDepTelephoneNo.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Address";
            // 
            // txtDepAddress
            // 
            this.txtDepAddress.Location = new System.Drawing.Point(129, 210);
            this.txtDepAddress.Name = "txtDepAddress";
            this.txtDepAddress.Size = new System.Drawing.Size(201, 22);
            this.txtDepAddress.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "Last Name";
            // 
            // txtDependantLastName
            // 
            this.txtDependantLastName.Location = new System.Drawing.Point(130, 164);
            this.txtDependantLastName.Name = "txtDependantLastName";
            this.txtDependantLastName.Size = new System.Drawing.Size(201, 22);
            this.txtDependantLastName.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 17);
            this.label11.TabIndex = 3;
            this.label11.Text = "First Name";
            // 
            // txtDependantFirstName
            // 
            this.txtDependantFirstName.Location = new System.Drawing.Point(130, 120);
            this.txtDependantFirstName.Name = "txtDependantFirstName";
            this.txtDependantFirstName.Size = new System.Drawing.Size(201, 22);
            this.txtDependantFirstName.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 17);
            this.label12.TabIndex = 1;
            this.label12.Text = "Occupant ID";
            // 
            // txtOccID
            // 
            this.txtOccID.Location = new System.Drawing.Point(130, 77);
            this.txtOccID.Name = "txtOccID";
            this.txtOccID.Size = new System.Drawing.Size(201, 22);
            this.txtOccID.TabIndex = 0;
            // 
            // frmDependant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1447, 735);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmDependant";
            this.Text = "Dependant Details";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDependant)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbDepType;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDependantID;
        private System.Windows.Forms.Button txtDepDelete;
        private System.Windows.Forms.Button txtDepUpdate;
        private System.Windows.Forms.Button txtDepAdd;
        private System.Windows.Forms.Button txtDepSearch;
        private System.Windows.Forms.DataGridView dgvDependant;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDepEmailAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtDepTelephoneNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDepAddress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDependantLastName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDependantFirstName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtOccID;
    }
}