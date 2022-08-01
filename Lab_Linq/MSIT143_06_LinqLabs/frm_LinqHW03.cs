using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MSIT143_06_LinqLabs.frm_LinqHW01;

namespace MSIT143_06_LinqLabs
{
    public partial class frm_LinqHW03 : Form
    {
        public frm_LinqHW03()
        {
            InitializeComponent();

            Random rd = new Random();
            students_scores = new List<Student>()
            {
                new Student{ 班級 = "NSA_306", 座號 = "01", 姓名 = "陳苡錚", 性別 = "女", 國文 = rd.Next(60,101), 英文 = rd.Next(60,101), 數學 = rd.Next(101) },
                new Student{ 班級 = "NSA_306", 座號 = "11", 姓名 = "廖家毅", 性別 = "男", 國文 = rd.Next(60,101), 英文 = rd.Next(70,101), 數學 = rd.Next(80,101) },
                new Student{ 班級 = "NSA_306", 座號 = "06", 姓名 = "王婷薇", 性別 = "女", 國文 = rd.Next(60,101), 英文 = rd.Next(60,101), 數學 = rd.Next(60,101) },
                new Student{ 班級 = "NSA_306", 座號 = "13", 姓名 = "李沛軒", 性別 = "男", 國文 = rd.Next(85,101), 英文 = rd.Next(85,101), 數學 = rd.Next(85,101) },
                new Student{ 班級 = "NSA_306", 座號 = "16", 姓名 = "洪暐婷", 性別 = "女", 國文 = rd.Next(60,101), 英文 = rd.Next(101), 數學 = rd.Next(60,101) },
                new Student{ 班級 = "NSA_306", 座號 = "20", 姓名 = "鄭　凱", 性別 = "男", 國文 = rd.Next(60), 英文 = rd.Next(101), 數學 = rd.Next(101) },
                new Student{ 班級 = "NSA_306", 座號 = "18", 姓名 = "游曉雯", 性別 = "女", 國文 = rd.Next(101), 英文 = rd.Next(101), 數學 = rd.Next(101) },
            };

            var q = from std in students_scores
                    orderby std.座號
                    select std.姓名;

            cbo_stdSingle.DataSource = q.ToList();
        }

        List<Student> students_scores;

        private void ClearMethod()
        {
            this.dataGridView_Master.DataSource = null;
            this.treeView.Nodes.Clear();
        }

        private void btn_StdAll_Click(object sender, EventArgs e)
        {
            // 全班學生成績
            ClearMethod();
            lab_Master.Text = $"　　{btn_StdAll.Text}";
            var q1 = from std in this.students_scores
                     select std;

            this.dataGridView_Master.DataSource = q1.ToList();

            //=============== Chart ===============

            this.chart_std.DataSource = q1;
            this.chart_std.Series[0].XValueMember = "姓名";
            this.chart_std.Series[0].YValueMembers = "總分";
            this.chart_std.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;

            this.chart_std.Series[1].YValueMembers = "國文";
            this.chart_std.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            this.chart_std.Series[2].YValueMembers = "英文";
            this.chart_std.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            this.chart_std.Series[3].YValueMembers = "數學";
            this.chart_std.Series[3].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            this.chart_std.Series[4].YValueMembers = "最高分";
            this.chart_std.Series[4].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;

            this.chart_std.Series[5].YValueMembers = "最低分";
            this.chart_std.Series[5].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;

            this.chart_std.Series[6].YValueMembers = "平均成績";
            this.chart_std.Series[6].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

            //=============== TreeView ===============

            var q2 = from s in students_scores
                     orderby s.座號
                     select s;

            foreach (var group in q2)
            {
                string s = $"{group.座號}_{group.姓名} ({group.性別})";
                TreeNode x = treeView.Nodes.Add(s);
                x.Nodes.Add($"國文: {group.國文}");
                x.Nodes.Add($"英文: {group.英文}");
                x.Nodes.Add($"數學: {group.數學}");
                x.Nodes.Add($"總分: {group.總分}");
                x.Nodes.Add($"最高分: {group.最高分}");
                x.Nodes.Add($"最低分: {group.最低分}");
                x.Nodes.Add($"平均成績: {group.平均成績}");
            }
        }

        private void btn_StdGender_Click(object sender, EventArgs e)
        {
            // 男/女學生成績
            ClearMethod();
            lab_Master.Text = $"　　{btn_StdGender.Text}";

            var q1 = from std in this.students_scores
                     orderby std.性別 descending
                     select std;

            this.dataGridView_Master.DataSource = q1.ToList();


            //=============== Chart ===============

            //var q1 = from std in this.students_scores
            //         orderby std.性別 descending
            //         select new { 性別 = std.性別, 國文 = std.國文 };

            //this.dataGridView_Master.DataSource = q1.ToList();

            //=============== TreeView ===============

            var q2 = from s in students_scores
                     group s by s.性別 into g
                     orderby g.Key descending
                     select new { 性別 = g.Key, 人數 = g.Count(), MyGroupG = g
                     .GroupBy( s => s.姓名)
                     .Select(n => new {姓名= n.Key , MyGroupN = n })};

            foreach (var group in q2)
            {
                string s = $"{group.性別} ({group.人數})";
                TreeNode x = treeView.Nodes.Add(s);
                foreach (var item in group.MyGroupG)
                {
                    string s2 = $"{item.姓名}";
                    TreeNode Y =x.Nodes.Add(s2);

                    foreach (var items in item.MyGroupN)
                    {
                        Y.Nodes.Add($"國文: {items.國文}");
                        Y.Nodes.Add($"英文: {items.英文}");
                        Y.Nodes.Add($"數學: {items.數學}");
                        Y.Nodes.Add($"總分: {items.總分}");
                        Y.Nodes.Add($"最高分: {items.最高分}");
                        Y.Nodes.Add($"最低分: {items.最低分}");
                        Y.Nodes.Add($"平均成績: {items.平均成績}");
                    }
                }
            }
        }

