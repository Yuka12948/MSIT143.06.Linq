
namespace MSIT143_06_LinqLabs
{
    partial class frm_LinqHW01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_LinqHW01));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grp_Orders = new System.Windows.Forms.GroupBox();
            this.btn_AllOrder = new System.Windows.Forms.Button();
            this.lab_OrderYear = new System.Windows.Forms.Label();
            this.cbo_OrderYear = new System.Windows.Forms.ComboBox();
            this.btn_OrderList = new System.Windows.Forms.Button();
            this.grp_Products = new System.Windows.Forms.GroupBox();
            this.txt_page = new System.Windows.Forms.TextBox();
            this.btn_NextPage = new System.Windows.Forms.Button();
            this.lab_page = new System.Windows.Forms.Label();
            this.btn_PreviousPage = new System.Windows.Forms.Button();
            this.grp_FileInfo = new System.Windows.Forms.GroupBox();
            this.btn_LogFile = new System.Windows.Forms.Button();
            this.btn_CreatedOrder = new System.Windows.Forms.Button();
            this.btn_BigFile = new System.Windows.Forms.Button();
            this.grp_student2 = new System.Windows.Forms.GroupBox();
            this.btn_StudentQ8 = new System.Windows.Forms.Button();
            this.btn_StudentQ9 = new System.Windows.Forms.Button();
            this.grp_student1 = new System.Windows.Forms.GroupBox();
            this.btn_StudentQ6 = new System.Windows.Forms.Button();
            this.btn_StudentQ7 = new System.Windows.Forms.Button();
            this.btn_StudentQ4 = new System.Windows.Forms.Button();
            this.btn_StudentQ5 = new System.Windows.Forms.Button();
            this.btn_StudentQ1 = new System.Windows.Forms.Button();
            this.btn_StudentQ2 = new System.Windows.Forms.Button();
            this.btn_StudentQ3 = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lab_Search = new System.Windows.Forms.Label();
            this.dataGridView_All = new System.Windows.Forms.DataGridView();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lab_Order = new System.Windows.Forms.Label();
            this.dataGridView_Order = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lab_OrderDetails = new System.Windows.Forms.Label();
            this.dataGridView_OrderDetails = new System.Windows.Forms.DataGridView();
            this.nwDataSet1 = new MSIT143_06_LinqLabs.NWDataSet();
            this.productsTableAdapter1 = new MSIT143_06_LinqLabs.NWDataSetTableAdapters.ProductsTableAdapter();
            this.ordersTableAdapter1 = new MSIT143_06_LinqLabs.NWDataSetTableAdapters.OrdersTableAdapter();
            this.order_DetailsTableAdapter1 = new MSIT143_06_LinqLabs.NWDataSetTableAdapters.Order_DetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grp_Orders.SuspendLayout();
            this.grp_Products.SuspendLayout();
            this.grp_FileInfo.SuspendLayout();
            this.grp_student2.SuspendLayout();
            this.grp_student1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_All)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Order)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_OrderDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grp_Orders);
            this.splitContainer1.Panel1.Controls.Add(this.grp_Products);
            this.splitContainer1.Panel1.Controls.Add(this.grp_FileInfo);
            this.splitContainer1.Panel1.Controls.Add(this.grp_student2);
            this.splitContainer1.Panel1.Controls.Add(this.grp_student1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(960, 961);
            this.splitContainer1.SplitterDistance = 345;
            this.splitContainer1.TabIndex = 0;
            // 
            // grp_Orders
            // 
            this.grp_Orders.Controls.Add(this.btn_AllOrder);
            this.grp_Orders.Controls.Add(this.lab_OrderYear);
            this.grp_Orders.Controls.Add(this.cbo_OrderYear);
            this.grp_Orders.Controls.Add(this.btn_OrderList);
            this.grp_Orders.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grp_Orders.ForeColor = System.Drawing.Color.CadetBlue;
            this.grp_Orders.Location = new System.Drawing.Point(12, 760);
            this.grp_Orders.Name = "grp_Orders";
            this.grp_Orders.Size = new System.Drawing.Size(322, 189);
            this.grp_Orders.TabIndex = 130;
            this.grp_Orders.TabStop = false;
            this.grp_Orders.Text = "LINQ to Northwind DataSet - Orders";
            // 
            // btn_AllOrder
            // 
            this.btn_AllOrder.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_AllOrder.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.btn_AllOrder.ForeColor = System.Drawing.Color.White;
            this.btn_AllOrder.Location = new System.Drawing.Point(23, 37);
            this.btn_AllOrder.Margin = new System.Windows.Forms.Padding(5);
            this.btn_AllOrder.Name = "btn_AllOrder";
            this.btn_AllOrder.Size = new System.Drawing.Size(276, 35);
            this.btn_AllOrder.TabIndex = 138;
            this.btn_AllOrder.Text = "All 訂單 ";
            this.btn_AllOrder.UseVisualStyleBackColor = false;
            this.btn_AllOrder.Click += new System.EventHandler(this.btn_AllOrder_Click);
            // 
            // lab_OrderYear
            // 
            this.lab_OrderYear.AutoSize = true;
            this.lab_OrderYear.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_OrderYear.ForeColor = System.Drawing.Color.Teal;
            this.lab_OrderYear.Location = new System.Drawing.Point(156, 140);
            this.lab_OrderYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_OrderYear.Name = "lab_OrderYear";
            this.lab_OrderYear.Size = new System.Drawing.Size(34, 24);
            this.lab_OrderYear.TabIndex = 139;
            this.lab_OrderYear.Text = "年:";
            // 
            // cbo_OrderYear
            // 
            this.cbo_OrderYear.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbo_OrderYear.ForeColor = System.Drawing.Color.CadetBlue;
            this.cbo_OrderYear.FormattingEnabled = true;
            this.cbo_OrderYear.Location = new System.Drawing.Point(197, 137);
            this.cbo_OrderYear.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_OrderYear.Name = "cbo_OrderYear";
            this.cbo_OrderYear.Size = new System.Drawing.Size(102, 32);
            this.cbo_OrderYear.TabIndex = 137;
            // 
            // btn_OrderList
            // 
            this.btn_OrderList.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_OrderList.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.btn_OrderList.ForeColor = System.Drawing.Color.White;
            this.btn_OrderList.Location = new System.Drawing.Point(23, 82);
            this.btn_OrderList.Margin = new System.Windows.Forms.Padding(5);
            this.btn_OrderList.Name = "btn_OrderList";
            this.btn_OrderList.Size = new System.Drawing.Size(276, 35);
            this.btn_OrderList.TabIndex = 135;
            this.btn_OrderList.Text = "     某年訂單 / 訂單明細";
            this.btn_OrderList.UseVisualStyleBackColor = false;
            this.btn_OrderList.Click += new System.EventHandler(this.btn_OrderList_Click);
            // 
            // grp_Products
            // 
            this.grp_Products.Controls.Add(this.txt_page);
            this.grp_Products.Controls.Add(this.btn_NextPage);
            this.grp_Products.Controls.Add(this.lab_page);
            this.grp_Products.Controls.Add(this.btn_PreviousPage);
            this.grp_Products.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grp_Products.ForeColor = System.Drawing.Color.SteelBlue;
            this.grp_Products.Location = new System.Drawing.Point(12, 620);
            this.grp_Products.Name = "grp_Products";
            this.grp_Products.Size = new System.Drawing.Size(322, 134);
            this.grp_Products.TabIndex = 131;
            this.grp_Products.TabStop = false;
            this.grp_Products.Text = "LINQ to Northwind DataSet - Products";
            // 
            // txt_page
            // 
            this.txt_page.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_page.ForeColor = System.Drawing.Color.SteelBlue;
            this.txt_page.Location = new System.Drawing.Point(175, 37);
            this.txt_page.Margin = new System.Windows.Forms.Padding(5);
            this.txt_page.Name = "txt_page";
            this.txt_page.Size = new System.Drawing.Size(124, 33);
            this.txt_page.TabIndex = 138;
            this.txt_page.Text = "10";
            // 
            // btn_NextPage
            // 
            this.btn_NextPage.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_NextPage.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_NextPage.ForeColor = System.Drawing.Color.White;
            this.btn_NextPage.Location = new System.Drawing.Point(175, 80);
            this.btn_NextPage.Margin = new System.Windows.Forms.Padding(5);
            this.btn_NextPage.Name = "btn_NextPage";
            this.btn_NextPage.Size = new System.Drawing.Size(124, 35);
            this.btn_NextPage.TabIndex = 136;
            this.btn_NextPage.Text = "下一頁";
            this.btn_NextPage.UseVisualStyleBackColor = false;
            this.btn_NextPage.Click += new System.EventHandler(this.btn_NextPage_Click);
            // 
            // lab_page
            // 
            this.lab_page.AutoSize = true;
            this.lab_page.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_page.ForeColor = System.Drawing.Color.SteelBlue;
            this.lab_page.Location = new System.Drawing.Point(61, 40);
            this.lab_page.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lab_page.Name = "lab_page";
            this.lab_page.Size = new System.Drawing.Size(86, 24);
            this.lab_page.TabIndex = 139;
            this.lab_page.Text = "一頁幾筆";
            // 
            // btn_PreviousPage
            // 
            this.btn_PreviousPage.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_PreviousPage.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_PreviousPage.ForeColor = System.Drawing.Color.White;
            this.btn_PreviousPage.Location = new System.Drawing.Point(23, 80);
            this.btn_PreviousPage.Margin = new System.Windows.Forms.Padding(5);
            this.btn_PreviousPage.Name = "btn_PreviousPage";
            this.btn_PreviousPage.Size = new System.Drawing.Size(124, 35);
            this.btn_PreviousPage.TabIndex = 137;
            this.btn_PreviousPage.Text = "上一頁";
            this.btn_PreviousPage.UseVisualStyleBackColor = false;
            this.btn_PreviousPage.Click += new System.EventHandler(this.btn_PreviousPage_Click);
            // 
            // grp_FileInfo
            // 
            this.grp_FileInfo.Controls.Add(this.btn_LogFile);
            this.grp_FileInfo.Controls.Add(this.btn_CreatedOrder);
            this.grp_FileInfo.Controls.Add(this.btn_BigFile);
            this.grp_FileInfo.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grp_FileInfo.ForeColor = System.Drawing.Color.SteelBlue;
            this.grp_FileInfo.Location = new System.Drawing.Point(12, 451);
            this.grp_FileInfo.Name = "grp_FileInfo";
            this.grp_FileInfo.Size = new System.Drawing.Size(322, 163);
            this.grp_FileInfo.TabIndex = 132;
            this.grp_FileInfo.TabStop = false;
            this.grp_FileInfo.Text = "LINQ to FileInfo [ ]";
            // 
            // btn_LogFile
            // 
            this.btn_LogFile.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_LogFile.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.btn_LogFile.ForeColor = System.Drawing.Color.White;
            this.btn_LogFile.Location = new System.Drawing.Point(23, 30);
            this.btn_LogFile.Margin = new System.Windows.Forms.Padding(5);
            this.btn_LogFile.Name = "btn_LogFile";
            this.btn_LogFile.Size = new System.Drawing.Size(276, 30);
            this.btn_LogFile.TabIndex = 125;
            this.btn_LogFile.Text = "FileInfo [ ] -  .Log 檔";
            this.btn_LogFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LogFile.UseVisualStyleBackColor = false;
            this.btn_LogFile.Click += new System.EventHandler(this.btn_LogFile_Click);
            // 
            // btn_CreatedOrder
            // 
            this.btn_CreatedOrder.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_CreatedOrder.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.btn_CreatedOrder.ForeColor = System.Drawing.Color.White;
            this.btn_CreatedOrder.Location = new System.Drawing.Point(23, 70);
            this.btn_CreatedOrder.Margin = new System.Windows.Forms.Padding(5);
            this.btn_CreatedOrder.Name = "btn_CreatedOrder";
            this.btn_CreatedOrder.Size = new System.Drawing.Size(276, 30);
            this.btn_CreatedOrder.TabIndex = 126;
            this.btn_CreatedOrder.Text = "FileInfo [ ] - 2019 Created - Order ";
            this.btn_CreatedOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CreatedOrder.UseVisualStyleBackColor = false;
            this.btn_CreatedOrder.Click += new System.EventHandler(this.btn_CreatedOrder_Click);
            // 
            // btn_BigFile
            // 
            this.btn_BigFile.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_BigFile.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.btn_BigFile.ForeColor = System.Drawing.Color.White;
            this.btn_BigFile.Location = new System.Drawing.Point(23, 110);
            this.btn_BigFile.Margin = new System.Windows.Forms.Padding(5);
            this.btn_BigFile.Name = "btn_BigFile";
            this.btn_BigFile.Size = new System.Drawing.Size(276, 30);
            this.btn_BigFile.TabIndex = 128;
            this.btn_BigFile.Text = "FileInfo [ ] - 大容量檔案";
            this.btn_BigFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_BigFile.UseVisualStyleBackColor = false;
            this.btn_BigFile.Click += new System.EventHandler(this.btn_BigFile_Click);
            // 
            // grp_student2
            // 
            this.grp_student2.Controls.Add(this.btn_StudentQ8);
            this.grp_student2.Controls.Add(this.btn_StudentQ9);
            this.grp_student2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grp_student2.ForeColor = System.Drawing.Color.SteelBlue;
            this.grp_student2.Location = new System.Drawing.Point(12, 331);
            this.grp_student2.Name = "grp_student2";
            this.grp_student2.Size = new System.Drawing.Size(322, 114);
            this.grp_student2.TabIndex = 131;
            this.grp_student2.TabStop = false;
            this.grp_student2.Text = "查詢每個學生的個人成績";
            // 
            // btn_StudentQ8
            // 
            this.btn_StudentQ8.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_StudentQ8.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.btn_StudentQ8.ForeColor = System.Drawing.Color.White;
            this.btn_StudentQ8.Location = new System.Drawing.Point(23, 30);
            this.btn_StudentQ8.Margin = new System.Windows.Forms.Padding(5);
            this.btn_StudentQ8.Name = "btn_StudentQ8";
            this.btn_StudentQ8.Size = new System.Drawing.Size(276, 30);
            this.btn_StudentQ8.TabIndex = 125;
            this.btn_StudentQ8.Text = "班級男學生的國文數學成績";
            this.btn_StudentQ8.UseVisualStyleBackColor = false;
            this.btn_StudentQ8.Click += new System.EventHandler(this.btn_StudentQ8_Click);
            // 
            // btn_StudentQ9
            // 
            this.btn_StudentQ9.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_StudentQ9.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.btn_StudentQ9.ForeColor = System.Drawing.Color.White;
            this.btn_StudentQ9.Location = new System.Drawing.Point(23, 70);
            this.btn_StudentQ9.Margin = new System.Windows.Forms.Padding(5);
            this.btn_StudentQ9.Name = "btn_StudentQ9";
            this.btn_StudentQ9.Size = new System.Drawing.Size(276, 30);
            this.btn_StudentQ9.TabIndex = 126;
            this.btn_StudentQ9.Text = "所有科目的總分/最高/最低分/平均成績";
            this.btn_StudentQ9.UseVisualStyleBackColor = false;
            this.btn_StudentQ9.Click += new System.EventHandler(this.btn_StudentQ9_Click);
            // 
            // grp_student1
            // 
            this.grp_student1.Controls.Add(this.btn_StudentQ6);
            this.grp_student1.Controls.Add(this.btn_StudentQ7);
            this.grp_student1.Controls.Add(this.btn_StudentQ4);
            this.grp_student1.Controls.Add(this.btn_StudentQ5);
            this.grp_student1.Controls.Add(this.btn_StudentQ1);
            this.grp_student1.Controls.Add(this.btn_StudentQ2);
            this.grp_student1.Controls.Add(this.btn_StudentQ3);
            this.grp_student1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grp_student1.ForeColor = System.Drawing.Color.SteelBlue;
            this.grp_student1.Location = new System.Drawing.Point(12, 12);
            this.grp_student1.Name = "grp_student1";
            this.grp_student1.Size = new System.Drawing.Size(322, 311);
            this.grp_student1.TabIndex = 130;
            this.grp_student1.TabStop = false;
            this.grp_student1.Text = "查詢班級學生成績";
            // 
            // btn_StudentQ6
            // 
            this.btn_StudentQ6.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_StudentQ6.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.btn_StudentQ6.ForeColor = System.Drawing.Color.White;
            this.btn_StudentQ6.Location = new System.Drawing.Point(23, 228);
            this.btn_StudentQ6.Margin = new System.Windows.Forms.Padding(5);
            this.btn_StudentQ6.Name = "btn_StudentQ6";
            this.btn_StudentQ6.Size = new System.Drawing.Size(276, 30);
            this.btn_StudentQ6.TabIndex = 131;
            this.btn_StudentQ6.Text = "指定學生之外所有學生的成績";
            this.btn_StudentQ6.UseVisualStyleBackColor = false;
            this.btn_StudentQ6.Click += new System.EventHandler(this.btn_StudentQ6_Click);
            // 
            // btn_StudentQ7
            // 
            this.btn_StudentQ7.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_StudentQ7.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.btn_StudentQ7.ForeColor = System.Drawing.Color.White;
            this.btn_StudentQ7.Location = new System.Drawing.Point(23, 268);
            this.btn_StudentQ7.Margin = new System.Windows.Forms.Padding(5);
            this.btn_StudentQ7.Name = "btn_StudentQ7";
            this.btn_StudentQ7.Size = new System.Drawing.Size(276, 30);
            this.btn_StudentQ7.TabIndex = 132;
            this.btn_StudentQ7.Text = "數學成績不及格的學生";
            this.btn_StudentQ7.UseVisualStyleBackColor = false;
            this.btn_StudentQ7.Click += new System.EventHandler(this.btn_StudentQ7_Click);
            // 
            // btn_StudentQ4
            // 
            this.btn_StudentQ4.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_StudentQ4.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.btn_StudentQ4.ForeColor = System.Drawing.Color.White;
            this.btn_StudentQ4.Location = new System.Drawing.Point(23, 148);
            this.btn_StudentQ4.Margin = new System.Windows.Forms.Padding(5);
            this.btn_StudentQ4.Name = "btn_StudentQ4";
            this.btn_StudentQ4.Size = new System.Drawing.Size(276, 30);
            this.btn_StudentQ4.TabIndex = 129;
            this.btn_StudentQ4.Text = "指定三位學生的成績";
            this.btn_StudentQ4.UseVisualStyleBackColor = false;
            this.btn_StudentQ4.Click += new System.EventHandler(this.btn_StudentQ4_Click);
            // 
            // btn_StudentQ5
            // 
            this.btn_StudentQ5.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_StudentQ5.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.btn_StudentQ5.ForeColor = System.Drawing.Color.White;
            this.btn_StudentQ5.Location = new System.Drawing.Point(23, 188);
            this.btn_StudentQ5.Margin = new System.Windows.Forms.Padding(5);
            this.btn_StudentQ5.Name = "btn_StudentQ5";
            this.btn_StudentQ5.Size = new System.Drawing.Size(276, 30);
            this.btn_StudentQ5.TabIndex = 130;
            this.btn_StudentQ5.Text = "指定學生的成績";
            this.btn_StudentQ5.UseVisualStyleBackColor = false;
            this.btn_StudentQ5.Click += new System.EventHandler(this.btn_StudentQ5_Click);
            // 
            // btn_StudentQ1
            // 
            this.btn_StudentQ1.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_StudentQ1.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.btn_StudentQ1.ForeColor = System.Drawing.Color.White;
            this.btn_StudentQ1.Location = new System.Drawing.Point(23, 28);
            this.btn_StudentQ1.Margin = new System.Windows.Forms.Padding(5);
            this.btn_StudentQ1.Name = "btn_StudentQ1";
            this.btn_StudentQ1.Size = new System.Drawing.Size(276, 30);
            this.btn_StudentQ1.TabIndex = 125;
            this.btn_StudentQ1.Text = "班級學生成績";
            this.btn_StudentQ1.UseVisualStyleBackColor = false;
            this.btn_StudentQ1.Click += new System.EventHandler(this.btn_StudentQ1_Click);
            // 
            // btn_StudentQ2
            // 
            this.btn_StudentQ2.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_StudentQ2.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.btn_StudentQ2.ForeColor = System.Drawing.Color.White;
            this.btn_StudentQ2.Location = new System.Drawing.Point(23, 68);
            this.btn_StudentQ2.Margin = new System.Windows.Forms.Padding(5);
            this.btn_StudentQ2.Name = "btn_StudentQ2";
            this.btn_StudentQ2.Size = new System.Drawing.Size(276, 30);
            this.btn_StudentQ2.TabIndex = 126;
            this.btn_StudentQ2.Text = "前三位學生所有科目成績";
            this.btn_StudentQ2.UseVisualStyleBackColor = false;
            this.btn_StudentQ2.Click += new System.EventHandler(this.btn_StudentQ2_Click);
            // 
            // btn_StudentQ3
            // 
            this.btn_StudentQ3.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_StudentQ3.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.btn_StudentQ3.ForeColor = System.Drawing.Color.White;
            this.btn_StudentQ3.Location = new System.Drawing.Point(23, 108);
            this.btn_StudentQ3.Margin = new System.Windows.Forms.Padding(5);
            this.btn_StudentQ3.Name = "btn_StudentQ3";
            this.btn_StudentQ3.Size = new System.Drawing.Size(276, 30);
            this.btn_StudentQ3.TabIndex = 128;
            this.btn_StudentQ3.Text = "後兩位學生所有科目成績";
            this.btn_StudentQ3.UseVisualStyleBackColor = false;
            this.btn_StudentQ3.Click += new System.EventHandler(this.btn_StudentQ3_Click);
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
            this.splitContainer2.Size = new System.Drawing.Size(611, 961);
            this.splitContainer2.SplitterDistance = 323;
            this.splitContainer2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.lab_Search, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.dataGridView_All, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(611, 323);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // lab_Search
            // 
            this.lab_Search.BackColor = System.Drawing.Color.SteelBlue;
            this.lab_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_Search.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_Search.ForeColor = System.Drawing.Color.White;
            this.lab_Search.Location = new System.Drawing.Point(4, 0);
            this.lab_Search.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_Search.Name = "lab_Search";
            this.lab_Search.Size = new System.Drawing.Size(603, 40);
            this.lab_Search.TabIndex = 101;
            this.lab_Search.Text = "　　查詢";
            this.lab_Search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView_All
            // 
            this.dataGridView_All.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView_All.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_All.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_All.Location = new System.Drawing.Point(5, 45);
            this.dataGridView_All.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView_All.Name = "dataGridView_All";
            this.dataGridView_All.RowHeadersWidth = 62;
            this.dataGridView_All.RowTemplate.Height = 24;
            this.dataGridView_All.Size = new System.Drawing.Size(601, 273);
            this.dataGridView_All.TabIndex = 71;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer3.Size = new System.Drawing.Size(611, 634);
            this.splitContainer3.SplitterDistance = 324;
            this.splitContainer3.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lab_Order, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView_Order, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(611, 324);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lab_Order
            // 
            this.lab_Order.BackColor = System.Drawing.Color.CadetBlue;
            this.lab_Order.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_Order.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_Order.ForeColor = System.Drawing.Color.White;
            this.lab_Order.Location = new System.Drawing.Point(4, 0);
            this.lab_Order.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_Order.Name = "lab_Order";
            this.lab_Order.Size = new System.Drawing.Size(603, 40);
            this.lab_Order.TabIndex = 101;
            this.lab_Order.Text = "　　訂單";
            this.lab_Order.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView_Order
            // 
            this.dataGridView_Order.BackgroundColor = System.Drawing.Color.MintCream;
            this.dataGridView_Order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Order.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Order.Location = new System.Drawing.Point(5, 45);
            this.dataGridView_Order.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView_Order.Name = "dataGridView_Order";
            this.dataGridView_Order.RowHeadersWidth = 62;
            this.dataGridView_Order.RowTemplate.Height = 24;
            this.dataGridView_Order.Size = new System.Drawing.Size(601, 274);
            this.dataGridView_Order.TabIndex = 71;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lab_OrderDetails, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dataGridView_OrderDetails, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(611, 306);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // lab_OrderDetails
            // 
            this.lab_OrderDetails.BackColor = System.Drawing.Color.CadetBlue;
            this.lab_OrderDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_OrderDetails.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_OrderDetails.ForeColor = System.Drawing.Color.White;
            this.lab_OrderDetails.Location = new System.Drawing.Point(4, 0);
            this.lab_OrderDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_OrderDetails.Name = "lab_OrderDetails";
            this.lab_OrderDetails.Size = new System.Drawing.Size(603, 40);
            this.lab_OrderDetails.TabIndex = 102;
            this.lab_OrderDetails.Text = "　　訂單明細";
            this.lab_OrderDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView_OrderDetails
            // 
            this.dataGridView_OrderDetails.BackgroundColor = System.Drawing.Color.MintCream;
            this.dataGridView_OrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_OrderDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_OrderDetails.Location = new System.Drawing.Point(5, 45);
            this.dataGridView_OrderDetails.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView_OrderDetails.Name = "dataGridView_OrderDetails";
            this.dataGridView_OrderDetails.RowHeadersWidth = 62;
            this.dataGridView_OrderDetails.RowTemplate.Height = 24;
            this.dataGridView_OrderDetails.Size = new System.Drawing.Size(601, 256);
            this.dataGridView_OrderDetails.TabIndex = 100;
            // 
            // nwDataSet1
            // 
            this.nwDataSet1.DataSetName = "NWDataSet";
            this.nwDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableAdapter1
            // 
            this.productsTableAdapter1.ClearBeforeFill = true;
            // 
            // ordersTableAdapter1
            // 
            this.ordersTableAdapter1.ClearBeforeFill = true;
            // 
            // order_DetailsTableAdapter1
            // 
            this.order_DetailsTableAdapter1.ClearBeforeFill = true;
            // 
            // frm_LinqHW01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 961);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_LinqHW01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_LinqHW";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grp_Orders.ResumeLayout(false);
            this.grp_Orders.PerformLayout();
            this.grp_Products.ResumeLayout(false);
            this.grp_Products.PerformLayout();
            this.grp_FileInfo.ResumeLayout(false);
            this.grp_student2.ResumeLayout(false);
            this.grp_student1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_All)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Order)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_OrderDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lab_Order;
        private System.Windows.Forms.DataGridView dataGridView_Order;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lab_OrderDetails;
        private System.Windows.Forms.DataGridView dataGridView_OrderDetails;
        private System.Windows.Forms.GroupBox grp_student1;
        private System.Windows.Forms.Button btn_StudentQ1;
        private System.Windows.Forms.Button btn_StudentQ2;
        private System.Windows.Forms.Button btn_StudentQ3;
        private System.Windows.Forms.GroupBox grp_student2;
        private System.Windows.Forms.Button btn_StudentQ8;
        private System.Windows.Forms.Button btn_StudentQ9;
        private System.Windows.Forms.GroupBox grp_FileInfo;
        private System.Windows.Forms.Button btn_LogFile;
        private System.Windows.Forms.Button btn_CreatedOrder;
        private System.Windows.Forms.Button btn_BigFile;
        private System.Windows.Forms.GroupBox grp_Products;
        private System.Windows.Forms.TextBox txt_page;
        private System.Windows.Forms.Button btn_NextPage;
        private System.Windows.Forms.Label lab_page;
        private System.Windows.Forms.Button btn_PreviousPage;
        private System.Windows.Forms.GroupBox grp_Orders;
        private System.Windows.Forms.Button btn_AllOrder;
        private System.Windows.Forms.Label lab_OrderYear;
        private System.Windows.Forms.ComboBox cbo_OrderYear;
        private System.Windows.Forms.Button btn_OrderList;
        private System.Windows.Forms.Button btn_StudentQ6;
        private System.Windows.Forms.Button btn_StudentQ7;
        private System.Windows.Forms.Button btn_StudentQ4;
        private System.Windows.Forms.Button btn_StudentQ5;
        private NWDataSet nwDataSet1;
        private NWDataSetTableAdapters.ProductsTableAdapter productsTableAdapter1;
        private NWDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter1;
        private NWDataSetTableAdapters.Order_DetailsTableAdapter order_DetailsTableAdapter1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lab_Search;
        private System.Windows.Forms.DataGridView dataGridView_All;
    }
}