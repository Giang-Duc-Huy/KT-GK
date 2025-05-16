namespace WindowsFormsApp1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.maSoTextBox = new System.Windows.Forms.TextBox();
            this.maSoLabel = new System.Windows.Forms.Label();
            this.hoTenLabel = new System.Windows.Forms.Label();
            this.hoTenTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ngaysinhTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.eMailTextBox = new System.Windows.Forms.TextBox();
            this.themButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.xLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.xLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 50);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhóm XX";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // maSoTextBox
            // 
            this.maSoTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.maSoTextBox.Location = new System.Drawing.Point(54, 64);
            this.maSoTextBox.Name = "maSoTextBox";
            this.maSoTextBox.Size = new System.Drawing.Size(625, 20);
            this.maSoTextBox.TabIndex = 1;
            // 
            // maSoLabel
            // 
            this.maSoLabel.AutoSize = true;
            this.maSoLabel.Location = new System.Drawing.Point(13, 67);
            this.maSoLabel.Name = "maSoLabel";
            this.maSoLabel.Size = new System.Drawing.Size(36, 13);
            this.maSoLabel.TabIndex = 2;
            this.maSoLabel.Text = "Mã số";
            // 
            // hoTenLabel
            // 
            this.hoTenLabel.AutoSize = true;
            this.hoTenLabel.Location = new System.Drawing.Point(14, 93);
            this.hoTenLabel.Name = "hoTenLabel";
            this.hoTenLabel.Size = new System.Drawing.Size(39, 13);
            this.hoTenLabel.TabIndex = 3;
            this.hoTenLabel.Text = "Họ tên";
            this.hoTenLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // hoTenTextBox
            // 
            this.hoTenTextBox.Location = new System.Drawing.Point(54, 90);
            this.hoTenTextBox.Name = "hoTenTextBox";
            this.hoTenTextBox.Size = new System.Drawing.Size(625, 20);
            this.hoTenTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ngày sinh";
            // 
            // ngaysinhTextBox
            // 
            this.ngaysinhTextBox.Location = new System.Drawing.Point(54, 116);
            this.ngaysinhTextBox.Name = "ngaysinhTextBox";
            this.ngaysinhTextBox.Size = new System.Drawing.Size(625, 20);
            this.ngaysinhTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email";
            // 
            // eMailTextBox
            // 
            this.eMailTextBox.Location = new System.Drawing.Point(54, 142);
            this.eMailTextBox.Name = "eMailTextBox";
            this.eMailTextBox.Size = new System.Drawing.Size(625, 20);
            this.eMailTextBox.TabIndex = 8;
            // 
            // themButton
            // 
            this.themButton.Location = new System.Drawing.Point(243, 191);
            this.themButton.Name = "themButton";
            this.themButton.Size = new System.Drawing.Size(57, 22);
            this.themButton.TabIndex = 9;
            this.themButton.Text = "Thêm";
            this.themButton.UseVisualStyleBackColor = true;
            this.themButton.Click += new System.EventHandler(this.themButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(297, 191);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(62, 23);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Lưu";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(355, 191);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(62, 23);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Thoát";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(-1, 224);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(680, 121);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.xLabel.Location = new System.Drawing.Point(647, 16);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(24, 24);
            this.xLabel.TabIndex = 13;
            this.xLabel.Text = "X";
            this.xLabel.Click += new System.EventHandler(this.xLabel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(509, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 50);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Maso";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Hoten";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "NgaySinh";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "email";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 357);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.themButton);
            this.Controls.Add(this.eMailTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ngaysinhTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hoTenTextBox);
            this.Controls.Add(this.hoTenLabel);
            this.Controls.Add(this.maSoLabel);
            this.Controls.Add(this.maSoTextBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox maSoTextBox;
        private System.Windows.Forms.Label maSoLabel;
        private System.Windows.Forms.Label hoTenLabel;
        private System.Windows.Forms.TextBox hoTenTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ngaysinhTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox eMailTextBox;
        private System.Windows.Forms.Button themButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

