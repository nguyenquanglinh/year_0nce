namespace LamLai
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.labelTen = new System.Windows.Forms.Label();
            this.labelGioiTinh = new System.Windows.Forms.Label();
            this.labelTuoi = new System.Windows.Forms.Label();
            this.labelDiaChi = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamePeople = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenDer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bds = new System.Windows.Forms.BindingSource(this.components);
            this.btnThem = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtStt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTen
            // 
            this.labelTen.AutoSize = true;
            this.labelTen.Location = new System.Drawing.Point(0, 20);
            this.labelTen.Name = "labelTen";
            this.labelTen.Size = new System.Drawing.Size(60, 13);
            this.labelTen.TabIndex = 0;
            this.labelTen.Text = "Họ và tên :";
            // 
            // labelGioiTinh
            // 
            this.labelGioiTinh.AutoSize = true;
            this.labelGioiTinh.Location = new System.Drawing.Point(0, 106);
            this.labelGioiTinh.Name = "labelGioiTinh";
            this.labelGioiTinh.Size = new System.Drawing.Size(57, 13);
            this.labelGioiTinh.TabIndex = 1;
            this.labelGioiTinh.Text = "Giới Tính :";
            // 
            // labelTuoi
            // 
            this.labelTuoi.AutoSize = true;
            this.labelTuoi.Location = new System.Drawing.Point(0, 63);
            this.labelTuoi.Name = "labelTuoi";
            this.labelTuoi.Size = new System.Drawing.Size(34, 13);
            this.labelTuoi.TabIndex = 2;
            this.labelTuoi.Text = "Tuổi :";
            // 
            // labelDiaChi
            // 
            this.labelDiaChi.AutoSize = true;
            this.labelDiaChi.Location = new System.Drawing.Point(0, 149);
            this.labelDiaChi.Name = "labelDiaChi";
            this.labelDiaChi.Size = new System.Drawing.Size(40, 13);
            this.labelDiaChi.TabIndex = 3;
            this.labelDiaChi.Text = "Địa chỉ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(116, 13);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(116, 99);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(100, 20);
            this.txtGender.TabIndex = 6;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(116, 56);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 7;
            this.txtAge.Validating += new System.ComponentModel.CancelEventHandler(this.txtAge_Validating);
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(116, 142);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(100, 20);
            this.txtAdress.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.CausesValidation = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Stt,
            this.NamePeople,
            this.Age,
            this.GenDer,
            this.Adress});
            this.dataGridView1.DataSource = this.bds;
            this.dataGridView1.Location = new System.Drawing.Point(3, 200);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(540, 190);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.UseWaitCursor = true;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Stt
            // 
            this.Stt.DataPropertyName = "Stt";
            this.Stt.HeaderText = "Stt";
            this.Stt.Name = "Stt";
            // 
            // NamePeople
            // 
            this.NamePeople.DataPropertyName = "Name";
            this.NamePeople.HeaderText = "Họ và tên";
            this.NamePeople.Name = "NamePeople";
            // 
            // Age
            // 
            this.Age.DataPropertyName = "Age";
            this.Age.HeaderText = "Tuổi";
            this.Age.Name = "Age";
            // 
            // GenDer
            // 
            this.GenDer.DataPropertyName = "Gender";
            this.GenDer.HeaderText = "Giới tính";
            this.GenDer.Name = "GenDer";
            // 
            // Adress
            // 
            this.Adress.DataPropertyName = "Adress";
            this.Adress.HeaderText = "Địa chỉ";
            this.Adress.Name = "Adress";
            // 
            // bds
            // 
            this.bds.CurrentItemChanged += new System.EventHandler(this.bds_CurrentItemChanged);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(269, 80);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 96);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // txtStt
            // 
            this.txtStt.Location = new System.Drawing.Point(286, 16);
            this.txtStt.Name = "txtStt";
            this.txtStt.Size = new System.Drawing.Size(58, 20);
            this.txtStt.TabIndex = 11;
            this.txtStt.TextChanged += new System.EventHandler(this.txtStt_TextChanged);
            this.txtStt.Enter += new System.EventHandler(this.txtStt_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "STT";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(407, 83);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(81, 93);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(390, 16);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(98, 23);
            this.btnXem.TabIndex = 15;
            this.btnXem.Text = "Xem thông tin";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 399);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStt);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labelDiaChi);
            this.Controls.Add(this.labelTuoi);
            this.Controls.Add(this.labelGioiTinh);
            this.Controls.Add(this.labelTen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTen;
        private System.Windows.Forms.Label labelGioiTinh;
        private System.Windows.Forms.Label labelTuoi;
        private System.Windows.Forms.Label labelDiaChi;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.BindingSource bds;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamePeople;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenDer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adress;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnXem;
    }
}

