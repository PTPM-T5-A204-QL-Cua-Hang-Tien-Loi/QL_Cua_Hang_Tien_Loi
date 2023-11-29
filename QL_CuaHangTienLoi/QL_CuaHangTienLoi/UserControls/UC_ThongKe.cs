using BLL_DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordExcelExport;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace QL_CuaHangTienLoi.UserControls
{
    public partial class UC_ThongKe : UserControl
    {
        static UC_ThongKe _obj;
        BLL_DAL_NhapHang nhaphang = new BLL_DAL_NhapHang();
        BLL_DAL_HDBan hd = new BLL_DAL_HDBan();
        public static UC_ThongKe Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new UC_ThongKe();
                }
                return _obj;
            }
        }
        public UC_ThongKe()
        {
            InitializeComponent();
        }

        private void btnCreateChart_Click(object sender, EventArgs e)
        {

        }

        private void loadNhapHang()
        {
            dgvImportHistory.DataSource = nhaphang.getNhapHangs_Table();
        }
        private void loadBanHang()
        {
            dgvSellingHistory.DataSource = hd.getHDBans_Table();
        }

        private void rad7days_CheckedChanged(object sender, EventArgs e)
        {
            if(rad7days.Checked)
            {
                DateTime datenow = DateTime.Now;
                DateTime datethen = DateTime.Now.AddDays(-7);
                dgvImportHistory.DataSource = nhaphang.getNhapHangsTheoNgay_Table(datenow, datethen);
                dgvSellingHistory.DataSource = hd.getHDBansTheoNgay_Table(datenow, datethen);
                tinhLoiNhuan();
            }    
        }

        private void rad6months_CheckedChanged(object sender, EventArgs e)
        {
            if(rad6months.Checked)
            {
                DateTime datenow = DateTime.Now;
                DateTime datethen = DateTime.Now.AddMonths(-6);
                dgvImportHistory.DataSource = nhaphang.getNhapHangsTheoNgay_Table(datenow, datethen);
                dgvSellingHistory.DataSource = hd.getHDBansTheoNgay_Table(datenow, datethen);
                tinhLoiNhuan();
            }    
        }

        private void rad5years_CheckedChanged(object sender, EventArgs e)
        {
            if(rad5years.Checked)
            {
                DateTime datenow = DateTime.Now;
                DateTime datethen = DateTime.Now.AddYears(-5);
                dgvImportHistory.DataSource = nhaphang.getNhapHangsTheoNgay_Table(datenow, datethen);
                dgvSellingHistory.DataSource = hd.getHDBansTheoNgay_Table(datenow, datethen);
                tinhLoiNhuan();
            }    
        }

        private void UC_ThongKe_Load(object sender, EventArgs e)
        {
            if (rad7days.Checked)
            {
                DateTime datenow = DateTime.Now;
                DateTime datethen = DateTime.Now.AddDays(-7);
                dgvImportHistory.DataSource = nhaphang.getNhapHangsTheoNgay_Table(datenow, datethen);
                dgvSellingHistory.DataSource = hd.getHDBansTheoNgay_Table(datenow, datethen);
                tinhLoiNhuan();
            }
        }

        private void dgvImportHistory_DataSourceChanged(object sender, EventArgs e)
        {
            double chitieutrongngay = 0;
            double tongchiteu = 0;
            if(dgvImportHistory.CurrentRow != null && dgvImportHistory.CurrentRow.Index < dgvImportHistory.Rows.Count - 1)
            {
                foreach (DataGridViewRow row in dgvImportHistory.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        if (row.Cells[1].Value.ToString() == DateTime.Now.Date.ToString())
                        {
                            chitieutrongngay += double.Parse(row.Cells[2].Value.ToString());
                        }
                        tongchiteu += double.Parse(row.Cells[2].Value.ToString());
                    }    
                }
                txtSpendingDay.Text = chitieutrongngay.ToString();
                txtTotalSpending.Text = tongchiteu.ToString();
                
            }    
        }

        private void dgvSellingHistory_DataSourceChanged(object sender, EventArgs e)
        {
            double thunhaptrongngay = 0;
            double tongthunhap = 0;
            if (dgvSellingHistory.CurrentRow != null && dgvSellingHistory.CurrentRow.Index < dgvSellingHistory.Rows.Count - 1)
            {
                foreach (DataGridViewRow row in dgvSellingHistory.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        if (row.Cells[2].Value.ToString() == DateTime.Now.Date.ToString())
                        {
                            thunhaptrongngay += double.Parse(row.Cells[4].Value.ToString());
                        }
                        tongthunhap += double.Parse(row.Cells[4].Value.ToString());
                    }    
                }
                txtIncomeDay.Text = thunhaptrongngay.ToString();
                txtTotalIncome.Text = tongthunhap.ToString();
            }    
                
        }
        private void tinhLoiNhuan()
        {
            if (txtTotalIncome.Text == "" || txtTotalSpending.Text == "")
                return;
            else
            {
                txtProfit.Text = (double.Parse(txtTotalIncome.Text) - double.Parse(txtSpendingDay.Text)).ToString();
            }
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            ExcelExport excel = new ExcelExport();
            List<HDBAN> hdlist = convertDataGridViewToListHD(dgvSellingHistory);
            string filename = "DanhMucHD";
            bool v = excel.ExportHD(hdlist, ref filename, txtTotalIncome.Text , true);
        }
        private List<HDBAN> convertDataGridViewToListHD(DataGridView dgv)
        {
            List<HDBAN> items = new List<HDBAN>();
            foreach (DataGridViewRow dr in dgv.Rows)
            {
                if (dr.Cells[0].Value != null)
                {
                    HDBAN item = new HDBAN();
                    item.MAHDBAN = dr.Cells[0].Value.ToString();
                    item.MANHANVIEN = dr.Cells[1].Value.ToString();
                    item.NGAYBAN = DateTime.Parse(dr.Cells[2].Value.ToString());
                    item.MAKHACH = dr.Cells[3].Value.ToString();
                    item.TONGTIEN = double.Parse(dr.Cells[4].Value.ToString());
                    items.Add(item);
                }
            }
            return items;
        }
        private List<NHAPHANG> convertDataGridViewToListNhapHang(DataGridView dgv)
        {
            List<NHAPHANG> items = new List<NHAPHANG>();
            foreach (DataGridViewRow dr in dgv.Rows)
            {
                if (dr.Cells[0].Value != null)
                {
                    NHAPHANG item = new NHAPHANG();
                    item.MANHAPHANG = dr.Cells[0].Value.ToString();
                    item.NGAYTAO = DateTime.Parse(dr.Cells[1].Value.ToString());
                    item.TONGTIEN = double.Parse(dr.Cells[2].Value.ToString());
                    item.MANHANVIEN = dr.Cells[3].Value.ToString();
                    items.Add(item);
                }
            }
            return items;
        }

        private void btnBaoCaoNhapHang_Click(object sender, EventArgs e)
        {
            ExcelExport excel = new ExcelExport();
            List<NHAPHANG> nhaphanglist = convertDataGridViewToListNhapHang(dgvImportHistory);
            string filename = "DanhMucNhapHang";
            bool v = excel.ExportNhapHang(nhaphanglist, ref filename, txtTotalSpending.Text, true);
        }

        private void rad1Year_CheckedChanged(object sender, EventArgs e)
        {
            if (rad1Year.Checked)
            {
                DateTime datenow = DateTime.Now;
                DateTime datethen = DateTime.Now.AddYears(-1);
                dgvImportHistory.DataSource = nhaphang.getNhapHangsTheoNgay_Table(datenow, datethen);
                dgvSellingHistory.DataSource = hd.getHDBansTheoNgay_Table(datenow, datethen);
                tinhLoiNhuan();
            }
        }

        private void rad1Month_CheckedChanged(object sender, EventArgs e)
        {
            if (rad1Month.Checked)
            {
                DateTime datenow = DateTime.Now;
                DateTime datethen = DateTime.Now.AddMonths(-1);
                dgvImportHistory.DataSource = nhaphang.getNhapHangsTheoNgay_Table(datenow, datethen);
                dgvSellingHistory.DataSource = hd.getHDBansTheoNgay_Table(datenow, datethen);
                tinhLoiNhuan();
            }
        }
    }
}
