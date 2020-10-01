namespace ClientApp
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
            this.btnThietBiDM = new System.Windows.Forms.Button();
            this.btnThietBiToiHan = new System.Windows.Forms.Button();
            this.btnThietBiHetHan = new System.Windows.Forms.Button();
            this.btnBaiTNTheoIDGV = new System.Windows.Forms.Button();
            this.txtIDGV = new System.Windows.Forms.TextBox();
            this.lvHienThi = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnThietBiDM
            // 
            this.btnThietBiDM.Location = new System.Drawing.Point(52, 30);
            this.btnThietBiDM.Name = "btnThietBiDM";
            this.btnThietBiDM.Size = new System.Drawing.Size(198, 29);
            this.btnThietBiDM.TabIndex = 0;
            this.btnThietBiDM.Text = "Thiết bị theo danh mục";
            this.btnThietBiDM.UseVisualStyleBackColor = true;
            this.btnThietBiDM.Click += new System.EventHandler(this.btnThietBiDM_Click);
            // 
            // btnThietBiToiHan
            // 
            this.btnThietBiToiHan.Location = new System.Drawing.Point(52, 90);
            this.btnThietBiToiHan.Name = "btnThietBiToiHan";
            this.btnThietBiToiHan.Size = new System.Drawing.Size(198, 29);
            this.btnThietBiToiHan.TabIndex = 1;
            this.btnThietBiToiHan.Text = "Thiết bị sắp tới hạn";
            this.btnThietBiToiHan.UseVisualStyleBackColor = true;
            // 
            // btnThietBiHetHan
            // 
            this.btnThietBiHetHan.Location = new System.Drawing.Point(52, 180);
            this.btnThietBiHetHan.Name = "btnThietBiHetHan";
            this.btnThietBiHetHan.Size = new System.Drawing.Size(198, 29);
            this.btnThietBiHetHan.TabIndex = 2;
            this.btnThietBiHetHan.Text = "Thiết bị hết hạn";
            this.btnThietBiHetHan.UseVisualStyleBackColor = true;
            // 
            // btnBaiTNTheoIDGV
            // 
            this.btnBaiTNTheoIDGV.Location = new System.Drawing.Point(52, 291);
            this.btnBaiTNTheoIDGV.Name = "btnBaiTNTheoIDGV";
            this.btnBaiTNTheoIDGV.Size = new System.Drawing.Size(198, 29);
            this.btnBaiTNTheoIDGV.TabIndex = 3;
            this.btnBaiTNTheoIDGV.Text = "Bài thí nghiệm theo id giáo viên";
            this.btnBaiTNTheoIDGV.UseVisualStyleBackColor = true;
            // 
            // txtIDGV
            // 
            this.txtIDGV.Location = new System.Drawing.Point(52, 351);
            this.txtIDGV.Name = "txtIDGV";
            this.txtIDGV.Size = new System.Drawing.Size(198, 27);
            this.txtIDGV.TabIndex = 4;
            // 
            // lvHienThi
            // 
            this.lvHienThi.HideSelection = false;
            this.lvHienThi.Location = new System.Drawing.Point(366, 30);
            this.lvHienThi.Name = "lvHienThi";
            this.lvHienThi.Size = new System.Drawing.Size(392, 348);
            this.lvHienThi.TabIndex = 5;
            this.lvHienThi.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvHienThi);
            this.Controls.Add(this.txtIDGV);
            this.Controls.Add(this.btnBaiTNTheoIDGV);
            this.Controls.Add(this.btnThietBiHetHan);
            this.Controls.Add(this.btnThietBiToiHan);
            this.Controls.Add(this.btnThietBiDM);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThietBiDM;
        private System.Windows.Forms.Button btnThietBiToiHan;
        private System.Windows.Forms.Button btnThietBiHetHan;
        private System.Windows.Forms.Button btnBaiTNTheoIDGV;
        private System.Windows.Forms.TextBox txtIDGV;
        private System.Windows.Forms.ListView lvHienThi;
    }
}

