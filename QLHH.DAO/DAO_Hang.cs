using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using QLHH.DAO;

namespace DAO
{
    public class DAO_Hang
    {
        QLSanPhamEntities1 db = new QLSanPhamEntities1();

        public List<DMHang> LayTatCaHangHoa()
        {
            return db.DMHangs.Include("DMChatLieu").ToList();
        }

        public DMHang LayHangTheoMa(string maHang)
        {
            return db.DMHangs.Find(maHang);
        }
        public bool ThemHang(DMHang hang)
        {
            try
            {
                db.DMHangs.Add(hang);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool SuaHang(DMHang hang)
        {
            try
            {
                var hangSua = db.DMHangs.Find(hang.MaHang);
                if (hangSua != null)
                {
                    hangSua.TenHang = hang.TenHang;
                    hangSua.MaChatLieu = hang.MaChatLieu;
                    hangSua.SoLuong = hang.SoLuong;
                    hangSua.DonGiaNhap = hang.DonGiaNhap;
                    hangSua.DonGiaBan = hang.DonGiaBan;
                    hangSua.Hinh = hang.Hinh;
                    hangSua.GhiChu = hang.GhiChu;

                    db.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool XoaHang(string maHang)
        {
            try
            {
                var hangXoa = db.DMHangs.Find(maHang);
                if (hangXoa != null)
                {
                    db.DMHangs.Remove(hangXoa);
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<DMHang> TimKiem(string tuKhoa)
        {
            return db.DMHangs.Include("DMChatLieu")
                      .Where(h => h.TenHang.Contains(tuKhoa) || h.MaHang.Contains(tuKhoa))
                      .ToList();
        }

    }
}