
namespace MSIT143_06_LinqLabs
{
    partial class frm_LinqHW03
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_Groupby = new System.Windows.Forms.Button();
            this.btn_StdAll = new System.Windows.Forms.Button();
            this.btn_StdGender = new System.Windows.Forms.Button();
            this.cbo_stdSingle = new System.Windows.Forms.ComboBox();
            this.btn_stdSingle = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lab_Master = new System.Windows.Forms.Label();
            this.dataGridView_Master = new System.Windows.Forms.DataGridView();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.treeView = new System.Windows.Forms.TreeView();
            this.chart_std = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Master)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_std)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_Groupby);
            this.splitContainer1.Panel1.Controls.Add(this.btn_StdAll);
            this.splitContainer1.Panel1.Controls.Add(this.btn_StdGender);
            this.splitContainer1.Panel1.Controls.Add(this.cbo_stdSingle);
            this.splitContainer1.Panel1.Controls.Add(this.btn_stdSingle);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1137, 638);
            this.splitContainer1.SplitterDistance = 306;
            this.splitContainer1.TabIndex = 0;
            // 
            // btn_Groupby
            // 
            this.btn_Groupby.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Groupby.Location = new System.Drawing.Point(14, 132);
            this.btn_Groupby.Name = "btn_Groupby";
            this.btn_Groupby.Size = new System.Drawing.Size(276, 50);
            this.btn_Groupby.TabIndex = 160;
            this.btn_Groupby.Text = "自己分群";
            this.btn_Groupby.UseVisualStyleBackColor = false;
            this.btn_Groupby.Click += new System.EventHandler(this.btn_Groupby_Click);
            // 
            // btn_StdAll
            // 
            this.btn_StdAll.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_StdAll.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.btn_StdAll.ForeColor = System.Drawing.Color.White;
            this.btn_StdAll.Location = new System.Drawing.Point(14, 14);
            this.btn_StdAll.Margin = new System.Windows.Forms.Padding(5);
            this.btn_StdAll.Name = "btn_StdAll";
            this.btn_StdAll.Size = new System.Drawing.Size(276, 30);
            this.btn_StdAll.TabIndex = 151;
            this.btn_StdAll.Text = "全班學生成績";
            this.btn_StdAll.UseVisualStyleBackColor = false;
            this.btn_StdAll.Click += new System.EventHandler(this.btn_StdAll_Click);
            // 
            // btn_StdGender
            // 
            this.btn_StdGender.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_StdGender.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.btn_StdGender.ForeColor = System.Drawing.Color.White;
            this.btn_StdGender.Location = new System.Drawing.Point(14, 54);
            this.btn_StdGender.Margin = new System.Windows.Forms.Padding(5);
            this.btn_StdGender.Name = "btn_StdGender";
            this.btn_StdGender.Size = new System.Drawing.Size(276, 30);
            this.btn_StdGender.TabIndex = 157;
            this.btn_StdGender.Text = "男/女學生成績";
            this.btn_StdGender.UseVisualStyleBackColor = false;
            this.btn_StdGender.Click += new System.EventHandler(this.btn_StdGender_Click);
            // 
            // cbo_stdSingle
            // 
            this.cbo_stdSingle.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbo_stdSingle.FormattingEnabled = true;
            this.cbo_stdSingle.Location = new System.Drawing.Point(162, 96);
            this.cbo_stdSingle.Name = "cbo_stdSingle";
            this.cbo_stdSingle.Size = new System.Drawing.Size(127, 25);
            this.cbo_stdSingle.TabIndex = 156;
            // 
            // btn_stdSingle
            // 
            this.btn_stdSingle.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_stdSingle.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.btn_stdSingle.ForeColor = System.Drawing.Color.White;
            this.btn_stdSingle.Location = new System.Drawing.Point(14, 94);
            this.btn_stdSingle.Margin = new System.Windows.Forms.Padding(5);
            this.btn_stdSingle.Name = "btn_stdSingle";
            this.btn_stdSingle.Size = new System.Drawing.Size(140, 30);
            this.btn_stdSingle.TabIndex = 155;
            this.btn_stdSingle.Text = "各別學生成績";
            this.btn_stdSingle.UseVisualStyleBackColor = false;
            this.btn_stdSingle.Click += new System.EventHandler(this.btn_stdSingle_Click);
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
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(827, 638);
            this.splitContainer2.SplitterDistance = 275;
            this.splitContainer2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.lab_Master, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.dataGridView_Master, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(827, 275);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // lab_Master
            // 
            this.lab_Master.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lab_Master.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_Master.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_Master.ForeColor = System.Drawing.Color.White;
            this.lab_Master.Location = new System.Drawing.Point(4, 0);
            this.lab_Master.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_Master.Name = "lab_Master";
            this.lab_Master.Size = new System.Drawing.Size(819, 40);
            this.lab_Master.TabIndex = 101;
            this.lab_Master.Text = "　　Master";
            this.lab_Master.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView_Master
            // 
            this.dataGridView_Master.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView_Master.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridView_Master.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Master.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Master.Location = new System.Drawing.Point(5, 45);
            this.dataGridView_Master.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView_Master.Name = "dataGridView_Master";
            this.dataGridView_Master.RowHeadersWidth = 62;
            this.dataGridView_Master.RowTemplate.Height = 24;
            this.dataGridView_Master.Size = new System.Drawing.Size(817, 225);
            this.dataGridView_Master.TabIndex = 71;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.treeView);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.chart_std);
            this.splitContainer3.Size = new System.Drawing.Size(827, 359);
            this.splitContainer3.SplitterDistance = 279;
            this.splitContainer3.TabIndex = 0;
            // 
            // treeView
            // 
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.treeView.Location = new System.Drawing.Point(0, 0);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(279, 359);
            this.treeView.TabIndex = 161;
            // 
            // chart_std
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_std.ChartAreas.Add(chartArea1);
            this.chart_std.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart_std.Legends.Add(legend1);
            this.chart_std.Location = new System.Drawing.Point(0, 0);
            this.chart_std.Name = "chart_std";
            this.chart_std.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series1.Color = System.Drawing.Color.Gainsboro;
            series1.Legend = "Legend1";
            series1.Name = "總分";
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.LightBlue;
            series2.Legend = "Legend1";
            series2.Name = "國文";
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.LightPink;
            series3.Legend = "Legend1";
            series3.Name = "英文";
            series3.ShadowColor = System.Drawing.Color.Empty;
            series4.ChartArea = "ChartArea1";
            series4.Color = System.Drawing.Color.Wheat;
            series4.Legend = "Legend1";
            series4.Name = "數學";
            series4.YValuesPerPoint = 4;
            series5.BorderWidth = 3;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series5.Color = System.Drawing.Color.DodgerBlue;
            series5.Legend = "Legend1";
            series5.Name = "最高分";
            series5.YValuesPerPoint = 4;
            series6.BorderWidth = 3;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series6.Color = System.Drawing.Color.Red;
            series6.Legend = "Legend1";
            series6.Name = "最低分";
            series6.YValuesPerPoint = 4;
            series7.BorderWidth = 3;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series7.Legend = "Legend1";
            series7.Name = "平均成績";
            this.chart_std.Series.Add(series1);
            this.chart_std.Series.Add(series2);
            this.chart_std.Series.Add(series3);
            this.chart_std.Series.Add(series4);
            this.chart_std.Series.Add(series5);
            this.chart_std.Series.Add(series6);
            this.chart_std.Series.Add(series7);
            this.chart_std.Size = new System.Drawing.Size(544, 359);
            this.chart_std.TabIndex = 155;
            this.chart_std.Text = "chart1";
            // 
            // frm_LinqHW03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 638);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frm_LinqHW03";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_LinqHW3";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Master)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_std)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_StdAll;
        private System.Windows.Forms.Button btn_StdGender;
        private System.Windows.Forms.ComboBox cbo_stdSingle;
        private System.Windows.Forms.Button btn_stdSingle;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lab_Master;
        private System.Windows.Forms.DataGridView dataGridView_Master;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_std;
        private System.Windows.Forms.Button btn_Groupby;
    }
}