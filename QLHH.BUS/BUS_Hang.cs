using System;
using System.Collections.Generic;
using DAO;
using DTO;
using System.Linq;
using QLHH.DAO;

namespace BUS
{
    public class BUS_Hang
    {
        DAO_Hang daoHang = new DAO_Hang();
        private Hang_DTO MapModelToDTO(DMHang model)
        {
            return new Hang_DTO
            {
                MaHang = model.MaHang,
                TenHang = model.TenHang,
                MaChatLieu = model.MaChatLieu,
                SoLuong = (float)model.SoLuong,
                DonGiaNhap = (double)model.DonGiaNhap,
                DonGiaBan = (double)model.DonGiaBan,
                Hinh = model.Hinh,
                GhiChu = model.GhiChu,
                TenChatLieu = model.DMChatLieu != null ? model.DMChatLieu.TenChatLieu : ""
            };
        }
        private DMHang MapDTOToModel(Hang_DTO dto)
        {
            return new DMHang
            {
                MaHang = dto.MaHang,
                TenHang = dto.TenHang,
                MaChatLieu = dto.MaChatLieu,
                SoLuong = dto.SoLuong,
                DonGiaNhap = dto.DonGiaNhap,
                DonGiaBan = dto.DonGiaBan,
                Hinh = dto.Hinh,
                GhiChu = dto.GhiChu
            };
        }
       
        public List<Hang_DTO> LayDanhSachHang()
        {
            List<DMHang> listModel = daoHang.LayTatCaHangHoa();
            return listModel.Select(model => MapModelToDTO(model)).ToList();
        }

        public bool ThemHang(Hang_DTO hang)
        {
            if (daoHang.LayHangTheoMa(hang.MaHang) != null)
            {
                return false;
            }
            DMHang model = MapDTOToModel(hang);
            return daoHang.ThemHang(model);
        }

        public bool SuaHang(Hang_DTO hang)
        {
            DMHang model = MapDTOToModel(hang);
            return daoHang.SuaHang(model);
        }

        public bool XoaHang(string maHang)
        {
            return daoHang.XoaHang(maHang);
        }

        public List<Hang_DTO> TimKiemHang(string tenHang)
        {
            List<DMHang> listModel = daoHang.TimKiem(tenHang);
            return listModel.Select(model => MapModelToDTO(model)).ToList();
        }
    }
}