using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSIT143_06_LinqLabs
{
    public partial class frm_LinqHW04 : Form
    {
        public frm_LinqHW04()
        {
            InitializeComponent();
        }

        NorthwindEntities dbContext = new NorthwindEntities();

        private void ClearMethod()
        {
            this.dataGridView_Master.DataSource = null;
            this.dataGridView_Deteil.DataSource = null;
            this.treeView.Nodes.Clear();
        }

        private void btn_GroupBy_Click(object sender, EventArgs e)
        {
            ClearMethod();

        }

        System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(@"c:\windows");

        private void btn_FileSize_Click(object sender, EventArgs e)
        {
            ClearMethod();
            System.IO.FileInfo[] files = dir.GetFiles();
            this.dataGridView_Master.DataSource = files;
            lab_Master.Text = $"　　{grp_FileInfo.Text}";

            var q1 = from f in files
                     orderby f.Length descending
                     select f;

            this.dataGridView_Master.DataSource = q1.ToList();

            //================ GroupBy ================

            lab_Deteil.Text = $"　　{btn_FileSize.Text}";

            var q2 = from f in files
                     orderby f.Length descending
                     group f by MySizeKey(f.Length) into g
                     select new { 檔案容量分類 = g.Key, 檔案數量 = g.Count(), MyGroup = g};

            this.dataGridView_Deteil.DataSource = q2.ToList();

            //================ TreeView ================

            foreach (var group in q2)
            {
                string s = $"{group.檔案容量分類} ({group.檔案數量})";
                TreeNode x = this.treeView.Nodes.Add(s);

                foreach (var item in group.MyGroup)
                    x.Nodes.Add(item.ToString());
            }
        }

        private string MySizeKey(long f)
        {
            if (f < 1000)
                return "極小容量檔案";
            else if (f < 10000)
                return "小容量檔案";
            else if (f < 100000)
                return "中容量檔案";
            else if (f < 1000000)
                return "大容量檔案";
            else
                return "極大容量檔案";
        }

        private void btn_FileYear_Click(object sender, EventArgs e)
        {
            ClearMethod();
            System.IO.FileInfo[] files = dir.GetFiles();
            this.dataGridView_Master.DataSource = files;
            lab_Master.Text = $"　　{grp_FileInfo.Text}";

            var q1 = from f in files
                     orderby f.CreationTime descending
                     select f;

            this.dataGridView_Master.DataSource = q1.ToList();

            //================ GroupBy ================

            lab_Deteil.Text = $"　　{btn_FileYear.Text}";

            var q2 = from f in files
                     group f by f.CreationTime.Year into g
                     orderby g.Key descending
                     select new { 檔案年份 = g.Key, 檔案數量 = g.Count(), MyGroup = g };

            this.dataGridView_Deteil.DataSource = q2.ToList();

            //================ TreeView ================

            foreach (var group in q2)
            {
                string s = $"{group.檔案年份} ({group.檔案數量})";
                TreeNode x = this.treeView.Nodes.Add(s);

                foreach (var item in group.MyGroup)
                    x.Nodes.Add(item.ToString());
            }
        }

        private void btn_PdPrice_Click(object sender, EventArgs e)
        {
            ClearMethod();
            lab_Master.Text = $"　　{grp_NWEntity1.Text}";

            var q1 = this.dbContext.Products.OrderBy(p => p.UnitPrice);

            this.dataGridView_Master.DataSource = q1.ToList();

            //================ GroupBy ================

            //var q2 = from p in dbContext.Products.AsEnumerable()
            //         orderby p.UnitPrice
            //         group p by MyPdPriceKey(p.UnitPrice) into g
            //         select new { 產品價位分類 = g.Key , 產品數量 = g.Count(), MyGroup = g};
            lab_Deteil.Text = $"　　{btn_PdPrice.Text}";

            var q2 = this.dbContext.Products.AsEnumerable()
                                            .OrderBy(p => p.UnitPrice)
                                            .GroupBy(p => MyPdPriceKey(p.UnitPrice))
                                            .Select(g => new { 產品價位分類 = g.Key, 產品數量 = g.Count(), MyGroup = g });

            this.dataGridView_Deteil.DataSource = q2.ToList();

            //================ TreeView ================

            foreach(var group in q2)
            {
                string s = $"{group.產品價位分類} ({group.產品數量})";
                TreeNode x = this.treeView.Nodes.Add(s);

                foreach (var item in group.MyGroup)
                    x.Nodes.Add($"{item.ProductName}   {item.UnitPrice:c2}");
            }
        }

        private string MyPdPriceKey(decimal? p)
        {
            if (p < 50)
                return "低價位產品";
            else if (p < 100)
                return "中價位產品";
            else
                return "高價位產品";
        }

        private void btn_OdYear_Click(object sender, EventArgs e)
        {
            ClearMethod();
            lab_Master.Text = $"　　{grp_NWEntity1.Text}";

            var q1 = this.dbContext.Orders.OrderBy(o => o.OrderDate.Value);

            this.dataGridView_Master.DataSource = q1.ToList();

            //================ GroupBy ================

            lab_Deteil.Text = $"　　{btn_OdYear.Text}";

            var q2 = this.dbContext.Orders.OrderBy(o => o.OrderDate.Value)
                                          .GroupBy(o => o.OrderDate.Value.Year)
                                          .Select(g=>new {訂單年份 = g.Key, 訂單數量 = g.Count(),MyGroup = g });

            this.dataGridView_Deteil.DataSource = q2.ToList();

            //================ TreeView ================

            foreach (var group in q2)
            {
                string s = $"{group.訂單年份}年 ({group.訂單數量})";
                TreeNode x = this.treeView.Nodes.Add(s);

                foreach (var item in group.MyGroup)
                    x.Nodes.Add($"訂單編號{item.OrderID}");
            }
        }

        private void btn_OdYearMonth_Click(object sender, EventArgs e)
        {
            ClearMethod();
            lab_Master.Text = $"　　{grp_NWEntity1.Text}";

            var q1 = this.dbContext.Orders.OrderBy(o => o.OrderDate.Value.Year).ThenBy(o => o.OrderDate.Value.Month);

            this.dataGridView_Master.DataSource = q1.ToList();

            //================ GroupBy ================

            lab_Deteil.Text = $"　　{btn_OdYearMonth.Text}";
            var q2 = this.dbContext.Orders.OrderBy(o => o.OrderDate.Value.Year)
                              .ThenBy(o => o.OrderDate.Value.Month)
                              .GroupBy(o => o.OrderDate.Value.Year )
                              .Select(Y => new { 訂單年份 = Y.Key, 訂單年份數量 = Y.Count(), MyGroupY = Y
                              .GroupBy(o => o.OrderDate.Value.Month)
                              .Select(M => new { 訂單月份 = M.Key, 訂單月份數量 = M.Count(), MyGroupM = M })
                              });

            //var q2 = this.dbContext.Orders.OrderBy(o => o.OrderDate.Value.Year)
            //                              .ThenBy(o => o.OrderDate.Value.Month)
            //                              .GroupBy(o => new { o.OrderDate.Value.Year, o.OrderDate.Value.Month })
            //                              .Select(g => new { 訂單年份 = g.Key.Year, 訂單月份 = g.Key.Month, 訂單數量 = g.Count(), MyGroup = g });

            this.dataGridView_Deteil.DataSource = q2.ToList();

            //================ TreeView ================

            foreach (var group in q2)
            {
                string s = $"{group.訂單年份}年 ({group.訂單年份數量})";
                TreeNode x = this.treeView.Nodes.Add(s);

                foreach (var item in group.MyGroupY)
                {
                    string s2 = $"{item.訂單月份}月 ({item.訂單月份數量})";
                    TreeNode y = x.Nodes.Add(s2);

                    foreach (var items in item.MyGroupM)
                        y.Nodes.Add($"訂單編號{items.OrderID}");
                }
            }

            #region //年份完下面還要再有月份樹狀圖
            /*
            //================ GroupBy2A ================
            lab_Deteil.Text = $"　　{btn_OdYearMonth.Text}";
            var q2A = this.dbContext.Orders.OrderBy(o => o.OrderDate.Value.Year)
                                          .ThenBy(o => o.OrderDate.Value.Month)
                                          .GroupBy(o => new { o.OrderDate.Value.Year})
                                          .Select(g => new { 訂單年份 = g.Key.Year, 訂單數量 = g.Count(), MyGroup = g });

            this.dataGridView_Deteil.DataSource = q2A.ToList();

            //================ TreeView2A ================

            foreach (var group in q2A)
            {
                string s = $"{group.訂單年份}年 ({group.訂單數量})";
                TreeNode x = this.treeView.Nodes.Add(s);

                    foreach (var item in group.MyGroup)
                        x.Nodes.Add($"訂單編號{item.OrderID}");
            }

            //================ GroupBy2B ================
            lab_Deteil.Text = $"　　{btn_OdYearMonth.Text}";
            var q2B = from o in this.dbContext.Orders
                      select new { 訂單月份 = o.OrderDate.Value.Month,訂單編號= o.OrderID} into newo
                      orderby newo.訂單月份
                      group newo by newo.訂單月份 into g 
                         select new { 訂單月份=g.Key,訂單月份數量=g.Count() , MyGroup = g};

            //================ TreeView2B ================

            foreach (var group in q2B)
            {
                string s = $"{group.訂單月份}月 ({group.訂單月份數量})";
                TreeNode x = this.treeView.Nodes.Add(s);

                foreach (var item in group.MyGroup)
                    x.Nodes.Add($"訂單編號{item.訂單編號}");
            }
            */
            #endregion
        }
        class MyTotal
        {
            public double 總銷售額 { get; set; }
        }

        private void btn_Total_Click(object sender, EventArgs e)
        {
            ClearMethod();
            lab_Master.Text = $"　　{grp_NWEntity2.Text}";

            var q1 = from p in dbContext.Products.AsEnumerable()
                    join od in this.dbContext.Order_Details on p.ProductID equals od.ProductID
                    select new {
                        od.OrderID,
                        od.ProductID,
                        p.ProductName,
                        UnitPrice = Math.Round(od.UnitPrice,2),
                        od.Quantity,折扣 = (decimal)(1-od.Discount),
                        Sales = Math.Round(od.UnitPrice * od.Quantity * (decimal)(1 - od.Discount),2)};

            this.dataGridView_Master.DataSource = q1.ToList();

            //var q2 = (from od in dbContext.Order_Details
            //          select new { sales = Math.Round(od.UnitPrice * od.Quantity * Convert.ToDecimal(1 - od.Discount), 2) }).Sum();

            lab_Deteil.Text = $"　　{btn_Total.Text}";

            var q2 = this.dbContext.Order_Details.Select(od => (double)(od.UnitPrice) * od.Quantity * (double)(1 - od.Discount)).Sum();
            
            List<MyTotal> list = new List<MyTotal>();
            MyTotal Total = new MyTotal();
            Total.總銷售額 = Math.Round(q2,2);
            list.Add(Total);

            this.dataGridView_Deteil.DataSource = list.ToArray();

        }

        private void btn_Top5Sales_Click(object sender, EventArgs e)
        {
            ClearMethod();
            lab_Master.Text = $"　　{grp_NWEntity2.Text}";

            var q1 = from od in dbContext.Order_Details.AsEnumerable()
                     select new
                     {
                         EmpName = od.Order.Employee.FirstName + "." + od.Order.Employee.LastName,
                         od.OrderID,
                         od.Product.ProductName,
                         UnitPrice = Math.Round(od.UnitPrice, 2),
                         od.Quantity,
                         折扣 = (decimal)(1 - od.Discount),
                         Sales = Math.Round(od.UnitPrice * od.Quantity * (decimal)(1 - od.Discount), 2)
                     };

            this.dataGridView_Master.DataSource = q1.ToList();

            lab_Deteil.Text = $"　　{btn_Top5Sales.Text}";

            var q2 = (from od in this.dbContext.Order_Details.AsEnumerable()
                     group od by od.Order.Employee.FirstName + "." + od.Order.Employee.LastName into g
                     select new { EmpName = g.Key, EmpCount = g.Count(), EmpSales = 
                     g.Sum(s => Math.Round(s.UnitPrice * s.Quantity * (decimal)(1 - s.Discount),2))}).Take(5);

            this.dataGridView_Deteil.DataSource = q2.ToList();    
        }

        private void btn_Top5PdPrice_Click(object sender, EventArgs e)
        {
            ClearMethod();
            lab_Master.Text = $"　　{grp_NWEntity2.Text}";
            lab_Deteil.Text = $"　　{btn_Top5PdPrice.Text}";

            var q = (from p in dbContext.Products.AsEnumerable()
                     join c in dbContext.Categories
                     on p.CategoryID equals c.CategoryID
                     //where p.Discontinued = false
                     orderby (decimal)(p.UnitPrice) descending
                     select new { p.ProductID, p.ProductName, UnitPrice = Math.Round((decimal)p.UnitPrice,2), p.UnitsInStock, c.CategoryName }).Take(5);

            this.dataGridView_Deteil.DataSource = q.ToList();
        }

        private void btn_Any_Click(object sender, EventArgs e)
        {
            ClearMethod();

            var q = (from p in dbContext.Products
                     where p.UnitPrice > 300
                     select p).Any();

            if (q!=true)
            MessageBox.Show("產品單價沒有大於300");
        }

        private void btn_plot_Click(object sender, EventArgs e)
        {
            ClearMethod();
            lab_Deteil.Text = $"　　{btn_plot.Text}";

            var q = from od in this.dbContext.Order_Details.AsEnumerable()
                    group od by od.Order.OrderDate.Value.Year into g
                    select new
                    {
                        Year = g.Key,
                        YearCount = g.Count(),
                        YearSales = g.Sum(s => Math.Round(s.UnitPrice * s.Quantity * (decimal)(1 - s.Discount), 2))
                    };

            this.dataGridView_Deteil.DataSource = q.ToList();

            //================ Chart ================

            this.chart.DataSource = q;
            this.chart.Series[0].XValueMember = "Year";
            this.chart.Series[0].YValueMembers = "YearSales";
            this.chart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
        }

        private void btn_GrowthRate_Click(object sender, EventArgs e)
        {
            ClearMethod(); 
            lab_Deteil.Text = $"　　{btn_GrowthRate.Text}";
            
            var qA = from od in this.dbContext.Order_Details.AsEnumerable()
                     group od by od.Order.OrderDate.Value.Year into g
                    select new {Year=g.Key, YearSales = Math.Round(g.Sum(s => s.UnitPrice * s.Quantity * (decimal)(1 - s.Discount)),2) };

            var qB = from od in this.dbContext.Order_Details.AsEnumerable()
                     group od by od.Order.OrderDate.Value.Year into g
                    select new { Year = g.Key+1, YearSales = Math.Round(g.Sum(s => s.UnitPrice * s.Quantity * (decimal)(1 - s.Discount)),2) };

            var q = from ThisYear in qA
                    join LastYear in qB
                    on ThisYear.Year equals LastYear.Year
                    select new
                    {
                        //年營收成長率=（當年營收– 去年營收）÷ 去年營收x 100%
                        YearGrowthRate = Math.Round((ThisYear.YearSales - LastYear.YearSales) / LastYear.YearSales * 100,2),
                        YearAndYearSales = ThisYear
                    };

            this.dataGridView_Deteil.DataSource = q.ToList();

            //================ Chart ================

            this.chart.Series.Clear();
            this.chart.DataSource = null;
            this.chart.Series.Add("YearGrowthRate");
            this.chart.DataSource = q;
            //this.chart.Series[0].XValueMember = "Year";
            this.chart.Series[0].YValueMembers = "YearGrowthRate";
            this.chart.Series[0].Name = "YearGrowthRate";
            this.chart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
        }
    }
}
