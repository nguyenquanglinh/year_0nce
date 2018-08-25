namespace Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtTuoi = new System.Windows.Forms.TextBox();
            this.gridview1 = new System.Windows.Forms.DataGridView();
            this.NamePeople = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdn = new System.Windows.Forms.BindingSource(this.components);
            this.btnLuu = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridview1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và  tên :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tuổi :";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(100, 24);
            this.txtTen.Name = "txtTen";
            this.txtTen.ReadOnly = true;
            this.txtTen.Size = new System.Drawing.Size(100, 20);
            this.txtTen.TabIndex = 2;
            // 
            // txtTuoi
            // 
            this.txtTuoi.Location = new System.Drawing.Point(100, 62);
            this.txtTuoi.Name = "txtTuoi";
            this.txtTuoi.ReadOnly = true;
            this.txtTuoi.Size = new System.Drawing.Size(100, 20);
            this.txtTuoi.TabIndex = 3;
            this.txtTuoi.Validating += new System.ComponentModel.CancelEventHandler(this.txtTuoi_Validating);
            // 
            // gridview1
            // 
            this.gridview1.AllowUserToAddRows = false;
            this.gridview1.AutoGenerateColumns = false;
            this.gridview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridview1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NamePeople,
            this.Age});
            this.gridview1.DataSource = this.bdn;
            this.gridview1.Location = new System.Drawing.Point(2, 102);
            this.gridview1.Name = "gridview1";
            this.gridview1.ReadOnly = true;
            this.gridview1.Size = new System.Drawing.Size(240, 150);
            this.gridview1.TabIndex = 4;
            this.gridview1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridview1_CellDoubleClick);
            // 
            // NamePeople
            // 
            this.NamePeople.DataPropertyName = "Name";
            this.NamePeople.HeaderText = "Họ và tên ";
            this.NamePeople.Name = "NamePeople";
            this.NamePeople.ReadOnly = true;
            // 
            // Age
            // 
            this.Age.DataPropertyName = "Age";
            this.Age.HeaderText = "Tuổi";
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            // 
            // bdn
            // 
            this.bdn.CurrentChanged += new System.EventHandler(this.bdn_CurrentChanged);
            this.bdn.CurrentItemChanged += new System.EventHandler(this.bdn_CurrentItemChanged);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(459, 57);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(459, 102);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Them";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(459, 154);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(459, 206);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 8;
            this.btnHuy.Text = "Huy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 285);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.gridview1);
            this.Controls.Add(this.txtTuoi);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridview1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtTuoi;
        private System.Windows.Forms.DataGridView gridview1;
        private System.Windows.Forms.BindingSource bdn;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamePeople;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnHuy;
    }
}

