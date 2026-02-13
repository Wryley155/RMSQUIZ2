namespace RMS.App

{

    partial class MainForm : Form

    {

        private System.ComponentModel.IContainer components = null;



        protected override void Dispose(bool disposing)

        {

            if (disposing && (components != null))

            {

                components.Dispose();

            }

            base.Dispose(disposing);

        }



        #region Windows Form Designer generated code



        private void InitializeComponent()

        {
            dgvEquipment = new DataGridView();
            grpDetails = new GroupBox();
            lblStatus = new Label();
            cboStatus = new ComboBox();
            lblCategory = new Label();
            txtCategory = new TextBox();
            lblModel = new Label();
            txtModel = new TextBox();
            lblSerial = new Label();
            txtSerial = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            lblTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEquipment).BeginInit();
            grpDetails.SuspendLayout();
            SuspendLayout();
            // 
            // dgvEquipment
            // 
            dgvEquipment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipment.Location = new Point(14, 58);
            dgvEquipment.Margin = new Padding(4, 3, 4, 3);
            dgvEquipment.Name = "dgvEquipment";
            dgvEquipment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEquipment.Size = new Size(583, 448);
            dgvEquipment.TabIndex = 0;
            dgvEquipment.SelectionChanged += dgvEquipment_SelectionChanged;
            // 
            // grpDetails
            // 
            grpDetails.Controls.Add(lblStatus);
            grpDetails.Controls.Add(cboStatus);
            grpDetails.Controls.Add(lblCategory);
            grpDetails.Controls.Add(txtCategory);
            grpDetails.Controls.Add(lblModel);
            grpDetails.Controls.Add(txtModel);
            grpDetails.Controls.Add(lblSerial);
            grpDetails.Controls.Add(txtSerial);
            grpDetails.Controls.Add(btnAdd);
            grpDetails.Controls.Add(btnUpdate);
            grpDetails.Controls.Add(btnDelete);
            grpDetails.Location = new Point(618, 58);
            grpDetails.Margin = new Padding(4, 3, 4, 3);
            grpDetails.Name = "grpDetails";
            grpDetails.Padding = new Padding(4, 3, 4, 3);
            grpDetails.Size = new Size(301, 448);
            grpDetails.TabIndex = 1;
            grpDetails.TabStop = false;
            grpDetails.Text = "Equipment Details";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(18, 185);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 15);
            lblStatus.TabIndex = 10;
            lblStatus.Text = "Status";
            // 
            // cboStatus
            // 
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatus.FormattingEnabled = true;
            cboStatus.Location = new Point(21, 203);
            cboStatus.Margin = new Padding(4, 3, 4, 3);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(256, 23);
            cboStatus.TabIndex = 9;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(18, 133);
            lblCategory.Margin = new Padding(4, 0, 4, 0);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(55, 15);
            lblCategory.TabIndex = 8;
            lblCategory.Text = "Category";
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(21, 151);
            txtCategory.Margin = new Padding(4, 3, 4, 3);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(256, 23);
            txtCategory.TabIndex = 7;
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(18, 81);
            lblModel.Margin = new Padding(4, 0, 4, 0);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(41, 15);
            lblModel.TabIndex = 6;
            lblModel.Text = "Model";
            // 
            // txtModel
            // 
            txtModel.Location = new Point(21, 99);
            txtModel.Margin = new Padding(4, 3, 4, 3);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(256, 23);
            txtModel.TabIndex = 5;
            // 
            // lblSerial
            // 
            lblSerial.AutoSize = true;
            lblSerial.Location = new Point(18, 29);
            lblSerial.Margin = new Padding(4, 0, 4, 0);
            lblSerial.Name = "lblSerial";
            lblSerial.Size = new Size(82, 15);
            lblSerial.TabIndex = 4;
            lblSerial.Text = "Serial Number";
            // 
            // txtSerial
            // 
            txtSerial.Location = new Point(21, 47);
            txtSerial.Margin = new Padding(4, 3, 4, 3);
            txtSerial.Name = "txtSerial";
            txtSerial.Size = new Size(256, 23);
            txtSerial.TabIndex = 3;
            txtSerial.TextChanged += txtSerial_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LightGreen;
            btnAdd.Location = new Point(21, 254);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(257, 40);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add New";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.LightBlue;
            btnUpdate.Location = new Point(21, 301);
            btnUpdate.Margin = new Padding(4, 3, 4, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(257, 40);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update ";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Salmon;
            btnDelete.Location = new Point(21, 348);
            btnDelete.Margin = new Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(257, 40);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(14, 15);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(300, 24);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Resource Management System";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(lblTitle);
            Controls.Add(grpDetails);
            Controls.Add(dgvEquipment);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            Text = "Resource Management System";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEquipment).EndInit();
            grpDetails.ResumeLayout(false);
            grpDetails.PerformLayout();
            ResumeLayout(false);
            PerformLayout();



        }



        #endregion



        private System.Windows.Forms.DataGridView dgvEquipment;

        private System.Windows.Forms.GroupBox grpDetails;

        private System.Windows.Forms.Label lblStatus;

        private System.Windows.Forms.ComboBox cboStatus;

        private System.Windows.Forms.Label lblCategory;

        private System.Windows.Forms.TextBox txtCategory;

        private System.Windows.Forms.Label lblModel;

        private System.Windows.Forms.TextBox txtModel;

        private System.Windows.Forms.Label lblSerial;

        private System.Windows.Forms.TextBox txtSerial;

        private System.Windows.Forms.Button btnAdd;

        private System.Windows.Forms.Button btnUpdate;

        private System.Windows.Forms.Button btnDelete;

        private System.Windows.Forms.Label lblTitle;

    }

}

