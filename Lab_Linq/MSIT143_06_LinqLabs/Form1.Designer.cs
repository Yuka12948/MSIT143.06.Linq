
namespace MSIT143_06_LinqLabs
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.grp_GroupBy = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.grp_FileInfo = new System.Windows.Forms.GroupBox();
            this.btn_StudentQ8 = new System.Windows.Forms.Button();
            this.btn_StudentQ9 = new System.Windows.Forms.Button();
            this.grp_FileI = new System.Windows.Forms.GroupBox();
            this.btn_LogFile = new System.Windows.Forms.Button();
            this.btn_CreatedOrder = new System.Windows.Forms.Button();
            this.btn_BigFile = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMaster = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grp_GroupBy.SuspendLayout();
            this.grp_FileInfo.SuspendLayout();
            this.grp_FileI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.grp_GroupBy);
            this.splitContainer1.Panel1.Controls.Add(this.grp_FileInfo);
            this.splitContainer1.Panel1.Controls.Add(this.grp_FileI);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(900, 980);
            this.splitContainer1.SplitterDistance = 688;
            this.splitContainer1.TabIndex = 130;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.ForeColor = System.Drawing.Color.CadetBlue;
            this.groupBox1.Location = new System.Drawing.Point(68, 389);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 197);
            this.groupBox1.TabIndex = 144;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LINQ to Northwind Entity";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.CadetBlue;
            this.button5.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(23, 150);
            this.button5.Margin = new System.Windows.Forms.Padding(5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(276, 30);
            this.button5.TabIndex = 129;
            this.button5.Text = "     NW 產品有任何一筆單價大於300 ?";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(23, 30);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(276, 30);
            this.button1.TabIndex = 125;
            this.button1.Text = "總銷售金額";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CadetBlue;
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(23, 70);
            this.button2.Margin = new System.Windows.Forms.Padding(5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(276, 30);
            this.button2.TabIndex = 126;
            this.button2.Text = "銷售最好的top 5業務員 ";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.CadetBlue;
            this.button3.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(23, 110);
            this.button3.Margin = new System.Windows.Forms.Padding(5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(276, 30);
            this.button3.TabIndex = 128;
            this.button3.Text = "     NW 產品最高單價前 5 筆 (包括類別名稱)";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // grp_GroupBy
            // 
            this.grp_GroupBy.Controls.Add(this.button4);
            this.grp_GroupBy.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grp_GroupBy.ForeColor = System.Drawing.Color.RosyBrown;
            this.grp_GroupBy.Location = new System.Drawing.Point(68, 20);
            this.grp_GroupBy.Name = "grp_GroupBy";
            this.grp_GroupBy.Size = new System.Drawing.Size(322, 74);
            this.grp_GroupBy.TabIndex = 143;
            this.grp_GroupBy.TabStop = false;
            this.grp_GroupBy.Text = "LINQ - GroupBy";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.RosyBrown;
            this.button4.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(23, 30);
            this.button4.Margin = new System.Windows.Forms.Padding(5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(276, 30);
            this.button4.TabIndex = 125;
            this.button4.Text = "int [ ] 分三群 - No LINQ";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // grp_FileInfo
            // 
            this.grp_FileInfo.Controls.Add(this.btn_StudentQ8);
            this.grp_FileInfo.Controls.Add(this.btn_StudentQ9);
            this.grp_FileInfo.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grp_FileInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            this.grp_FileInfo.Location = new System.Drawing.Point(68, 100);
            this.grp_FileInfo.Name = "grp_FileInfo";
            this.grp_FileInfo.Size = new System.Drawing.Size(322, 114);
            this.grp_FileInfo.TabIndex = 141;
            this.grp_FileInfo.TabStop = false;
            this.grp_FileInfo.Text = "LINQ to FileInfo [ ]";
            // 
            // btn_StudentQ8
            // 
            this.btn_StudentQ8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            this.btn_StudentQ8.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.btn_StudentQ8.ForeColor = System.Drawing.Color.White;
            this.btn_StudentQ8.Location = new System.Drawing.Point(23, 30);
            this.btn_StudentQ8.Margin = new System.Windows.Forms.Padding(5);
            this.btn_StudentQ8.Name = "btn_StudentQ8";
            this.btn_StudentQ8.Size = new System.Drawing.Size(276, 30);
            this.btn_StudentQ8.TabIndex = 125;
            this.btn_StudentQ8.Text = "依 檔案大小 分組檔案 (大=>小)";
            this.btn_StudentQ8.UseVisualStyleBackColor = false;
            // 
            // btn_StudentQ9
            // 
            this.btn_StudentQ9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            this.btn_StudentQ9.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.btn_StudentQ9.ForeColor = System.Drawing.Color.White;
            this.btn_StudentQ9.Location = new System.Drawing.Point(23, 70);
            this.btn_StudentQ9.Margin = new System.Windows.Forms.Padding(5);
            this.btn_StudentQ9.Name = "btn_StudentQ9";
            this.btn_StudentQ9.Size = new System.Drawing.Size(276, 30);
            this.btn_StudentQ9.TabIndex = 126;
            this.btn_StudentQ9.Text = "  依 年 分組檔案 (大=>小)";
            this.btn_StudentQ9.UseVisualStyleBackColor = false;
            // 
            // grp_FileI
            // 
            this.grp_FileI.Controls.Add(this.btn_LogFile);
            this.grp_FileI.Controls.Add(this.btn_CreatedOrder);
            this.grp_FileI.Controls.Add(this.btn_BigFile);
            this.grp_FileI.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grp_FileI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(180)))), ((int)(((byte)(120)))));
            this.grp_FileI.Location = new System.Drawing.Point(68, 220);
            this.grp_FileI.Name = "grp_FileI";
            this.grp_FileI.Size = new System.Drawing.Size(322, 163);
            this.grp_FileI.TabIndex = 142;
            this.grp_FileI.TabStop = false;
            this.grp_FileI.Text = "LINQ to Northwind Entity";
            // 
            // btn_LogFile
            // 
            this.btn_LogFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(180)))), ((int)(((byte)(120)))));
            this.btn_LogFile.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.btn_LogFile.ForeColor = System.Drawing.Color.White;
            this.btn_LogFile.Location = new System.Drawing.Point(23, 30);
            this.btn_LogFile.Margin = new System.Windows.Forms.Padding(5);
            this.btn_LogFile.Name = "btn_LogFile";
            this.btn_LogFile.Size = new System.Drawing.Size(276, 30);
            this.btn_LogFile.TabIndex = 125;
            this.btn_LogFile.Text = "NW Products 低中高 價產品 ";
            this.btn_LogFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LogFile.UseVisualStyleBackColor = false;
            // 
            // btn_CreatedOrder
            // 
            this.btn_CreatedOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(180)))), ((int)(((byte)(120)))));
            this.btn_CreatedOrder.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.btn_CreatedOrder.ForeColor = System.Drawing.Color.White;
            this.btn_CreatedOrder.Location = new System.Drawing.Point(23, 70);
            this.btn_CreatedOrder.Margin = new System.Windows.Forms.Padding(5);
            this.btn_CreatedOrder.Name = "btn_CreatedOrder";
            this.btn_CreatedOrder.Size = new System.Drawing.Size(276, 30);
            this.btn_CreatedOrder.TabIndex = 126;
            this.btn_CreatedOrder.Text = " Orders -  Group by 年";
            this.btn_CreatedOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CreatedOrder.UseVisualStyleBackColor = false;
            // 
            // btn_BigFile
            // 
            this.btn_BigFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(180)))), ((int)(((byte)(120)))));
            this.btn_BigFile.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.btn_BigFile.ForeColor = System.Drawing.Color.White;
            this.btn_BigFile.Location = new System.Drawing.Point(23, 110);
            this.btn_BigFile.Margin = new System.Windows.Forms.Padding(5);
            this.btn_BigFile.Name = "btn_BigFile";
            this.btn_BigFile.Size = new System.Drawing.Size(276, 30);
            this.btn_BigFile.TabIndex = 128;
            this.btn_BigFile.Text = " Orders -  Group by 年 / 月";
            this.btn_BigFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_BigFile.UseVisualStyleBackColor = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer2.Size = new System.Drawing.Size(208, 980);
            this.splitContainer2.SplitterDistance = 326;
            this.splitContainer2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblMaster, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(208, 326);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblMaster
            // 
            this.lblMaster.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaster.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMaster.ForeColor = System.Drawing.Color.White;
            this.lblMaster.Location = new System.Drawing.Point(4, 0);
            this.lblMaster.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaster.Name = "lblMaster";
            this.lblMaster.Size = new System.Drawing.Size(200, 40);
            this.lblMaster.TabIndex = 101;
            this.lblMaster.Text = "訂單";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(5, 45);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(198, 276);
            this.dataGridView1.TabIndex = 71;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 1001);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.grp_GroupBy.ResumeLayout(false);
            this.grp_FileInfo.ResumeLayout(false);
            this.grp_FileI.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblMaster;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox grp_GroupBy;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox grp_FileInfo;
        private System.Windows.Forms.Button btn_StudentQ8;
        private System.Windows.Forms.Button btn_StudentQ9;
        private System.Windows.Forms.GroupBox grp_FileI;
        private System.Windows.Forms.Button btn_LogFile;
        private System.Windows.Forms.Button btn_CreatedOrder;
        private System.Windows.Forms.Button btn_BigFile;
    }
}

