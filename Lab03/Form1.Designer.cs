namespace Lab03
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxBirth = new System.Windows.Forms.TextBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.textBoxGrade = new System.Windows.Forms.TextBox();
            this.textBoxBranch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.lable7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.StName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iHeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Branch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxAll = new System.Windows.Forms.TextBox();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ชื่อ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "รหัสนักศึกษา";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "ปีเกิด";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "ส่วนสูง";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "เกรด";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "สาขา";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(140, 35);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(217, 27);
            this.textBoxName.TabIndex = 6;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(140, 68);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(217, 27);
            this.textBoxId.TabIndex = 7;
            // 
            // textBoxBirth
            // 
            this.textBoxBirth.Location = new System.Drawing.Point(140, 101);
            this.textBoxBirth.Name = "textBoxBirth";
            this.textBoxBirth.Size = new System.Drawing.Size(217, 27);
            this.textBoxBirth.TabIndex = 8;
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(140, 167);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(217, 27);
            this.textBoxHeight.TabIndex = 9;
            // 
            // textBoxGrade
            // 
            this.textBoxGrade.Location = new System.Drawing.Point(140, 200);
            this.textBoxGrade.Name = "textBoxGrade";
            this.textBoxGrade.Size = new System.Drawing.Size(217, 27);
            this.textBoxGrade.TabIndex = 10;
            this.textBoxGrade.TextChanged += new System.EventHandler(this.textBoxGrade_TextChanged);
            // 
            // textBoxBranch
            // 
            this.textBoxBranch.Location = new System.Drawing.Point(140, 233);
            this.textBoxBranch.Name = "textBoxBranch";
            this.textBoxBranch.Size = new System.Drawing.Size(217, 27);
            this.textBoxBranch.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(140, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 29);
            this.button1.TabIndex = 12;
            this.button1.Text = "ตกลง";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(140, 134);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(217, 27);
            this.textBoxAge.TabIndex = 14;
            // 
            // lable7
            // 
            this.lable7.AutoSize = true;
            this.lable7.Location = new System.Drawing.Point(40, 141);
            this.lable7.Name = "lable7";
            this.lable7.Size = new System.Drawing.Size(32, 20);
            this.lable7.TabIndex = 13;
            this.lable7.Text = "อายุ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StName,
            this.Id,
            this.Birth,
            this.Age,
            this.iHeight,
            this.Grade,
            this.Branch});
            this.dataGridView1.Location = new System.Drawing.Point(382, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(927, 356);
            this.dataGridView1.TabIndex = 15;
            // 
            // StName
            // 
            this.StName.HeaderText = "ชื่อ";
            this.StName.MinimumWidth = 6;
            this.StName.Name = "StName";
            this.StName.ReadOnly = true;
            this.StName.Width = 125;
            // 
            // Id
            // 
            this.Id.HeaderText = "รหัสนักศึกษา";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 125;
            // 
            // Birth
            // 
            this.Birth.HeaderText = "ปีเกิด";
            this.Birth.MinimumWidth = 6;
            this.Birth.Name = "Birth";
            this.Birth.ReadOnly = true;
            this.Birth.Width = 125;
            // 
            // Age
            // 
            this.Age.HeaderText = "อายุ";
            this.Age.MinimumWidth = 6;
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            this.Age.Width = 125;
            // 
            // iHeight
            // 
            this.iHeight.HeaderText = "ส่วนสูง";
            this.iHeight.MinimumWidth = 6;
            this.iHeight.Name = "iHeight";
            this.iHeight.ReadOnly = true;
            this.iHeight.Width = 125;
            // 
            // Grade
            // 
            this.Grade.HeaderText = "เกรด";
            this.Grade.MinimumWidth = 6;
            this.Grade.Name = "Grade";
            this.Grade.ReadOnly = true;
            this.Grade.Width = 125;
            // 
            // Branch
            // 
            this.Branch.HeaderText = "สาขา";
            this.Branch.MinimumWidth = 6;
            this.Branch.Name = "Branch";
            this.Branch.ReadOnly = true;
            this.Branch.Width = 125;
            // 
            // textBoxAll
            // 
            this.textBoxAll.Location = new System.Drawing.Point(1092, 472);
            this.textBoxAll.Name = "textBoxAll";
            this.textBoxAll.Size = new System.Drawing.Size(217, 27);
            this.textBoxAll.TabIndex = 18;
            // 
            // textBoxMin
            // 
            this.textBoxMin.Location = new System.Drawing.Point(1092, 439);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.Size = new System.Drawing.Size(217, 27);
            this.textBoxMin.TabIndex = 17;
            // 
            // textBoxMax
            // 
            this.textBoxMax.Location = new System.Drawing.Point(1092, 406);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(217, 27);
            this.textBoxMax.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 517);
            this.Controls.Add(this.textBoxAll);
            this.Controls.Add(this.textBoxMin);
            this.Controls.Add(this.textBoxMax);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.lable7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxBranch);
            this.Controls.Add(this.textBoxGrade);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.textBoxBirth);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBoxName;
        private TextBox textBoxId;
        private TextBox textBoxBirth;
        private TextBox textBoxHeight;
        private TextBox textBoxGrade;
        private TextBox textBoxBranch;
        private Button button1;
        private TextBox textBoxAge;
        private Label lable7;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn StName;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Birth;
        private DataGridViewTextBoxColumn Age;
        private DataGridViewTextBoxColumn iHeight;
        private DataGridViewTextBoxColumn Grade;
        private DataGridViewTextBoxColumn Branch;
        private TextBox textBoxAll;
        private TextBox textBoxMin;
        private TextBox textBoxMax;
    }
}