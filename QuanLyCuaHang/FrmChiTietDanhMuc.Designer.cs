
namespace QuanLyCuaHang
{
    partial class FrmChiTietDanhMuc
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
            this.txtTenDanhMuc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.RichTextBox();
            this.btnDongY = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên danh mục";
            // 
            // txtTenDanhMuc
            // 
            this.txtTenDanhMuc.Location = new System.Drawing.Point(49, 63);
            this.txtTenDanhMuc.Name = "txtTenDanhMuc";
            this.txtTenDanhMuc.Size = new System.Drawing.Size(200, 20);
            this.txtTenDanhMuc.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mô tả";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(49, 138);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(200, 83);
            this.txtMoTa.TabIndex = 4;
            this.txtMoTa.Text = "";
            // 
            // btnDongY
            // 
            this.btnDongY.Location = new System.Drawing.Point(82, 250);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(75, 23);
            this.btnDongY.TabIndex = 5;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.UseVisualStyleBackColor = true;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // btnBoQua
            // 
            this.btnBoQua.Location = new System.Drawing.Point(174, 250);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(75, 23);
            this.btnBoQua.TabIndex = 6;
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.UseVisualStyleBackColor = true;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmChiTietDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 285);
            this.Controls.Add(this.btnBoQua);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenDanhMuc);
            this.Controls.Add(this.label1);
            this.Name = "FrmChiTietDanhMuc";
            this.Text = "FrmChiTietDanhMuc";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenDanhMuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtMoTa;
        private System.Windows.Forms.Button btnDongY;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}