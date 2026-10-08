namespace nguyenhailongb3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox groupBoxLeft;
        private System.Windows.Forms.Button btnXoaAll;
        private System.Windows.Forms.Button btnXoaDong;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label labelDonGia;
        private System.Windows.Forms.ComboBox comboDonVi;
        private System.Windows.Forms.Label labelDonVi;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label labelTen;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label labelMa;
        private System.Windows.Forms.GroupBox groupBoxRight;
        private System.Windows.Forms.ListView listViewItems;
        private System.Windows.Forms.ColumnHeader columnMa;
        private System.Windows.Forms.ColumnHeader columnTen;
        private System.Windows.Forms.ColumnHeader columnDonVi;
        private System.Windows.Forms.ColumnHeader columnDonGia;

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
            groupBoxLeft = new GroupBox();
            btnXoaAll = new Button();
            btnXoaDong = new Button();
            btnCapNhat = new Button();
            btnThem = new Button();
            txtDonGia = new TextBox();
            labelDonGia = new Label();
            comboDonVi = new ComboBox();
            labelDonVi = new Label();
            txtTen = new TextBox();
            labelTen = new Label();
            txtMa = new TextBox();
            labelMa = new Label();
            groupBoxRight = new GroupBox();
            listViewItems = new ListView();
            columnMa = new ColumnHeader();
            columnTen = new ColumnHeader();
            columnDonVi = new ColumnHeader();
            columnDonGia = new ColumnHeader();
            groupBoxLeft.SuspendLayout();
            groupBoxRight.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxLeft
            // 
            groupBoxLeft.Controls.Add(btnXoaAll);
            groupBoxLeft.Controls.Add(btnXoaDong);
            groupBoxLeft.Controls.Add(btnCapNhat);
            groupBoxLeft.Controls.Add(btnThem);
            groupBoxLeft.Controls.Add(txtDonGia);
            groupBoxLeft.Controls.Add(labelDonGia);
            groupBoxLeft.Controls.Add(comboDonVi);
            groupBoxLeft.Controls.Add(labelDonVi);
            groupBoxLeft.Controls.Add(txtTen);
            groupBoxLeft.Controls.Add(labelTen);
            groupBoxLeft.Controls.Add(txtMa);
            groupBoxLeft.Controls.Add(labelMa);
            groupBoxLeft.Location = new Point(12, 12);
            groupBoxLeft.Name = "groupBoxLeft";
            groupBoxLeft.Size = new Size(350, 426);
            groupBoxLeft.TabIndex = 0;
            groupBoxLeft.TabStop = false;
            groupBoxLeft.Text = "Khung nhập liệu";
            // 
            // btnXoaAll
            // 
            btnXoaAll.Location = new Point(126, 246);
            btnXoaAll.Name = "btnXoaAll";
            btnXoaAll.Size = new Size(90, 30);
            btnXoaAll.TabIndex = 11;
            btnXoaAll.Text = "Xóa toàn bộ";
            btnXoaAll.UseVisualStyleBackColor = true;
            btnXoaAll.Click += btnXoaAll_Click;
            // 
            // btnXoaDong
            // 
            btnXoaDong.Location = new Point(16, 246);
            btnXoaDong.Name = "btnXoaDong";
            btnXoaDong.Size = new Size(90, 30);
            btnXoaDong.TabIndex = 10;
            btnXoaDong.Text = "Xóa dòng";
            btnXoaDong.UseVisualStyleBackColor = true;
            btnXoaDong.Click += btnXoaDong_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(126, 200);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(90, 30);
            btnCapNhat.TabIndex = 9;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(16, 200);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(90, 30);
            btnThem.TabIndex = 8;
            btnThem.Text = "Thêm mới";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(120, 148);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(200, 23);
            txtDonGia.TabIndex = 7;
            // 
            // labelDonGia
            // 
            labelDonGia.AutoSize = true;
            labelDonGia.Location = new Point(16, 151);
            labelDonGia.Name = "labelDonGia";
            labelDonGia.Size = new Size(51, 15);
            labelDonGia.TabIndex = 6;
            labelDonGia.Text = "Đơn giá:";
            // 
            // comboDonVi
            // 
            comboDonVi.DropDownStyle = ComboBoxStyle.DropDownList;
            comboDonVi.FormattingEnabled = true;
            comboDonVi.Items.AddRange(new object[] { "Cái", "Bộ", "Kg", "Mét" });
            comboDonVi.Location = new Point(120, 109);
            comboDonVi.Name = "comboDonVi";
            comboDonVi.Size = new Size(200, 23);
            comboDonVi.TabIndex = 5;
            // 
            // labelDonVi
            // 
            labelDonVi.AutoSize = true;
            labelDonVi.Location = new Point(16, 112);
            labelDonVi.Name = "labelDonVi";
            labelDonVi.Size = new Size(68, 15);
            labelDonVi.TabIndex = 4;
            labelDonVi.Text = "Đơn vị tính:";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(120, 70);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(200, 23);
            txtTen.TabIndex = 3;
            // 
            // labelTen
            // 
            labelTen.AutoSize = true;
            labelTen.Location = new Point(16, 73);
            labelTen.Name = "labelTen";
            labelTen.Size = new Size(62, 15);
            labelTen.TabIndex = 2;
            labelTen.Text = "Tên vật tư:";
            // 
            // txtMa
            // 
            txtMa.Location = new Point(120, 31);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(200, 23);
            txtMa.TabIndex = 1;
            // 
            // labelMa
            // 
            labelMa.AutoSize = true;
            labelMa.Location = new Point(16, 34);
            labelMa.Name = "labelMa";
            labelMa.Size = new Size(60, 15);
            labelMa.TabIndex = 0;
            labelMa.Text = "Mã vật tư:";
            // 
            // groupBoxRight
            // 
            groupBoxRight.Controls.Add(listViewItems);
            groupBoxRight.Location = new Point(378, 12);
            groupBoxRight.Name = "groupBoxRight";
            groupBoxRight.Size = new Size(410, 426);
            groupBoxRight.TabIndex = 1;
            groupBoxRight.TabStop = false;
            groupBoxRight.Text = "Danh sách Vật tư / Linh kiện";
            // 
            // listViewItems
            // 
            listViewItems.Columns.AddRange(new ColumnHeader[] { columnMa, columnTen, columnDonVi, columnDonGia });
            listViewItems.FullRowSelect = true;
            listViewItems.GridLines = true;
            listViewItems.Location = new Point(6, 22);
            listViewItems.Name = "listViewItems";
            listViewItems.Size = new Size(398, 398);
            listViewItems.TabIndex = 0;
            listViewItems.UseCompatibleStateImageBehavior = false;
            listViewItems.View = View.Details;
            listViewItems.SelectedIndexChanged += listViewItems_SelectedIndexChanged;
            // 
            // columnMa
            // 
            columnMa.Text = "Mã VT";
            columnMa.Width = 80;
            // 
            // columnTen
            // 
            columnTen.Text = "Tên VT";
            columnTen.Width = 150;
            // 
            // columnDonVi
            // 
            columnDonVi.Text = "Đơn vị tính";
            columnDonVi.Width = 80;
            // 
            // columnDonGia
            // 
            columnDonGia.Text = "Đơn giá";
            columnDonGia.Width = 80;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxRight);
            Controls.Add(groupBoxLeft);
            Name = "Form1";
            Text = "Quản lý danh mục Vật tư / Linh kiện";
            groupBoxLeft.ResumeLayout(false);
            groupBoxLeft.PerformLayout();
            groupBoxRight.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
    }
}
