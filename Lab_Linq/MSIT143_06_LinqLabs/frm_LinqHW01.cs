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
    public partial class frm_LinqHW01 : Form
    {
        public frm_LinqHW01()
        {
            InitializeComponent();

            this.ordersTableAdapter1.Fill(this.nwDataSet1.Orders);
            this.order_DetailsTableAdapter1.Fill(this.nwDataSet1.Order_Details);
            this.productsTableAdapter1.Fill(this.nwDataSet1.Products);

            Random rd = new Random();
            students_scores = new List<Student>()
            {
                new Student{ 班級 = "NSA_306", 座號 = "01", 姓名 = "陳苡錚", 性別 = "女", 國文 = rd.Next(101), 英文 = rd.Next(101), 數學 = rd.Next(101) },
                new Student{ 班級 = "NSA_306", 座號 = "06", 姓名 = "王婷薇", 性別 = "女", 國文 = rd.Next(101), 英文 = rd.Next(101), 數學 = rd.Next(101) },
                new Student{ 班級 = "NSA_306", 座號 = "11", 姓名 = "廖家毅", 性別 = "男", 國文 = rd.Next(101), 英文 = rd.Next(101), 數學 = rd.Next(101) },
                new Student{ 班級 = "NSA_306", 座號 = "13", 姓名 = "李沛軒", 性別 = "男", 國文 = rd.Next(101), 英文 = rd.Next(101), 數學 = rd.Next(101) },
                new Student{ 班級 = "NSA_306", 座號 = "16", 姓名 = "洪暐婷", 性別 = "女", 國文 = rd.Next(101), 英文 = rd.Next(101), 數學 = rd.Next(101) },
                new Student{ 班級 = "NSA_306", 座號 = "18", 姓名 = "游曉雯", 性別 = "女", 國文 = rd.Next(101), 英文 = rd.Next(101), 數學 = rd.Next(101) },
                new Student{ 班級 = "NSA_306", 座號 = "20", 姓名 = "鄭　凱", 性別 = "男", 國文 = rd.Next(101), 英文 = rd.Next(101), 數學 = rd.Next(101) },
            };
        }

        List<Student> students_scores;

        public class Student
        {
            public string 座號 { get; set; }
            public string 姓名 { get; set; }
            public string 班級 { get; set; }
            public int 國文 { get; set; }
            public int 英文 { get; internal set; }
            public int 數學 { get; set; }
            public string 性別 { get; set; }
            public int 總分
            {
                get
                {
                    return 國文 + 英文 + 數學;
                }
            }
            public int 最高分
            {
                get
                {
                    int max = 0;
                    if (國文 > 英文 && 國文 > 數學)
                        max = 國文;
                    if (英文 > 國文 && 英文 > 數學)
                        max = 英文;
                    if (數學 > 國文 && 數學 > 英文)
                        max = 數學;
                    return max;
                }
            }
            public int 最低分
            {
                get
                {
                    int min = 0;
                    if (國文 < 英文 && 國文 < 數學)
                        min = 國文;
                    if (英文 < 國文 && 英文 < 數學)
                        min = 英文;
                    if (數學 < 國文 && 數學 < 英文)
                        min = 數學;
                    return min;
                }
            }
            public double 平均成績
            {
                get
                {
                    return Math.Round(Convert.ToDouble(國文 + 英文 + 數學) / 3, 1);
                }
            }
        }

        void DataGridViewClear()
        {
            clicked = true;
            this.dataGridView_All.DataSource = null;
            this.dataGridView_Order.DataSource = null;
            this.dataGridView_OrderDetails.DataSource = null;
            TittleClear();
        }

        bool clicked = false; // T >> 按 F >> 沒按
        void TittleClear()
        {
            if (clicked == true)
            {
                lab_Order.Text = "　　訂單";
                lab_OrderDetails.Text= "　　訂單明細";
            }
        }

        private void btn_StudentQ1_Click(object sender, EventArgs e)
        {
            // 班級學生成績
            DataGridViewClear();
            lab_Search.Text = $"　　{btn_StudentQ1.Text}";
            this.dataGridView_All.DataSource = students_scores;
        }

        private void btn_StudentQ2_Click(object sender, EventArgs e)
        {
            // 前三位學生所有科目成績
            DataGridViewClear();
            lab_Search.Text = $"　　{btn_StudentQ2.Text}";

            var q = from s in students_scores
                    orderby s.座號
                    select s;
            this.dataGridView_All.DataSource = q.Take(3).ToList(); 
        }

        private void btn_StudentQ3_Click(object sender, EventArgs e)
        {
            // 後兩位學生所有科目成績
            DataGridViewClear();
            lab_Search.Text = $"　　{btn_StudentQ3.Text}";
            var q = from s in students_scores
                    orderby s.座號 descending
                    select s;
            this.dataGridView_All.DataSource = q.Take(2).ToList();
        }

        private void btn_StudentQ4_Click(object sender, EventArgs e)
        {
            // 找出指定3位學生1,6,16的成績
            DataGridViewClear();
            lab_Search.Text = $"　　{btn_StudentQ4.Text} (1號,6號,16號同學)";
            var q = from s in students_scores
                    where s.座號 == "01" || s.座號 == "06" || s.座號 == "16"
                    select s;
            this.dataGridView_All.DataSource = q.ToList();
        }

        private void btn_StudentQ5_Click(object sender, EventArgs e)
        {
            // 找出學生18的成績
            DataGridViewClear();
            lab_Search.Text = $"　　{btn_StudentQ5.Text} (18號確診同學)";
            var q = from s in students_scores
                    where s.座號 == "18"
                    select s;
            this.dataGridView_All.DataSource = q.ToList();
        }

        private void btn_StudentQ6_Click(object sender, EventArgs e)
        {
            // 找出除了學生18以外的學生所有成績 (學生18確診隔離)
            DataGridViewClear();
            lab_Search.Text = $"　　{btn_StudentQ6.Text} (18號學生確診隔離中)";

            var q = from s in students_scores
                    where s.座號 != "18"
                    select s;

            this.dataGridView_All.DataSource = q.ToList();
        }

        private void btn_StudentQ7_Click(object sender, EventArgs e)
        {
            // 數學成績不及格的學生
            DataGridViewClear();
            lab_Search.Text = $"　　{btn_StudentQ7.Text}";

            var q = from s in students_scores
                    where s.數學 < 60
                    select s;

            this.dataGridView_All.DataSource = q.ToList();
        }

        private void btn_StudentQ8_Click(object sender, EventArgs e)
        {
            // 找出男學生的國文數學兩科科目成績
            DataGridViewClear();
            lab_Search.Text = $"　　{btn_StudentQ8.Text}";

            var q = students_scores.Where(s => s.性別 == "男").Select(s => new {s.姓名, s.國文, s.數學 });
            
            this.dataGridView_All.DataSource = q.ToList();
        }

        private void btn_StudentQ9_Click(object sender, EventArgs e)
        {
            //學生個人所有科目的 sum, min, max, avg
            DataGridViewClear();
            lab_Search.Text = $"　　{btn_StudentQ9.Text}";

            var q = students_scores.Select(s => new
            {
                名字 = s.姓名,
                總分 = s.國文 + s.英文 + s.數學,
                最高分 = new[] { s.國文, s.英文, s.數學 }.Max(),
                最低分 = new[] { s.國文, s.英文, s.數學 }.Min(),
                平均分數 = new[] { s.國文 + s.英文 + s.數學 }.Average().ToString("0.00")
            });

            this.dataGridView_All.DataSource = q.ToList();
        }

        System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(@"c:\windows");

        private void btn_LogFile_Click(object sender, EventArgs e)
        {
            DataGridViewClear();
            lab_Search.Text = $"　　{btn_LogFile.Text}";

            System.IO.FileInfo[] files = dir.GetFiles();
            this.dataGridView_All.DataSource = files;

            var q = from f in files
                    where f.Extension.Contains(".log")
                    select f;

            this.dataGridView_All.DataSource = q.ToList();
        }

        private void btn_CreatedOrder_Click(object sender, EventArgs e)
        {
            DataGridViewClear();
            lab_Search.Text = $"　　{btn_CreatedOrder.Text}";

            System.IO.FileInfo[] files = dir.GetFiles();
            this.dataGridView_All.DataSource = files;

            var q = from f in files
                    where f.CreationTime.Year == 2019
                    orderby f.CreationTime.Minute descending
                    select f;

            this.dataGridView_All.DataSource = q.ToList();
        }

        private void btn_BigFile_Click(object sender, EventArgs e)
        {
            DataGridViewClear();
            lab_Search.Text = $"　　{btn_BigFile.Text}";

            System.IO.FileInfo[] files = dir.GetFiles();
            this.dataGridView_All.DataSource = files;

            var q = from f in files
                    where f.Length >= 100000
                    orderby f.Length descending
                    select f;

            this.dataGridView_All.DataSource = q.ToList();
        }

        int count;
        private void btn_PreviousPage_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(txt_page.Text);
            int page = (count * i) - i;
            lab_Search.Text = $"　　{grp_Products.Text}   第{page-i+1}至{page}頁";
            if (count -1 <= 0)
            { count++; return; }
            count--;

            DataGridViewClear();
            
            var q = from f in nwDataSet1.Products.Take(count * i).Skip((count - 1) * i)
                    select new
                    {
                        f.ProductID,
                        f.ProductName,
                        f.SupplierID,
                        f.CategoryID,
                        f.QuantityPerUnit,
                        f.UnitPrice,
                        f.UnitsInStock,
                        f.UnitsOnOrder,
                        f.ReorderLevel,
                        f.Discontinued
                    };
            this.dataGridView_All.DataSource = q.ToList();
        }

        private void btn_NextPage_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(txt_page.Text);
            int page = (count * i) + i;
            lab_Search.Text = $"　　{grp_Products.Text}   第{page - i + 1}至{page}筆資料";

            if (nwDataSet1.Products.Count < count * i)
            { count--; return; }
            count++;

            DataGridViewClear();

            var q = from f in nwDataSet1.Products.Take(count * i).Skip((count - 1) * i)
                    select new
                    {
                        f.ProductID,
                        f.ProductName,
                        f.SupplierID,
                        f.CategoryID,
                        f.QuantityPerUnit,
                        f.UnitPrice,
                        f.UnitsInStock,
                        f.UnitsOnOrder,
                        f.ReorderLevel,
                        f.Discontinued
                    };

            this.dataGridView_All.DataSource = q.ToList();
        }

        private void btn_AllOrder_Click(object sender, EventArgs e)
        {
            DataGridViewClear();
            lab_Order.Text = $"　　{btn_AllOrder.Text}";

            var q = from o in nwDataSet1.Orders
                    select new
                    {
                        o.OrderID,
                        o.CustomerID,
                        o.EmployeeID,
                        o.OrderDate,
                        o.RequiredDate,
                        //f.ShippedDate,
                        o.ShipVia,
                        o.Freight,
                        o.ShipName,
                        o.ShipAddress,
                        o.ShipCity,
                        //f.ShipRegion,
                        //f.ShipPostalCode,
                        o.ShipCountry,
                    };

            this.dataGridView_Order.DataSource = q.ToList();

            var r = from o in nwDataSet1.Orders
                    group o by o.OrderDate.Year into Y
                    select Y.Key;

            cbo_OrderYear.DataSource = r.ToList();
        }

        string y;
        private void btn_OrderList_Click(object sender, EventArgs e)
        {
            
            DataGridViewClear();

            if (cbo_OrderYear.SelectedItem == null)
                return;

            if (cbo_OrderYear.Items != null)
                y = cbo_OrderYear.SelectedItem.ToString();

            lab_Order.Text = $"　　{y}年 訂單";
            lab_OrderDetails.Text = $"　　{y}年 訂單明細";

            var q1 = from o in nwDataSet1.Orders
                     where o.OrderDate.Year == Convert.ToInt32(cbo_OrderYear.SelectedItem)
                     select new
                     {
                         o.OrderID,
                         o.CustomerID,
                         o.EmployeeID,
                         o.OrderDate,
                         o.RequiredDate,
                         //f.ShippedDate,
                         o.ShipVia,
                         o.Freight,
                         o.ShipName,
                         o.ShipAddress,
                         o.ShipCity,
                         //f.ShipRegion,
                         //f.ShipPostalCode,
                         o.ShipCountry,
                     };

            this.dataGridView_Order.DataSource = q1.ToList();

            //========================================================================

            var q2 = from od in nwDataSet1.Order_Details
                     join o in nwDataSet1.Orders
                     on od.OrderID equals o.OrderID
                     where o.OrderDate.Year == Convert.ToInt32(cbo_OrderYear.SelectedItem)
                     select od;

            this.dataGridView_OrderDetails.DataSource = q2.ToList();
        }
    }
}
