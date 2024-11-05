namespace Behr_Singo_Thomas_Veldman_PRG282_Project
{
    partial class frmStudent
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.gbxDetails = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.edtName = new System.Windows.Forms.TextBox();
            this.edtNumber = new System.Windows.Forms.TextBox();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.cmbxCourse = new System.Windows.Forms.ComboBox();
            this.dtgvStudent = new System.Windows.Forms.DataGridView();
            this.StudentNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentCourse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSummary = new System.Windows.Forms.Button();
            this.lblResults = new System.Windows.Forms.Label();
            this.gbxDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Arial Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblHeading.Location = new System.Drawing.Point(141, 9);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(525, 48);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Managing Student Records";
            // 
            // gbxDetails
            // 
            this.gbxDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gbxDetails.Controls.Add(this.cmbxCourse);
            this.gbxDetails.Controls.Add(this.numAge);
            this.gbxDetails.Controls.Add(this.edtNumber);
            this.gbxDetails.Controls.Add(this.edtName);
            this.gbxDetails.Controls.Add(this.lblCourse);
            this.gbxDetails.Controls.Add(this.lblAge);
            this.gbxDetails.Controls.Add(this.lblNumber);
            this.gbxDetails.Controls.Add(this.lblName);
            this.gbxDetails.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDetails.Location = new System.Drawing.Point(13, 67);
            this.gbxDetails.Name = "gbxDetails";
            this.gbxDetails.Size = new System.Drawing.Size(291, 218);
            this.gbxDetails.TabIndex = 1;
            this.gbxDetails.TabStop = false;
            this.gbxDetails.Text = "ENTER NEW STUDENT\'S DETAILS:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 34);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 22);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(6, 80);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(127, 22);
            this.lblNumber.TabIndex = 1;
            this.lblNumber.Text = "Student Number:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(6, 128);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(42, 22);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Age:";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(6, 177);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(65, 22);
            this.lblCourse.TabIndex = 3;
            this.lblCourse.Text = "Course:";
            // 
            // edtName
            // 
            this.edtName.Location = new System.Drawing.Point(136, 34);
            this.edtName.Name = "edtName";
            this.edtName.Size = new System.Drawing.Size(149, 27);
            this.edtName.TabIndex = 4;
            // 
            // edtNumber
            // 
            this.edtNumber.Location = new System.Drawing.Point(136, 80);
            this.edtNumber.Name = "edtNumber";
            this.edtNumber.Size = new System.Drawing.Size(149, 27);
            this.edtNumber.TabIndex = 5;
            // 
            // numAge
            // 
            this.numAge.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numAge.Location = new System.Drawing.Point(136, 128);
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(149, 27);
            this.numAge.TabIndex = 6;
            // 
            // cmbxCourse
            // 
            this.cmbxCourse.FormattingEnabled = true;
            this.cmbxCourse.Items.AddRange(new object[] {
            "Bachelor of Computing",
            "Bachelor of IT",
            "Diploma in IT"});
            this.cmbxCourse.Location = new System.Drawing.Point(136, 177);
            this.cmbxCourse.Name = "cmbxCourse";
            this.cmbxCourse.Size = new System.Drawing.Size(149, 30);
            this.cmbxCourse.TabIndex = 7;
            // 
            // dtgvStudent
            // 
            this.dtgvStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentNumber,
            this.StudentName,
            this.StudentAge,
            this.StudentCourse});
            this.dtgvStudent.Location = new System.Drawing.Point(311, 67);
            this.dtgvStudent.Name = "dtgvStudent";
            this.dtgvStudent.RowHeadersWidth = 51;
            this.dtgvStudent.RowTemplate.Height = 24;
            this.dtgvStudent.Size = new System.Drawing.Size(477, 287);
            this.dtgvStudent.TabIndex = 2;
            // 
            // StudentNumber
            // 
            this.StudentNumber.HeaderText = "Student Number";
            this.StudentNumber.MinimumWidth = 6;
            this.StudentNumber.Name = "StudentNumber";
            // 
            // StudentName
            // 
            this.StudentName.HeaderText = "Name";
            this.StudentName.MinimumWidth = 6;
            this.StudentName.Name = "StudentName";
            // 
            // StudentAge
            // 
            this.StudentAge.HeaderText = "Age";
            this.StudentAge.MinimumWidth = 6;
            this.StudentAge.Name = "StudentAge";
            // 
            // StudentCourse
            // 
            this.StudentCourse.HeaderText = "Course";
            this.StudentCourse.MinimumWidth = 6;
            this.StudentCourse.Name = "StudentCourse";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAdd.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(13, 291);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(291, 44);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add A New Student";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnView.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(311, 360);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(477, 44);
            this.btnView.TabIndex = 4;
            this.btnView.Text = "View All Students";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDelete.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(311, 410);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(237, 44);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete A Student";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnUpdate.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(554, 410);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(234, 44);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update Student\'s Information";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSummary
            // 
            this.btnSummary.BackColor = System.Drawing.Color.Teal;
            this.btnSummary.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSummary.Location = new System.Drawing.Point(13, 360);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(292, 44);
            this.btnSummary.TabIndex = 7;
            this.btnSummary.Text = "Generate A Summary Report";
            this.btnSummary.UseVisualStyleBackColor = false;
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(12, 425);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(287, 16);
            this.lblResults.TabIndex = 8;
            this.lblResults.Text = "The results of the summary will appear here";
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.btnSummary);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtgvStudent);
            this.Controls.Add(this.gbxDetails);
            this.Controls.Add(this.lblHeading);
            this.Name = "frmStudent";
            this.Text = "Managing Student Records";
            this.gbxDetails.ResumeLayout(false);
            this.gbxDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.GroupBox gbxDetails;
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.TextBox edtNumber;
        private System.Windows.Forms.TextBox edtName;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cmbxCourse;
        private System.Windows.Forms.DataGridView dtgvStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentCourse;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSummary;
        private System.Windows.Forms.Label lblResults;
    }
}

