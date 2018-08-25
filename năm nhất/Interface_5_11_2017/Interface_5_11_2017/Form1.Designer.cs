namespace Interface_5_11_2017
{
    partial class People
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbGender = new System.Windows.Forms.ComboBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.GridView1 = new System.Windows.Forms.DataGridView();
            this.NamePeople = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgePeople = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressPeople = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenderPeople = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdn = new System.Windows.Forms.BindingSource(this.components);
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbbUse = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbGender);
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Controls.Add(this.TxtAddress);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 186);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Imformation";
            // 
            // cbbGender
            // 
            this.cbbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGender.FormattingEnabled = true;
            this.cbbGender.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbbGender.Location = new System.Drawing.Point(123, 135);
            this.cbbGender.Name = "cbbGender";
            this.cbbGender.Size = new System.Drawing.Size(150, 21);
            this.cbbGender.TabIndex = 3;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(123, 65);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(150, 20);
            this.txtAge.TabIndex = 1;
            this.txtAge.Validating += new System.ComponentModel.CancelEventHandler(this.txtAge_Validating);
            // 
            // TxtAddress
            // 
            this.TxtAddress.Location = new System.Drawing.Point(123, 100);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(150, 20);
            this.TxtAddress.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(123, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 20);
            this.txtName.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Giới tính :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Address :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Age :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLoad);
            this.groupBox2.Controls.Add(this.btnRemove);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Location = new System.Drawing.Point(381, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(205, 119);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Use Of Imformation";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(113, 65);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(81, 29);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(113, 19);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(7, 71);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(7, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.GridView1);
            this.groupBox3.Location = new System.Drawing.Point(13, 205);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(554, 118);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Imformation";
            // 
            // GridView1
            // 
            this.GridView1.AutoGenerateColumns = false;
            this.GridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NamePeople,
            this.AgePeople,
            this.AddressPeople,
            this.GenderPeople});
            this.GridView1.DataSource = this.bdn;
            this.GridView1.Location = new System.Drawing.Point(7, 20);
            this.GridView1.Name = "GridView1";
            this.GridView1.Size = new System.Drawing.Size(547, 107);
            this.GridView1.TabIndex = 0;
            // 
            // NamePeople
            // 
            this.NamePeople.DataPropertyName = "Name";
            this.NamePeople.FillWeight = 150F;
            this.NamePeople.HeaderText = "Name";
            this.NamePeople.Name = "NamePeople";
            this.NamePeople.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NamePeople.Width = 130;
            // 
            // AgePeople
            // 
            this.AgePeople.DataPropertyName = "Age";
            this.AgePeople.FillWeight = 150F;
            this.AgePeople.HeaderText = "Age";
            this.AgePeople.Name = "AgePeople";
            this.AgePeople.Width = 130;
            // 
            // AddressPeople
            // 
            this.AddressPeople.DataPropertyName = "Address";
            this.AddressPeople.FillWeight = 150F;
            this.AddressPeople.HeaderText = "Addess";
            this.AddressPeople.Name = "AddressPeople";
            this.AddressPeople.Width = 130;
            // 
            // GenderPeople
            // 
            this.GenderPeople.DataPropertyName = "Gender";
            this.GenderPeople.FillWeight = 150F;
            this.GenderPeople.HeaderText = "Gender";
            this.GenderPeople.Name = "GenderPeople";
            this.GenderPeople.Width = 130;
            // 
            // bdn
            // 
            this.bdn.CurrentItemChanged += new System.EventHandler(this.bdn_CurrentItemChanged);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbbUse);
            this.groupBox4.Location = new System.Drawing.Point(374, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(181, 46);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Data";
            // 
            // cbbUse
            // 
            this.cbbUse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbUse.FormattingEnabled = true;
            this.cbbUse.Items.AddRange(new object[] {
            "Memory",
            "Data.Txt"});
            this.cbbUse.Location = new System.Drawing.Point(7, 20);
            this.cbbUse.Name = "cbbUse";
            this.cbbUse.Size = new System.Drawing.Size(174, 21);
            this.cbbUse.TabIndex = 0;
            this.cbbUse.SelectedIndexChanged += new System.EventHandler(this.cbbUse_SelectedIndexChanged);
            this.cbbUse.SelectedValueChanged += new System.EventHandler(this.cbbUse_SelectedValueChanged);
            // 
            // People
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 386);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "People";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbGender;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView GridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamePeople;
        private System.Windows.Forms.DataGridViewTextBoxColumn AgePeople;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressPeople;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenderPeople;
        private System.Windows.Forms.BindingSource bdn;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbbUse;
    }
}

