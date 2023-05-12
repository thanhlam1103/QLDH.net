
namespace QuanLyDonHang
{
    partial class frmTimHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimHang));
            this.dgvTimHang = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.btnResset = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimHang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTimHang
            // 
            this.dgvTimHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimHang.Location = new System.Drawing.Point(1, 305);
            this.dgvTimHang.Name = "dgvTimHang";
            this.dgvTimHang.RowHeadersWidth = 51;
            this.dgvTimHang.RowTemplate.Height = 24;
            this.dgvTimHang.Size = new System.Drawing.Size(574, 214);
            this.dgvTimHang.TabIndex = 0;
            this.dgvTimHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTimHang_CellClick);
            this.dgvTimHang.DoubleClick += new System.EventHandler(this.dgvTimHang_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(191, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "TÌM HÀNG HÓA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(35, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nháy đúp chuột để xem chi tiết hàng ";
            // 
            // btnHienThi
            // 
            this.btnHienThi.BackColor = System.Drawing.Color.SkyBlue;
            this.btnHienThi.Image = global::QuanLyDonHang.Properties.Resources.add_3z372yqb5qw3_16;
            this.btnHienThi.Location = new System.Drawing.Point(38, 215);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(130, 43);
            this.btnHienThi.TabIndex = 5;
            this.btnHienThi.Text = "Hiển thị";
            this.btnHienThi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHienThi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHienThi.UseVisualStyleBackColor = false;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // btnResset
            // 
            this.btnResset.BackColor = System.Drawing.Color.SkyBlue;
            this.btnResset.Image = global::QuanLyDonHang.Properties.Resources.skip_d7ekgd26ad3a_161;
            this.btnResset.Location = new System.Drawing.Point(242, 216);
            this.btnResset.Name = "btnResset";
            this.btnResset.Size = new System.Drawing.Size(118, 40);
            this.btnResset.TabIndex = 6;
            this.btnResset.Text = "Reset";
            this.btnResset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnResset.UseVisualStyleBackColor = false;
            this.btnResset.Click += new System.EventHandler(this.btnResset_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.SkyBlue;
            this.btnThoat.Image = global::QuanLyDonHang.Properties.Resources.x_uzjoda9lvcz0_16;
            this.btnThoat.Location = new System.Drawing.Point(422, 216);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(119, 40);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtMaHang
            // 
            this.txtMaHang.Location = new System.Drawing.Point(169, 83);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(307, 24);
            this.txtMaHang.TabIndex = 8;
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(171, 146);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(305, 24);
            this.txtTenHang.TabIndex = 9;
            // 
            // frmTimHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(568, 518);
            this.Controls.Add(this.txtTenHang);
            this.Controls.Add(this.txtMaHang);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnResset);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTimHang);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ForeColor = System.Drawing.Color.Blue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmTimHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm hàng hóa";
            this.Load += new System.EventHandler(this.frmTimHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTimHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Button btnResset;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.TextBox txtTenHang;
    }
}