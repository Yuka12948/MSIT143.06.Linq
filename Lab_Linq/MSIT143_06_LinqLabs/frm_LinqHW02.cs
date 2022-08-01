using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSIT143_06_LinqLabs
{
    public partial class frm_LinqHW02 : Form
    {
        public frm_LinqHW02()
        {
            InitializeComponent();
            this.productPhotoTableAdapter1.Fill(this.awDataSet1.ProductPhoto);
            
            var y = from p in awDataSet1.ProductPhoto
                    orderby p.ModifiedDate.Year
                    group p by p.ModifiedDate.Year into Y
                    select Y.Key;

            cbo_Year.DataSource = y.ToList();
        }

        void RowHeight()
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
                dataGridView.Rows[i].Height = 60;
        }

        private void btn_AllBike_Click(object sender, EventArgs e)
        {
            var q = from p in awDataSet1.ProductPhoto
                    select p;

            txt_Count.Text = q.Count().ToString();
            this.dataGridView.DataSource = q.ToList();
            RowHeight();
        }

        private void btn_SelectTimeBike_Click(object sender, EventArgs e)
        {
            DateTime dateS = dateTimePicker_Start.Value;
            DateTime dateE = dateTimePicker_End.Value;

            var q = from p in awDataSet1.ProductPhoto
                    where p.ModifiedDate >= dateS && p.ModifiedDate <= dateE
                    select p;

            txt_Count.Text = q.Count().ToString();
            this.dataGridView.DataSource = q.ToList();
            RowHeight();
        }

        private void btn_YearBike_Click(object sender, EventArgs e)
        {
            var q = from p in awDataSet1.ProductPhoto
                    where p.ModifiedDate.Year == Convert.ToInt32(cbo_Year.SelectedItem)
                    orderby p.ModifiedDate.Date
                    select p;

            txt_Count.Text = q.Count().ToString();
            this.dataGridView.DataSource = q.ToList();
            RowHeight();
        }

        private void btn_SeasonBike_Click(object sender, EventArgs e)
        {
            if (cbo_Season.SelectedItem == null)
                return;

            if (cbo_Season.SelectedItem.ToString() == "第一季")
            {
                var q = from p in awDataSet1.ProductPhoto
                         where p.ModifiedDate.Month >= 1 && p.ModifiedDate.Month <= 3
                         orderby p.ModifiedDate.Date
                         select p;

                txt_Count.Text = q.Count().ToString();
                this.dataGridView.DataSource = q.ToList();
                RowHeight();
            }

            if (cbo_Season.SelectedItem.ToString() == "第二季")
            {
                var q = from p in awDataSet1.ProductPhoto
                         where p.ModifiedDate.Month >= 4 && p.ModifiedDate.Month <= 6
                         orderby p.ModifiedDate.Date
                         select p;

                txt_Count.Text = q.Count().ToString();
                this.dataGridView.DataSource = q.ToList();
                RowHeight();
            }

            if (cbo_Season.SelectedItem.ToString() == "第三季")
            {
                var q = from p in awDataSet1.ProductPhoto
                         where p.ModifiedDate.Month >= 7 && p.ModifiedDate.Month <= 9
                         orderby p.ModifiedDate.Date
                         select p;

                txt_Count.Text = q.Count().ToString();
                this.dataGridView.DataSource = q.ToList();
                RowHeight();
            }

            if (cbo_Season.SelectedItem.ToString() == "第四季")
            {
                var q = from p in awDataSet1.ProductPhoto
                         where p.ModifiedDate.Month >= 10 && p.ModifiedDate.Month <= 12
                         orderby p.ModifiedDate.Date
                         select p;

                txt_Count.Text = q.Count().ToString();
                this.dataGridView.DataSource = q.ToList();
                RowHeight();
            }
        }

        private void dataGridView_MouseUp(object sender, MouseEventArgs e)
        {
            byte[] ByteData = (byte[])dataGridView.CurrentRow.Cells["LargePhoto"].Value;
            MemoryStream memoryStream = new MemoryStream(ByteData);
            picBox.Image = Image.FromStream(memoryStream);
            memoryStream.Close();
        }

        private void dataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //int position = e.RowIndex;
            //if (position < 0)
            //    return;

            //var q = awDataSet1.ProductPhoto.Select(p => p.LargePhoto);
            //picBox.Image = Image.FromStream(new MemoryStream(q.ToList()[position]));
        }
    }
}
