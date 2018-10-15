namespace 二维码生成
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.codePictureBox = new System.Windows.Forms.PictureBox();
            this.QcodeIdBox = new System.Windows.Forms.TextBox();
            this.DisplayQcrod = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.QcodeNumbox = new System.Windows.Forms.TextBox();
            this.Qcord_GenerateBut = new System.Windows.Forms.Button();
            this.QcodeProductionBar = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IdPrefixBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.codePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // codePictureBox
            // 
            this.codePictureBox.Location = new System.Drawing.Point(16, 15);
            this.codePictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.codePictureBox.Name = "codePictureBox";
            this.codePictureBox.Size = new System.Drawing.Size(335, 218);
            this.codePictureBox.TabIndex = 0;
            this.codePictureBox.TabStop = false;
            // 
            // QcodeIdBox
            // 
            this.QcodeIdBox.Location = new System.Drawing.Point(79, 306);
            this.QcodeIdBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.QcodeIdBox.Name = "QcodeIdBox";
            this.QcodeIdBox.Size = new System.Drawing.Size(141, 25);
            this.QcodeIdBox.TabIndex = 2;
            // 
            // DisplayQcrod
            // 
            this.DisplayQcrod.Font = new System.Drawing.Font("微软雅黑 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DisplayQcrod.Location = new System.Drawing.Point(251, 304);
            this.DisplayQcrod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DisplayQcrod.Name = "DisplayQcrod";
            this.DisplayQcrod.Size = new System.Drawing.Size(108, 29);
            this.DisplayQcrod.TabIndex = 3;
            this.DisplayQcrod.Text = "显示二维码";
            this.DisplayQcrod.UseVisualStyleBackColor = true;
            this.DisplayQcrod.Click += new System.EventHandler(this.DisplayQcrod_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 310);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "起始Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 349);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "数 量:";
            // 
            // QcodeNumbox
            // 
            this.QcodeNumbox.Location = new System.Drawing.Point(79, 349);
            this.QcodeNumbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.QcodeNumbox.Name = "QcodeNumbox";
            this.QcodeNumbox.Size = new System.Drawing.Size(141, 25);
            this.QcodeNumbox.TabIndex = 4;
            // 
            // Qcord_GenerateBut
            // 
            this.Qcord_GenerateBut.Font = new System.Drawing.Font("华文细黑", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Qcord_GenerateBut.Location = new System.Drawing.Point(251, 349);
            this.Qcord_GenerateBut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Qcord_GenerateBut.Name = "Qcord_GenerateBut";
            this.Qcord_GenerateBut.Size = new System.Drawing.Size(108, 29);
            this.Qcord_GenerateBut.TabIndex = 5;
            this.Qcord_GenerateBut.Text = "生成";
            this.Qcord_GenerateBut.UseVisualStyleBackColor = true;
            this.Qcord_GenerateBut.Click += new System.EventHandler(this.Qcord_GenerateBut_Click);
            // 
            // QcodeProductionBar
            // 
            this.QcodeProductionBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QcodeProductionBar.Location = new System.Drawing.Point(16, 386);
            this.QcodeProductionBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.QcodeProductionBar.Name = "QcodeProductionBar";
            this.QcodeProductionBar.Size = new System.Drawing.Size(283, 38);
            this.QcodeProductionBar.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 351);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 269);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Id前缀:";
            // 
            // IdPrefixBox
            // 
            this.IdPrefixBox.Location = new System.Drawing.Point(79, 265);
            this.IdPrefixBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IdPrefixBox.Name = "IdPrefixBox";
            this.IdPrefixBox.Size = new System.Drawing.Size(271, 25);
            this.IdPrefixBox.TabIndex = 1;
            this.IdPrefixBox.Text = "http://downapp.xiaoyugongxiang.com/downapp/xiaoyudown.html?lockid=";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("楷体", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(307, 402);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 38);
            this.label5.TabIndex = 11;
            this.label5.Text = "      ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 454);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.IdPrefixBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.QcodeProductionBar);
            this.Controls.Add(this.Qcord_GenerateBut);
            this.Controls.Add(this.QcodeNumbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DisplayQcrod);
            this.Controls.Add(this.QcodeIdBox);
            this.Controls.Add(this.codePictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "二维码批量生成工具";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.codePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox codePictureBox;
        private System.Windows.Forms.TextBox QcodeIdBox;
        private System.Windows.Forms.Button DisplayQcrod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox QcodeNumbox;
        private System.Windows.Forms.Button Qcord_GenerateBut;
        private System.Windows.Forms.ProgressBar QcodeProductionBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IdPrefixBox;
        private System.Windows.Forms.Label label5;
    }
}