        private void btn_stdSingle_Click(object sender, EventArgs e)
        {
            //各別學生成績
            ClearMethod();
            lab_Master.Text = $"　　{btn_stdSingle.Text}({cbo_stdSingle.SelectedItem})";

            var q = from std in students_scores
                    where std.姓名 == cbo_stdSingle.SelectedItem.ToString()
                    select std;

            this.dataGridView_Master.DataSource = q.ToList();

            //=============== Chart ===============

            this.chart_std.DataSource = q;
            this.chart_std.Series[0].XValueMember = "姓名";
            this.chart_std.Series[0].YValueMembers = "總分";
            this.chart_std.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;

            this.chart_std.Series[1].YValueMembers = "國文";
            this.chart_std.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            this.chart_std.Series[2].YValueMembers = "英文";
            this.chart_std.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            this.chart_std.Series[3].YValueMembers = "數學";
            this.chart_std.Series[3].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            this.chart_std.Series[4].YValueMembers = "最高分";
            this.chart_std.Series[4].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;

            this.chart_std.Series[5].YValueMembers = "最低分";
            this.chart_std.Series[5].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;

            this.chart_std.Series[6].YValueMembers = "平均成績";
            this.chart_std.Series[6].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            this.chart_std.Series[6].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;

            //=============== TreeView ===============

            var q2 = from s in students_scores
                     where s.姓名 == cbo_stdSingle.SelectedItem.ToString()
                     select s;

            foreach (var group in q2)
            {
                string s = $"{group.座號}_{group.姓名} ({group.性別})";
                TreeNode x = treeView.Nodes.Add(s);
                x.Nodes.Add($"國文: {group.國文}");
                x.Nodes.Add($"英文: {group.英文}");
                x.Nodes.Add($"數學: {group.數學}");
                x.Nodes.Add($"總分: {group.總分}");
                x.Nodes.Add($"最高分: {group.最高分}");
                x.Nodes.Add($"最低分: {group.最低分}");
                x.Nodes.Add($"平均成績: {group.平均成績}");
            }
        }

        private void btn_Groupby_Click(object sender, EventArgs e)
        {
            ClearMethod();
            lab_Master.Text = $"　　{btn_Groupby.Text} 段考能力指標";

            var q1 = from std in this.students_scores
                     orderby std.平均成績 descending
                     select std;

            this.dataGridView_Master.DataSource = q1.ToList();

            //=============== Chart ===============

            //var q2 = from std in students_scores
            //         orderby std.座號
            //         group std by Scoreskey(std.總分) into g
            //         select g;

            this.chart_std.DataSource = q1;
            this.chart_std.Series[0].XValueMember = "姓名";
            this.chart_std.Series[0].YValueMembers = "總分";
            this.chart_std.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;

            this.chart_std.Series[1].YValueMembers = "國文";
            this.chart_std.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            this.chart_std.Series[2].YValueMembers = "英文";
            this.chart_std.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            this.chart_std.Series[3].YValueMembers = "數學";
            this.chart_std.Series[3].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            this.chart_std.Series[4].YValueMembers = "最高分";
            this.chart_std.Series[4].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;

            this.chart_std.Series[5].YValueMembers = "最低分";
            this.chart_std.Series[5].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;

            this.chart_std.Series[6].YValueMembers = "平均成績";
            this.chart_std.Series[6].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

            //=============== TreeView ===============

            var q2 = from std in students_scores.AsEnumerable()
                     orderby std.平均成績 descending
                     group std by Scoreskey(std.平均成績) into g
                     select new { 段考能力指標 = g.Key, 人數 = g.Count(), MyGroup = g};

            foreach (var group in q2)
            {
                string s = $"{group.段考能力指標} ({group.人數})";
                TreeNode x = this.treeView.Nodes.Add(s);

                foreach (var item in group.MyGroup)
                    x.Nodes.Add($"{item.姓名} 國: {item.國文} 英 {item.英文} 數: {item.數學} 平均: {item.平均成績} 總分: {item.總分}");
            }

            /*


            */
        }

        private string Scoreskey(double std)
        {
            // D 不及格 (0~59)
            // C 待加強 (60~69)
            // B 普　通 (70~89)
            // A 優　等 (90~100)

            if (std < 60)
                return "D 不及格";
            else if (std < 70)
                return "C 待加強";
            else if (std < 90)
                return "B 普　通";
            else
                return "A 優　等";
        }
    }
}
