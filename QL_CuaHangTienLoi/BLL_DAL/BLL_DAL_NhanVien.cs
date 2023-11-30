using BLL_DAL.Function;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class BLL_DAL_NhanVien
    {
        QLCuaHangTienLoiDataContext qlch = new QLCuaHangTienLoiDataContext();
        public BLL_DAL_NhanVien() { }
        public List<NHANVIEN> getNhanViens_List()
        {
            List<NHANVIEN> list = new List<NHANVIEN>();
            list = qlch.NHANVIENs.ToList();
            return list;
        }
        //Gọi hàm này khi dùng cho datagridview
        public DataTable getNhanViens_Table()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã nhân viên");
            dt.Columns.Add("Tên nhân viên");
            dt.Columns.Add("Giới tính");
            dt.Columns.Add("Địa chỉ");
            dt.Columns.Add("Điện thoại");
            dt.Columns.Add("Ngày sinh");
            dt.Columns.Add("Email");
            var nhanvien = from nv in qlch.NHANVIENs select new { nv.MANHANVIEN,nv.TENNHANVIEN,nv.GIOITINH,nv.DIACHI_NV,nv.DIENTHOAI_NV,nv.NGAYSINH, nv.Email };
            foreach (var item in nhanvien)
            {
                var row = dt.NewRow();
                row[0] = item.MANHANVIEN;
                row[1] = item.TENNHANVIEN;
                row[2] = item.GIOITINH;
                row[3] = item.DIACHI_NV;
                row[4] = item.DIENTHOAI_NV;
                row[5] = item.NGAYSINH;
                row[6] = item.Email;
                dt.Rows.Add(row);
            }
            return dt;
        }

        public NHANVIEN getInfoNhanVien(string maNV)
        {
            NHANVIEN nv = new NHANVIEN();

            var info = from h in qlch.NHANVIENs where h.MANHANVIEN.Contains(maNV) select new { h.MANHANVIEN, h.TENNHANVIEN, h.GIOITINH, h.DIENTHOAI_NV, h.DIACHI_NV, h.NGAYSINH, h.Email };

            foreach (var item in info)
            {
                nv.MANHANVIEN = item.MANHANVIEN;
                nv.TENNHANVIEN = item.TENNHANVIEN;
                nv.GIOITINH = item.GIOITINH;
                nv.DIACHI_NV = item.DIACHI_NV;
                nv.NGAYSINH = item.NGAYSINH;
                nv.Email = item.Email;
                nv.DIENTHOAI_NV = item.DIENTHOAI_NV;
            }

            return nv;
        }

        public System.Drawing.Image GetHinhAnhNV(string maNV)
        {
            var imageData = (from nv in qlch.NHANVIENs
                             where nv.MANHANVIEN == maNV
                             select nv.HinhAnh).FirstOrDefault();

            if (imageData != null && imageData.Length > 0)
            {
                byte[] imageBytes = imageData.ToArray();
                return FConvert.ByteArrayToImage(imageBytes);
            }
            else
            {
                return null;
            }
        }

        public bool Create(NHANVIEN nv)
        {
            try
            {
                qlch.NHANVIENs.InsertOnSubmit(nv);
                qlch.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Edit(NHANVIEN nv)
        {
            try
            {
                NHANVIEN nHANVIEN = qlch.NHANVIENs.Where(u => u.MANHANVIEN == nv.MANHANVIEN).SingleOrDefault();
                nHANVIEN.MANHANVIEN = nv.MANHANVIEN;
                nHANVIEN.TENNHANVIEN = nv.TENNHANVIEN;
                nHANVIEN.GIOITINH = nv.GIOITINH;
                nHANVIEN.NGAYSINH = nv.NGAYSINH;
                nHANVIEN.DIACHI_NV = nv.DIACHI_NV;
                nHANVIEN.DIENTHOAI_NV = nv.DIENTHOAI_NV;
                qlch.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(NHANVIEN nv)
        {
            try
            {
                NHANVIEN nHANVIEN = qlch.NHANVIENs.Where(u => u.MANHANVIEN == nv.MANHANVIEN).SingleOrDefault();
                qlch.NHANVIENs.DeleteOnSubmit(nHANVIEN);
                qlch.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public DataTable timSP_NhieuGiaTri(string tennv, string gt, string sdt)
        {
            DataTable dt = taoTable();
            if (tennv != null)
            {
                var nhanvien = from h in qlch.NHANVIENs where h.TENNHANVIEN.Contains(tennv) select new { h.MANHANVIEN, h.TENNHANVIEN, h.GIOITINH, h.DIENTHOAI_NV, h.DIACHI_NV, h.NGAYSINH, h.Email };
                foreach (var item in nhanvien)
                {
                    var row = dt.NewRow();
                    row[0] = item.MANHANVIEN;
                    row[1] = item.TENNHANVIEN;
                    row[2] = item.GIOITINH;
                    row[3] = item.DIACHI_NV;
                    row[4] = item.DIENTHOAI_NV;
                    row[5] = item.NGAYSINH;
                    row[6] = item.Email;
                    dt.Rows.Add(row);
                }
            }
            else if (gt != null)
            {
                var nhanvien = from h in qlch.NHANVIENs where h.GIOITINH.Contains(gt) select new { h.MANHANVIEN, h.TENNHANVIEN, h.GIOITINH, h.DIENTHOAI_NV, h.DIACHI_NV, h.NGAYSINH, h.Email };
                foreach (var item in nhanvien)
                {
                    var row = dt.NewRow();
                    row[0] = item.MANHANVIEN;
                    row[1] = item.TENNHANVIEN;
                    row[2] = item.GIOITINH;
                    row[3] = item.DIACHI_NV;
                    row[4] = item.DIENTHOAI_NV;
                    row[5] = item.NGAYSINH;
                    row[6] = item.Email;
                    dt.Rows.Add(row);
                }
                gt = null;
            }
            else if (sdt != null)
            {
                var nhanvien = from h in qlch.NHANVIENs where h.DIENTHOAI_NV.Contains(sdt) select new { h.MANHANVIEN, h.TENNHANVIEN, h.GIOITINH, h.DIENTHOAI_NV, h.DIACHI_NV, h.NGAYSINH, h.Email };
                foreach (var item in nhanvien)
                {
                    var row = dt.NewRow();
                    row[0] = item.MANHANVIEN;
                    row[1] = item.TENNHANVIEN;
                    row[2] = item.GIOITINH;
                    row[3] = item.DIACHI_NV;
                    row[4] = item.DIENTHOAI_NV;
                    row[5] = item.NGAYSINH;
                    row[6] = item.Email;
                    dt.Rows.Add(row);
                }
                sdt = null;
            }
            if (gt != null)
            {
                DataRow[] rows = dt.Select("[Giới tính]='" + gt + "'");
                cloneTable(dt, rows);
            }
            if (sdt != null)
            {
                DataRow[] rows = dt.Select("[Điện thoại]='" + sdt + "'");
                cloneTable(dt, rows);
            }

            return dt;
        }
        private void cloneTable(DataTable dt, DataRow[] rows)
        {
            DataTable newdt = dt.Clone();
            foreach (DataRow row in rows)
            {
                DataRow newRow = newdt.NewRow();
                newRow.ItemArray = row.ItemArray;
                newdt.Rows.Add(newRow);
            }
            dt = newdt;
        }
        private DataTable taoTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã nhân viên");
            dt.Columns.Add("Tên nhân viên");
            dt.Columns.Add("Giới tính");
            dt.Columns.Add("Địa chỉ");
            dt.Columns.Add("Điện thoại");
            dt.Columns.Add("Ngày sinh");
            dt.Columns.Add("Email");
            return dt;
        }
    }
}
