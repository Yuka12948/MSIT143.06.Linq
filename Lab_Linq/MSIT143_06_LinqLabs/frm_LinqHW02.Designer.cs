
namespace MSIT143_06_LinqLabs
{
    partial class frm_LinqHW02
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grp_DataSet = new System.Windows.Forms.GroupBox();
            this.txt_Count = new System.Windows.Forms.Label();
            this.lab_Count = new System.Windows.Forms.Label();
            this.lab_Year = new System.Windows.Forms.Label();
            this.btn_SeasonBike = new System.Windows.Forms.Button();
            this.cbo_Year = new System.Windows.Forms.ComboBox();
            this.btn_AllBike = new System.Windows.Forms.Button();
            this.lab_Season = new System.Windows.Forms.Label();
            this.btn_SelectTimeBike = new System.Windows.Forms.Button();
            this.cbo_Season = new System.Windows.Forms.ComboBox();
            this.btn_YearBike = new System.Windows.Forms.Button();
            this.dateTimePicker_End = new System.Windows.Forms.DateTimePicker();
            this.lab_SelectTime = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker_Start = new System.Windows.Forms.DateTimePicker();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lab_Search = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDetails = new System.Windows.Forms.Label();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.awDataSet1 = new MSIT143_06_LinqLabs.AWDataSet();
            this.productPhotoTableAdapter1 = new MSIT143_06_LinqLabs.AWDataSetTableAdapters.ProductPhotoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grp_DataSet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.awDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grp_DataSet);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(939, 652);
            this.splitContainer1.SplitterDistance = 230;
            this.splitContainer1.TabIndex = 0;
            // 
            // grp_DataSet
            // 
            this.grp_DataSet.Controls.Add(this.txt_Count);
            this.grp_DataSet.Controls.Add(this.lab_Count);
            this.grp_DataSet.Controls.Add(this.lab_Year);
            this.grp_DataSet.Controls.Add(this.btn_SeasonBike);
            this.grp_DataSet.Controls.Add(this.cbo_Year);
            this.grp_DataSet.Controls.Add(this.btn_AllBike);
            this.grp_DataSet.Controls.Add(this.lab_Season);
            this.grp_DataSet.Controls.Add(this.btn_SelectTimeBike);
            this.grp_DataSet.Controls.Add(this.cbo_Season);
            this.grp_DataSet.Controls.Add(this.btn_YearBike);
            this.grp_DataSet.Controls.Add(this.dateTimePicker_End);
            this.grp_DataSet.Controls.Add(this.lab_SelectTime);
            this.grp_DataSet.Controls.Add(this.label7);
            this.grp_DataSet.Controls.Add(this.dateTimePicker_Start);
            this.grp_DataSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp_DataSet.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grp_DataSet.ForeColor = System.Drawing.Color.Gray;
            this.grp_DataSet.Location = new System.Drawing.Point(0, 0);
            this.grp_DataSet.Name = "grp_DataSet";
            this.grp_DataSet.Size = new System.Drawing.Size(939, 230);
            this.grp_DataSet.TabIndex = 134;
            this.grp_DataSet.TabStop = false;
            this.grp_DataSet.Text = "LINQ to AdventureWorks DataSet";
            // 
            // txt_Count
            // 
            this.txt_Count.ForeColor = System.Drawing.Color.DimGray;
            this.txt_Count.Location = new System.Drawing.Point(384, 167);
            this.txt_Count.Name = "txt_Count";
            this.txt_Count.Size = new System.Drawing.Size(164, 28);
            this.txt_Count.TabIndex = 147;
            this.txt_Count.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lab_Count
            // 
            this.lab_Count.AutoSize = true;
            this.lab_Count.ForeColor = System.Drawing.Color.Gray;
            this.lab_Count.Location = new System.Drawing.Point(332, 171);
            this.lab_Count.Name = "lab_Count";
            this.lab_Count.Size = new System.Drawing.Size(46, 21);
            this.lab_Count.TabIndex = 146;
            this.lab_Count.Text = "筆數:";
            // 
            // lab_Year
            // 
            this.lab_Year.AutoSize = true;
            this.lab_Year.ForeColor = System.Drawing.Color.Gray;
            this.lab_Year.Location = new System.Drawing.Point(332, 92);
            this.lab_Year.Name = "lab_Year";
            this.lab_Year.Size = new System.Drawing.Size(30, 21);
            this.lab_Year.TabIndex = 144;
            this.lab_Year.Text = "年:";
            // 
            // btn_SeasonBike
            // 
            this.btn_SeasonBike.BackColor = System.Drawing.Color.Gray;
            this.btn_SeasonBike.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btn_SeasonBike.ForeColor = System.Drawing.Color.White;
            this.btn_SeasonBike.Location = new System.Drawing.Point(23, 164);
            this.btn_SeasonBike.Margin = new System.Windows.Forms.Padding(5);
            this.btn_SeasonBike.Name = "btn_SeasonBike";
            this.btn_SeasonBike.Size = new System.Drawing.Size(279, 35);
            this.btn_SeasonBike.TabIndex = 129;
            this.btn_SeasonBike.Text = "　某季腳踏車  ? 有幾筆 ?";
            this.btn_SeasonBike.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SeasonBike.UseVisualStyleBackColor = false;
            this.btn_SeasonBike.Click += new System.EventHandler(this.btn_SeasonBike_Click);
            // 
            // cbo_Year
            // 
            this.cbo_Year.ForeColor = System.Drawing.Color.DimGray;
            this.cbo_Year.FormattingEnabled = true;
            this.cbo_Year.Location = new System.Drawing.Point(388, 89);
            this.cbo_Year.Name = "cbo_Year";
            this.cbo_Year.Size = new System.Drawing.Size(164, 29);
            this.cbo_Year.TabIndex = 143;
            // 
            // btn_AllBike
            // 
            this.btn_AllBike.BackColor = System.Drawing.Color.Gray;
            this.btn_AllBike.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btn_AllBike.ForeColor = System.Drawing.Color.White;
            this.btn_AllBike.Location = new System.Drawing.Point(23, 45);
            this.btn_AllBike.Margin = new System.Windows.Forms.Padding(5);
            this.btn_AllBike.Name = "btn_AllBike";
            this.btn_AllBike.Size = new System.Drawing.Size(279, 35);
            this.btn_AllBike.TabIndex = 125;
            this.btn_AllBike.Text = "　All 腳踏車";
            this.btn_AllBike.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AllBike.UseVisualStyleBackColor = false;
            this.btn_AllBike.Click += new System.EventHandler(this.btn_AllBike_Click);
            // 
            // lab_Season
            // 
            this.lab_Season.AutoSize = true;
            this.lab_Season.ForeColor = System.Drawing.Color.Gray;
            this.lab_Season.Location = new System.Drawing.Point(332, 132);
            this.lab_Season.Name = "lab_Season";
            this.lab_Season.Size = new System.Drawing.Size(30, 21);
            this.lab_Season.TabIndex = 142;
            this.lab_Season.Text = "季:";
            // 
            // btn_SelectTimeBike
            // 
            this.btn_SelectTimeBike.BackColor = System.Drawing.Color.Gray;
            this.btn_SelectTimeBike.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btn_SelectTimeBike.ForeColor = System.Drawing.Color.White;
            this.btn_SelectTimeBike.Location = new System.Drawing.Point(23, 85);
            this.btn_SelectTimeBike.Margin = new System.Windows.Forms.Padding(5);
            this.btn_SelectTimeBike.Name = "btn_SelectTimeBike";
            this.btn_SelectTimeBike.Size = new System.Drawing.Size(279, 35);
            this.btn_SelectTimeBike.TabIndex = 126;
            this.btn_SelectTimeBike.Text = "　區間腳踏車";
            this.btn_SelectTimeBike.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SelectTimeBike.UseVisualStyleBackColor = false;
            this.btn_SelectTimeBike.Click += new System.EventHandler(this.btn_SelectTimeBike_Click);
            // 
            // cbo_Season
            // 
            this.cbo_Season.ForeColor = System.Drawing.Color.DimGray;
            this.cbo_Season.FormattingEnabled = true;
            this.cbo_Season.Items.AddRange(new object[] {
            "第一季",
            "第二季",
            "第三季",
            "第四季"});
            this.cbo_Season.Location = new System.Drawing.Point(388, 129);
            this.cbo_Season.Name = "cbo_Season";
            this.cbo_Season.Size = new System.Drawing.Size(164, 29);
            this.cbo_Season.TabIndex = 141;
            // 
            // btn_YearBike
            // 
            this.btn_YearBike.BackColor = System.Drawing.Color.Gray;
            this.btn_YearBike.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btn_YearBike.ForeColor = System.Drawing.Color.White;
            this.btn_YearBike.Location = new System.Drawing.Point(23, 125);
            this.btn_YearBike.Margin = new System.Windows.Forms.Padding(5);
            this.btn_YearBike.Name = "btn_YearBike";
            this.btn_YearBike.Size = new System.Drawing.Size(279, 35);
            this.btn_YearBike.TabIndex = 128;
            this.btn_YearBike.Text = "　某年腳踏車";
            this.btn_YearBike.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_YearBike.UseVisualStyleBackColor = false;
            this.btn_YearBike.Click += new System.EventHandler(this.btn_YearBike_Click);
            // 
            // dateTimePicker_End
            // 
            this.dateTimePicker_End.CalendarForeColor = System.Drawing.Color.Gray;
            this.dateTimePicker_End.CalendarTitleForeColor = System.Drawing.Color.Gray;
            this.dateTimePicker_End.Location = new System.Drawing.Point(612, 46);
            this.dateTimePicker_End.Name = "dateTimePicker_End";
            this.dateTimePicker_End.Size = new System.Drawing.Size(164, 29);
            this.dateTimePicker_End.TabIndex = 140;
            this.dateTimePicker_End.Value = new System.DateTime(2013, 4, 30, 0, 0, 0, 0);
            // 
            // lab_SelectTime
            // 
            this.lab_SelectTime.AutoSize = true;
            this.lab_SelectTime.ForeColor = System.Drawing.Color.Gray;
            this.lab_SelectTime.Location = new System.Drawing.Point(332, 52);
            this.lab_SelectTime.Name = "lab_SelectTime";
            this.lab_SelectTime.Size = new System.Drawing.Size(46, 21);
            this.lab_SelectTime.TabIndex = 137;
            this.lab_SelectTime.Text = "區間:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(574, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 21);
            this.label7.TabIndex = 139;
            this.label7.Text = "~";
            // 
            // dateTimePicker_Start
            // 
            this.dateTimePicker_Start.CalendarForeColor = System.Drawing.Color.Gray;
            this.dateTimePicker_Start.CalendarTitleForeColor = System.Drawing.Color.Gray;
            this.dateTimePicker_Start.Location = new System.Drawing.Point(388, 46);
            this.dateTimePicker_Start.Name = "dateTimePicker_Start";
            this.dateTimePicker_Start.Size = new System.Drawing.Size(164, 29);
            this.dateTimePicker_Start.TabIndex = 138;
            this.dateTimePicker_Start.Value = new System.DateTime(2008, 3, 31, 0, 0, 0, 0);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer2.Size = new System.Drawing.Size(939, 418);
            this.splitContainer2.SplitterDistance = 468;
            this.splitContainer2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.lab_Search, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.dataGridView, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(468, 418);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // lab_Search
            // 
            this.lab_Search.BackColor = System.Drawing.Color.Gray;
            this.lab_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_Search.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_Search.ForeColor = System.Drawing.Color.White;
            this.lab_Search.Location = new System.Drawing.Point(4, 0);
            this.lab_Search.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_Search.Name = "lab_Search";
            this.lab_Search.Size = new System.Drawing.Size(460, 40);
            this.lab_Search.TabIndex = 101;
            this.lab_Search.Text = "　　Master";
            this.lab_Search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(5, 45);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(458, 368);
            this.dataGridView.TabIndex = 71;
            this.dataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_RowEnter);
            this.dataGridView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridView_MouseUp);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lblDetails, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.picBox, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(467, 418);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // lblDetails
            // 
            this.lblDetails.BackColor = System.Drawing.Color.Gray;
            this.lblDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDetails.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.lblDetails.ForeColor = System.Drawing.Color.White;
            this.lblDetails.Location = new System.Drawing.Point(3, 0);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(461, 40);
            this.lblDetails.TabIndex = 102;
            this.lblDetails.Text = "　　Details";
            this.lblDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picBox
            // 
            this.picBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBox.Location = new System.Drawing.Point(3, 43);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(461, 372);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox.TabIndex = 103;
            this.picBox.TabStop = false;
            // 
            // awDataSet1
            // 
            this.awDataSet1.DataSetName = "AWDataSet";
            this.awDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productPhotoTableAdapter1
            // 
            this.productPhotoTableAdapter1.ClearBeforeFill = true;
            // 
            // frm_LinqHW02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 652);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frm_LinqHW02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_LinqHW02";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grp_DataSet.ResumeLayout(false);
            this.grp_DataSet.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.awDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grp_DataSet;
        private System.Windows.Forms.Label lab_Year;
        private System.Windows.Forms.Button btn_SeasonBike;
        private System.Windows.Forms.ComboBox cbo_Year;
        private System.Windows.Forms.Button btn_AllBike;
        private System.Windows.Forms.Label lab_Season;
        private System.Windows.Forms.Button btn_SelectTimeBike;
        private System.Windows.Forms.ComboBox cbo_Season;
        private System.Windows.Forms.Button btn_YearBike;
        private System.Windows.Forms.DateTimePicker dateTimePicker_End;
        private System.Windows.Forms.Label lab_SelectTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Start;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lab_Search;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.PictureBox picBox;
        private AWDataSet awDataSet1;
        private AWDataSetTableAdapters.ProductPhotoTableAdapter productPhotoTableAdapter1;
        private System.Windows.Forms.Label txt_Count;
        private System.Windows.Forms.Label lab_Count;
    }
}