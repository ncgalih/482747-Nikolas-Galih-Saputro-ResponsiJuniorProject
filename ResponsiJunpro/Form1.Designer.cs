namespace ResponsiJunpro
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            tbKaryawan = new TextBox();
            tbDepartemen = new TextBox();
            btnInsert = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            dgvKaryawan = new DataGridView();
            btnSave = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvKaryawan).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(78, 67);
            label1.Name = "label1";
            label1.Size = new Size(135, 21);
            label1.TabIndex = 0;
            label1.Text = "Nama Karyawan : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(78, 106);
            label2.Name = "label2";
            label2.Size = new Size(133, 21);
            label2.TabIndex = 1;
            label2.Text = "Dep Karyawan    : ";
            // 
            // tbKaryawan
            // 
            tbKaryawan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbKaryawan.Location = new Point(230, 64);
            tbKaryawan.Name = "tbKaryawan";
            tbKaryawan.Size = new Size(181, 29);
            tbKaryawan.TabIndex = 2;
            // 
            // tbDepartemen
            // 
            tbDepartemen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbDepartemen.Location = new Point(230, 106);
            tbDepartemen.Name = "tbDepartemen";
            tbDepartemen.Size = new Size(181, 29);
            tbDepartemen.TabIndex = 3;
            // 
            // btnInsert
            // 
            btnInsert.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnInsert.Location = new Point(78, 180);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(119, 31);
            btnInsert.TabIndex = 5;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.Location = new Point(230, 180);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(119, 31);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(604, 180);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(119, 31);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvKaryawan
            // 
            dgvKaryawan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKaryawan.Location = new Point(78, 229);
            dgvKaryawan.Name = "dgvKaryawan";
            dgvKaryawan.RowTemplate.Height = 25;
            dgvKaryawan.Size = new Size(645, 289);
            dgvKaryawan.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(355, 180);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(119, 31);
            btnSave.TabIndex = 9;
            btnSave.Text = "SaveEdit";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(601, 23);
            label3.Name = "label3";
            label3.Size = new Size(122, 21);
            label3.TabIndex = 10;
            label3.Text = "ID Departemen :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(601, 44);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 11;
            label4.Text = "HR : HR";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(601, 64);
            label5.Name = "label5";
            label5.Size = new Size(107, 20);
            label5.TabIndex = 12;
            label5.Text = "ENG : Engineer";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(601, 84);
            label6.Name = "label6";
            label6.Size = new Size(117, 20);
            label6.TabIndex = 13;
            label6.Text = "DEV : Developer";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(601, 104);
            label7.Name = "label7";
            label7.Size = new Size(109, 20);
            label7.TabIndex = 14;
            label7.Text = "PM : Product M";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(601, 124);
            label8.Name = "label8";
            label8.Size = new Size(92, 20);
            label8.TabIndex = 15;
            label8.Text = "FIN : Finance";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 555);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnSave);
            Controls.Add(dgvKaryawan);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnInsert);
            Controls.Add(tbDepartemen);
            Controls.Add(tbKaryawan);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKaryawan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbKaryawan;
        private TextBox tbDepartemen;
        private Button btnInsert;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridView dgvKaryawan;
        private Button btnSave;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}